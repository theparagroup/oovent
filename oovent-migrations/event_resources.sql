SET IDENTITY_INSERT entities ON;
DELETE FROM entity_urls
DELETE FROM entities
DELETE FROM urls;
INSERT INTO entities (id, entity_type_id, name) VALUES (1, 5, 'Acoustic Coffe House');
INSERT INTO entities (id, entity_type_id, name) VALUES (2, 5, 'Back Door Records');
INSERT INTO entities (id, entity_type_id, name) VALUES (3, 5, 'Barter Theatre');
INSERT INTO entities (id, entity_type_id, name) VALUES (4, 5, 'Brew Plum Coffe Bar');
INSERT INTO entities (id, entity_type_id, name) VALUES (5, 5, 'Bristol Chamber');
INSERT INTO entities (id, entity_type_id, name) VALUES (6, 5, 'Capone''s');
INSERT INTO entities (id, entity_type_id, name) VALUES (7, 5, 'Caribbean Grill');
INSERT INTO entities (id, entity_type_id, name) VALUES (8, 5, 'Elizabethton Chamber');
INSERT INTO entities (id, entity_type_id, name) VALUES (9, 5, 'Elizabethton Star');
INSERT INTO entities (id, entity_type_id, name) VALUES (10, 5, 'Erwin Chamber');
INSERT INTO entities (id, entity_type_id, name) VALUES (11, 5, 'Erwin Record');
INSERT INTO entities (id, entity_type_id, name) VALUES (12, 5, 'ETSU News');
INSERT INTO entities (id, entity_type_id, name) VALUES (13, 5, 'Foodie Fiction');
INSERT INTO entities (id, entity_type_id, name) VALUES (14, 5, 'Founders Park');
INSERT INTO entities (id, entity_type_id, name) VALUES (15, 5, 'GoTricities');
INSERT INTO entities (id, entity_type_id, name) VALUES (16, 5, 'Herald & Tribune');
INSERT INTO entities (id, entity_type_id, name) VALUES (17, 5, 'Herald Courier');
INSERT INTO entities (id, entity_type_id, name) VALUES (18, 5, 'Holston River Brewing Co.');
INSERT INTO entities (id, entity_type_id, name) VALUES (19, 5, 'Johnson City Chamber');
INSERT INTO entities (id, entity_type_id, name) VALUES (20, 5, 'Johnson City 360');
INSERT INTO entities (id, entity_type_id, name) VALUES (21, 5, 'Johnson City Brewing Co.');
INSERT INTO entities (id, entity_type_id, name) VALUES (22, 5, 'Johnson City Farmers Market');
INSERT INTO entities (id, entity_type_id, name) VALUES (23, 5, 'Johnson City Press');
INSERT INTO entities (id, entity_type_id, name) VALUES (24, 5, 'Jonesborough Chamber');
INSERT INTO entities (id, entity_type_id, name) VALUES (25, 5, 'Kingsport Chamber');
INSERT INTO entities (id, entity_type_id, name) VALUES (26, 5, 'Kingsport Renaissance Center');
INSERT INTO entities (id, entity_type_id, name) VALUES (27, 5, 'Kingsport Times');
INSERT INTO entities (id, entity_type_id, name) VALUES (28, 5, 'Morrell Music');
INSERT INTO entities (id, entity_type_id, name) VALUES (29, 5, 'National Story Telling Festival');
INSERT INTO entities (id, entity_type_id, name) VALUES (30, 5, 'NETTA');
INSERT INTO entities (id, entity_type_id, name) VALUES (31, 5, 'News & Neighbor');
INSERT INTO entities (id, entity_type_id, name) VALUES (32, 5, 'Noli Food Truck');
INSERT INTO entities (id, entity_type_id, name) VALUES (33, 5, 'Out-N-About');
INSERT INTO entities (id, entity_type_id, name) VALUES (34, 5, 'Radio Web village');
INSERT INTO entities (id, entity_type_id, name) VALUES (35, 5, 'Shop Local');
INSERT INTO entities (id, entity_type_id, name) VALUES (36, 5, 'Slammin Sammy''s');
INSERT INTO entities (id, entity_type_id, name) VALUES (37, 5, 'Sleepy Owl Brewery');
INSERT INTO entities (id, entity_type_id, name) VALUES (38, 5, 'Story Telling Center');
INSERT INTO entities (id, entity_type_id, name) VALUES (39, 5, 'The Atlantic Ale House');
INSERT INTO entities (id, entity_type_id, name) VALUES (40, 5, 'The Comedy Zone');
INSERT INTO entities (id, entity_type_id, name) VALUES (41, 5, 'The Down Home');
INSERT INTO entities (id, entity_type_id, name) VALUES (42, 5, 'The Hideaway');
INSERT INTO entities (id, entity_type_id, name) VALUES (43, 5, 'The Loafer');
INSERT INTO entities (id, entity_type_id, name) VALUES (44, 5, 'The Willow Tree');
INSERT INTO entities (id, entity_type_id, name) VALUES (45, 5, 'Tipton Street Pub');
INSERT INTO entities (id, entity_type_id, name) VALUES (46, 5, 'Tweetsie Trail events');
INSERT INTO entities (id, entity_type_id, name) VALUES (47, 5, 'WCYB');
INSERT INTO entities (id, entity_type_id, name) VALUES (48, 5, 'Wellington''s');
INSERT INTO entities (id, entity_type_id, name) VALUES (49, 5, 'WETS');
INSERT INTO entities (id, entity_type_id, name) VALUES (50, 5, 'WJHL');
INSERT INTO entities (id, entity_type_id, name) VALUES (51, 5, 'WTFM');
INSERT INTO entities (id, entity_type_id, name) VALUES (52, 5, 'WXBQ');
INSERT INTO entities (id, entity_type_id, name) VALUES (53, 5, 'Yee-Haw Brewing');
SET IDENTITY_INSERT entities OFF;


SET IDENTITY_INSERT urls ON;
--Acoustic Coffe House
INSERT INTO urls (id, url, url_type_id) VALUES (1, 'http://acousticcoffeehouse.net/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (2, 'https://www.facebook.com/coffeeacoustic/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (3, 'https://twitter.com/acousticcoffee_', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (4, 'https://www.youtube.com/user/acousticcoffeehouse', 7);
--------------------------------------------------
--Back Door Records
INSERT INTO urls (id, url, url_type_id) VALUES (5, 'https://www.facebook.com/Back-Door-Records-266977259776/', 2);
--------------------------------------------------
--Barter Theatre 
INSERT INTO urls (id, url, url_type_id) VALUES (6, 'http://www.bartertheatre.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (7, 'https://www.facebook.com/BarterTheatre', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (8, 'https://twitter.com/BarterInsider', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (9, 'https://www.youtube.com/user/BarterTheatre', 7);
INSERT INTO urls (id, url, url_type_id) VALUES (10, 'https://www.instagram.com/bartertheatre/', 6);
INSERT INTO urls (id, url, url_type_id) VALUES (11, 'https://www.pinterest.com/bartertheatre', 4);
---------------------------------------------------
--Brew Plum Coffe Bar
INSERT INTO urls (id, url, url_type_id) VALUES (12, 'https://www.facebook.com/brewplumcoffeebar/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (13, 'https://twitter.com/brewplum', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (14, 'https://www.instagram.com/explore/locations/273186244/', 6);
---------------------------------------------------
--Bristol Chamber
INSERT INTO urls (id, url, url_type_id) VALUES (15, 'http://www.bristolchamber.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (16, 'https://www.facebook.com/BristolChamber', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (17, 'https://twitter.com/BristolChamber', 3);
---------------------------------------------------
--Capone's 
INSERT INTO urls (id, url, url_type_id) VALUES (18, 'http://www.caponesjohnsoncity.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (19, 'https://www.facebook.com/Capones', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (20, 'https://twitter.com/caponesjc', 3);
---------------------------------------------------
--Caribbean Grill 
INSERT INTO urls (id, url, url_type_id) VALUES (21, 'https://www.facebook.com/caribbeangrillPR/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (22, 'https://twitter.com/daveshawpr', 3);
---------------------------------------------------
--Elizabethton Chamber
INSERT INTO urls (id, url, url_type_id) VALUES (23, 'http://www.elizabethtonchamber.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (24, 'https://www.facebook.com/ElizabethtonEvents', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (25, 'https://twitter.com/ElizEvents', 3);
---------------------------------------------------
--Elizabethton Star
INSERT INTO urls (id, url, url_type_id) VALUES (26, 'http://www.elizabethton.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (27, 'https://www.facebook.com/ElizabethtonStar', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (28, 'https://twitter.com/ElizStarNews?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (29, 'https://www.youtube.com/channel/UCp4-28N2HYbNGv0_qvMHrEw', 7);
---------------------------------------------------
--Erwin Chamber
INSERT INTO urls (id, url, url_type_id) VALUES (30, 'http://www.erwinchamber.org/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (31, 'https://www.facebook.com/erwin.chamber?fref=ts', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (32, 'https://twitter.com/erwinchamber', 3);
---------------------------------------------------
--Erwin Record
INSERT INTO urls (id, url, url_type_id) VALUES (33, 'http://www.erwinrecord.net/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (34, 'https://www.facebook.com/erwinrecord/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (35, 'https://twitter.com/erwinrecord', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (36, 'https://www.youtube.com/channel/UCRLxKmq7GN7JKyuaXPzCY-g', 7);
INSERT INTO urls (id, url, url_type_id) VALUES (37, 'https://www.instagram.com/theerwinrecord/', 6);
INSERT INTO urls (id, url, url_type_id) VALUES (38, 'https://uk.pinterest.com/pin/18225573468355644/', 4);
---------------------------------------------------
--ETSU News
INSERT INTO urls (id, url, url_type_id) VALUES (39, 'http://www.etsu.edu/news/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (40, 'https://www.facebook.com/easttennesseestateuniversity', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (41, 'https://twitter.com/etsu', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (42, 'https://www.youtube.com/user/EastTennesseeState', 7);
INSERT INTO urls (id, url, url_type_id) VALUES (43, 'https://www.instagram.com/etsu/', 6);
---------------------------------------------------
--Foodie Fiction
INSERT INTO urls (id, url, url_type_id) VALUES (44, 'https://www.facebook.com/Foodie-Fiction-1466138086958341/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (45, 'https://twitter.com/foodiefiction?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (46, 'https://www.instagram.com/foodiefiction/', 6);
---------------------------------------------------
--Founder's Park
INSERT INTO urls (id, url, url_type_id) VALUES (47, 'https://www.facebook.com/FoundersParkJC/', 2);
---------------------------------------------------
--GoTriCities
INSERT INTO urls (id, url, url_type_id) VALUES (48, 'http://www.gotricities.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (49, 'https://www.facebook.com/gotricities/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (50, 'https://twitter.com/gotricities', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (51, 'https://www.youtube.com/user/gotricities', 7);
-----------------------------------------------------------------------
--Herald and Tribune 
INSERT INTO urls (id, url, url_type_id) VALUES (52, 'http://www.heraldandtribune.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (53, 'https://www.facebook.com/HeraldandTribune/', 2);
---------------------------------------------------
--Herald Courier
INSERT INTO urls (id, url, url_type_id) VALUES (54, 'http://www.heraldcourier.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (55, 'https://www.facebook.com/heraldcourierdotcom/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (56, 'https://twitter.com/heraldcourier', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (57, 'https://www.youtube.com/user/BHCTriCities', 7);
INSERT INTO urls (id, url, url_type_id) VALUES (58, 'https://www.instagram.com/bristolheraldcourier/', 6);
INSERT INTO urls (id, url, url_type_id) VALUES (59, 'https://www.pinterest.com/bristolheraldco/', 4);
---------------------------------------------------
--Holston River Brewing Co.
INSERT INTO urls (id, url, url_type_id) VALUES (60, 'http://www.hrbrewing.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (61, 'https://www.facebook.com/holstonriverbrewing/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (62, 'https://twitter.com/hrbrewingco', 3);
---------------------------------------------------
--Johnson City Chamber
INSERT INTO urls (id, url, url_type_id) VALUES (63, 'http://www.johnsoncitytnchamber.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (64, 'https://www.facebook.com/JohnsonCityChamber', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (65, 'https://twitter.com/jcchamber', 3);
---------------------------------------------------
--Johnson City 360
INSERT INTO urls (id, url, url_type_id) VALUES (66, 'http://johnsoncity360.com/', 1);
---------------------------------------------------
--Johnson City Brewing Co.
INSERT INTO urls (id, url, url_type_id) VALUES (67, 'http://johnsoncitybrewing.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (68, 'https://www.facebook.com/johnsoncitybrewing/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (69, 'https://twitter.com/johnsoncitybrew', 3);
---------------------------------------------------
--Johnson City Farmers Market
INSERT INTO urls (id, url, url_type_id) VALUES (70, 'http://www.johnsoncityfarmersmarket.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (71, 'https://www.facebook.com/Johnson-City-Farmers-Market-241717076230/', 2);
---------------------------------------------------
--Johnson City Press
INSERT INTO urls (id, url, url_type_id) VALUES (72, 'http://www.johnsoncitypress.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (73, 'https://www.facebook.com/JohnsonCityPress', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (74, 'https://twitter.com/JCPress', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (75, 'https://www.youtube.com/channel/UCYZixCNzcgknXLPdHUXQPXw', 7);
INSERT INTO urls (id, url, url_type_id) VALUES (76, 'https://www.instagram.com/johnson_city_press/', 6);
---------------------------------------------------
--Jonesborough Chamber
INSERT INTO urls (id, url, url_type_id) VALUES (77, 'http://www.jonesborochamber.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (78, 'https://www.facebook.com/JonesboroChamber', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (79, 'https://twitter.com/jtownchamber', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (80, 'https://www.youtube.com/channel/UCdynP_nvQaORkJiKjhjNbGg', 7);
INSERT INTO urls (id, url, url_type_id) VALUES (81, 'https://www.pinterest.com/bristolchamber/', 4);
---------------------------------------------------
--Kingsport Chamber
INSERT INTO urls (id, url, url_type_id) VALUES (82, 'http://www.kingsportchamber.org/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (83, 'https://www.facebook.com/Kingsport.Chamber', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (84, 'https://twitter.com/kptchamber', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (85, 'https://www.youtube.com/channel/UC9q0YFE8meCEFEHr6zIECLw', 7);
---------------------------------------------------
--Kingsport Renaissance Center
INSERT INTO urls (id, url, url_type_id) VALUES (86, 'http://www.kingsportparksandrecreation.org/renaissancecenter/renaissancecenter.htm', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (87, 'https://www.facebook.com/RenaissanceCenterKpt/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (88, 'https://twitter.com/publicartkpt', 3);
---------------------------------------------------
--Kingsport Times
INSERT INTO urls (id, url, url_type_id) VALUES (89, 'http://www.timesnews.net/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (90, 'https://www.facebook.com/timesnews', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (91, 'https://twitter.com/TimesNewsOnline', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (92, 'https://www.youtube.com/channel/UCdd6-08yhtqjjwFVpq_u1TA', 7);
INSERT INTO urls (id, url, url_type_id) VALUES (93, 'https://www.instagram.com/timesnewsphotos/', 6);
---------------------------------------------------
--Morrell Music
INSERT INTO urls (id, url, url_type_id) VALUES (94, 'http://www.campbellsmusic.net/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (95, 'https://www.facebook.com/campbellsmorrellmusic/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (96, 'https://twitter.com/campbellsmusic', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (97, 'https://www.instagram.com/campbellsmusic/', 6);
---------------------------------------------------
--National Story Telling Festival
INSERT INTO urls (id, url, url_type_id) VALUES (98, 'http://www.storytellingcenter.net/festival/', 1);
---------------------------------------------------
--NETTA
INSERT INTO urls (id, url, url_type_id) VALUES (99, 'http://netta.com/events/', 1);
---------------------------------------------------
--News & Neighbor
INSERT INTO urls (id, url, url_type_id) VALUES (100, 'http://jcnewsandneighbor.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (101, 'https://www.facebook.com/The-Johnson-City-News-Neighbor-90093209519/', 2);
----------------------------------------------------
--Noli Food Truck
INSERT INTO urls (id, url, url_type_id) VALUES (102, 'https://www.facebook.com/Noli-425075587633794/?rf=378185665665895', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (103, 'https://twitter.com/NoliTruck?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (104, 'https://www.instagram.com/nolitruck/?hl=en', 6);
---------------------------------------------------
--Out-N-About
INSERT INTO urls (id, url, url_type_id) VALUES (105, 'http://www.outnaboutmagazine.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (106, 'https://www.facebook.com/Out-N-About-Magazine-119130208144914/', 2);
----------------------------------------------------
--Radio Web village
INSERT INTO urls (id, url, url_type_id) VALUES (107, 'http://www.radiowebvillage.com/', 1);
----------------------------------------------------
--Shop Local
INSERT INTO urls (id, url, url_type_id) VALUES (108, 'https://www.facebook.com/shoplocalinjc/', 2);
----------------------------------------------------
--Slammin Sammy's
INSERT INTO urls (id, url, url_type_id) VALUES (109, 'https://www.facebook.com/slamminsammyssandwicheskingsport/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (110, 'https://twitter.com/slamminsammys1', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (111, 'https://www.instagram.com/slamminsammyssandwiches/', 6);
----------------------------------------------------
--Sleepy Owl Brewery
INSERT INTO urls (id, url, url_type_id) VALUES (112, 'http://sleepyowlbrewery.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (113, 'https://www.facebook.com/SleepyOwlBrewery/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (114, 'https://twitter.com/SleepyOwlBrew?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (115, 'https://instagram.com/sleepyowlbrewing/', 6);
----------------------------------------------------
--Story Telling Center
INSERT INTO urls (id, url, url_type_id) VALUES (116, 'http://www.storytellingcenter.net/events/national-storytelling-festival/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (117, 'https://www.facebook.com/StorytellingCenter', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (118, 'https://twitter.com/StoryConnect', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (119, 'https://www.youtube.com/user/StorytellingFestival', 7);
INSERT INTO urls (id, url, url_type_id) VALUES (120, 'https://www.instagram.com/intstorytellingcenter/', 6);
----------------------------------------------------
--The Atlantic Ale House
INSERT INTO urls (id, url, url_type_id) VALUES (121, 'https://www.facebook.com/pages/Atlantic-Ale-House/374910849324940', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (122, 'https://twitter.com/atlanticale?ref_src=twsrc^google|twcamp^serp|twgr^author', 3);
----------------------------------------------------
--The Comedy Zone
INSERT INTO urls (id, url, url_type_id) VALUES (123, 'http://comedyzoneworldwide.com/location/6/the-comedy-zone-johnson-city-tn', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (124, 'https://www.facebook.com/TheComedyZoneJohnsonCityTN/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (125, 'https://twitter.com/reflections1', 3);
----------------------------------------------------
--The Down Home
INSERT INTO urls (id, url, url_type_id) VALUES (126, 'http://downhome.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (127, 'https://www.facebook.com/thedownhome/', 2);
----------------------------------------------------
--The Hideaway
INSERT INTO urls (id, url, url_type_id) VALUES (128, 'https://www.facebook.com/pages/The-Hideaway/135731466493421', 2);
----------------------------------------------------
--The Loafer
INSERT INTO urls (id, url, url_type_id) VALUES (129, 'https://theloaferonline.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (130, 'https://www.facebook.com/theloaferonline/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (131, 'https://twitter.com/pricelessloafer', 3);
----------------------------------------------------
--The Willow Tree
INSERT INTO urls (id, url, url_type_id) VALUES (132, 'http://www.thewillowtreejc.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (133, 'https://www.facebook.com/willowcoffeehouse', 2);
----------------------------------------------------
--Tipton Street Pub
INSERT INTO urls (id, url, url_type_id) VALUES (134, 'http://www.tiptonstreetpub.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (135, 'https://www.facebook.com/tiptonstreetpub', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (136, 'https://twitter.com/TIPTONPUB', 3);
----------------------------------------------------
--Tweetsie Trail events
INSERT INTO urls (id, url, url_type_id) VALUES (137, 'http://www.tweetsietrail.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (138, 'https://www.facebook.com/tweetsietrail/', 2);
----------------------------------------------------
--WCYB
INSERT INTO urls (id, url, url_type_id) VALUES (139, 'http://www.wcyb.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (140, 'https://www.facebook.com/news5wcyb', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (141, 'https://twitter.com/news5wcyb?ref_src=twsrc^google|twcamp^serp|twgr^author', 3);
----------------------------------------------------
--Wellington's
INSERT INTO urls (id, url, url_type_id) VALUES (142, 'http://wellingtonsrestaurant.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (143, 'https://www.facebook.com/wellingtonsrestaurant/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (144, 'https://twitter.com/wellingtonstn', 3);
----------------------------------------------------
--WETS
INSERT INTO urls (id, url, url_type_id) VALUES (145, 'http://www.etsu.edu/news/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (146, 'https://www.facebook.com/easttennesseestateuniversity', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (147, 'https://twitter.com/etsu', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (148, 'https://www.youtube.com/user/EastTennesseeState', 7);
INSERT INTO urls (id, url, url_type_id) VALUES (149, 'https://www.instagram.com/etsu/', 6);
----------------------------------------------------
--WJHL
INSERT INTO urls (id, url, url_type_id) VALUES (150, 'http://wjhl.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (151, 'https://www.facebook.com/wjhltv11', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (152, 'https://twitter.com/WJHL11', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (153, 'https://www.youtube.com/user/WJHLtv11', 7);
INSERT INTO urls (id, url, url_type_id) VALUES (154, 'https://www.instagram.com/wjhl11/', 6);
----------------------------------------------------
--WTFM
INSERT INTO urls (id, url, url_type_id) VALUES (155, 'http://www.wtfm.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (156, 'https://www.facebook.com/98.5WTFM', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (157, 'https://twitter.com/985wtfm', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (158, 'https://www.instagram.com/985wtfm/', 6);
----------------------------------------------------
--WXBQ
INSERT INTO urls (id, url, url_type_id) VALUES (159, 'http://www.wxbq.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (160, 'https://www.facebook.com/wxbqmorningairshow/', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (161, 'https://twitter.com/the_wxbq_rabbit', 3);
----------------------------------------------------
--Yee-Haw Brewing
INSERT INTO urls (id, url, url_type_id) VALUES (162, 'http://yeehawbrewing.com/', 1);
INSERT INTO urls (id, url, url_type_id) VALUES (163, 'https://www.facebook.com/yeehawbrewing', 2);
INSERT INTO urls (id, url, url_type_id) VALUES (164, 'https://twitter.com/yeehawbrewing', 3);
INSERT INTO urls (id, url, url_type_id) VALUES (165, 'https://www.instagram.com/yeehawbrewing/', 6);
----------------------------------------------------
SET IDENTITY_INSERT urls OFF


SET IDENTITY_INSERT entity_urls ON ; 
--Acoustic Coffe House
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 1, 1, 1 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 2, 1, 2 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 3, 1, 3 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 4, 1, 4 );
-------------------------------------------------------------------
--Back Door Records
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 5, 2, 5 );
-------------------------------------------------------------------
--Barter Theatre 
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 6, 3, 6 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 7, 3, 7 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 8, 3, 8 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 9, 3, 9 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 10, 3, 10 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 11, 3, 11 );
---------------------------------------------------------------------
--Brew Plum Coffe Bar
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 12, 4, 12 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 13, 4, 13 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 14, 4, 14 );
---------------------------------------------------------------------
--Bristol Chamber
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 15, 5, 15 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 16, 5, 16 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 17, 5, 17 );
---------------------------------------------------------------------
--Capone's 
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 18, 6, 18 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 19, 6, 19 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 20, 6, 20 );
---------------------------------------------------------------------
--Caribbean Grill 
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 21, 7, 21 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 22, 7, 22 );
---------------------------------------------------------------------
--Elizabethton Chamber
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 23, 8, 23 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 24, 8, 24 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 25, 8, 25 );
---------------------------------------------------------------------
--Elizabethton Star
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 26, 9, 26 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 27, 9, 27 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 28, 9, 28 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 29, 9, 29 );
---------------------------------------------------------------------
--Erwin Chamber
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 30, 10, 30);
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 31, 10, 31 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 32, 10, 32 );
----------------------------------------------------------------------
--Erwin Record
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 33, 11, 33 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 34, 11, 34 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 35, 11, 35 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 36, 11, 36 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 37, 11, 37 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 38, 11, 38 );
----------------------------------------------------------------------
--ETSU News
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 39, 12, 39 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 40, 12, 40 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 41, 12, 41 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 42, 12, 42 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 43, 12, 43 );
----------------------------------------------------------------------
--Foodie Fiction
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 44, 13, 44 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 45, 13, 45 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 46, 13, 46 );
----------------------------------------------------------------------
--Founder's Park
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 47, 14, 47 );
----------------------------------------------------------------------
--GoTriCities
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 48, 15, 48 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 49, 15, 49 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 50, 15, 50 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 51, 15, 51 );
----------------------------------------------------------------------
--Herald and Tribune 
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 52, 16, 52 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 53, 16, 53 );
----------------------------------------------------------------------
--Herald Courier
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 54, 17, 54 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 55, 17, 55 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 56, 17, 56 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 57, 17, 57 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 58, 17, 58 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 59, 17, 59 );
----------------------------------------------------------------------
--Holston River Brewing Co.
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 60, 18, 60 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 61, 18, 61 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 62, 18, 62 );
----------------------------------------------------------------------
--Johnson City Chamber
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 63, 19, 63 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 64, 19, 64 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 65, 19, 65 );
----------------------------------------------------------------------
--Johnson City 360
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 66, 20, 66 );
----------------------------------------------------------------------
--Johnson City Brewing Co.
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 67, 21, 67 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 68, 21, 68 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 69, 21, 69 );
----------------------------------------------------------------------
--Johnson City Farmers Market
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 70, 22, 70 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 71, 22, 71 );
----------------------------------------------------------------------
--Johnson City Press
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 72, 23, 72 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 73, 23, 73 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 74, 23, 74 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 75, 23, 75 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 76, 23, 76 );
----------------------------------------------------------------------
--Jonesborough Chamber
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 77, 24, 77 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 78, 24, 78 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 79, 24, 79 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 80, 24, 80 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 81, 24, 81 );
----------------------------------------------------------------------
--Kingsport Chamber
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 82, 25, 82 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 83, 25, 83 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 84, 25, 84 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 85, 25, 85 );
----------------------------------------------------------------------
--Kingsport Renaissance Center
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 86, 26, 86 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 87, 26, 87 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 88, 26, 88 );
----------------------------------------------------------------------
--Kingsport Times
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 89, 27, 89 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 90, 27, 90 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 91, 27, 91 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 92, 27, 92 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 93, 27, 93 );
----------------------------------------------------------------------
--Morrell Music
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 94, 28, 94 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 95, 28, 95 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 96, 28, 96 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 97, 28, 97 );
----------------------------------------------------------------------
--National Story Telling Festival
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 98, 29, 98 );
----------------------------------------------------------------------
--NETTA
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 99, 30, 99 );
----------------------------------------------------------------------
--News & Neighbor
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 100, 31, 100 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 101, 31, 101 );
------------------------------------------------------------------------
--Noli Food Truck
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 102, 32, 102 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 103, 32, 103 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 104, 32, 104 );
------------------------------------------------------------------------
--Out-N-About
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 105, 33, 105 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 106, 33, 106 );
------------------------------------------------------------------------
--Radio Web village
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 107, 34, 107 );
------------------------------------------------------------------------
--Shop Local
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 108, 35, 108 );
------------------------------------------------------------------------
--Slammin Sammy's
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 109, 36, 109 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 110, 36, 110 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 111, 36, 111 );
------------------------------------------------------------------------
--Sleepy Owl Brewery
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 112, 37, 112 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 113, 37, 113 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 114, 37, 114 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 115, 37, 115 );
------------------------------------------------------------------------
--Story Telling Center
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 116, 38, 116 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 117, 38, 117 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 118, 38, 118 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 119, 38, 119 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 120, 38, 120 );
------------------------------------------------------------------------
--The Atlantic Ale House
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 121, 39, 121 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 122, 39, 122 );
------------------------------------------------------------------------
--The Comedy Zone
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 123, 40, 123 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 124, 40, 124 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 125, 40, 125 );
------------------------------------------------------------------------
--The Down Home
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 126, 41, 126 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 127, 41, 127 );
------------------------------------------------------------------------
--The Hideaway
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 128, 42, 128 );
------------------------------------------------------------------------
--The Loafer
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 129, 43, 129 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 130, 43, 130 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 131, 43, 131 );
------------------------------------------------------------------------
--The Willow Tree
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 132, 44, 132 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 133, 44, 133 );
------------------------------------------------------------------------
--Tipton Street Pub
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 134, 45, 134 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 135, 45, 135 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 136, 45, 136 );
------------------------------------------------------------------------
--Tweetsie Trail events
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 137, 46, 137 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 138, 46, 138 );
------------------------------------------------------------------------
--WCYB
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 139, 47, 139 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 140, 47, 140 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 141, 47, 141 );
------------------------------------------------------------------------
--Wellington's
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 142, 48, 142 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 143, 48, 143 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 144, 48, 144 );
------------------------------------------------------------------------
--WETS
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 145, 49, 145 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 146, 49, 146 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 147, 49, 147 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 148, 49, 148 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 149, 49, 149 );
------------------------------------------------------------------------
--WJHL
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 150, 50, 150 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 151, 50, 151 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 152, 50, 152 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 153, 50, 153 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 154, 50, 154 );
------------------------------------------------------------------------
--WTFM
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 155, 51, 155 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 156, 51, 156 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 157, 51, 157 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 158, 51, 158 );
------------------------------------------------------------------------
--WXBQ
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 159, 52, 159 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 160, 52, 160 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 161, 52, 161 );
------------------------------------------------------------------------
--Yee-Haw Brewing
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 162, 53, 162 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 163, 53, 163 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 164, 53, 164 );
INSERT INTO entity_urls (id, entity_id, url_id) VALUES ( 165, 53, 165 );
------------------------------------------------------------------------
SET IDENTITY_INSERT entity_urls OFF ; 


