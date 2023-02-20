# Unfinished: Needs to auto refresh on save for dev

FROM node:16-alpine as builder
WORKDIR /app

COPY package.json .
COPY . .

RUN npm install

EXPOSE 8080:8080

CMD ["npm", "run", "start_unix"]