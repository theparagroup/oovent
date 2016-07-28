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

INSERT INTO event_entity_relationship_types(id, name) VALUES (1, 'Happening');
INSERT INTO event_entity_relationship_types(id, name) VALUES (2, 'Special');
INSERT INTO event_entity_relationship_types(id, name) VALUES (3, 'Food Truck');
INSERT INTO event_entity_relationship_types(id, name) VALUES (4, 'Data Entry');

INSERT INTO event_entity_relationship_types(id, name) VALUES (1, 'Created By');
INSERT INTO event_entity_relationship_types(id, name) VALUES (2, 'Located At');
INSERT INTO event_entity_relationship_types(id, name) VALUES (3, 'Featuring');

INSERT INTO entity_entity_relationship_types(id, name) VALUES (1, 'Added By');
INSERT INTO entity_entity_relationship_types(id, name) VALUES (2, 'Located At');
INSERT INTO entity_entity_relationship_types(id, name) VALUES (3, 'Featuring');