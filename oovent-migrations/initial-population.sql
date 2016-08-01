DELETE FROM entity_user_info;
DELETE FROM entities;
DELETE FROM entity_types;
DELETE FROM event_types;
DELETE FROM entity_entity_relationship_types;
DELETE FROM event_entity_relationship_types;
DELETE FROM url_types;


INSERT INTO entity_types (id, name) VALUES (1, 'User');
INSERT INTO entity_types (id, parent_entity_type_id, name) VALUES (2, 1, 'Ooventer');
INSERT INTO entity_types (id, name) VALUES (3, 'What');
INSERT INTO entity_types (id, name) VALUES (4, 'Where');
INSERT INTO entity_types (id, name) VALUES (5, 'Source');

INSERT INTO url_types(id, name) VALUES (1, 'Web');
INSERT INTO url_types(id, name) VALUES (2, 'Facebook');
INSERT INTO url_types(id, name) VALUES (3, 'Twitter');
INSERT INTO url_types(id, name) VALUES (4, 'Pintrist');
INSERT INTO url_types(id, name) VALUES (5, 'Tumblr');
INSERT INTO url_types(id, name) VALUES (6, 'Instagram');
INSERT INTO url_types(id, name) VALUES (7, 'Other');

INSERT INTO event_types(id, name) VALUES (1, 'Happening');
INSERT INTO event_types(id, name) VALUES (2, 'Special');
INSERT INTO event_types(id, name) VALUES (3, 'Food Truck');
INSERT INTO event_types(id, name) VALUES (4, 'Data Entry');

INSERT INTO event_entity_relationship_types(id, name) VALUES (1, '{Happening/Special} has a {What}');
INSERT INTO event_entity_relationship_types(id, name) VALUES (2, '{Happening/Special} has a {Who}');
INSERT INTO event_entity_relationship_types(id, name) VALUES (3, '{Happening/Special} was created by {Ooventer}');
INSERT INTO event_entity_relationship_types(id, name) VALUES (4, '{Happening/Special} has a {Source}');
INSERT INTO event_entity_relationship_types(id, name) VALUES (5, '{Data/Entry} has a {Source}');
INSERT INTO event_entity_relationship_types(id, name) VALUES (6, '{Data/Entry} has an {Ooventer}');