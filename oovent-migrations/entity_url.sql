SET IDENTITY_INSERT entity_urls ON ; 


DELETE FROM entity_urls

INSERT INTO entity_urls (id, entity_id, url_id)

	VALUES
		(
		1,
		1,
		1
		
		);
INSERT INTO entity_urls (id, entity_id, url_id)

	VALUES
		(
		2,
		1,
		2
		
		);

INSERT INTO entity_urls (id, entity_id, url_id)

	VALUES
		(
		3,
		1,
		3
		
		);

INSERT INTO entity_urls (id, entity_id, url_id)

	VALUES
		(
		4,
		1,
		4
		
		);


INSERT INTO entity_urls (id, entity_id, url_id)

	VALUES
		(
		5,
		2,
		5
		);

SET IDENTITY_INSERT entity_urls OFF ; 
