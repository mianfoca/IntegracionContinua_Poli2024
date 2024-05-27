#!/bin/sh

# Reemplaza las variables de entorno en env.js
sed -i 's|DEFAULT_API_URL|'"${API_URL}"'|g' /usr/share/nginx/html/assets/env.js

# Ejecuta el comando original de Nginx
exec "$@"
