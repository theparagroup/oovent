DELETE FROM entity_user_info;
DELETE FROM entities;
DELETE FROM event_entity_relationships;
DELETE FROM events;

SET IDENTITY_INSERT entities ON;
INSERT INTO entities (id, entity_type_id, name)
VALUES (1, 1, 'John Doe');

INSERT INTO entities (id, entity_type_id, name)
VALUES (2, 2, 'Destin Hebner');
SET IDENTITY_INSERT entities OFF;

SET IDENTITY_INSERT entity_user_info ON;
INSERT INTO entity_user_info (entity_id, email, password)
VALUES (1, 'johndoe@gmail.com', 'Qd8zZJQR0ummILM3N399Qqp/NlPQkuKqIoT3CyMkl5Y=|piZD6jwTjU7OvMdA/07lH6I0+hI=');

INSERT INTO entity_user_info (entity_id, email, password)
VALUES (2, 'destinhebner@gmail.com', 'Qd8zZJQR0ummILM3N399Qqp/NlPQkuKqIoT3CyMkl5Y=|piZD6jwTjU7OvMdA/07lH6I0+hI=');
SET IDENTITY_INSERT entity_user_info OFF;

SET IDENTITY_INSERT events ON;
INSERT INTO events (id, event_type_id, title, description, start, [end], ordinal, m, t, w, th, f, s, su)
VALUES (1, 1, 'McDonalds McHealthweek', 'Come down to your local McDonalds and get a free burger to support being healthy.', '8/8/2016', '8/16/2016', 0, 1, 1, 1, 1, 1, 1, 1);
SET IDENTITY_INSERT events OFF;

SET IDENTITY_INSERT event_entity_relationships ON;
INSERT INTO event_entity_relationships (id, event_id, event_entity_relationship_type_id, entity_id)
VALUES (1, 1, 3, 2);
SET IDENTITY_INSERT event_entity_relationships OFF;