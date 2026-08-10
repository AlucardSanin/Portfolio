(() => {
  'use strict';

  const reducedMotion = window.matchMedia('(prefers-reduced-motion: reduce)').matches;
  const observers = new Map();

  const disconnect = (key) => {
    const existing = observers.get(key);
    if (existing) {
      existing.disconnect();
      observers.delete(key);
    }
  };

  /** Reveal-on-scroll for any element carrying [data-reveal]. */
  const initReveal = () => {
    disconnect('reveal');

    const targets = document.querySelectorAll('[data-reveal]:not(.is-revealed)');
    if (reducedMotion) {
      targets.forEach((el) => el.classList.add('is-revealed'));
      return;
    }

    const observer = new IntersectionObserver(
      (entries) => {
        entries.forEach((entry) => {
          if (!entry.isIntersecting) return;
          entry.target.classList.add('is-revealed');
          observer.unobserve(entry.target);
        });
      },
      { rootMargin: '0px 0px -12% 0px', threshold: 0.12 }
    );

    targets.forEach((el) => observer.observe(el));
    observers.set('reveal', observer);
  };

  /** Animates every [data-count] once it enters the viewport. */
  const initCounters = () => {
    disconnect('counters');

    const targets = document.querySelectorAll('[data-count]:not(.is-counted)');
    const run = (el) => {
      el.classList.add('is-counted');
      const raw = el.dataset.count;
      const target = parseFloat(raw);
      if (Number.isNaN(target)) {
        el.textContent = raw;
        return;
      }
      const suffix = raw.replace(/[\d.,\s]/g, '');
      if (reducedMotion) {
        el.textContent = raw;
        return;
      }
      const duration = 1200;
      const start = performance.now();
      const tick = (now) => {
        const progress = Math.min((now - start) / duration, 1);
        const eased = 1 - Math.pow(1 - progress, 3);
        el.textContent = Math.round(target * eased) + suffix;
        if (progress < 1) requestAnimationFrame(tick);
      };
      requestAnimationFrame(tick);
    };

    const observer = new IntersectionObserver(
      (entries) => {
        entries.forEach((entry) => {
          if (!entry.isIntersecting) return;
          run(entry.target);
          observer.unobserve(entry.target);
        });
      },
      { threshold: 0.5 }
    );

    targets.forEach((el) => observer.observe(el));
    observers.set('counters', observer);
  };

  /** Tells .NET which section is currently under the navbar. */
  const observeSections = (dotNetRef) => {
    disconnect('sections');

    const sections = document.querySelectorAll('section[id]');
    if (!sections.length) return;

    const observer = new IntersectionObserver(
      (entries) => {
        const visible = entries
          .filter((e) => e.isIntersecting)
          .sort((a, b) => b.intersectionRatio - a.intersectionRatio)[0];
        if (visible) {
          dotNetRef.invokeMethodAsync('OnSectionChanged', visible.target.id);
        }
      },
      { rootMargin: '-45% 0px -45% 0px', threshold: [0, 0.25, 0.5, 1] }
    );

    sections.forEach((el) => observer.observe(el));
    observers.set('sections', observer);
  };

  /** Pointer-following glow plus a subtle parallax signal for the hero. */
  const initPointer = () => {
    if (reducedMotion || window.matchMedia('(pointer: coarse)').matches) return;
    if (window.__portfolioPointer) return;
    window.__portfolioPointer = true;

    let frame = 0;
    window.addEventListener(
      'pointermove',
      (event) => {
        if (frame) return;
        frame = requestAnimationFrame(() => {
          frame = 0;
          const x = event.clientX;
          const y = event.clientY;
          const root = document.documentElement;
          root.style.setProperty('--pointer-x', `${x}px`);
          root.style.setProperty('--pointer-y', `${y}px`);
          root.style.setProperty('--tilt-x', `${(x / window.innerWidth - 0.5) * 2}`);
          root.style.setProperty('--tilt-y', `${(y / window.innerHeight - 0.5) * 2}`);
        });
      },
      { passive: true }
    );
  };

  /** Card tilt for [data-tilt] elements. */
  const initTilt = () => {
    if (reducedMotion || window.matchMedia('(pointer: coarse)').matches) return;

    document.querySelectorAll('[data-tilt]:not([data-tilt-ready])').forEach((card) => {
      card.setAttribute('data-tilt-ready', 'true');

      card.addEventListener('pointermove', (event) => {
        const rect = card.getBoundingClientRect();
        const px = (event.clientX - rect.left) / rect.width;
        const py = (event.clientY - rect.top) / rect.height;
        card.style.setProperty('--rx', `${(0.5 - py) * 7}deg`);
        card.style.setProperty('--ry', `${(px - 0.5) * 9}deg`);
        card.style.setProperty('--mx', `${px * 100}%`);
        card.style.setProperty('--my', `${py * 100}%`);
      });

      const reset = () => {
        card.style.setProperty('--rx', '0deg');
        card.style.setProperty('--ry', '0deg');
      };
      card.addEventListener('pointerleave', reset);
      card.addEventListener('blur', reset);
    });
  };

  /** Reading progress bar + "page has scrolled" flag for the navbar. */
  const initScrollState = () => {
    if (window.__portfolioScroll) return;
    window.__portfolioScroll = true;

    let frame = 0;
    const update = () => {
      frame = 0;
      const doc = document.documentElement;
      const max = doc.scrollHeight - window.innerHeight;
      const progress = max > 0 ? window.scrollY / max : 0;
      doc.style.setProperty('--scroll-progress', progress.toFixed(4));
      doc.classList.toggle('is-scrolled', window.scrollY > 24);
    };

    window.addEventListener(
      'scroll',
      () => {
        if (frame) return;
        frame = requestAnimationFrame(update);
      },
      { passive: true }
    );
    update();
  };

  const scrollToId = (id) => {
    const el = document.getElementById(id);
    if (!el) return;
    el.scrollIntoView({ behavior: reducedMotion ? 'auto' : 'smooth', block: 'start' });
  };

  const scrollToTop = () => {
    window.scrollTo({ top: 0, behavior: reducedMotion ? 'auto' : 'smooth' });
  };

  const lockScroll = (locked) => {
    document.body.classList.toggle('is-locked', locked);
  };

  const readTheme = () => {
    try {
      return localStorage.getItem('portfolio-theme') || 'dark';
    } catch {
      return 'dark';
    }
  };

  const applyTheme = (theme) => {
    document.documentElement.setAttribute('data-theme', theme);
    document
      .querySelector('meta[name="theme-color"]')
      ?.setAttribute('content', theme === 'light' ? '#f4f5fb' : '#06070d');
    try {
      localStorage.setItem('portfolio-theme', theme);
    } catch {
      /* storage unavailable — theme simply will not persist */
    }
  };

  const copyText = async (text) => {
    try {
      await navigator.clipboard.writeText(text);
      return true;
    } catch {
      return false;
    }
  };

  const ready = () => document.body.classList.add('is-ready');

  window.portfolio = {
    initReveal,
    initCounters,
    initTilt,
    initPointer,
    initScrollState,
    observeSections,
    scrollToId,
    scrollToTop,
    lockScroll,
    readTheme,
    applyTheme,
    copyText,
    ready,
    reducedMotion
  };

  applyTheme(readTheme());
})();
