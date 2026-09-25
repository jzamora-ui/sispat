(function () {
    "use strict";

    document.addEventListener("DOMContentLoaded", function () {

        // --------------------------------------------------
        // Toggle mostrar/ocultar contraseña
        // --------------------------------------------------
        var toggle = document.getElementById("togglePassword");
        var pass = document.getElementById("Contrasena");

        if (toggle && pass) {
            toggle.addEventListener("click", function () {
                var icon = toggle.querySelector("i");
                var isPassword = pass.type === "password";

                pass.type = isPassword ? "text" : "password";

                if (icon) {
                    icon.classList.toggle("fa-eye-slash", !isPassword);
                    icon.classList.toggle("fa-eye", isPassword);
                }

                toggle.setAttribute(
                    "aria-label",
                    isPassword ? "Ocultar contraseña" : "Mostrar contraseña"
                );
            });
        }

        // --------------------------------------------------
        // Estado loading del botón al enviar
        // --------------------------------------------------
        var form = document.getElementById("loginForm");
        var btn = document.getElementById("btnLogin");

        if (form && btn) {
            form.addEventListener("submit", function () {
                btn.classList.add("loading");
                var span = btn.querySelector("span");
                if (span) { span.textContent = "Ingresando..."; }
            });
        }

    });

})();