CREATE TABLE categories (
                            id serial PRIMARY KEY ,
                            category varchar(30)
);
INSERT INTO categories (category) VALUES ('Phones'), ('Computers'), ('TV');


CREATE TABLE products
(
    id          serial PRIMARY KEY,
    title       varchar(30) not null,
    price       float       not null,
    category_id integer references categories (id)
);

INSERT INTO products (title, price, category_id) VALUES ('iphone 13', 10000, 1);
INSERT INTO products (title, price, category_id) VALUES ('iphone 13 PRO', 14000, 1);
INSERT INTO products (title, price, category_id) VALUES ('Samsung A51', 3000, 1);
INSERT INTO products (title, price, category_id) VALUES ('Lenovo', 14000, 2);
INSERT INTO products (title, price, category_id) VALUES ('MacBook M2', 21000, 2);
INSERT INTO products (title, price, category_id) VALUES ('Samsung', 2000, 3);
INSERT INTO products (title, price, category_id) VALUES ('LG', 4000, 3);


CREATE TABLE period
(
    id          serial PRIMARY KEY,
    period       integer not null,
    commission   integer       not null,
    category_id integer references categories (id)
);

INSERT INTO period (period, commission, category_id) VALUES (3, 0, 1);
INSERT INTO period (period, commission, category_id) VALUES (6, 0, 1);
INSERT INTO period (period, commission, category_id) VALUES (9, 0, 1);
INSERT INTO period (period, commission, category_id) VALUES (12, 3, 1);
INSERT INTO period (period, commission, category_id) VALUES (18, 6, 1);
INSERT INTO period (period, commission, category_id) VALUES (24, 9, 1);

INSERT INTO period (period, commission, category_id) VALUES (3, 0, 2);
INSERT INTO period (period, commission, category_id) VALUES (6, 0, 2);
INSERT INTO period (period, commission, category_id) VALUES (9, 0, 2);
INSERT INTO period (period, commission, category_id) VALUES (12, 0, 2);
INSERT INTO period (period, commission, category_id) VALUES (18, 4, 2);
INSERT INTO period (period, commission, category_id) VALUES (24, 8, 2);

INSERT INTO period (period, commission, category_id) VALUES (3, 0, 3);
INSERT INTO period (period, commission, category_id) VALUES (6, 0, 3);
INSERT INTO period (period, commission, category_id) VALUES (9, 0, 3);
INSERT INTO period (period, commission, category_id) VALUES (12, 0, 3);
INSERT INTO period (period, commission, category_id) VALUES (18, 0, 3);
INSERT INTO period (period, commission, category_id) VALUES (24, 5, 3);