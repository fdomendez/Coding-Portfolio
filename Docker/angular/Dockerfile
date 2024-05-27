FROM nginx:alpine

WORKDIR /usr/share/nginx/html
COPY ./publish .

COPY default.conf  /etc/nginx/conf.d/

EXPOSE 80