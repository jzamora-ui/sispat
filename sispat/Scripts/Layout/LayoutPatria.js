(function () {
    "use strict";
    var shell = document.getElementById("appShell");
    var menuToggle = document.getElementById("menuToggle");
    var scrim = document.getElementById("mobileScrim");
    var trigger = document.getElementById("userMenuTrigger");
    var popover = document.getElementById("userPopover");

    function mobile() { return window.matchMedia("(max-width: 760px)").matches; }

    if (menuToggle && shell) {
        menuToggle.addEventListener("click", function () {
            if (mobile()) shell.classList.toggle("mobile-menu-open");
            else shell.classList.toggle("sidebar-collapsed");
        });
    }
    if (scrim && shell) {
        scrim.addEventListener("click", function () {
            shell.classList.remove("mobile-menu-open");
        });
    }
    function closePopover() {
        if (!popover || !trigger) return;
        popover.hidden = true;
        trigger.setAttribute("aria-expanded", "false");
    }
    if (trigger && popover) {
        trigger.addEventListener("click", function (e) {
            e.stopPropagation();
            var open = popover.hidden;
            popover.hidden = !open;
            trigger.setAttribute("aria-expanded", open ? "true" : "false");
        });
        popover.addEventListener("click", function (e) { e.stopPropagation(); });
        document.addEventListener("click", closePopover);
        document.addEventListener("keydown", function (e) {
            if (e.key === "Escape") {
                closePopover();
                if (shell) shell.classList.remove("mobile-menu-open");
            }
        });
    }
})();