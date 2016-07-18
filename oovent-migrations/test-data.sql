DELETE entities;
DELETE events;
DELETE event_entity_relationships;

SET IDENTITY_INSERT entities ON;
INSERT INTO entities (id, entity_type_id, name) 
VALUES (1, 13, 'Jane Brinkman');
INSERT INTO entities (id, entity_type_id, name) 
VALUES (2, 6, '214 Park St SE Abingdon VA 24210');
SET IDENTITY_INSERT entities OFF;

SET IDENTITY_INSERT events ON;
INSERT INTO events (id, event_type_id, description, start, [end], ordinal, m, t, w, th, f, s, su)
VALUES (1, 0, 'Sign up today before it is too late! Basket Class July 23, 9 AM in the Artisans Annex.', '7/23/16 8:00', '7/23/16 4:00', 0, 1, 0, 0, 0, 0, 0, 0); 
SET IDENTITY_INSERT events OFF;

-- Basket class event featuring Jane Brinkman at 214 Park St SE Abingdon VA 24210.
SET IDENTITY_INSERT event_entity_relationships ON;
INSERT INTO event_entity_relationships (id, event_id, event_relationship_type_id, entity_id)
VALUES (1, 1, 7, 2);
INSERT INTO event_entity_relationships (id, event_id, event_relationship_type_id, entity_id)
VALUES (2, 1, 1, 1);
SET IDENTITY_INSERT event_entity_relationships OFF;