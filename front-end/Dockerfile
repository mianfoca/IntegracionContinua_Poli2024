# ----------------------------
# build from source
# ----------------------------
FROM node:14 as build-stage

# Establece el directorio de trabajo
WORKDIR /app

# Copia el package.json y el package-lock.json
COPY package*.json ./

# Instala las dependencias de la aplicación
RUN npm install

# Copia el código fuente de la aplicación
COPY . .

# Compila la aplicación Angular
RUN npm run build --prod

# ----------------------------
# run with nginx
# ----------------------------
FROM nginx:1.21.0-alpine as production-stage

RUN rm /etc/nginx/conf.d/default.conf
COPY nginx.conf /etc/nginx/conf.d

# Copia los archivos compilados desde el build-stage
COPY --from=build-stage /app/dist/pokedex /usr/share/nginx/html

# EXPOSE 80

# Copia el script de entorno
COPY src/assets/env.js /usr/share/nginx/html/assets/env.js


# Copia el script de inicialización
COPY init.sh /init.sh
RUN chmod +x /init.sh
CMD ["/init.sh", "nginx", "-g", "daemon off;"]