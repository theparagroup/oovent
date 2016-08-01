SET IDENTITY_INSERT urls ON ; 
DELETE FROM urls;

--Acoustic Coffe House

INSERT INTO urls (id, url, url_type_id)

	VALUES
		(
            1,
			'http://acousticcoffeehouse.net/',
			1
		);
INSERT INTO urls (id, url, url_type_id)

	VALUES
	    (
		    2,
			'https://www.facebook.com/coffeeacoustic/',
			2
		);
INSERT INTO urls (id, url, url_type_id)

	VALUES
		(
		    3,
			'https://twitter.com/acousticcoffee_',
			3
		);
INSERT INTO urls (id, url, url_type_id)

	VALUES
		(
		    4,
			'https://www.youtube.com/user/acousticcoffeehouse',
			7
		);

--Acoustic Coffe House

INSERT INTO urls (id, url, url_type_id)

	VALUES
		(
		    5,
			'https://www.facebook.com/Back-Door-Records-266977259776/',
			2
		);

SET IDENTITY_INSERT urls OFF 
