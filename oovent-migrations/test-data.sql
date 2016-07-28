DELETE FROM entity_user_info;
DELETE FROM entities;

SET IDENTITY_INSERT entities ON;
INSERT INTO entities (id, entity_type_id, name)
VALUES (1, 1, 'John Doe');

INSERT INTO entities (id, entity_type_id, name)
VALUES (2, 2, 'Destin Hebner');
SET IDENTITY_INSERT entities OFF;

SET IDENTITY_INSERT entity_user_info ON;
INSERT INTO entity_user_info (id, email, password)
VALUES (1, 'johndoe@gmail.com', 'password');

INSERT INTO entity_user_info (id, email, password)
VALUES (2, 'destinhebner@gmail.com', 'password');
SET IDENTITY_INSERT entity_user_info OFF;