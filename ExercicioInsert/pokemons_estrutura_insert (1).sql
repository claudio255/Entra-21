﻿CREATE TABLE pokemons (
	id					INTEGER PRIMARY KEY IDENTITY(1,1),
	nome				VARCHAR(255),
	codigo				VARCHAR(4),
	categoria			VARCHAR(255),
	altura				FLOAT,
	peso				FLOAT,
	hp					INT,
	ataque				INT,
	defesa				INT,
	especial_ataque		INT,
	especial_defesa		INT,
	velocidade			INT,
	descricao			TEXT
 );

INSERT INTO pokemons (nome, codigo, categoria, descricao, altura, peso, hp, ataque, defesa, especial_ataque, especial_defesa, velocidade) VALUES
 ('Bulbasaur', '001', 'Seed', 'Bulbasaur can be seen napping in bright sunlight.There is a seed on its back. By soaking up the sun&#39;s rays,the seed grows progressively larger.', 0.7, 6.9, 2, 3, 2, 3, 3, 3),
('Ivysaur', '002', 'Seed', 'There is a bud on this Pokémon&#39;s back. To support its weight,Ivysaur&#39;s legs and trunk grow thick and strong.If it starts spending more time lying in the sunlight,it&#39;s a sign that the bud will bloom into a large flower soon.', 1.0, 13.0, 3, 3, 3, 4, 3, 3),
('Venusaur', '003', 'Seed', 'There is a large flower on Venusaur&#39;s back. The flower is saidto take on vivid colors if it gets plenty of nutrition and sunlight.The flower&#39;s aroma soothes the emotions of people.', 2.0, 100.0, 3, 4, 4, 5, 4, 4),
('Charmander', '004', 'Lizard', 'The flame that burns at the tip of its tail is an indicationof its emotions. The flame wavers when Charmanderis enjoying itself. If the Pokémon becomes enraged,the flame burns fiercely.', 0.6, 8.5, 2, 3, 2, 3, 2, 4),
('Charmeleon', '005', 'Flame', 'Charmeleon mercilessly destroys its foes using its sharp claws.If it encounters a strong foe, it turns aggressive.In this excited state, the flame at the tip of its tail flares with abluish white color.', 1.1, 19.0, 3, 3, 3, 4, 3, 4),
('Charizard', '006', 'Flame', 'Charizard flies around the sky in search of powerful opponents.It breathes fire of such great heat that it melts anything.However, it never turns its fiery breath on any opponentweaker than itself.', 1.7, 90.5, 3, 4, 3, 5, 4, 5),
('Squirtle', '007', 'Tiny Turtle', 'Squirtle&#39;s shell is not merely used for protection.The shell&#39;s rounded shape and the grooves on its surfacehelp minimize resistance in water, enabling this Pokémonto swim at high speeds.', 0.5, 9.0, 2, 3, 3, 2, 3, 2),
('Wartortle', '008', 'Turtle', 'Its tail is large and covered with a rich, thick fur. The tailbecomes increasingly deeper in color as Wartortle ages.The scratches on its shell are evidence of this Pokémon&#39;stoughness as a battler.', 1.0, 22.5, 3, 3, 4, 3, 3, 3),
('Blastoise', '009', 'Shellfish', 'Blastoise has water spouts that protrude from its shell.The water spouts are very accurate. They can shoot bullets ofwater with enough accuracy to strike empty cans from adistance of over 160 feet.', 1.6, 85.5, 3, 4, 4, 4, 4, 4),
('Caterpie', '010', 'Worm', 'Caterpie has a voracious appetite. It can devour leaves biggerthan its body right before your eyes. From its antenna, thisPokémon releases a terrifically strong odor.', 0.3, 2.9, 2, 2, 2, 1, 1, 3),
('Metapod', '011', 'Cocoon', 'The shell covering this Pokémon&#39;s body is as hard as aniron slab. Metapod does not move very much. It stays stillbecause it is preparing its soft innards for evolution insidethe hard shell.', 0.7, 9.9, 2, 1, 3, 1, 1, 2),
('Butterfree', '012', 'Butterfly', 'Butterfree has a superior ability to search for delicious honeyfrom flowers. It can even search out, extract, and carry honeyfrom flowers that are blooming over six miles from its nest.', 1.1, 32.0, 3, 2, 2, 4, 3, 4),
('Weedle', '013', 'Hairy Bug', 'Weedle has an extremely acute sense of smell. It is capable ofdistinguishing its favorite kinds of leaves from those it dislikesjust by sniffing with its big red proboscis (nose).', 0.3, 3.2, 2, 2, 2, 1, 1, 3),
('Kakuna', '014', 'Cocoon', 'Kakuna remains virtually immobile as it clings to a tree.However, on the inside, it is extremely busy as it prepares forits coming evolution. This is evident from how hot the shellbecomes to the touch.', 0.6, 10.0, 2, 1, 2, 1, 1, 2),
('Beedrill', '015', 'Poison Bee', 'Beedrill is extremely territorial. No one should ever approachits nest—this is for their own safety. If angered, they will attackin a furious swarm.', 1.0, 29.5, 3, 5, 2, 2, 3, 4),
('Pidgey', '016', 'Tiny Bird', 'Pidgey has an extremely sharp sense of direction. It is capableof unerringly returning home to its nest, however far it may beremoved from its familiar surroundings.', 0.3, 1.8, 2, 2, 2, 2, 2, 3),
('Pidgeotto', '017', 'Bird', 'Pidgeotto claims a large area as its own territory.This Pokémon flies around, patrolling its living space.If its territory is violated, it shows no mercy in thoroughlypunishing the foe with its sharp claws.', 1.1, 30.0, 3, 3, 3, 2, 2, 4),
('Pidgeot', '018', 'Bird', 'This Pokémon has a dazzling plumage of beautifullyglossy feathers. Many Trainers are captivated by thestriking beauty of the feathers on its head, compellingthem to choose Pidgeot as their Pokémon.', 1.5, 39.5, 3, 4, 3, 3, 3, 5),
('Rattata', '019', 'Mouse', 'Rattata is cautious in the extreme. Even while it is asleep,it constantly listens by moving its ears around. It is not pickyabout where it lives—it will make its nest anywhere.', 0.3, 3.5, 2, 3, 2, 1, 2, 4),
('Raticate', '020', 'Mouse', 'Raticate&#39;s sturdy fangs grow steadily. To keep them grounddown, it gnaws on rocks and logs. It may even chew on thewalls of houses.', 0.7, 18.5, 2, 4, 3, 2, 3, 5),
('Spearow', '021', 'Tiny Bird', 'Spearow has a very loud cry that can be heard overhalf a mile away. If its high, keening cry is heard echoing allaround, it is a sign that they are warning each other of danger.', 0.3, 2.0, 2, 3, 2, 2, 1, 4),
('Fearow', '022', 'Beak', 'Fearow is recognized by its long neck and elongated beak.They are conveniently shaped for catching prey in soilor water. It deftly moves its long and skinny beak topluck prey.', 1.2, 38.0, 3, 5, 3, 3, 3, 5),
('Ekans', '023', 'Snake', 'Ekans curls itself up in a spiral while it rests. Assuming thisposition allows it to quickly respond to a threat from anydirection with a glare from its upraised head.', 2.0, 6.9, 2, 3, 2, 2, 2, 3),
('Arbok', '024', 'Cobra', 'This Pokémon is terrifically strong in order to constrict thingswith its body. It can even flatten steel oil drums.Once Arbok wraps its body around its foe, escaping itscrunching embrace is impossible.', 3.5, 65.0, 3, 4, 3, 3, 3, 4),
('Pikachu', '025', 'Mouse', 'Whenever Pikachu comes across something new,it blasts it with a jolt of electricity. If you come across ablackened berry, it&#39;s evidence that this Pokémon mistook theintensity of its charge.', 0.4, 6.0, 2, 3, 2, 2, 2, 5),
('Raichu', '026', 'Mouse', 'If the electrical sacs become excessively charged,Raichu plants its tail in the ground and discharges.Scorched patches of ground will be found near thisPokémon&#39;s nest.', 0.8, 30.0, 3, 5, 3, 4, 3, 6),
('Sandshrew', '027', 'Mouse', 'Sandshrew&#39;s body is configured to absorb water without waste,enabling it to survive in an arid desert. This Pokémon curls upto protect itself from its enemies.', 0.6, 12.0, 2, 4, 4, 1, 1, 2),
('Sandslash', '028', 'Mouse', 'Sandslash&#39;s body is covered by tough spikes, which arehardened sections of its hide. Once a year, the old spikesfall out, to be replaced with new spikes that grow out frombeneath the old ones.', 1.0, 29.5, 3, 5, 5, 2, 2, 4),
('Nidoran', '029', 'Poison Pin', 'Nidoran? has barbs that secrete a powerful poison.They are thought to have developed as protection forthis small-bodied Pokémon. When enraged, it releasesa horrible toxin from its horn.', 0.4, 7.0, 2, 3, 2, 2, 2, 2),
('Nidorina', '030', 'Poison Pin', 'When Nidorina are with their friends or family, they keep theirbarbs tucked away to prevent hurting each other.This Pokémon appears to become nervous if separated fromthe others.', 0.8, 20.0, 3, 3, 3, 3, 2, 3),
('Nidoqueen', '031', 'Drill', 'Nidoqueen&#39;s body is encased in extremely hard scales.It is adept at sending foes flying with harsh tackles.This Pokémon is at its strongest when it is defending its young.', 1.3, 60.0, 4, 5, 4, 4, 4, 4),
('Nidoran♂', '032', 'Poison Pin', 'Nidoran? has developed muscles for moving its ears. Thanksto them, the ears can be freely moved in any direction. Eventhe slightest sound does not escape this Pokémon&#39;s notice.', 0.5, 9.0, 2, 3, 2, 2, 2, 3),
('Nidorino', '033', 'Poison Pin', 'Nidorino has a horn that is harder than a diamond. If it sensesa hostile presence, all the barbs on its back bristle up at once,and it challenges the foe with all its might.', 0.9, 19.5, 3, 4, 3, 3, 2, 4),
('Nidoking', '034', 'Drill', 'Nidoking&#39;s thick tail packs enormously destructive power.With one swing, it can topple a metal transmission tower.Once this Pokémon goes on a rampage, there is no stopping it.', 1.4, 62.0, 3, 5, 3, 4, 3, 5),
('Clefairy', '035', 'Fairy', 'On every night of a full moon, groups of this Pokémon comeout to play. When dawn arrives, the tired Clefairy return to theirquiet mountain retreats and go to sleep nestled up againsteach other.', 0.6, 7.5, 3, 2, 2, 3, 3, 2),
('Clefable', '036', 'Fairy', 'Clefable moves by skipping lightly as if it were flying using itswings. Its bouncy step lets it even walk on water. It is knownto take strolls on lakes on quiet, moonlit nights.', 1.3, 40.0, 4, 4, 3, 5, 4, 3),
('Vulpix', '037', 'Fox', 'At the time of its birth, Vulpix has one white tail. The tailseparates into six if this Pokémon receives plenty of lovefrom its Trainer. The six tails become magnificently curled.', 0.6, 9.9, 2, 2, 2, 2, 3, 4),
('Ninetales', '038', 'Fox', 'Ninetales casts a sinister light from its bright red eyes to gaintotal control over its foe&#39;s mind. This Pokémon is said to livefor a thousand years.', 1.1, 19.9, 3, 4, 3, 4, 4, 5),
('Jigglypuff', '039', 'Balloon', 'Jigglypuff&#39;s vocal cords can freely adjust the wavelength of itsvoice. This Pokémon uses this ability to sing at precisely theright wavelength to make its foes most drowsy.', 0.5, 5.5, 5, 2, 1, 2, 1, 1),
('Wigglytuff', '040', 'Balloon', 'Wigglytuff has large, saucerlike eyes. The surfaces of its eyesare always covered with a thin layer of tears. If any dust gets inthis Pokémon&#39;s eyes, it is quickly washed away.', 1.0, 12.0, 5, 4, 2, 4, 2, 3),
('Zubat', '041', 'Bat', 'Zubat remains quietly unmoving in a dark spot during the brightdaylight hours. It does so because prolonged exposure to thesun causes its body to become slightly burned.', 0.8, 7.5, 2, 2, 2, 1, 2, 3),
('Golbat', '042', 'Bat', 'Golbat loves to drink the blood of living things. It is particularlyactive in the pitch black of night. This Pokémon flits around inthe night skies, seeking fresh blood.', 1.6, 55.0, 3, 4, 3, 3, 3, 5),
('Oddish', '043', 'Weed', 'During the daytime, Oddish buries itself in soil to absorbnutrients from the ground using its entire body.The more fertile the soil, the glossier its leaves become.', 0.5, 5.4, 2, 3, 3, 4, 3, 2),
('Gloom', '044', 'Weed', 'Gloom releases a foul fragrance from the pistil of its flower.When faced with danger, the stench worsens.If this Pokémon is feeling calm and secure, it does notrelease its usual stinky aroma.', 0.8, 8.6, 3, 3, 3, 4, 3, 2),
('Vileplume', '045', 'Flower', 'Vileplume&#39;s toxic pollen triggers atrocious allergy attacks.That&#39;s why it is advisable never to approach any attractiveflowers in a jungle, however pretty they may be.', 1.2, 18.6, 3, 4, 4, 5, 4, 3),
('Paras', '046', 'Mushroom', 'Paras has parasitic mushrooms growing on its back calledtochukaso. They grow large by drawing nutrients from thisBug Pokémon host. They are highly valued as a medicinefor extending life.', 0.3, 5.4, 2, 4, 3, 2, 2, 2),
('Parasect', '047', 'Mushroom', 'Parasect is known to infest large trees en masse and drainnutrients from the lower trunk and roots. When an infested treedies, they move onto another tree all at once.', 1.0, 29.5, 3, 5, 4, 3, 3, 2),
('Venonat', '048', 'Insect', 'Venonat is said to have evolved with a coat of thin,stiff hair that covers its entire body for protection.It possesses large eyes that never fail to spot evenminuscule prey.', 1.0, 30.0, 3, 3, 2, 2, 2, 3),
('Venomoth', '049', 'Poison Moth', 'Venomoth is nocturnal—it is a Pokémon that only becomesactive at night. Its favorite prey are small insects that gatheraround streetlights, attracted by the light in the darkness.', 1.5, 12.5, 3, 3, 3, 4, 3, 5),
('Diglett', '050', 'Mole', 'Diglett are raised in most farms. The reason is simple—wherever this Pokémon burrows, the soil is left perfectly tilledfor planting crops. This soil is made ideal for growingdelicious vegetables.', 0.2, 0.8, 1, 3, 1, 2, 2, 5),
('Dugtrio', '051', 'Mole', 'Dugtrio are actually triplets that emerged from one body.As a result, each triplet thinks exactly like the othertwo triplets. They work cooperatively to burrow endlessly.', 0.7, 33.3, 2, 4, 2, 2, 3, 6),
('Meowth', '052', 'Scratch Cat', 'Meowth withdraws its sharp claws into its paws to slinkily sneakabout without making any incriminating footsteps.For some reason, this Pokémon loves shiny coins thatglitter with light.', 0.4, 4.2, 2, 2, 2, 2, 2, 5),
('Persian', '053', 'Classy Cat', 'Persian has six bold whiskers that give it a look of toughness.The whiskers sense air movements to determine what is in thePokémon&#39;s surrounding vicinity. It becomes docile if grabbedby the whiskers.', 1.0, 32.0, 3, 4, 3, 3, 3, 6),
('Psyduck', '054', 'Duck', 'Psyduck uses a mysterious power. When it does so, thisPokémon generates brain waves that are supposedly only seenin sleepers. This discovery spurred controversyamong scholars.', 0.8, 19.6, 2, 3, 2, 3, 2, 3),
('Golduck', '055', 'Duck', 'The webbed flippers on its forelegs and hind legs and thestreamlined body of Golduck give it frightening speed.This Pokémon is definitely much faster than even the mostathletic swimmer.', 1.7, 76.6, 3, 4, 3, 5, 3, 5),
('Mankey', '056', 'Pig Monkey', 'When Mankey starts shaking and its nasal breathing turnsrough, it&#39;s a sure sign that it is becoming angry. However,because it goes into a towering rage almost instantly,it is impossible for anyone to flee its wrath.', 0.5, 28.0, 2, 4, 2, 2, 2, 4),
('Primeape', '057', 'Pig Monkey', 'When Primeape becomes furious, its blood circulation isboosted. In turn, its muscles are made even stronger.However, it also becomes much less intelligent at thesame time.', 1.0, 32.0, 3, 5, 3, 3, 3, 5),
('Growlithe', '058', 'Puppy', 'Growlithe has a superb sense of smell. Once it smells anything,this Pokémon won&#39;t forget the scent, no matter what. It usesits advanced olfactory sense to determine the emotions ofother living things.', 0.7, 19.0, 2, 4, 2, 3, 2, 3),
('Arcanine', '059', 'Legendary', 'Arcanine is known for its high speed. It is said to be capable ofrunning over 6,200 miles in a single day and night.The fire that blazes wildly within this Pokémon&#39;s body is itssource of power.', 1.9, 155.0, 4, 6, 4, 5, 3, 5),
('Poliwag', '060', 'Tadpole', 'Poliwag has a very thin skin. It is possible to see thePokémon&#39;s spiral innards right through the skin.Despite its thinness, however, the skin is also very flexible.Even sharp fangs bounce right off it.', 0.6, 12.4, 2, 3, 2, 2, 2, 5),
('Poliwhirl', '061', 'Tadpole', 'The surface of Poliwhirl&#39;s body is always wet and slick witha slimy fluid. Because of this slippery covering, it can easilyslip and slide out of the clutches of any enemy in battle.', 1.0, 20.0, 3, 3, 3, 2, 2, 5),
('Poliwrath', '062', 'Tadpole', 'Poliwrath&#39;s highly developed, brawny muscles never growfatigued, however much it exercises. It is so tirelessly strong,this Pokémon can swim back and forth across the oceanwithout effort.', 1.3, 54.0, 4, 5, 4, 3, 4, 4),
('Abra', '063', 'Psi', 'Abra sleeps for eighteen hours a day. However, it can sensethe presence of foes even while it is sleeping. In such asituation, this Pokémon immediately teleports to safety.', 0.9, 19.5, 1, 1, 1, 5, 2, 5),
('Kadabra', '064', 'Psi', 'Kadabra emits a peculiar alpha wave if it develops a headache.Only those people with a particularly strong psyche can hopeto become a Trainer of this Pokémon.', 1.3, 56.5, 2, 2, 2, 6, 3, 6),
('Alakazam', '065', 'Psi', 'Alakazam&#39;s brain continually grows, making its head far tooheavy to support with its neck. This Pokémon holds its head upusing its psychokinetic power instead.', 1.5, 48.0, 2, 3, 2, 7, 4, 6),
('Machop', '066', 'Superpower', 'Machop&#39;s muscles are special—they never get sore no matterhow much they are used in exercise. This Pokémon hassufficient power to hurl a hundred adult humans.', 0.8, 19.5, 3, 4, 2, 2, 2, 2),
('Machoke', '067', 'Superpower', 'Machoke&#39;s thoroughly toned muscles possess the hardnessof steel. This Pokémon has so much strength, it can easilyhold aloft a sumo wrestler on just one finger.', 1.5, 70.5, 3, 5, 3, 2, 3, 3),
('Machamp', '068', 'Superpower', 'Machamp has the power to hurl anything aside. However,trying to do any work requiring care and dexterity causes itsarms to get tangled. This Pokémon tends to leap into actionbefore it thinks.', 1.6, 130.0, 4, 7, 4, 3, 4, 3),
('Bellsprout', '069', 'Flower', 'Bellsprout&#39;s thin and flexible body lets it bend and sway toavoid any attack, however strong it may be. From its mouth,this Pokémon spits a corrosive fluid that melts even iron.', 0.7, 4.0, 2, 4, 2, 3, 1, 2),
('Weepinbell', '070', 'Flycatcher', 'Weepinbell has a large hook on its rear end. At night, thePokémon hooks on to a tree branch and goes to sleep.If it moves around in its sleep, it may wake up to find itselfon the ground.', 1.0, 6.4, 3, 5, 2, 4, 2, 3),
('Victreebel', '071', 'Flycatcher', 'Victreebel has a long vine that extends from its head.This vine is waved and flicked about as if it were an animal toattract prey. When an unsuspecting prey draws near, thisPokémon swallows it whole.', 1.7, 15.5, 3, 5, 3, 5, 3, 4),
('Tentacool', '072', 'Jellyfish', 'Tentacool&#39;s body is largely composed of water. If it is removedfrom the sea, it dries up like parchment. If this Pokémonhappens to become dehydrated, put it back into the sea.', 0.9, 45.5, 2, 2, 2, 2, 4, 4),
('Tentacruel', '073', 'Jellyfish', 'Tentacruel has large red orbs on its head. The orbs glowbefore lashing the vicinity with a harsh ultrasonic blast.This Pokémon&#39;s outburst creates rough waves around it.', 1.6, 55.0, 3, 4, 3, 4, 5, 5),
('Geodude', '074', 'Rock', 'The longer a Geodude lives, the more its edges are chippedand worn away, making it more rounded in appearance.However, this Pokémon&#39;s heart will remain hard, craggy,and rough always.', 0.4, 20.0, 2, 4, 4, 1, 1, 1),
('Graveler', '075', 'Rock', 'Graveler grows by feeding on rocks. Apparently, it prefers toeat rocks that are covered in moss. This Pokémon eats its waythrough a ton of rocks on a daily basis.', 1.0, 105.0, 2, 5, 5, 2, 2, 2),
('Golem', '076', 'Megaton', 'Golem live up on mountains. If there is a large earthquake,these Pokémon will come rolling down off the mountainsen masse to the foothills below.', 1.4, 300.0, 3, 6, 6, 3, 3, 3),
('Ponyta', '077', 'Fire Horse', 'Ponyta is very weak at birth. It can barely stand up.This Pokémon becomes stronger by stumbling and falling tokeep up with its parent.', 1.0, 30.0, 2, 4, 3, 3, 3, 5),
('Rapidash', '078', 'Fire Horse', 'Rapidash usually can be seen casually cantering in thefields and plains. However, when this Pokémon turns serious,its fiery manes flare and blaze as it gallops its way up to150 mph.', 1.7, 95.0, 3, 5, 3, 4, 3, 6),
('Slowpoke', '079', 'Dopey', 'Slowpoke uses its tail to catch prey by dipping it in water atthe side of a river. However, this Pokémon often forgets whatit&#39;s doing and often spends entire days just loafing atwater&#39;s edge.', 1.2, 36.0, 4, 3, 3, 2, 2, 1),
('Slowbro', '080', 'Hermit Crab', 'Slowbro&#39;s tail has a Shellder firmly attached with a bite.As a result, the tail can&#39;t be used for fishing anymore.This causes Slowbro to grudgingly swim and catchprey instead.', 1.6, 78.5, 4, 4, 5, 5, 3, 2),
('Magnemite', '081', 'Magnet', 'Magnemite attaches itself to power lines to feed on electricity.If your house has a power outage, check your circuit breakers.You may find a large number of this Pokémon clinging to thebreaker box.', 0.3, 6.0, 1, 2, 3, 5, 2, 3),
('Magneton', '082', 'Magnet', 'Magneton emits a powerful magnetic force that is fatal tomechanical devices. As a result, large cities sound sirensto warn citizens of large-scale outbreaks of this Pokémon.', 1.0, 60.0, 2, 3, 4, 6, 3, 4),
('Farfetch&#39;d', '083', 'Wild Duck', 'Farfetch&#39;d is always seen with a stalk from a plant of somesort. Apparently, there are good stalks and bad stalks. ThisPokémon has been known to fight with others over stalks.', 0.8, 15.0, 2, 3, 3, 3, 3, 3),
('Doduo', '084', 'Twin Bird', 'Doduo&#39;s two heads never sleep at the same time. Its twoheads take turns sleeping, so one head can always keepwatch for enemies while the other one sleeps.', 1.4, 39.2, 2, 4, 2, 2, 2, 4),
('Dodrio', '085', 'Triple Bird', 'Watch out if Dodrio&#39;s three heads are looking in three separatedirections. It&#39;s a sure sign that it is on its guard. Don&#39;t go nearthis Pokémon if it&#39;s being wary—it may decide to peck you.', 1.8, 85.2, 3, 6, 3, 3, 3, 5),
('Seel', '086', 'Sea Lion', 'Seel hunts for prey in the frigid sea underneath sheets of ice.When it needs to breathe, it punches a hole through the icewith the sharply protruding section of its head.', 1.1, 90.0, 3, 2, 3, 2, 3, 3),
('Dewgong', '087', 'Sea Lion', 'Dewgong loves to snooze on bitterly cold ice. The sight of thisPokémon sleeping on a glacier was mistakenly thought to be amermaid by a mariner long ago.', 1.7, 120.0, 4, 4, 4, 3, 4, 4),
('Grimer', '088', 'Sludge', 'Grimer&#39;s sludgy and rubbery body can be forced through anyopening, however small it may be. This Pokémon enters sewerpipes to drink filthy wastewater.', 0.9, 30.0, 3, 4, 2, 2, 2, 2),
('Muk', '089', 'Sludge', 'From Muk&#39;s body seeps a foul fluid that gives off anose-bendingly horrible stench. Just one drop of thisPokémon&#39;s body fluid can turn a pool stagnant and rancid.', 1.2, 30.0, 4, 5, 3, 3, 4, 3),
('Shellder', '090', 'Bivalve', 'At night, this Pokémon uses its broad tongue to burrow a holein the seafloor sand and then sleep in it. While it is sleeping,Shellder closes its shell, but leaves its tongue hanging out.', 0.3, 4.0, 2, 3, 4, 2, 1, 2),
('Cloyster', '091', 'Bivalve', 'Cloyster is capable of swimming in the sea. It does so byswallowing water, then jetting it out toward the rear.This Pokémon shoots spikes from its shell using thesame system.', 1.5, 132.5, 2, 5, 8, 4, 2, 4),
('Gastly', '092', 'Gas', 'Gastly is largely composed of gaseous matter. When exposedto a strong wind, the gaseous body quickly dwindles away.Groups of this Pokémon cluster under the eaves of houses toescape the ravages of wind.', 1.3, 0.1, 2, 2, 2, 5, 2, 4),
('Haunter', '093', 'Gas', 'Haunter is a dangerous Pokémon. If one beckons you whilefloating in darkness, you must never approach it. This Pokémonwill try to lick you with its tongue and steal your life away.', 1.6, 0.1, 2, 3, 2, 6, 2, 5),
('Gengar', '094', 'Shadow', 'Sometimes, on a dark night, your shadow thrown by astreetlight will suddenly and startlingly overtake you.It is actually a Gengar running past you, pretending to beyour shadow.', 1.5, 40.5, 3, 3, 3, 6, 3, 6),
('Onix', '095', 'Rock Snake', 'Onix has a magnet in its brain. It acts as a compass so that thisPokémon does not lose direction while it is tunneling.As it grows older, its body becomes increasingly rounderand smoother.', 8.8, 210.0, 2, 2, 7, 1, 2, 4),
('Drowzee', '096', 'Hypnosis', 'If your nose becomes itchy while you are sleeping, it&#39;s a suresign that one of these Pokémon is standing above your pillowand trying to eat your dream through your nostrils.', 1.0, 32.4, 3, 3, 2, 2, 4, 2),
('Hypno', '097', 'Hypnosis', 'Hypno holds a pendulum in its hand. The arcing movement andglitter of the pendulum lull the foe into a deep state ofhypnosis. While this Pokémon searches for prey, it polishesthe pendulum.', 1.6, 75.6, 3, 4, 3, 4, 5, 4),
('Krabby', '098', 'River Crab', 'Krabby live on beaches, burrowed inside holes dug into thesand. On sandy beaches with little in the way of food, thesePokémon can be seen squabbling with each otherover territory.', 0.4, 6.5, 2, 5, 4, 1, 1, 3),
('Kingler', '099', 'Pincer', 'Kingler has an enormous, oversized claw. It waves this hugeclaw in the air to communicate with others. However, becausethe claw is so heavy, the Pokémon quickly tires.', 1.3, 60.0, 2, 7, 5, 2, 2, 4),
('Voltorb', '100', 'Ball', 'Voltorb was first sighted at a company that manufacturesPoké Balls. The link between that sighting and the factthat this Pokémon looks very similar to a Poké Ball remainsa mystery.', 0.5, 10.4, 2, 2, 2, 3, 2, 5),
('Electrode', '101', 'Ball', 'Electrode eats electricity in the atmosphere. On days whenlightning strikes, you can see this Pokémon exploding all overthe place from eating too much electricity.', 1.2, 66.6, 3, 3, 3, 4, 3, 7),
('Exeggcute', '102', 'Egg', 'This Pokémon consists of six eggs that form a closely knitcluster. The six eggs attract each other and spin around.When cracks increasingly appear on the eggs, Exeggcute isclose to evolution.', 0.4, 2.5, 3, 2, 4, 3, 2, 2),
('Exeggutor', '103', 'Coconut', 'Exeggutor originally came from the tropics. Its headssteadily grow larger from exposure to strong sunlight.It is said that when the heads fall off, they group togetherto form Exeggcute.', 2.0, 120.0, 4, 5, 4, 6, 3, 3),
('Cubone', '104', 'Lonely', 'Cubone pines for the mother it will never see again.Seeing a likeness of its mother in the full moon, it cries.The stains on the skull the Pokémon wears are made by thetears it sheds.', 0.4, 6.5, 2, 3, 4, 2, 2, 2),
('Marowak', '105', 'Bone Keeper', 'Marowak is the evolved form of a Cubone that has overcomeits sadness at the loss of its mother and grown tough.This Pokémon&#39;s tempered and hardened spirit is noteasily broken.', 1.0, 45.0, 3, 4, 5, 2, 3, 3),
('Hitmonlee', '106', 'Kicking', 'Hitmonlee&#39;s legs freely contract and stretch. Using thesespringlike legs, it bowls over foes with devastating kicks.After battle, it rubs down its legs and loosens the muscles toovercome fatigue.', 1.5, 49.8, 2, 6, 2, 2, 5, 5),
('Hitmonchan', '107', 'Punching', 'Hitmonchan is said to possess the spirit of a boxer who hadbeen working toward a world championship. This Pokémon hasan indomitable spirit and will never give up in the faceof adversity.', 1.4, 50.2, 2, 5, 3, 2, 5, 4),
('Lickitung', '108', 'Licking', 'Whenever Lickitung comes across something new, it willunfailingly give it a lick. It does so because it memorizes thingsby texture and by taste. It is somewhat put off by sour things.', 1.2, 65.5, 4, 3, 3, 3, 3, 2),
('Koffing', '109', 'Poison Gas', 'If Koffing becomes agitated, it raises the toxicity of its internalgases and jets them out from all over its body. This Pokémonmay also overinflate its round body, then explode.', 0.6, 1.0, 2, 3, 4, 3, 2, 2),
('Weezing', '110', 'Poison Gas', 'Weezing loves the gases given off by rotted kitchen garbage.This Pokémon will find a dirty, unkempt house and make it itshome. At night, when the people in the house are asleep, it willgo through the trash.', 1.2, 9.5, 3, 5, 5, 4, 3, 3),
('Rhyhorn', '111', 'Spikes', 'Rhyhorn runs in a straight line, smashing everything in its path.It is not bothered even if it rushes headlong into a block ofsteel. This Pokémon may feel some pain from the collision thenext day, however.', 1.0, 115.0, 3, 4, 4, 1, 1, 2),
('Rhydon', '112', 'Drill', 'Rhydon&#39;s horn can crush even uncut diamonds. One sweepingblow of its tail can topple a building. This Pokémon&#39;s hide isextremely tough. Even direct cannon hits don&#39;t leave a scratch.', 1.9, 120.0, 4, 7, 5, 2, 2, 2),
('Chansey', '113', 'Egg', 'Chansey lays nutritionally excellent eggs on an everyday basis.The eggs are so delicious, they are easily and eagerlydevoured by even those people who have lost their appetite.', 1.1, 34.6, 9, 1, 1, 2, 4, 3),
('Tangela', '114', 'Vine', 'Tangela&#39;s vines snap off easily if they are grabbed.This happens without pain, allowing it to make a quickgetaway. The lost vines are replaced by newly grown vines thevery next day.', 1.0, 35.0, 3, 3, 5, 5, 2, 3),
('Kangaskhan', '115', 'Parent', 'If you come across a young Kangaskhan playing by itself, youmust never disturb it or attempt to catch it. The babyPokémon&#39;s parent is sure to be in the area, and it will becomeviolently enraged at you.', 2.2, 80.0, 4, 5, 4, 2, 3, 5),
('Horsea', '116', 'Dragon', 'Horsea eats small insects and moss off of rocks. If the oceancurrent turns fast, this Pokémon anchors itself by wrapping itstail around rocks or coral to prevent being washed away.', 0.4, 8.0, 2, 2, 3, 3, 1, 3),
('Seadra', '117', 'Dragon', 'Seadra sleeps after wriggling itself between the branches ofcoral. Those trying to harvest coral are occasionally stung bythis Pokémon&#39;s poison barbs if they fail to notice it.', 1.2, 25.0, 2, 3, 4, 5, 2, 5),
('Goldeen', '118', 'Goldfish', 'Goldeen is a very beautiful Pokémon with fins that billowelegantly in water. However, don&#39;t let your guard down aroundthis Pokémon—it could ram you powerfully with its horn.', 0.6, 15.0, 2, 4, 3, 2, 2, 3),
('Seaking', '119', 'Goldfish', 'In the autumn, Seaking males can be seen performingcourtship dances in riverbeds to woo females. During thisseason, this Pokémon&#39;s body coloration is at its most beautiful.', 1.3, 39.0, 3, 5, 3, 3, 3, 4),
('Staryu', '120', 'Star Shape', 'Staryu&#39;s center section has an organ called the core thatshines bright red. If you go to a beach toward the end ofsummer, the glowing cores of these Pokémon look like thestars in the sky.', 0.8, 34.5, 2, 2, 3, 3, 2, 5),
('Starmie', '121', 'Mysterious', 'Starmie&#39;s center section—the core—glows brightly in sevencolors. Because of its luminous nature, this Pokémon hasbeen given the nickname “the gem of the sea.&quot;', 1.1, 80.0, 3, 4, 4, 5, 4, 6),
('Mr. Mime', '122', 'Barrier', 'Mr. Mime is a master of pantomime. Its gestures and motionsconvince watchers that something unseeable actually exists.Once the watchers are convinced, the unseeable thing existsas if it were real.', 1.3, 54.5, 2, 2, 3, 5, 5, 5),
('Scyther', '123', 'Mantis', 'Scyther is blindingly fast. Its blazing speed enhances theeffectiveness of the twin scythes on its forearms.This Pokémon&#39;s scythes are so effective, they can slicethrough thick logs in one wicked stroke.', 1.5, 56.0, 3, 6, 4, 3, 3, 6),
('Jynx', '124', 'Human Shape', 'Jynx walks rhythmically, swaying and shaking its hips as if itwere dancing. Its motions are so bouncingly alluring, peopleseeing it are compelled to shake their hips without giving anythought to what they are doing.', 1.4, 40.6, 3, 3, 2, 6, 4, 5),
('Electabuzz', '125', 'Electric', 'When a storm arrives, gangs of this Pokémon compete witheach other to scale heights that are likely to be stricken bylightning bolts. Some towns use Electabuzz in place oflightning rods.', 1.1, 30.0, 3, 4, 3, 5, 4, 6),
('Magmar', '126', 'Spitfire', 'In battle, Magmar blows out intensely hot flames from allover its body to intimidate its opponent. This Pokémon&#39;sfiery bursts create heat waves that ignite grass and treesin its surroundings.', 1.3, 44.5, 3, 5, 3, 5, 4, 5),
('Pinsir', '127', 'Stag Beetle', 'Pinsir is astoundingly strong. It can grip a foe weighing twiceits weight in its horns and easily lift it. This Pokémon&#39;smovements turn sluggish in cold places.', 1.5, 55.0, 3, 6, 4, 3, 3, 5),
('Tauros', '128', 'Wild Bull', 'This Pokémon is not satisfied unless it is rampaging at alltimes. If there is no opponent for Tauros to battle, it willcharge at thick trees and knock them down to calm itself.', 1.4, 88.4, 3, 5, 4, 2, 3, 6),
('Magikarp', '129', 'Fish', 'Magikarp is a pathetic excuse for a Pokémon that is onlycapable of flopping and splashing. This behavior promptedscientists to undertake research into it.', 0.9, 10.0, 1, 1, 3, 1, 1, 4),
('Gyarados', '130', 'Atrocious', 'When Magikarp evolves into Gyarados, its brain cells undergo astructural transformation. It is said that this transformation is toblame for this Pokémon&#39;s wildly violent nature.', 6.5, 235.0, 4, 6, 3, 3, 4, 4),
('Lapras', '131', 'Transport', 'People have driven Lapras almost to the point of extinction.In the evenings, this Pokémon is said to sing plaintively as itseeks what few others of its kind still remain.', 2.5, 220.0, 5, 4, 4, 4, 4, 3),
('Ditto', '132', 'Transform', 'Ditto rearranges its cell structure to transform itself into othershapes. However, if it tries to transform itself into somethingby relying on its memory, this Pokémon manages to getdetails wrong.', 0.3, 4.0, 2, 3, 2, 2, 2, 3),
('Eevee', '133', 'Evolution', 'Eevee has an unstable genetic makeup that suddenly mutatesdue to the environment in which it lives. Radiation from variousstones causes this Pokémon to evolve.', 0.3, 6.5, 2, 3, 2, 2, 3, 3),
('Vaporeon', '134', 'Bubble Jet', 'Vaporeon underwent a spontaneous mutation and grew finsand gills that allow it to live underwater. This Pokémon has theability to freely control water.', 1.0, 29.0, 5, 3, 3, 5, 4, 4),
('Jolteon', '135', 'Lightning', 'Jolteon&#39;s cells generate a low level of electricity. This power isamplified by the static electricity of its fur, enabling thePokémon to drop thunderbolts. The bristling fur is made ofelectrically charged needles.', 0.8, 24.5, 3, 3, 3, 5, 4, 7),
('Flareon', '136', 'Flame', 'Flareon&#39;s fluffy fur has a functional purpose—it releases heatinto the air so that its body does not get excessively hot.This Pokémon&#39;s body temperature can rise to a maximum of1,650 degrees Fahrenheit.', 0.9, 25.0, 3, 7, 3, 5, 5, 4),
('Porygon', '137', 'Virtual', 'Porygon is capable of reverting itself entirely back to programdata and entering cyberspace. This Pokémon is copy protectedso it cannot be duplicated by copying.', 0.8, 36.5, 3, 3, 3, 4, 3, 2),
('Omanyte', '138', 'Spiral', 'Omanyte is one of the ancient and long-since-extinct Pokémonthat have been regenerated from fossils by people. If attackedby an enemy, it withdraws itself inside its hard shell.', 0.4, 7.5, 2, 2, 4, 4, 2, 2),
('Omastar', '139', 'Spiral', 'Omastar uses its tentacles to capture its prey. It is believed tohave become extinct because its shell grew too large andheavy, causing its movements to become too slowand ponderous.', 1.0, 35.0, 3, 3, 5, 6, 3, 3),
('Kabuto', '140', 'Shellfish', 'Kabuto is a Pokémon that has been regenerated from a fossil.However, in extremely rare cases, living examples have beendiscovered. The Pokémon has not changed at all for300 million years.', 0.5, 11.5, 2, 4, 4, 3, 2, 3),
('Kabutops', '141', 'Shellfish', 'Kabutops swam underwater to hunt for its prey in ancienttimes. The Pokémon was apparently evolving from being awater dweller to living on land as evident from the beginningsof change in its gills and legs.', 1.3, 40.5, 3, 6, 5, 3, 3, 4),
('Aerodactyl', '142', 'Fossil', 'Aerodactyl is a Pokémon from the age of dinosaurs. It wasregenerated from genetic material extracted from amber. It isimagined to have been the king of the skies in ancient times.', 1.8, 59.0, 3, 5, 3, 3, 3, 7),
('Snorlax', '143', 'Sleeping', 'Snorlax&#39;s typical day consists of nothing more than eating andsleeping. It is such a docile Pokémon that there are childrenwho use its expansive belly as a place to play.', 2.1, 460.0, 6, 6, 3, 3, 5, 2),
('Articuno', '144', 'Freeze', 'Articuno is a legendary bird Pokémon that can control ice.The flapping of its wings chills the air. As a result, it is saidthat when this Pokémon flies, snow will fall.', 1.7, 55.4, 4, 4, 4, 5, 5, 5),
('Zapdos', '145', 'Electric', 'Zapdos is a legendary bird Pokémon that has the ability tocontrol electricity. It usually lives in thunderclouds.The Pokémon gains power if it is stricken by lightning bolts.', 1.6, 52.6, 4, 5, 4, 6, 4, 5),
('Moltres', '146', 'Flame', 'Moltres is a legendary bird Pokémon that has the ability tocontrol fire. If this Pokémon is injured, it is said to dip its bodyin the molten magma of a volcano to burn and heal itself.', 2.0, 60.0, 4, 5, 4, 6, 4, 5),
('Dratini', '147', 'Dragon', 'Dratini continually molts and sloughs off its old skin. It does sobecause the life energy within its body steadily builds to reachuncontrollable levels.', 1.8, 3.3, 2, 3, 2, 2, 2, 3),
('Dragonair', '148', 'Dragon', 'Dragonair stores an enormous amount of energy inside itsbody. It is said to alter weather conditions in its vicinity bydischarging energy from the crystals on its neck and tail.', 4.0, 16.5, 3, 4, 3, 3, 3, 4),
('Dragonite', '149', 'Dragon', 'Dragonite is capable of circling the globe in just 16 hours.It is a kindhearted Pokémon that leads lost and founderingships in a storm to the safety of land.', 2.2, 210.0, 4, 7, 4, 5, 4, 4),
('Mewtwo', '150', 'Genetic', 'Mewtwo is a Pokémon that was created by geneticmanipulation. However, even though the scientific power ofhumans created this Pokémon&#39;s body, they failed to endowMewtwo with a compassionate heart.', 2.0, 122.0, 4, 6, 4, 8, 4, 7),
('Mew', '151', 'New Species', 'Mew is said to possess the genetic composition of allPokémon. It is capable of making itself invisible at will,so it entirely avoids notice even if it approaches people.', 0.4, 4.0, 4, 5, 4, 5, 4, 5),
('Chikorita', '152', 'Leaf', 'In battle, Chikorita waves its leaf around to keep the foe atbay. However, a sweet fragrance also wafts from the leaf,becalming the battling Pokémon and creating a cozy, friendlyatmosphere all around.', 0.9, 6.4, 2, 3, 3, 2, 3, 3),
('Bayleef', '153', 'Leaf', 'Bayleef&#39;s neck is ringed by curled-up leaves. Inside eachtubular leaf is a small shoot of a tree. The fragrance of thisshoot makes people peppy.', 1.2, 15.8, 3, 3, 4, 3, 3, 3),
('Meganium', '154', 'Herb', 'The fragrance of Meganium&#39;s flower soothes and calmsemotions. In battle, this Pokémon gives off more of itsbecalming scent to blunt the foe&#39;s fighting spirit.', 1.8, 100.5, 3, 4, 4, 4, 4, 4),
('Cyndaquil', '155', 'Fire Mouse', 'Cyndaquil protects itself by flaring up the flames on its back.The flames are vigorous if the Pokémon is angry. However, if itis tired, the flames splutter fitfully with incomplete combustion.', 0.5, 7.9, 2, 3, 2, 3, 2, 4),
('Quilava', '156', 'Volcano', 'Quilava keeps its foes at bay with the intensity of its flames andgusts of superheated air. This Pokémon applies its outstandingnimbleness to dodge attacks even while scorching the foewith flames.', 0.9, 19.0, 3, 3, 3, 4, 3, 4),
('Typhlosion', '157', 'Volcano', 'Typhlosion obscures itself behind a shimmering heat haze thatit creates using its intensely hot flames. This Pokémon createsblazing explosive blasts that burn everything to cinders.', 1.7, 79.5, 3, 4, 3, 5, 4, 5),
('Totodile', '158', 'Big Jaw', 'Despite the smallness of its body, Totodile&#39;s jaws are verypowerful. While the Pokémon may think it is just playfullynipping, its bite has enough power to cause serious injury.', 0.6, 9.5, 2, 3, 3, 2, 2, 2),
('Croconaw', '159', 'Big Jaw', 'Once Croconaw has clamped its jaws on its foe, it willabsolutely not let go. Because the tips of its fangs are forkedback like barbed fishhooks, they become impossible to removewhen they have sunk in.', 1.1, 25.0, 3, 4, 4, 3, 3, 3),
('Feraligatr', '160', 'Big Jaw', 'Feraligatr intimidates its foes by opening its huge mouth.In battle, it will kick the ground hard with its thick and powerfulhind legs to charge at the foe at an incredible speed.', 2.3, 88.8, 3, 5, 4, 4, 3, 4),
('Sentret', '161', 'Scout', 'When Sentret sleeps, it does so while another stands guard.The sentry wakes the others at the first sign of danger.When this Pokémon becomes separated from its pack,it becomes incapable of sleep due to fear.', 0.8, 6.0, 2, 2, 2, 2, 2, 1),
('Furret', '162', 'Long Body', 'Furret has a very slim build. When under attack, it can slicklysquirm through narrow spaces and get away. In spite of itsshort limbs, this Pokémon is very nimble and fleet.', 1.8, 32.5, 3, 4, 3, 2, 2, 5),
('Hoothoot', '163', 'Owl', 'Hoothoot has an internal organ that senses and tracks theearth&#39;s rotation. Using this special organ, this Pokémon beginshooting at precisely the same time every day.', 0.7, 21.2, 3, 2, 2, 2, 2, 3),
('Noctowl', '164', 'Owl', 'Noctowl never fails at catching prey in darkness. This Pokémonowes its success to its superior vision that allows it to see inminimal light, and to its soft, supple wings that make no soundin flight.', 1.6, 40.8, 4, 3, 2, 4, 4, 4),
('Ledyba', '165', 'Five Star', 'Ledyba secretes an aromatic fluid from where its legs join itsbody. This fluid is used for communicating with others.This Pokémon conveys its feelings to others by altering thefluid&#39;s scent.', 1.0, 10.8, 2, 1, 2, 2, 3, 3),
('Ledian', '166', 'Five Star', 'It is said that in lands with clean air, where the stars fill thesky, there live Ledian in countless numbers. There is a goodreason for this—the Pokémon uses the light of the stars asits energy.', 1.4, 35.6, 2, 2, 2, 3, 5, 5),
('Spinarak', '167', 'String Spit', 'The web spun by Spinarak can be considered its secondnervous system. It is said that this Pokémon can determinewhat kind of prey is touching its web just by the tiny vibrationsit feels through the web&#39;s strands.', 0.5, 8.5, 2, 3, 2, 2, 2, 2),
('Ariados', '168', 'Long Leg', 'Ariados&#39;s feet are tipped with tiny hooked claws that enable itto scuttle on ceilings and vertical walls. This Pokémonconstricts the foe with thin and strong silk webbing.', 1.1, 33.5, 3, 5, 3, 3, 3, 2),
('Crobat', '169', 'Bat', 'If this Pokémon is flying by fluttering only a pair of wings oneither the forelegs or hind legs, it&#39;s proof that Crobat has beenflying a long distance. It switches the wings it uses if it is tired.', 1.8, 75.0, 3, 5, 4, 3, 3, 7),
('Chinchou', '170', 'Angler', 'Chinchou lets loose positive and negative electrical chargesfrom its two antennas to make its prey faint. This Pokémonflashes its electric lights to exchange signals with others.', 0.5, 12.0, 3, 2, 2, 3, 2, 4),
('Lanturn', '171', 'Light', 'Lanturn is nicknamed “the deep-sea star&quot; for its illuminatedantenna. This Pokémon produces light by causing a chemicalreaction between bacteria and its bodily fluids insidethe antenna.', 1.2, 22.5, 5, 3, 3, 4, 3, 4),
('Pichu', '172', 'Tiny Mouse', 'Pichu charges itself with electricity more easily on days withthunderclouds or when the air is very dry. You can hear thecrackling of static electricity coming off this Pokémon.', 0.3, 2.0, 1, 2, 1, 2, 2, 3),
('Cleffa', '173', 'Star Shape', 'On nights with many shooting stars, Cleffa can be seendancing in a ring. They dance through the night and stop onlyat the break of day, when these Pokémon quench their thirstwith the morning dew.', 0.3, 3.0, 2, 1, 1, 2, 2, 1),
('Igglybuff', '174', 'Balloon', 'Igglybuff&#39;s vocal cords are not sufficiently developed. It wouldhurt its throat if it were to sing too much. This Pokémongargles with freshwater from a clean stream.', 0.3, 1.0, 4, 2, 1, 2, 1, 1),
('Togepi', '175', 'Spike Ball', 'As its energy, Togepi uses the positive emotions ofcompassion and pleasure exuded by people and Pokémon.This Pokémon stores up feelings of happiness inside its shell,then shares them with others.', 0.3, 1.5, 2, 1, 3, 2, 3, 1),
('Togetic', '176', 'Happiness', 'Togetic is said to be a Pokémon that brings good fortune.When the Pokémon spots someone who is pure of heart, it issaid to appear and share its happiness with that person.', 0.6, 3.2, 2, 2, 4, 4, 4, 2),
('Natu', '177', 'Tiny Bird', 'Natu cannot fly because its wings are not yet fully grown.If your eyes meet with this Pokémon&#39;s eyes, it will stare backintently at you. But if you move even slightly, it will hop awayto safety.', 0.2, 2.0, 2, 3, 2, 3, 2, 4),
('Xatu', '178', 'Mystic', 'Xatu stands rooted and still in one spot all day long.People believe that this Pokémon does so out of fear of theterrible things it has foreseen in the future.', 1.5, 15.0, 3, 4, 3, 5, 3, 5),
('Mareep', '179', 'Wool', 'Mareep&#39;s fluffy coat of wool rubs together and builds a staticcharge. The more static electricity is charged, the more brightlythe lightbulb at the tip of its tail glows.', 0.6, 7.8, 2, 2, 2, 3, 2, 2),
('Flaaffy', '180', 'Wool', 'Flaaffy&#39;s wool quality changes so that it can generate a highamount of static electricity with a small amount of wool.The bare and slick parts of its hide are shieldedagainst electricity.', 0.8, 13.3, 3, 3, 3, 4, 3, 3),
('Ampharos', '181', 'Light', 'Ampharos gives off so much light that it can be seen even fromspace. People in the old days used the light of this Pokémonto send signals back and forth with others far away.', 1.4, 61.5, 4, 4, 4, 6, 4, 3),
('Bellossom', '182', 'Flower', 'When Bellossom gets exposed to plenty of sunlight, the leavesringing its body begin to spin around. This Pokémon&#39;s dancingis renowned in the southern lands.', 0.4, 5.8, 3, 4, 4, 4, 4, 3),
('Marill', '183', 'Aqua Mouse', 'Marill&#39;s oil-filled tail acts much like a life preserver. If you seejust its tail bobbing on the water&#39;s surface, it&#39;s a sureindication that this Pokémon is diving beneath the water tofeed on aquatic plants.', 0.4, 8.5, 3, 1, 2, 1, 2, 2),
('Azumarill', '184', 'Aqua Rabbit', 'Azumarill&#39;s long ears are indispensable sensors. By focusing itshearing, this Pokémon can identify what kinds of prey arearound, even in rough and fast-running rivers.', 0.8, 28.5, 4, 3, 4, 3, 3, 3),
('Sudowoodo', '185', 'Imitation', 'Sudowoodo camouflages itself as a tree to avoid beingattacked by enemies. However, because its hands remaingreen throughout the year, the Pokémon is easily identifiedas a fake during the winter.', 1.2, 38.0, 3, 5, 5, 1, 3, 2),
('Politoed', '186', 'Frog', 'The curled hair on Politoed&#39;s head is proof of its status as aking. It is said that the longer and more curled the hair, themore respect this Pokémon earns from its peers.', 1.1, 33.9, 4, 4, 3, 4, 4, 4),
('Hoppip', '187', 'Cottonweed', 'This Pokémon drifts and floats with the wind. If it senses theapproach of strong winds, Hoppip links its leaves with otherHoppip to prepare against being blown away.', 0.4, 0.5, 2, 2, 2, 2, 2, 3),
('Skiploom', '188', 'Cottonweed', 'Skiploom&#39;s flower blossoms when the temperature risesabove 64 degrees Fahrenheit. How much the flower opensdepends on the temperature. For that reason, this Pokémonis sometimes used as a thermometer.', 0.6, 1.0, 2, 2, 2, 2, 3, 4),
('Jumpluff', '189', 'Cottonweed', 'Jumpluff rides warm southern winds to cross the sea and fly toforeign lands. The Pokémon descends to the ground when itencounters cold air while it is floating.', 0.8, 3.0, 3, 3, 3, 3, 4, 6),
('Aipom', '190', 'Long Tail', 'Aipom&#39;s tail ends in a hand-like appendage that can be cleverlymanipulated. However, because the Pokémon uses its tail somuch, its real hands have become rather clumsy.', 0.8, 11.5, 2, 4, 3, 2, 2, 5),
('Sunkern', '191', 'Seed', 'Sunkern tries to move as little as it possibly can. It does sobecause it tries to conserve all the nutrients it has stored in itsbody for its evolution. It will not eat a thing, subsisting only onmorning dew.', 0.3, 1.8, 2, 2, 2, 1, 1, 2),
('Sunflora', '192', 'Sun', 'Sunflora converts solar energy into nutrition. It moves aroundactively in the daytime when it is warm. It stops moving assoon as the sun goes down for the night.', 0.8, 8.5, 3, 4, 3, 5, 4, 2),
('Yanma', '193', 'Clear Wing', 'Yanma is capable of seeing 360 degrees without having tomove its eyes. It is a great flier that is adept at making suddenstops and turning midair. This Pokémon uses its flying ability toquickly chase down targeted prey.', 1.2, 38.0, 3, 3, 2, 4, 2, 5),
('Wooper', '194', 'Water Fish', 'Wooper usually lives in water. However, it occasionally comesout onto land in search of food. On land, it coats its body witha gooey, toxic film.', 0.4, 8.5, 2, 2, 2, 1, 1, 1),
('Quagsire', '195', 'Water Fish', 'Quagsire hunts for food by leaving its mouth wide open inwater and waiting for its prey to blunder in unaware. Becausethe Pokémon does not move, it does not get very hungry.', 1.4, 75.0, 4, 4, 4, 3, 3, 2),
('Espeon', '196', 'Sun', 'Espeon is extremely loyal to any Trainer it considers tobe worthy. It is said that this Pokémon developed itsprecognitive powers to protect its Trainer from harm.', 0.9, 26.5, 3, 3, 3, 6, 4, 6),
('Umbreon', '197', 'Moonlight', 'Umbreon evolved as a result of exposure to the moon&#39;s waves.It hides silently in darkness and waits for its foes to make amove. The rings on its body glow when it leaps to attack.', 1.0, 27.0, 4, 3, 5, 3, 5, 4),
('Murkrow', '198', 'Darkness', 'Murkrow was feared and loathed as the alleged bearer of illfortune. This Pokémon shows strong interest in anything thatsparkles or glitters. It will even try to steal rings from women.', 0.5, 2.1, 3, 4, 2, 4, 2, 5),
('Slowking', '199', 'Royal', 'Slowking undertakes research every day in an effort to solvethe mysteries of the world. However, this Pokémon apparentlyforgets everything it has learned if the Shellder on its headcomes off.', 2.0, 79.5, 4, 4, 4, 5, 5, 2),
('Misdreavus', '200', 'Screech', 'Misdreavus frightens people with a creepy, sobbing cry.The Pokémon apparently uses its red spheres to absorb thefearful feelings of foes and turn them into nutrition.', 0.7, 1.0, 3, 3, 3, 4, 4, 5),
('Unown', '201', 'Symbol', 'This Pokémon is shaped like ancient writing. It is a mystery asto which came first, the ancient writings or the various Unown.Research into this topic is ongoing but nothing is known.', 0.5, 5.0, 2, 4, 2, 4, 2, 3),
('Wobbuffet', '202', 'Patient', 'If two or more Wobbuffet meet, they will turn competitiveand try to outdo each other&#39;s endurance. However, they maytry to see which one can endure the longest without food.Trainers need to beware of this habit.', 1.3, 28.5, 7, 2, 3, 2, 2, 2),
('Girafarig', '203', 'Long Neck', 'Girafarig&#39;s rear head also has a brain, but it is small. The rearhead attacks in response to smells and sounds. Approachingthis Pokémon from behind can cause the rear head to suddenlylash out and bite.', 1.5, 41.5, 3, 4, 3, 4, 3, 5),
('Pineco', '204', 'Bagworm', 'Pineco hangs from a tree branch and patiently waits for prey tocome along. If the Pokémon is disturbed while eating bysomeone shaking its tree, it drops down to the ground andexplodes with no warning.', 0.6, 7.2, 2, 3, 4, 2, 2, 1),
('Forretress', '205', 'Bagworm', 'Forretress conceals itself inside its hardened steel shell.The shell is opened when the Pokémon is catching prey,but it does so at such a quick pace that the shell&#39;s insidecannot be seen.', 1.2, 125.8, 3, 5, 6, 3, 3, 2),
('Dunsparce', '206', 'Land Snake', 'Dunsparce has a drill for its tail. It uses this tail to burrow intothe ground backward. This Pokémon is known to make itsnest in complex shapes deep under the ground.', 1.5, 14.0, 4, 4, 3, 3, 3, 3),
('Gligar', '207', 'Fly Scorpion', 'Gligar glides through the air without a sound as if it weresliding. This Pokémon hangs on to the face of its foe usingits clawed hind legs and the large pincers on its forelegs, theninjects the prey with its poison barb.', 1.1, 64.8, 3, 4, 5, 2, 3, 5),
('Steelix', '208', 'Iron Snake', 'Steelix lives even further underground than Onix.This Pokémon is known to dig toward the earth&#39;s core.There are records of this Pokémon reaching a depth of oversix-tenths of a mile underground.', 9.2, 400.0, 3, 4, 8, 3, 3, 2),
('Snubbull', '209', 'Fairy', 'By baring its fangs and making a scary face, Snubbull sendssmaller Pokémon scurrying away in terror. However, thisPokémon seems a little sad at making its foes flee.', 0.6, 7.8, 3, 4, 2, 2, 2, 2),
('Granbull', '210', 'Fairy', 'Granbull has a particularly well-developed lower jaw.The enormous fangs are heavy, causing the Pokémon to tip itshead back for balance. Unless it is startled, it will not try tobite indiscriminately.', 1.4, 48.7, 4, 6, 3, 3, 3, 3),
('Qwilfish', '211', 'Balloon', 'Qwilfish sucks in water, inflating itself. This Pokémonuses the pressure of the water it swallowed to shoot toxicquills all at once from all over its body. It finds swimmingsomewhat challenging.', 0.5, 3.9, 3, 5, 3, 3, 2, 5),
('Scizor', '212', 'Pincer', 'Scizor has a body with the hardness of steel. It is not easilyfazed by ordinary sorts of attacks. This Pokémon flaps itswings to regulate its body temperature.', 1.8, 118.0, 3, 7, 4, 3, 3, 4),
('Shuckle', '213', 'Mold', 'Shuckle quietly hides itself under rocks, keeping its bodyconcealed inside its hard shell while eating berries it hasstored away. The berries mix with its body fluids to becomea juice.', 0.6, 20.5, 1, 1, 10, 1, 10, 1),
('Heracross', '214', 'Single Horn', 'Heracross charges in a straight line at its foe, slips beneath thefoe&#39;s grasp, and then scoops up and hurls the opponent withits mighty horn. This Pokémon even has enough power totopple a massive tree.', 1.5, 54.0, 3, 6, 3, 2, 4, 5),
('Sneasel', '215', 'Sharp Claw', 'Sneasel scales trees by punching its hooked claws into thebark. This Pokémon seeks out unguarded nests and stealseggs for food while the parents are away.', 0.9, 28.0, 2, 5, 3, 2, 3, 6),
('Teddiursa', '216', 'Little Bear', 'This Pokémon likes to lick its palms that are sweetened bybeing soaked in honey. Teddiursa concocts its own honeyby blending fruits and pollen collected by Beedrill.', 0.6, 8.8, 3, 4, 2, 2, 2, 2),
('Ursaring', '217', 'Hibernator', 'In the forests inhabited by Ursaring, it is said that there aremany streams and towering trees where they gather food.This Pokémon walks through its forest gathering foodevery day.', 1.8, 125.8, 4, 7, 3, 4, 3, 3),
('Slugma', '218', 'Lava', 'Molten magma courses throughout Slugma&#39;s circulatorysystem. If this Pokémon is chilled, the magma cools andhardens. Its body turns brittle and chunks fall off, reducingits size.', 0.7, 35.0, 2, 2, 2, 3, 2, 1),
('Magcargo', '219', 'Lava', 'Magcargo&#39;s shell is actually its skin that hardened as a resultof cooling. Its shell is very brittle and fragile—just touching itcauses it to crumble apart. This Pokémon returns to its originalsize by dipping itself in magma.', 0.8, 55.0, 2, 3, 5, 4, 3, 2),
('Swinub', '220', 'Pig', 'Swinub roots for food by rubbing its snout against the ground.Its favorite food is a mushroom that grows under the cover ofdead grass. This Pokémon occasionally roots out hot springs.', 0.4, 6.5, 2, 3, 2, 1, 1, 3),
('Piloswine', '221', 'Swine', 'Piloswine is covered by a thick coat of long hair that enables itto endure the freezing cold. This Pokémon uses its tusks todig up food that has been buried under ice.', 1.1, 55.8, 4, 5, 4, 3, 3, 3),
('Corsola', '222', 'Coral', 'Corsola&#39;s branches glitter very beautifully in seven colors whenthey catch sunlight. If any branch breaks off, this Pokémongrows it back in just one night.', 0.6, 5.0, 2, 3, 4, 3, 4, 2),
('Remoraid', '223', 'Jet', 'Remoraid sucks in water, then expels it at high velocity usingits abdominal muscles to shoot down flying prey. Whenevolution draws near, this Pokémon travels downstreamfrom rivers.', 0.6, 12.0, 2, 3, 2, 3, 2, 4),
('Octillery', '224', 'Jet', 'Octillery grabs onto its foe using its tentacles. This Pokémontries to immobilize it before delivering the finishing blow. If thefoe turns out to be too strong, Octillery spews ink to escape.', 0.9, 28.5, 3, 5, 3, 5, 3, 3),
('Delibird', '225', 'Delivery', 'Delibird carries its food bundled up in its tail. There once wasa famous explorer who managed to reach the peak of theworld&#39;s highest mountain, thanks to one of these Pokémonsharing its food.', 0.9, 16.0, 2, 3, 2, 3, 2, 4),
('Mantine', '226', 'Kite', 'On sunny days, schools of Mantine can be seen elegantlyleaping over the sea&#39;s waves. This Pokémon is not botheredby the Remoraid that hitches rides.', 2.1, 220.0, 3, 2, 3, 4, 6, 4),
('Skarmory', '227', 'Armor Bird', 'Skarmory is entirely encased in hard, protective armor.This Pokémon flies at close to 190 mph. It slashes foes withits wings that possess swordlike cutting edges.', 1.7, 50.5, 3, 4, 6, 2, 3, 4),
('Houndour', '228', 'Dark', 'Houndour hunt as a coordinated pack. They communicate witheach other using a variety of cries to corner their prey.This Pokémon&#39;s remarkable teamwork is unparalleled.', 0.6, 10.8, 2, 3, 2, 4, 2, 4),
('Houndoom', '229', 'Dark', 'In a Houndoom pack, the one with its horns raked sharplytoward the back serves a leadership role. These Pokémonchoose their leader by fighting among themselves.', 1.4, 35.0, 3, 5, 2, 5, 3, 5),
('Kingdra', '230', 'Dragon', 'Kingdra lives at extreme ocean depths that are otherwiseuninhabited. It has long been believed that the yawning of thisPokémon creates spiraling ocean currents.', 1.8, 152.0, 3, 5, 4, 5, 4, 5),
('Phanpy', '231', 'Long Nose', 'For its nest, Phanpy digs a vertical pit in the ground at theedge of a river. It marks the area around its nest with its trunkto let the others know that the area has been claimed.', 0.5, 33.5, 4, 3, 3, 2, 2, 2),
('Donphan', '232', 'Armor', 'Donphan&#39;s favorite attack is curling its body into a ball, thencharging at its foe while rolling at high speed. Once it startsrolling, this Pokémon can&#39;t stop very easily.', 1.1, 120.0, 4, 6, 5, 3, 3, 3),
('Porygon2', '233', 'Virtual', 'Porygon2 was created by humans using the power of science.The man-made Pokémon has been endowed with artificialintelligence that enables it to learn new gestures and emotionson its own.', 0.6, 32.5, 3, 4, 4, 5, 4, 3),
('Stantler', '234', 'Big Horn', 'Stantler&#39;s magnificent antlers were traded at high prices asworks of art. As a result, this Pokémon was hunted close toextinction by those who were after the priceless antlers.', 1.4, 71.2, 3, 5, 3, 4, 3, 5),
('Smeargle', '235', 'Painter', 'Smeargle marks the boundaries of its territory using a bodyfluid that leaks out from the tip of its tail. Over 5,000 differentmarks left by this Pokémon have been found.', 1.2, 58.0, 2, 1, 2, 1, 2, 4),
('Tyrogue', '236', 'Scuffle', 'Tyrogue becomes stressed out if it does not get to train everyday. When raising this Pokémon, the Trainer must establishand uphold various training methods.', 0.7, 21.0, 2, 2, 2, 2, 2, 2),
('Hitmontop', '237', 'Handstand', 'Hitmontop spins on its head at high speed, all the whiledelivering kicks. This technique is a remarkable mix of bothoffense and defense at the same time. The Pokémon travelsfaster spinning than it does walking.', 1.4, 48.0, 2, 5, 4, 2, 5, 4),
('Smoochum', '238', 'Kiss', 'Smoochum actively runs about, but also falls quite often.Whenever the chance arrives, it will look for its reflection tomake sure its face hasn&#39;t become dirty.', 0.4, 6.0, 2, 2, 1, 4, 3, 4),
('Elekid', '239', 'Electric', 'Elekid stores electricity in its body. If it touches metal andaccidentally discharges all its built-up electricity, this Pokémonbegins swinging its arms in circles to recharge itself.', 0.6, 23.5, 2, 3, 2, 3, 2, 5),
('Magby', '240', 'Live Coal', 'Magby&#39;s state of health is determined by observing the fire itbreathes. If the Pokémon is spouting yellow flames from itsmouth, it is in good health. When it is fatigued, black smokewill be mixed in with the flames.', 0.7, 21.4, 2, 4, 2, 3, 2, 5),
('Miltank', '241', 'Milk Cow', 'Miltank gives over five gallons of milk on a daily basis.Its sweet milk is enjoyed by children and grown-ups alike.People who can&#39;t drink milk turn it into yogurt and eatit instead.', 1.2, 75.5, 4, 4, 5, 2, 3, 5),
('Blissey', '242', 'Happiness', 'Blissey senses sadness with its fluffy coat of fur. If it does so,this Pokémon will rush over to a sad person, no matter how faraway, to share a Lucky Egg that brings a smile to any face.', 1.5, 46.8, 10, 1, 1, 4, 6, 3),
('Raikou', '243', 'Thunder', 'Raikou embodies the speed of lightning. The roars of thisPokémon send shock waves shuddering through the airand shake the ground as if lightning bolts had comecrashing down.', 1.9, 178.0, 4, 4, 3, 6, 4, 6),
('Entei', '244', 'Volcano', 'Entei embodies the passion of magma. This Pokémon isthought to have been born in the eruption of a volcano.It sends up massive bursts of fire that utterly consume all thatthey touch.', 2.1, 198.0, 5, 6, 4, 4, 3, 5),
('Suicune', '245', 'Aurora', 'Suicune embodies the compassion of a pure spring of water.It runs across the land with gracefulness. This Pokémon hasthe power to purify dirty water.', 2.0, 187.0, 4, 4, 5, 4, 5, 5),
('Larvitar', '246', 'Rock Skin', 'Larvitar is born deep under the ground. To come up to thesurface, this Pokémon must eat its way through the soil above.Until it does so, Larvitar cannot see its parents.', 0.6, 72.0, 2, 3, 2, 2, 2, 2),
('Pupitar', '247', 'Hard Shell', 'Pupitar creates a gas inside its body that it compresses andforcefully ejects to propel itself like a jet. The body is verydurable—it avoids damage even if it hits solid steel.', 1.2, 152.0, 3, 4, 3, 3, 3, 3),
('Tyranitar', '248', 'Armor', 'Tyranitar is so overwhelmingly powerful, it can bring down awhole mountain to make its nest. This Pokémon wanders aboutin mountains seeking new opponents to fight.', 2.0, 202.0, 4, 7, 5, 5, 4, 3),
('Lugia', '249', 'Diving', 'Lugia&#39;s wings pack devastating power—a light fluttering of itswings can blow apart regular houses. As a result, thisPokémon chooses to live out of sight deep under the sea.', 5.2, 216.0, 4, 5, 6, 4, 6, 6),
('Ho-Oh', '250', 'Rainbow', 'Ho-Oh&#39;s feathers glow in seven colors depending on the angleat which they are struck by light. These feathers are said tobring happiness to the bearers. This Pokémon is said to live atthe foot of a rainbow.', 3.8, 199.0, 4, 7, 4, 5, 6, 5),
('Celebi', '251', 'Time Travel', 'This Pokémon came from the future by crossing over time.It is thought that so long as Celebi appears, a bright andshining future awaits us.', 0.6, 5.0, 4, 5, 4, 5, 4, 5),
('Treecko', '252', 'Wood Gecko', 'Treecko has small hooks on the bottom of its feet that enableit to scale vertical walls. This Pokémon attacks by slammingfoes with its thick tail.', 0.5, 5.0, 2, 2, 2, 3, 2, 4),
('Grovyle', '253', 'Wood Gecko', 'The leaves growing out of Grovyle&#39;s body are convenient forcamouflaging it from enemies in the forest. This Pokémon is amaster at climbing trees in jungles.', 0.9, 21.6, 2, 3, 2, 4, 3, 5),
('Sceptile', '254', 'Forest', 'The leaves growing on Sceptile&#39;s body are very sharp edged.This Pokémon is very agile—it leaps all over the branches oftrees and jumps on its foe from above or behind.', 1.7, 52.2, 3, 4, 3, 5, 4, 6),
('Torchic', '255', 'Chick', 'Torchic sticks with its Trainer, following behind withunsteady steps. This Pokémon breathes fire of over1,800 degrees Fahrenheit, including fireballs that leavethe foe scorched black.', 0.4, 2.5, 2, 3, 2, 3, 2, 3),
('Combusken', '256', 'Young Fowl', 'Combusken toughens up its legs and thighs by runningthrough fields and mountains. This Pokémon&#39;s legs possessboth speed and power, enabling it to dole out 10 kicks inone second.', 0.9, 19.5, 3, 4, 3, 4, 3, 3),
('Blaziken', '257', 'Blaze', 'In battle, Blaziken blows out intense flames from its wrists andattacks foes courageously. The stronger the foe, the moreintensely this Pokémon&#39;s wrists burn.', 1.9, 52.0, 3, 6, 3, 5, 3, 4),
('Mudkip', '258', 'Mud Fish', 'The fin on Mudkip&#39;s head acts as highly sensitive radar.Using this fin to sense movements of water and air, thisPokémon can determine what is taking place around itwithout using its eyes.', 0.4, 7.6, 2, 4, 2, 2, 2, 2),
('Marshtomp', '259', 'Mud Fish', 'The surface of Marshtomp&#39;s body is enveloped by a thin, stickyfilm that enables it to live on land. This Pokémon plays in mudon beaches when the ocean tide is low.', 0.7, 28.0, 3, 4, 3, 3, 3, 3),
('Swampert', '260', 'Mud Fish', 'Swampert is very strong. It has enough power to easily drag aboulder weighing more than a ton. This Pokémon also haspowerful vision that lets it see even in murky water.', 1.5, 81.9, 4, 6, 4, 4, 4, 3),
('Poochyena', '261', 'Bite', 'At first sight, Poochyena takes a bite at anything that moves.This Pokémon chases after prey until the victim becomesexhausted. However, it may turn tail if the prey strikes back.', 0.5, 13.6, 2, 3, 2, 1, 1, 2),
('Mightyena', '262', 'Bite', 'Mightyena gives obvious signals when it is preparing to attack.It starts to growl deeply and then flattens its body.This Pokémon will bite savagely with its sharply pointed fangs.', 1.0, 37.0, 3, 5, 3, 3, 3, 4),
('Zigzagoon', '263', 'Tiny Raccoon', 'Zigzagoon restlessly wanders everywhere at all times.This Pokémon does so because it is very curious. It becomesinterested in anything that it happens to see.', 0.4, 17.5, 2, 2, 2, 1, 2, 3),
('Linoone', '264', 'Rushing', 'Linoone always runs full speed and only in straight lines.If facing an obstacle, it makes a right-angle turn to evade it.This Pokémon is very challenged by gently curving roads.', 0.5, 32.5, 3, 4, 3, 2, 3, 5),
('Wurmple', '265', 'Worm', 'Using the spikes on its rear end, Wurmple peels the bark offtrees and feeds on the sap that oozes out. This Pokémon&#39;sfeet are tipped with suction pads that allow it to cling to glasswithout slipping.', 0.3, 3.6, 2, 2, 2, 1, 1, 1),
('Silcoon', '266', 'Cocoon', 'Silcoon tethers itself to a tree branch using silk to keep fromfalling. There, this Pokémon hangs quietly while it awaitsevolution. It peers out of the silk cocoon through a small hole.', 0.6, 10.0, 2, 2, 3, 1, 1, 1),
('Beautifly', '267', 'Butterfly', 'Beautifly&#39;s favorite food is the sweet pollen of flowers. If youwant to see this Pokémon, just leave a potted flower by anopen window. Beautifly is sure to come looking for pollen.', 1.0, 28.4, 3, 4, 2, 5, 2, 4),
('Cascoon', '268', 'Cocoon', 'Cascoon makes its protective cocoon by wrapping its bodyentirely with a fine silk from its mouth. Once the silk goesaround its body, it hardens. This Pokémon prepares for itsevolution inside the cocoon.', 0.7, 11.5, 2, 2, 3, 1, 1, 1),
('Dustox', '269', 'Poison Moth', 'Dustox is instinctively drawn to light. Swarms of this Pokémonare attracted by the bright lights of cities, where they wreakhavoc by stripping the leaves off roadside trees for food.', 1.2, 31.6, 3, 3, 3, 2, 4, 4),
('Lotad', '270', 'Water Weed', 'Lotad live in ponds and lakes, where they float on the surface.It grows weak if its broad leaf dies. On rare occasions, thisPokémon travels on land in search of clean water.', 0.5, 2.6, 2, 2, 2, 2, 2, 2),
('Lombre', '271', 'Jolly', 'Lombre is nocturnal—it will get active after dusk.It is also a mischief maker. When this Pokémonspots anglers, it tugs on their fishing lines frombeneath the surface and enjoys their consternation.', 1.2, 32.5, 3, 3, 2, 3, 3, 3),
('Ludicolo', '272', 'Carefree', 'Ludicolo begins dancing as soon as it hears cheerful,festive music. This Pokémon is said to appear when ithears the singing of children on hiking outings.', 1.5, 55.0, 3, 4, 3, 4, 4, 4),
('Seedot', '273', 'Acorn', 'Seedot attaches itself to a tree branch using the top of itshead. It sucks moisture from the tree while hanging off thebranch. The more water it drinks, the glossier this Pokémon&#39;sbody becomes.', 0.5, 4.0, 2, 2, 2, 1, 1, 2),
('Nuzleaf', '274', 'Wily', 'Nuzleaf live in densely overgrown forests. They occasionallyventure out of the forest to startle people. This Pokémondislikes having its long nose pinched.', 1.0, 28.0, 3, 4, 2, 3, 2, 3),
('Shiftry', '275', 'Wicked', 'Shiftry is a mysterious Pokémon that is said to live atoptowering trees dating back over a thousand years. It createsterrific windstorms with the fans it holds.', 1.3, 59.6, 4, 5, 3, 4, 3, 4),
('Taillow', '276', 'Tiny Swallow', 'Taillow courageously stands its ground against foes, howeverstrong they may be. This gutsy Pokémon will remain defianteven after a loss. On the other hand, it cries loudly if itbecomes hungry.', 0.3, 2.3, 2, 3, 2, 1, 1, 5),
('Swellow', '277', 'Swallow', 'Swellow flies high above our heads, making graceful arcsin the sky. This Pokémon dives at a steep angle as soon asit spots its prey. The hapless prey is tightly grasped bySwellow&#39;s clawed feet, preventing escape.', 0.7, 19.8, 3, 4, 3, 2, 2, 7),
('Wingull', '278', 'Seagull', 'Wingull has the habit of carrying prey and valuables in its beakand hiding them in all sorts of locations. This Pokémon ridesthe winds and flies as if it were skating across the sky.', 0.6, 9.5, 2, 2, 2, 3, 1, 5),
('Pelipper', '279', 'Water Bird', 'Pelipper is a flying transporter that carries small Pokémon andeggs inside its massive bill. This Pokémon builds its nest onsteep cliffs facing the sea.', 1.2, 28.0, 3, 3, 4, 4, 3, 4),
('Ralts', '280', 'Feeling', 'Ralts senses the emotions of people using the horns onits head. This Pokémon rarely appears before people.But when it does, it draws closer if it senses that the personhas a positive disposition.', 0.4, 6.6, 1, 1, 1, 2, 2, 2),
('Kirlia', '281', 'Emotion', 'It is said that a Kirlia that is exposed to the positive emotionsof its Trainer grows beautiful. This Pokémon controlspsychokinetic powers with its highly developed brain.', 0.8, 20.2, 2, 2, 2, 3, 2, 3),
('Gardevoir', '282', 'Embrace', 'Gardevoir has the ability to read the future. If it sensesimpending danger to its Trainer, this Pokémon is saidto unleash its psychokinetic energy at full power.', 1.6, 48.4, 3, 3, 3, 6, 5, 4),
('Surskit', '283', 'Pond Skater', 'From the tips of its feet, Surskit secretes an oil that enables itto walk on water as if it were skating. This Pokémon feeds onmicroscopic organisms in ponds and lakes.', 0.5, 1.7, 2, 2, 2, 2, 2, 4),
('Masquerain', '284', 'Eyeball', 'Masquerain intimidates enemies with the eyelike patternson its antennas. This Pokémon flaps its four wings to freely flyin any direction—even sideways and backwards—as if it werea helicopter.', 0.8, 3.6, 3, 3, 3, 4, 3, 3),
('Shroomish', '285', 'Mushroom', 'Shroomish live in damp soil in the dark depths of forests.They are often found keeping still under fallen leaves.This Pokémon feeds on compost that is made up of fallen,rotted leaves.', 0.4, 4.5, 3, 2, 3, 2, 3, 2),
('Breloom', '286', 'Mushroom', 'Breloom closes in on its foe with light and sprightly footwork,then throws punches with its stretchy arms. This Pokémon&#39;sfighting technique puts boxers to shame.', 1.2, 39.2, 3, 7, 4, 3, 3, 4),
('Slakoth', '287', 'Slacker', 'Slakoth lolls around for over 20 hours every day. Because itmoves so little, it does not need much food. This Pokémon&#39;ssole daily meal consists of just three leaves.', 0.8, 24.0, 3, 3, 3, 2, 2, 2),
('Vigoroth', '288', 'Wild Monkey', 'Vigoroth is always itching and agitated to go on a wildrampage. It simply can&#39;t tolerate sitting still for evena minute. This Pokémon&#39;s stress level rises if it can&#39;tbe moving constantly.', 1.4, 46.5, 3, 4, 4, 3, 2, 5),
('Slaking', '289', 'Lazy', 'Slaking spends all day lying down and lolling about. It eatsgrass growing within its reach. If it eats all the grass it canreach, this Pokémon reluctantly moves to another spot.', 2.0, 130.5, 6, 8, 4, 5, 3, 5),
('Nincada', '290', 'Trainee', 'Nincada lives underground for many years in completedarkness. This Pokémon absorbs nutrients from the roots oftrees. It stays motionless as it waits for evolution.', 0.5, 5.5, 2, 2, 4, 1, 1, 2),
('Ninjask', '291', 'Ninja', 'Ninjask moves around at such a high speed that itcannot be seen, even while its crying can be clearly heard.For that reason, this Pokémon was long believed tobe invisible.', 0.8, 12.0, 3, 5, 2, 2, 2, 8),
('Shedinja', '292', 'Shed', 'Shedinja&#39;s hard body doesn&#39;t move—not even a twitch. In fact,its body appears to be merely a hollow shell. It is believed thatthis Pokémon will steal the spirit of anyone peering into itshollow body from its back.', 0.8, 1.2, 1, 5, 2, 1, 1, 2),
('Whismur', '293', 'Whisper', 'Normally, Whismur&#39;s voice is very quiet—it is barely audibleeven if one is paying close attention. However, if this Pokémonsenses danger, it starts crying at an earsplitting volume.', 0.6, 16.3, 3, 3, 1, 3, 1, 2),
('Loudred', '294', 'Big Voice', 'Loudred&#39;s bellowing can completely decimate a wood-framehouse. It uses its voice to punish its foes. This Pokémon&#39;sround ears serve as loudspeakers.', 1.0, 40.5, 3, 4, 2, 3, 2, 3),
('Exploud', '295', 'Loud Noise', 'Exploud triggers earthquakes with the tremors it createsby bellowing. If this Pokémon violently inhales from theports on its body, it&#39;s a sign that it is preparing to let loosea huge bellow.', 1.5, 84.0, 4, 5, 3, 4, 3, 4),
('Makuhita', '296', 'Guts', 'Makuhita is tenacious—it will keep getting up and attackingits foe however many times it is knocked down. Every time itgets back up, this Pokémon stores more energy in its bodyfor evolving.', 1.0, 86.4, 3, 3, 2, 1, 1, 2),
('Hariyama', '297', 'Arm Thrust', 'Hariyama practices its straight-arm slaps in any number oflocations. One hit of this Pokémon&#39;s powerful, openhanded,straight-arm punches could snap a telephone pole in two.', 2.3, 253.8, 6, 6, 3, 2, 3, 3),
('Azurill', '298', 'Polka Dot', 'Azurill spins its tail as if it were a lasso, then hurls it far.The momentum of the throw sends its body flying, too.Using this unique action, one of these Pokémon managed tohurl itself a record 33 feet.', 0.2, 2.0, 2, 1, 2, 1, 2, 1),
('Nosepass', '299', 'Compass', 'Nosepass&#39;s magnetic nose is always pointed to the north.If two of these Pokémon meet, they cannot turn their faces toeach other when they are close because their magnetic nosesrepel one another.', 1.0, 97.0, 2, 2, 6, 2, 4, 2),
('Skitty', '300', 'Kitten', 'Skitty has the habit of becoming fascinated by moving objectsand chasing them around. This Pokémon is known to chaseafter its own tail and become dizzy.', 0.6, 11.0, 2, 2, 2, 2, 2, 3),
('Delcatty', '301', 'Prim', 'Delcatty prefers to live an unfettered existence in which it cando as it pleases at its own pace. Because this Pokémon eatsand sleeps whenever it decides, its daily routines arecompletely random.', 1.1, 32.6, 3, 3, 3, 3, 2, 4),
('Sableye', '302', 'Darkness', 'Sableye lead quiet lives deep inside caverns.They are feared, however, because these Pokémon arethought to steal the spirits of people when their eyes burnwith a sinister glow in the darkness.', 0.5, 11.0, 2, 4, 3, 3, 3, 3),
('Mawile', '303', 'Deceiver', 'Mawile&#39;s huge jaws are actually steel horns that have beentransformed. Its docile-looking face serves to lull its foe intoletting down its guard. When the foe least expects it, Mawilechomps it with its gaping jaws.', 0.6, 11.5, 2, 4, 4, 3, 2, 3),
('Aron', '304', 'Iron Armor', 'This Pokémon has a body of steel. To make its body, Aronfeeds on iron ore that it digs from mountains. Occasionally,it causes major trouble by eating bridges and rails.', 0.4, 60.0, 2, 4, 4, 2, 2, 2),
('Lairon', '305', 'Iron Armor', 'Lairon tempers its steel body by drinking highly nutritiousmineral springwater until it is bloated. This Pokémon makes itsnest close to springs of delicious water.', 0.9, 120.0, 3, 5, 6, 2, 2, 2),
('Aggron', '306', 'Iron Armor', 'Aggron claims an entire mountain as its own territory.It mercilessly beats up anything that violates its environment.This Pokémon vigilantly patrols its territory at all times.', 2.1, 360.0, 3, 6, 8, 3, 3, 3),
('Meditite', '307', 'Meditate', 'Meditite undertakes rigorous mental training deep in themountains. However, whenever it meditates, this Pokémonalways loses its concentration and focus. As a result,its training never ends.', 0.6, 11.2, 2, 2, 3, 2, 2, 3),
('Medicham', '308', 'Meditate', 'It is said that through meditation, Medicham heightens energyinside its body and sharpens its sixth sense. This Pokémonhides its presence by merging itself with fields and mountains.', 1.3, 31.5, 3, 3, 3, 3, 3, 4),
('Electrike', '309', 'Lightning', 'Electrike stores electricity in its long body hair. This Pokémonstimulates its leg muscles with electric charges. These jolts ofpower give its legs explosive acceleration performance.', 0.6, 15.2, 2, 2, 2, 3, 2, 4),
('Manectric', '310', 'Discharge', 'Manectric is constantly discharging electricity from its mane.The sparks sometimes ignite forest fires. When it enters abattle, this Pokémon creates thunderclouds.', 1.5, 40.2, 3, 4, 3, 5, 3, 6),
('Plusle', '311', 'Cheering', 'Plusle always acts as a cheerleader for its partners.Whenever a teammate puts out a good effort in battle, thisPokémon shorts out its body to create the crackling noises ofsparks to show its joy.', 0.4, 4.2, 3, 3, 2, 4, 3, 5),
('Minun', '312', 'Cheering', 'Minun is more concerned about cheering on its partners thanits own safety. It shorts out the electricity in its body to createbrilliant showers of sparks to cheer on its teammates.', 0.4, 4.2, 3, 2, 2, 4, 4, 5),
('Volbeat', '313', 'Firefly', 'With the arrival of night, Volbeat emits light from its tail.It communicates with others by adjusting the intensity andflashing of its light. This Pokémon is attracted by the sweetaroma of Illumise.', 0.7, 17.7, 3, 4, 3, 2, 3, 5),
('Illumise', '314', 'Firefly', 'Illumise attracts a swarm of Volbeat using a sweet fragrance.Once the Volbeat have gathered, this Pokémon leads thelit-up swarm in drawing geometric designs on the canvas ofthe night sky.', 0.6, 17.7, 3, 3, 3, 4, 3, 5),
('Roselia', '315', 'Thorn', 'Roselia shoots sharp thorns as projectiles at any opponent thattries to steal the flowers on its arms. The aroma of thisPokémon brings serenity to living things.', 0.3, 2.0, 2, 3, 2, 5, 3, 4),
('Gulpin', '316', 'Stomach', 'Virtually all of Gulpin&#39;s body is its stomach. As a result, it canswallow something its own size. This Pokémon&#39;s stomachcontains a special fluid that digests anything.', 0.4, 10.3, 3, 2, 2, 2, 2, 2),
('Swalot', '317', 'Poison Bag', 'When Swalot spots prey, it spurts out a hideously toxic fluidfrom its pores and sprays the target. Once the prey hasweakened, this Pokémon gulps it down whole with itscavernous mouth.', 1.7, 80.0, 4, 4, 4, 4, 3, 3),
('Carvanha', '318', 'Savage', 'Carvanha&#39;s strongly developed jaws and its sharply pointedfangs pack the destructive power to rip out boat hulls.Many boats have been attacked and sunk by this Pokémon.', 0.8, 20.8, 2, 5, 1, 3, 1, 4),
('Sharpedo', '319', 'Brutal', 'Nicknamed “the bully of the sea,&quot; Sharpedo is widely feared.Its cruel fangs grow back immediately if they snap off. Just oneof these Pokémon can thoroughly tear apart a supertanker.', 1.8, 88.8, 3, 6, 2, 5, 2, 5),
('Wailmer', '320', 'Ball Whale', 'Wailmer&#39;s nostrils are located above its eyes. This playfulPokémon loves to startle people by forcefully snorting outseawater it stores inside its body out of its nostrils.', 2.0, 130.0, 5, 4, 2, 3, 2, 3),
('Wailord', '321', 'Float Whale', 'Wailord is the largest of all identified Pokémon up to now.This giant Pokémon swims languorously in the vast open sea,eating massive amounts of food at once with its enormousmouth.', 14.5, 398.0, 6, 5, 2, 4, 2, 3),
('Numel', '322', 'Numb', 'Numel is extremely dull witted—it doesn&#39;t notice being hit.However, it can&#39;t stand hunger for even a second.This Pokémon&#39;s body is a seething cauldron of boiling magma.', 0.7, 24.0, 3, 3, 2, 3, 2, 2),
('Camerupt', '323', 'Eruption', 'Camerupt has a volcano inside its body. Magma of18,000 degrees Fahrenheit courses through its body.Occasionally, the humps on this Pokémon&#39;s back erupt,spewing the superheated magma.', 1.9, 220.0, 3, 5, 3, 5, 3, 2),
('Torkoal', '324', 'Coal', 'Torkoal digs through mountains in search of coal. If it findssome, it fills hollow spaces on its shell with the coal and burnsit. If it is attacked, this Pokémon spouts thick black smoke tobeat a retreat.', 0.5, 80.4, 3, 4, 6, 4, 3, 1),
('Spoink', '325', 'Bounce', 'Spoink bounces around on its tail. The shock of its bouncingmakes its heart pump. As a result, this Pokémon cannot affordto stop bouncing—if it stops, its heart will stop.', 0.7, 30.6, 3, 1, 2, 3, 3, 3),
('Grumpig', '326', 'Manipulate', 'Grumpig uses the black pearls on its body to amplify itspsychic power waves for gaining total control over its foe.When this Pokémon uses its special power, its snorting breathgrows labored.', 0.9, 71.5, 3, 2, 3, 4, 5, 4),
('Spinda', '327', 'Spot Panda', 'All the Spinda that exist in the world are said to have utterlyunique spot patterns. The shaky, tottering steps of thisPokémon give it the appearance of dancing.', 1.1, 5.0, 3, 3, 3, 3, 3, 3),
('Trapinch', '328', 'Ant Pit', 'Trapinch&#39;s nest is a sloped, bowl-like pit dug in sand.This Pokémon patiently waits for prey to tumble down the pit.Its giant jaws have enough strength to crush even boulders.', 0.7, 15.0, 2, 5, 2, 2, 2, 1),
('Vibrava', '329', 'Vibration', 'To make prey faint, Vibrava generates ultrasonic waves byvigorously making its two wings vibrate. This Pokémon&#39;sultrasonic waves are so powerful, they can bring on headachesin people.', 1.1, 15.3, 2, 4, 2, 2, 2, 4),
('Flygon', '330', 'Mystic', 'Flygon is nicknamed “the elemental spirit of the desert.&quot;Because its flapping wings whip up a cloud of sand, thisPokémon is always enveloped in a sandstorm while flying.', 2.0, 82.0, 3, 5, 4, 4, 3, 5),
('Cacnea', '331', 'Cactus', 'Cacnea lives in arid locations such as deserts. It releases astrong aroma from its flower to attract prey. When prey comesnear, this Pokémon shoots sharp thorns from its body to bringthe victim down.', 0.4, 51.3, 2, 4, 2, 4, 2, 2),
('Cacturne', '332', 'Scarecrow', 'During the daytime, Cacturne remains unmoving so that it doesnot lose any moisture to the harsh desert sun. This Pokémonbecomes active at night when the temperature drops.', 1.3, 77.4, 3, 6, 3, 6, 3, 3),
('Swablu', '333', 'Cotton Bird', 'Swablu has light and fluffy wings that are like cottony clouds.This Pokémon is not frightened of people. It lands on theheads of people and sits there like a cotton-fluff hat.', 0.4, 1.2, 2, 2, 3, 2, 3, 3),
('Altaria', '334', 'Humming', 'Altaria dances and wheels through the sky among billowing,cotton-like clouds. By singing melodies in its crystal-clearvoice, this Pokémon makes its listeners experience dreamywonderment.', 1.1, 20.6, 3, 4, 4, 3, 4, 4),
('Zangoose', '335', 'Cat Ferret', 'Memories of battling its archrival Seviper are etched into everycell of Zangoose&#39;s body. This Pokémon adroitly dodgesattacks with incredible agility.', 1.3, 40.3, 3, 6, 3, 3, 3, 5),
('Seviper', '336', 'Fang Snake', 'Seviper shares a generations-long feud with Zangoose.The scars on its body are evidence of vicious battles.This Pokémon attacks using its sword-edged tail.', 2.7, 52.5, 3, 5, 3, 5, 3, 4),
('Lunatone', '337', 'Meteorite', 'Lunatone was discovered at a location where a meteoroid fell.As a result, some people theorize that this Pokémon camefrom space. However, no one has been able to prove thistheory so far.', 1.0, 168.0, 3, 3, 3, 5, 4, 4),
('Solrock', '338', 'Meteorite', 'Solrock is a new species of Pokémon that is said to have fallenfrom space. It floats in air and moves silently. In battle, thisPokémon releases intensely bright light.', 1.2, 154.0, 3, 5, 4, 3, 3, 4),
('Barboach', '339', 'Whiskers', 'Barboach&#39;s sensitive whiskers serve as a superb radar system.This Pokémon hides in mud, leaving only its two whiskersexposed while it waits for prey to come along.', 0.4, 1.9, 2, 3, 2, 2, 2, 3),
('Whiscash', '340', 'Whiskers', 'Whiscash is extremely territorial. Just one of these Pokémonwill claim a large pond as its exclusive territory. If a foeapproaches it, it thrashes about and triggers a massiveearthquake.', 0.9, 23.6, 4, 4, 3, 4, 3, 3),
('Corphish', '341', 'Ruffian', 'Corphish were originally foreign Pokémon that were importedas pets. They eventually turned up in the wild. This Pokémon isvery hardy and has greatly increased its population.', 0.6, 11.5, 2, 4, 3, 2, 2, 2),
('Crawdaunt', '342', 'Rogue', 'Crawdaunt has an extremely violent nature that compels it tochallenge other living things to battle. Other life-forms refuseto live in ponds inhabited by this Pokémon, making themdesolate places.', 1.1, 32.8, 3, 6, 4, 4, 2, 3),
('Baltoy', '343', 'Clay Doll', 'Baltoy moves while spinning around on its one foot. Primitivewall paintings depicting this Pokémon living among peoplewere discovered in some ancient ruins.', 0.5, 21.5, 2, 2, 3, 2, 3, 3),
('Claydol', '344', 'Clay Doll', 'Claydol are said to be dolls of mud made by primitive humansand brought to life by exposure to a mysterious ray.This Pokémon moves about while levitating.', 1.5, 108.0, 3, 4, 5, 3, 5, 4),
('Lileep', '345', 'Sea Lily', 'Lileep became extinct approximately a hundred million yearsago. This ancient Pokémon attaches itself to a rock on theseafloor and catches approaching prey using tentacles shapedlike flower petals.', 1.0, 23.8, 3, 2, 3, 3, 4, 1),
('Cradily', '346', 'Barnacle', 'Cradily roams around the ocean floor in search of food.This Pokémon freely extends its tree trunk-like neck andcaptures unwary prey using its eight tentacles.', 1.5, 60.4, 4, 4, 4, 4, 4, 2),
('Anorith', '347', 'Old Shrimp', 'Anorith was regenerated from a prehistoric fossil. This primitivePokémon once lived in warm seas. It grips its prey firmlybetween its two large claws.', 0.7, 12.5, 2, 5, 2, 2, 2, 4),
('Armaldo', '348', 'Plate', 'Armaldo&#39;s tough armor makes all attacks bounce off. ThisPokémon&#39;s two enormous claws can be freely extended orcontracted. They have the power to punch right through asteel slab.', 1.5, 68.2, 3, 6, 4, 3, 3, 3),
('Feebas', '349', 'Fish', 'Feebas&#39;s fins are ragged and tattered from the start of its life.Because of its shoddy appearance, this Pokémon is largelyignored. It is capable of living in both the sea and in rivers.', 0.6, 7.4, 1, 1, 1, 1, 2, 4),
('Milotic', '350', 'Tender', 'Milotic is said to be the most beautiful of all the Pokémon.It has the power to becalm such emotions as anger andhostility to quell bitter feuding.', 6.2, 162.0, 4, 3, 3, 5, 5, 4),
('Castform', '351', 'Weather', 'Castform&#39;s appearance changes with the weather.This Pokémon gained the ability to use the vast power ofnature to protect its tiny body.', 0.3, 0.8, 3, 4, 3, 3, 3, 4),
('Kecleon', '352', 'Color Swap', 'Kecleon is capable of changing its body colors at will to blendin with its surroundings. There is one exception—this Pokémoncan&#39;t change the zigzag pattern on its belly.', 1.0, 22.0, 3, 5, 3, 3, 5, 2),
('Shuppet', '353', 'Puppet', 'Shuppet is attracted by feelings of jealousy and vindictiveness.If someone develops strong feelings of vengeance, thisPokémon will appear in a swarm and line up beneath the eavesof that person&#39;s home.', 0.6, 2.3, 2, 4, 2, 3, 1, 3),
('Banette', '354', 'Marionette', 'Banette generates energy for laying strong curses by stickingpins into its own body. This Pokémon was originally a pitifulplush doll that was thrown away.', 1.1, 12.5, 3, 6, 3, 4, 3, 4),
('Duskull', '355', 'Requiem', 'Duskull can pass through any wall no matter how thick it maybe. Once this Pokémon chooses a target, it will doggedlypursue the intended victim until the break of dawn.', 0.8, 15.0, 1, 2, 4, 1, 4, 2),
('Dusclops', '356', 'Beckon', 'Dusclops&#39;s body is completely hollow—there is nothing at allinside. It is said that its body is like a black hole. ThisPokémon will absorb anything into its body, but nothing willever come back out.', 1.6, 30.6, 2, 4, 6, 3, 5, 2),
('Tropius', '357', 'Fruit', 'The bunches of fruit around Tropius&#39;s neck are very popularwith children. This Pokémon loves fruit, and eats itcontinuously. Apparently, its love for fruit resulted in its ownoutgrowth of fruit.', 2.0, 100.0, 4, 4, 4, 4, 4, 3),
('Chimecho', '358', 'Wind Chime', 'Chimecho makes its cries echo inside its hollow body.When this Pokémon becomes enraged, its cries result inultrasonic waves that have the power to knock foes flying.', 0.6, 1.0, 3, 3, 3, 5, 3, 4),
('Absol', '359', 'Disaster', 'Every time Absol appears before people, it is followed by adisaster such as an earthquake or a tidal wave. As a result,it came to be known as the disaster Pokémon.', 1.2, 47.0, 3, 7, 3, 4, 3, 4),
('Wynaut', '360', 'Bright', 'Wynaut can always be seen with a big, happy smile on its face.Look at its tail to determine if it is angry. When angered, thisPokémon will be slapping the ground with its tail.', 0.6, 14.0, 4, 1, 2, 1, 2, 1),
('Snorunt', '361', 'Snow Hat', 'Snorunt live in regions with heavy snowfall. In seasonswithout snow, such as spring and summer, this Pokémonsteals away to live quietly among stalactites and stalagmitesdeep in caverns.', 0.7, 16.8, 2, 3, 2, 2, 2, 3),
('Glalie', '362', 'Face', 'Glalie has a body made of rock, which it hardens with an armorof ice. This Pokémon has the ability to freeze moisture in theatmosphere into any shape it desires.', 1.5, 256.5, 3, 4, 4, 4, 3, 4),
('Spheal', '363', 'Clap', 'Spheal is much faster rolling than walking to get around.When groups of this Pokémon eat, they all clap at once toshow their pleasure. Because of this, their mealtimes are noisy.', 0.8, 39.5, 3, 2, 2, 3, 2, 2),
('Sealeo', '364', 'Ball Roll', 'Sealeo has the habit of always juggling on the tip of its noseanything it sees for the first time. This Pokémon occasionallyentertains itself by balancing and rolling a Spheal on its nose.', 1.1, 87.6, 4, 3, 3, 4, 3, 3),
('Walrein', '365', 'Ice Break', 'Walrein&#39;s two massively developed tusks can totally shatterblocks of ice weighing 10 tons with one blow. This Pokémon&#39;sthick coat of blubber insulates it from subzero temperatures.', 1.4, 150.6, 4, 4, 4, 5, 4, 4),
('Clamperl', '366', 'Bivalve', 'Clamperl&#39;s sturdy shell is not only good for protection—it isalso used for clamping and catching prey. A fully grownClamperl&#39;s shell will be scored with nicks and scratchesall over.', 0.4, 52.5, 2, 3, 4, 4, 2, 2),
('Huntail', '367', 'Deep Sea', 'Huntail&#39;s presence went unnoticed by people for a longtime because it lives at extreme depths in the sea.This Pokémon&#39;s eyes can see clearly even in the murkydark depths of the ocean.', 1.7, 27.0, 2, 5, 5, 5, 3, 3),
('Gorebyss', '368', 'South Sea', 'Gorebyss lives in the southern seas at extreme depths. Itsbody is built to withstand the enormous pressure of water atincredible depths. Because of this, this Pokémon&#39;s body isunharmed by ordinary attacks.', 1.8, 22.6, 2, 4, 5, 6, 3, 3),
('Relicanth', '369', 'Longevity', 'Relicanth is a Pokémon species that existed for a hundredmillion years without ever changing its form. This ancientPokémon feeds on microscopic organisms with itstoothless mouth.', 1.0, 23.4, 4, 5, 6, 2, 3, 3),
('Luvdisc', '370', 'Rendezvous', 'Luvdisc live in shallow seas in the tropics. This heart-shapedPokémon earned its name by swimming after loving couples itspotted in the ocean&#39;s waves.', 0.6, 8.7, 2, 2, 3, 2, 3, 5),
('Bagon', '371', 'Rock Head', 'Bagon has a dream of one day soaring in the sky.In doomed efforts to fly, this Pokémon hurls itself off cliffs.As a result of its dives, its head has grown tough and as hardas tempered steel.', 0.6, 42.1, 2, 4, 3, 2, 1, 3),
('Shelgon', '372', 'Endurance', 'Inside Shelgon&#39;s armor-like shell, cells are in the midst oftransformation to create an entirely new body. This Pokémon&#39;sshell is extremely heavy, making its movements sluggish.', 1.1, 110.5, 3, 5, 4, 3, 2, 3),
('Salamence', '373', 'Dragon', 'Salamence came about as a result of a strong, long-helddream of growing wings. It is said that this powerful desiretriggered a sudden mutation in this Pokémon&#39;s cells,causing it to sprout its magnificent wings.', 1.5, 102.6, 4, 7, 4, 5, 3, 5),
('Beldum', '374', 'Iron Ball', 'Instead of blood, a powerful magnetic force coursesthroughout Beldum&#39;s body. This Pokémon communicateswith others by sending controlled pulses of magnetism.', 0.6, 95.2, 2, 3, 4, 2, 3, 2),
('Metang', '375', 'Iron Claw', 'When two Beldum fuse together, Metang is formed. The brainsof the Beldum are joined by a magnetic nervous system.By linking its brains magnetically, this Pokémon generatesstrong psychokinetic power.', 1.2, 202.5, 3, 4, 4, 3, 3, 3),
('Metagross', '376', 'Iron Leg', 'Metagross has four brains in total. Combined, the four brainscan breeze through difficult calculations faster than asupercomputer. This Pokémon can float in the air by tucking inits four legs.', 1.6, 550.0, 3, 7, 6, 5, 4, 4),
('Regirock', '377', 'Rock Peak', 'Regirock was sealed away by people long ago. If thisPokémon&#39;s body is damaged in battle, it is said to seekout suitable rocks on its own to repair itself.', 1.7, 230.0, 3, 5, 8, 2, 4, 3),
('Regice', '378', 'Iceberg', 'Regice&#39;s body was made during an ice age. The deep-frozenbody can&#39;t be melted, even by fire. This Pokémon controlsfrigid air of -328 degrees Fahrenheit.', 1.8, 175.0, 3, 3, 4, 5, 8, 3),
('Registeel', '379', 'Iron', 'Registeel has a body that is harder than any kind of metal.Its body is apparently hollow. No one has any idea what thisPokémon eats.', 1.9, 205.0, 3, 4, 6, 4, 6, 3),
('Latias', '380', 'Eon', 'Latias is highly sensitive to the emotions of people. If it sensesany hostility, this Pokémon ruffles the feathers all over its bodyand cries shrilly to intimidate the foe.', 1.4, 40.0, 3, 4, 4, 5, 5, 6),
('Latios', '381', 'Eon', 'Latios has the ability to make others see an image of what ithas seen or imagines in its head. This Pokémon is intelligentand understands human speech.', 2.0, 60.0, 3, 5, 4, 6, 5, 6),
('Kyogre', '382', 'Sea Basin', 'Through Primal Reversion and with nature&#39;sfull power, it will take back its true form. It cansummon storms that cause the sea levels to rise.', 4.5, 352.0, 4, 5, 4, 7, 6, 5),
('Groudon', '383', 'Continent', 'Groudon is said to be the personification of the landitself. Legends tell of its many clashes against Kyogre,as each sought to gain the power of nature.', 3.5, 950.0, 4, 8, 6, 5, 4, 5),
('Rayquaza', '384', 'Sky High', 'Rayquaza is said to have lived for hundreds of millionsof years. Legends remain of how it put to restthe clash between Kyogre and Groudon.', 7.0, 206.5, 4, 8, 4, 7, 4, 5),
('Jirachi', '385', 'Wish', 'A legend states that Jirachi will make true any wish that iswritten on notes attached to its head when it awakens. If thisPokémon senses danger, it will fight without awakening.', 0.3, 1.1, 4, 5, 4, 5, 4, 5),
('Deoxys', '386', 'DNA', 'The DNA of a space virus underwent a sudden mutation uponexposure to a laser beam and resulted in Deoxys.The crystalline organ on this Pokémon&#39;s chest appears to beits brain.', 1.7, 60.8, 2, 8, 2, 7, 2, 8),
('Turtwig', '387', 'Tiny Leaf', 'Photosynthesis occurs across its body under thesun. The shell on its back is actually hardened soil.', 0.4, 10.2, 2, 4, 3, 2, 2, 2),
('Grotle', '388', 'Grove', 'It lives along water in forests. In the daytime,it leaves the forest to sunbathe its treed shell.', 1.1, 97.0, 3, 5, 4, 3, 3, 2),
('Torterra', '389', 'Continent', 'Ancient people imagined that beneath the ground,a gigantic Torterra dwelled.', 2.2, 310.0, 4, 6, 5, 4, 4, 3),
('Chimchar', '390', 'Chimp', 'Its fiery rear end is fueled by gas made in its belly.Even rain can&#39;t extinguish the fire.', 0.5, 6.2, 2, 3, 2, 3, 2, 3),
('Monferno', '391', 'Playful', 'It skillfully controls the intensity of the fire on itstail to keep its foes at an ideal distance.', 0.9, 22.0, 3, 4, 2, 4, 2, 4),
('Infernape', '392', 'Flame', 'Its crown of fire is indicative of its fiery nature.It is beaten by none in terms of quickness.', 1.2, 55.0, 3, 5, 3, 5, 3, 6),
('Piplup', '393', 'Penguin', 'It doesn&#39;t like to be taken care of. It&#39;s difficult tobond with since it won&#39;t listen to its Trainer.', 0.4, 5.2, 2, 3, 2, 3, 2, 2),
('Prinplup', '394', 'Penguin', 'It lives alone, away from others. Apparently, everyone of them believes it is the most important.', 0.8, 23.0, 3, 3, 3, 4, 3, 3),
('Empoleon', '395', 'Emperor', 'It swims as fast as a jet boat. The edges of itswings are sharp and can slice apart drifting ice.', 1.7, 84.5, 3, 4, 4, 5, 4, 3),
('Starly', '396', 'Starling', 'They flock in great numbers. Though small, theyflap their wings with great power.', 0.3, 2.0, 2, 3, 2, 1, 1, 3),
('Staravia', '397', 'Starling', 'They maintain huge flocks, although fierce scufflesbreak out between various flocks.', 0.6, 15.5, 2, 4, 2, 2, 2, 4),
('Staraptor', '398', 'Predator', 'The muscles in its wings and legs are strong.It can easily fly while gripping a small Pokémon.', 1.2, 24.9, 3, 6, 3, 2, 3, 5),
('Bidoof', '399', 'Plump Mouse', 'With nerves of steel, nothing can perturb it. It ismore agile and active than it appears.', 0.5, 20.0, 3, 2, 2, 2, 2, 2),
('Bibarel', '400', 'Beaver', 'It busily makes its nest with stacks of branches androots it has cut up with its sharp incisors.', 1.0, 31.5, 3, 4, 3, 3, 3, 4),
('Kricketot', '401', 'Cricket', 'It chats with others using the sounds of its collidingantennae. These sounds are fall hallmarks.', 0.3, 2.2, 2, 1, 2, 1, 2, 2),
('Kricketune', '402', 'Cricket', 'It crosses its knifelike arms in front of its chestwhen it cries. It can compose melodies ad lib.', 1.0, 25.5, 3, 4, 2, 3, 2, 4),
('Shinx', '403', 'Flash', 'The extension and contraction of its musclesgenerates electricity. It glows when in trouble.', 0.5, 9.5, 2, 3, 2, 2, 1, 3),
('Luxio', '404', 'Spark', 'Its claws loose electricity with enough amperageto cause fainting. They live in small groups.', 0.9, 30.5, 3, 4, 2, 3, 2, 3),
('Luxray', '405', 'Gleam Eyes', 'When its eyes gleam gold, it can spot hidingprey—even those taking shelter behind a wall.', 1.4, 42.0, 3, 6, 3, 5, 3, 4),
('Budew', '406', 'Bud', 'When it feels the sun&#39;s warm touch, it opens its budto release pollen. It lives alongside clear pools.', 0.2, 1.2, 2, 2, 2, 2, 3, 3),
('Roserade', '407', 'Bouquet', 'Luring prey with a sweet scent, it uses poison whipson its arms to poison, bind, and finish off the prey.', 0.9, 14.5, 3, 4, 3, 6, 4, 5),
('Cranidos', '408', 'Head Butt', 'It was resurrected from an iron ball-like fossil.It downs prey with its headbutts.', 0.9, 31.5, 3, 6, 2, 1, 1, 3),
('Rampardos', '409', 'Head Butt', 'Its skull withstands impacts of any magnitude. As aresult, its brain never gets the chance to grow.', 1.6, 102.5, 4, 8, 3, 3, 2, 3),
('Shieldon', '410', 'Shield', 'It habitually polishes its face by rubbing it againsttree trunks. It is weak to attacks from behind.', 0.5, 57.0, 2, 2, 5, 2, 4, 2),
('Bastiodon', '411', 'Shield', 'When they lined up side by side, no foe couldbreak through. They shielded their young inthat way.', 1.3, 149.5, 3, 3, 7, 2, 6, 2),
('Burmy', '412', 'Bagworm', 'To shelter itself from cold, wintry winds, it coversitself with a cloak made of twigs and leaves.', 0.2, 3.4, 2, 2, 2, 1, 2, 2),
('Wormadam', '413', 'Bagworm', 'Its appearance changes depending on where itevolved. The materials on hand become a part ofits body.', 0.5, 6.5, 3, 3, 4, 4, 4, 2),
('Mothim', '414', 'Moth', 'It loves the honey of flowers and steals honeycollected by Combee.', 0.9, 23.3, 3, 5, 2, 5, 2, 4),
('Combee', '415', 'Tiny Bee', 'The trio is together from birth. It constantly gathershoney from flowers to please Vespiquen.', 0.3, 5.5, 2, 2, 2, 1, 2, 4),
('Vespiquen', '416', 'Beehive', 'It houses its colony in cells in its body and releasesvarious pheromones to make those grubs do its bidding.', 1.2, 38.5, 3, 4, 4, 4, 4, 2),
('Pachirisu', '417', 'EleSquirrel', 'It makes fur balls that crackle with static electricity.It stores them with berries in tree holes.', 0.4, 3.9, 3, 2, 3, 2, 4, 5),
('Buizel', '418', 'Sea Weasel', 'It swims by rotating its two tails like a screw.When it dives, its flotation sac collapses.', 0.7, 29.5, 2, 3, 2, 3, 1, 5),
('Floatzel', '419', 'Sea Weasel', 'It floats using its well-developed flotation sac.It assists in the rescues of drowning people.', 1.1, 33.5, 3, 5, 3, 4, 2, 6),
('Cherubi', '420', 'Cherry', 'Sunlight colors it red. When the small ball isdrained of nutrients, it shrivels to herald evolution.', 0.4, 3.3, 2, 2, 2, 3, 2, 2),
('Cherrim', '421', 'Blossom', 'During times of strong sunlight, its bud blooms,its petals open fully, and it becomes very active.', 0.5, 9.3, 3, 3, 3, 4, 3, 5),
('Shellos', '422', 'Sea Slug', 'Beware of pushing strongly on its squishy body,as it makes a mysterious purple fluid ooze out.', 0.3, 6.3, 3, 3, 2, 3, 3, 2),
('Gastrodon', '423', 'Sea Slug', 'When its natural enemy attacks, it oozes purplefluid and escapes.', 0.9, 29.9, 4, 4, 3, 5, 3, 2),
('Ambipom', '424', 'Long Tail', 'They work in large colonies and make rings bylinking their tails, apparently in friendship.', 1.2, 20.3, 3, 5, 3, 3, 3, 6),
('Drifloon', '425', 'Balloon', 'A Pokémon formed by the spirits of people and Pokémon.It loves damp, humid seasons.', 0.4, 1.2, 4, 3, 2, 3, 2, 4),
('Drifblim', '426', 'Blimp', 'It carries people and Pokémon when it flies.But since it only drifts, it can end up anywhere.', 1.2, 15.0, 6, 4, 2, 4, 2, 4),
('Buneary', '427', 'Rabbit', 'Its ears are always rolled up. They can be forcefullyextended to shatter even a large boulder.', 0.4, 5.5, 2, 3, 2, 2, 2, 5),
('Lopunny', '428', 'Rabbit', 'Extremely cautious, it quickly bounds off when itsenses danger.', 1.2, 33.3, 3, 4, 4, 3, 4, 6),
('Mismagius', '429', 'Magical', 'It chants incantations. While they usually tormenttargets, some chants bring happiness.', 0.9, 4.4, 3, 3, 3, 5, 4, 6),
('Honchkrow', '430', 'Big Boss', 'If one utters a deep cry, many Murkrow gatherquickly. For this, it is called “Summoner of Night.”', 0.9, 27.3, 4, 6, 2, 5, 2, 4),
('Glameow', '431', 'Catty', 'It claws if displeased and purrs when affectionate.Its fickleness is very popular among some.', 0.5, 3.9, 2, 3, 2, 2, 2, 5),
('Purugly', '432', 'Tiger Cat', 'It would claim another Pokémon&#39;s nest as its ownif it finds a nest sufficiently comfortable.', 1.0, 43.8, 3, 4, 3, 3, 3, 6),
('Chingling', '433', 'Bell', 'Each time it hops, it makes a ringing sound.It deafens foes by emitting high-frequency cries.', 0.2, 0.6, 2, 2, 2, 3, 2, 3),
('Stunky', '434', 'Skunk', 'It sprays a foul fluid from its rear. Its stenchspreads over a mile radius, driving Pokémon away.', 0.4, 19.2, 3, 3, 2, 2, 2, 4),
('Skuntank', '435', 'Skunk', 'It sprays a vile-smelling fluid from the tip of its tailto attack. Its range is over 160 feet.', 1.0, 38.0, 4, 5, 3, 3, 3, 5),
('Bronzor', '436', 'Bronze', 'Ancient people believed that the pattern onBronzor&#39;s back contained a mysterious power.', 0.5, 60.5, 2, 1, 4, 1, 4, 1),
('Bronzong', '437', 'Bronze Bell', 'In ages past, this Pokémon was revered as abringer of rain. It was found buried in the ground.', 1.3, 187.0, 3, 5, 5, 4, 5, 2),
('Bonsly', '438', 'Bonsai', 'It prefers arid environments. It leaks water from itseyes to adjust its body&#39;s fluid levels.', 0.5, 15.0, 2, 4, 4, 1, 2, 1),
('Mime Jr.', '439', 'Mime', 'In an attempt to confuse its enemy, it mimics theenemy&#39;s movements. Then it wastes no time inmaking itself scarce!', 0.6, 13.0, 1, 1, 2, 3, 4, 3),
('Happiny', '440', 'Playhouse', 'It carries a round, egg-shaped rock in its bellypouch and gives the rock to its friends.', 0.6, 24.4, 4, 1, 1, 1, 3, 2),
('Chatot', '441', 'Music Note', 'It mimics the cries of other Pokémon to trick theminto thinking it&#39;s one of them. This way they won&#39;tattack it.', 0.5, 1.9, 3, 3, 2, 5, 2, 5),
('Spiritomb', '442', 'Forbidden', 'A Pokémon that was formed by 108 spirits. It isbound to a fissure in an odd keystone.', 1.0, 108.0, 2, 5, 5, 5, 5, 2),
('Gible', '443', 'Land Shark', 'It nests in horizontal holes warmed by geothermalheat. Foes who get too close can expect to bepounced on and bitten.', 0.7, 20.5, 3, 4, 2, 2, 2, 2),
('Gabite', '444', 'Cave', 'It loves sparkly things. It seeks treasures in cavesand hoards the loot in its nest.', 1.4, 56.0, 3, 5, 3, 2, 2, 4),
('Garchomp', '445', 'Mach', 'When it folds up its body and extends its wings,it looks like a jet plane. It flies at sonic speed.', 1.9, 95.0, 4, 7, 4, 4, 4, 5),
('Munchlax', '446', 'Big Eater', 'It hides food under its long body hair. However,it forgets it has hidden the food.', 0.6, 105.0, 5, 4, 2, 2, 4, 1),
('Riolu', '447', 'Emanation', 'It uses the shapes of auras, which changeaccording to emotion, to communicate with others.', 0.7, 20.2, 2, 4, 2, 2, 2, 3),
('Lucario', '448', 'Aura', 'By catching the aura emanating from others, it canread their thoughts and movements.', 1.2, 54.0, 3, 6, 3, 6, 3, 5),
('Hippopotas', '449', 'Hippo', 'It lives in arid places. Instead of perspiration,it expels grainy sand from its body.', 0.8, 49.5, 3, 4, 3, 2, 2, 2),
('Hippowdon', '450', 'Heavyweight', 'It brandishes its gaping mouth in a display offearsome strength. It raises vast quantities of sandwhile attacking.', 2.0, 300.0, 4, 6, 5, 3, 3, 3),
('Skorupi', '451', 'Scorpion', 'It grips prey with its tail claws and injects poison.It tenaciously hangs on until the poison takes.', 0.8, 12.0, 2, 3, 4, 1, 2, 4),
('Drapion', '452', 'Ogre Scorpion', 'It takes pride in its strength. Even though it cantear foes apart, it finishes them off withpowerful poison.', 1.3, 61.5, 3, 5, 5, 3, 3, 5),
('Croagunk', '453', 'Toxic Mouth', 'Its cheeks hold poison sacs. It tries to catch foesoff guard to jab them with toxic fingers.', 0.7, 23.0, 2, 3, 2, 3, 2, 3),
('Toxicroak', '454', 'Toxic Mouth', 'It has a poison sac at its throat. When it croaks,the stored poison is churned for greater potency.', 1.3, 44.4, 3, 5, 3, 4, 3, 5),
('Carnivine', '455', 'Bug Catcher', 'It attracts prey with its sweet-smelling saliva, thenchomps down. It takes a whole day to eat prey.', 1.4, 27.0, 3, 5, 3, 4, 3, 3),
('Finneon', '456', 'Wing Fish', 'The line running down its side can store sunlight.It shines vividly at night.', 0.4, 7.0, 2, 3, 3, 2, 3, 4),
('Lumineon', '457', 'Neon', 'It lives on the deep-sea floor. It attracts prey byflashing the patterns on its four tail fins.', 1.2, 24.0, 3, 4, 3, 3, 4, 5),
('Mantyke', '458', 'Kite', 'The pattern on its back varies by region.It often swims in a school of Remoraid.', 1.0, 65.0, 2, 1, 2, 3, 5, 3),
('Snover', '459', 'Frost Tree', 'During cold seasons, it migrates to the mountain&#39;slower reaches. It returns to the snow-coveredsummit in the spring.', 1.0, 50.5, 3, 3, 2, 3, 3, 2),
('Abomasnow', '460', 'Frost Tree', 'It blankets wide areas in snow by whipping upblizzards. It is also known as “The Ice Monster.”', 2.2, 135.5, 4, 5, 3, 5, 4, 3),
('Weavile', '461', 'Sharp Claw', 'It lives in snowy regions. It carves patterns in treeswith its claws as a signal to others.', 1.1, 34.0, 3, 6, 3, 2, 4, 7),
('Magnezone', '462', 'Magnet Area', 'Sometimes the magnetism emitted by Magnezone istoo strong, making them attract each other so theycannot move.', 1.2, 180.0, 3, 4, 5, 6, 4, 3),
('Lickilicky', '463', 'Licking', 'It wraps things with its extensible tongue. Gettingtoo close to it will leave you soaked with drool.', 1.7, 140.0, 4, 4, 4, 4, 4, 3),
('Rhyperior', '464', 'Drill', 'From holes in its palms, it fires out Geodude.Its carapace can withstand volcanic eruptions.', 2.4, 282.8, 5, 7, 6, 3, 2, 2),
('Tangrowth', '465', 'Vine', 'It ensnares prey by extending arms made of vines.Losing arms to predators does not trouble it.', 2.0, 128.6, 4, 5, 5, 5, 2, 3),
('Electivire', '466', 'Thunderbolt', 'As its electric charge amplifies, blue sparks beginto crackle between its horns.', 1.8, 138.6, 3, 6, 3, 5, 4, 5),
('Magmortar', '467', 'Blast', 'It blasts fireballs of over 3,600 degrees Fahrenheitfrom the ends of its arms. It lives involcanic craters.', 1.6, 68.0, 3, 5, 3, 6, 4, 5),
('Togekiss', '468', 'Jubilee', 'As everyone knows, it visits peaceful regions,bringing them gifts of kindness andsweet blessings.', 1.5, 38.0, 3, 3, 4, 6, 5, 4),
('Yanmega', '469', 'Ogre Darner', 'It prefers to battle by biting apart foes&#39; headsinstantly while flying by at high speed.', 1.9, 51.5, 4, 4, 4, 6, 2, 5),
('Leafeon', '470', 'Verdant', 'When you see Leafeon asleep in a patch ofsunshine, you&#39;ll know it is using photosynthesisto produce clean air.', 1.0, 25.5, 3, 6, 6, 3, 3, 5),
('Glaceon', '471', 'Fresh Snow', 'By controlling its body heat, it can freeze theatmosphere around it to make adiamond-dust flurry.', 0.8, 25.9, 3, 3, 5, 6, 4, 4),
('Gliscor', '472', 'Fang Scorpion', 'It observes prey while hanging inverted frombranches. When the chance presents itself,it swoops!', 2.0, 42.5, 3, 5, 5, 2, 3, 5),
('Mamoswine', '473', 'Twin Tusk', 'A frozen Mamoswine was dug from ice dating back10,000 years. This Pokémon has been around along, long, long time.', 2.5, 291.0, 4, 7, 4, 3, 3, 4),
('Porygon-Z', '474', 'Virtual', 'Additional software was installed to make it a betterPokémon. It began acting oddly, however.', 0.9, 34.0, 3, 4, 3, 7, 3, 5),
('Gallade', '475', 'Blade', 'Because it can sense what its foe is thinking,its attacks burst out first, fast, and fierce.', 1.6, 52.0, 3, 6, 3, 3, 5, 4),
('Probopass', '476', 'Compass', 'It exudes strong magnetism from all over.It controls three small units called Mini-Noses.', 1.4, 340.0, 3, 3, 6, 4, 6, 2),
('Dusknoir', '477', 'Gripper', 'It is said to take lost spirits into its pliant body andguide them home.', 2.2, 106.6, 2, 5, 6, 3, 6, 3),
('Froslass', '478', 'Snow Land', 'It freezes foes with an icy breath nearly-60 degrees Fahrenheit. What seems to be its bodyis actually hollow.', 1.3, 26.6, 3, 4, 3, 4, 3, 6),
('Rotom', '479', 'Plasma', 'Research continues on this Pokémon, which couldbe the power source of a unique motor.', 0.3, 0.3, 2, 3, 3, 5, 3, 5),
('Uxie', '480', 'Knowledge', 'Known as “The Being of Knowledge.” It is said thatit can wipe out the memory of those who seeits eyes.', 0.3, 0.3, 3, 4, 6, 4, 5, 5),
('Mesprit', '481', 'Emotion', 'Known as “The Being of Emotion.” It taughthumans the nobility of sorrow, pain, and joy.', 0.3, 0.3, 3, 5, 5, 5, 4, 4),
('Azelf', '482', 'Willpower', 'Known as “The Being of Willpower.” It sleeps at thebottom of a lake to keep the world in balance.', 0.3, 0.3, 3, 6, 3, 6, 3, 6),
('Dialga', '483', 'Temporal', 'A Pokémon spoken of in legend. It is said that timebegan moving when Dialga was born.', 5.4, 683.0, 4, 6, 5, 7, 4, 5),
('Palkia', '484', 'Spatial', 'It is said to live in a gap in the spatial dimensionparallel to ours. It appears in mythology.', 4.2, 336.0, 4, 6, 4, 7, 5, 5),
('Heatran', '485', 'Lava Dome', 'It dwells in volcanic caves. It digs in with itscross-shaped feet to crawl on ceilings and walls.', 1.7, 430.0, 4, 5, 5, 6, 4, 4),
('Regigigas', '486', 'Colossal', 'It is said to have made Pokémon that look likeitself from a special ice mountain, rocks,and magma.', 3.7, 420.0, 4, 8, 5, 4, 5, 5),
('Giratina', '487', 'Renegade', 'This Pokémon is said to live in a world on thereverse side of ours, where common knowledge isdistorted and strange.', 4.5, 750.0, 6, 5, 5, 5, 5, 5),
('Cresselia', '488', 'Lunar', 'Shiny particles are released from its wings like aveil. It is said to represent the crescent moon.', 1.5, 85.6, 5, 4, 5, 4, 5, 5),
('Phione', '489', 'Sea Drifter', 'When the water warms, they inflate the flotation sacon their heads and drift languidly on the seain packs.', 0.4, 3.1, 3, 4, 4, 4, 3, 4),
('Manaphy', '490', 'Seafaring', 'It is born with a wondrous power that lets it bondwith any kind of Pokémon.', 0.3, 1.4, 4, 5, 4, 5, 4, 5),
('Darkrai', '491', 'Pitch-Black', 'It chases people and Pokémon from its territory bycausing them to experience deep,nightmarish slumbers.', 1.5, 50.5, 3, 5, 4, 7, 4, 7),
('Shaymin', '492', 'Gratitude', 'It can dissolve toxins in the air to instantlytransform ruined land into a lush field of flowers.', 0.2, 2.1, 4, 5, 4, 5, 4, 5),
('Arceus', '493', 'Alpha', 'According to the legends of Sinnoh, this Pokémonemerged from an egg and shaped all there is inthis world.', 3.2, 320.0, 5, 6, 5, 6, 5, 6),
('Victini', '494', 'Victory', 'This Pokémon brings victory. It is said that Trainerswith Victini always win, regardless of the typeof encounter.', 0.4, 4.0, 4, 5, 4, 5, 4, 5),
('Snivy', '495', 'Grass Snake', 'Being exposed to sunlight makes its movementsswifter. It uses vines more adeptly than its hands.', 0.6, 8.1, 2, 2, 3, 2, 2, 3),
('Servine', '496', 'Grass Snake', 'It moves along the ground as if sliding. Its swiftmovements befuddle its foes, and it then attackswith a vine whip.', 0.8, 16.0, 3, 3, 3, 3, 3, 5),
('Serperior', '497', 'Regal', 'It only gives its all against strong opponents whoare not fazed by the glare from Serperior&#39;snoble eyes.', 3.3, 63.0, 3, 4, 4, 4, 4, 6),
('Tepig', '498', 'Fire Pig', 'It can deftly dodge its foe&#39;s attacks while shootingfireballs from its nose. It roasts berries before iteats them.', 0.5, 9.9, 3, 3, 2, 2, 2, 3),
('Pignite', '499', 'Fire Pig', 'The more it eats, the more fuel it has to make thefire in its stomach stronger. This fills it with evenmore power.', 1.0, 55.5, 4, 5, 3, 3, 2, 3),
('Emboar', '500', 'Mega Fire Pig', 'It can throw a fire punch by setting its fists on firewith its fiery chin. It cares deeply about its friends.', 1.6, 150.0, 4, 6, 3, 5, 3, 4),
('Oshawott', '501', 'Sea Otter', 'The scalchop on its stomach isn&#39;t just used forbattle—it can be used to break open hard berriesas well.', 0.5, 5.9, 2, 3, 2, 3, 2, 3),
('Dewott', '502', 'Discipline', 'Strict training is how it learns its flowingdouble-scalchop technique.', 0.8, 24.5, 3, 4, 3, 4, 3, 3),
('Samurott', '503', 'Formidable', 'In the time it takes a foe to blink, it can draw andsheathe the seamitars attached to its front legs.', 1.5, 94.6, 4, 5, 4, 5, 3, 4),
('Patrat', '504', 'Scout', 'Using food stored in cheek pouches, they can keepwatch for days. They use their tails to communicatewith others.', 0.5, 11.6, 2, 3, 2, 2, 2, 2),
('Watchog', '505', 'Lookout', 'Using luminescent matter, it makes its eyes andbody glow and stuns attacking opponents.', 1.1, 27.0, 3, 4, 3, 3, 3, 4),
('Lillipup', '506', 'Puppy', 'The long hair around its face provides an amazingradar that lets it sense subtle changes inits surroundings.', 0.4, 4.1, 2, 3, 2, 1, 2, 3),
('Herdier', '507', 'Loyal Dog', 'This very loyal Pokémon helps Trainers, and it alsotakes care of other Pokémon.', 0.9, 14.7, 3, 4, 3, 2, 3, 3),
('Stoutland', '508', 'Big-Hearted', 'It rescues people stranded by blizzards in themountains. Its shaggy fur shields it from the cold.', 1.2, 61.0, 3, 6, 4, 2, 4, 4),
('Purrloin', '509', 'Devious', 'Its cute act is a ruse. When victims let down theirguard, they find their items taken. It attacks withsharp claws.', 0.4, 10.1, 2, 3, 2, 2, 2, 4),
('Liepard', '510', 'Cruel', 'Their beautiful form comes from the muscles theyhave developed. They run silently in the night.', 1.1, 37.5, 3, 5, 2, 4, 2, 6),
('Pansage', '511', 'Grass Monkey', 'It shares the leaf on its head with weary-lookingPokémon. These leaves are known to relieve stress.', 0.6, 10.5, 2, 3, 2, 3, 2, 4),
('Simisage', '512', 'Thorn Monkey', 'It attacks enemies with strikes of its thorn-coveredtail. This Pokémon is wild tempered.', 1.1, 30.5, 3, 5, 3, 5, 3, 5),
('Pansear', '513', 'High Temp', 'Very intelligent, it roasts berries before eating them.It likes to help people.', 0.6, 11.0, 2, 3, 2, 3, 2, 4),
('Simisear', '514', 'Ember', 'A flame burns inside its body. It scatters embersfrom its head and tail to sear its opponents.', 1.0, 28.0, 3, 5, 3, 5, 3, 5),
('Panpour', '515', 'Spray', 'The water stored inside the tuft on its head is fullof nutrients. It waters plants with it using its tail.', 0.6, 13.5, 2, 3, 2, 3, 2, 4),
('Simipour', '516', 'Geyser', 'The high-pressure water expelled from its tail is sopowerful, it can destroy a concrete wall.', 1.0, 29.0, 3, 5, 3, 5, 3, 5),
('Munna', '517', 'Dream Eater', 'This Pokémon appears before people and Pokémonwho are having nightmares and eats those dreams.', 0.6, 23.3, 3, 1, 2, 3, 2, 1),
('Musharna', '518', 'Drowsing', 'The mist emanating from their foreheads is packedwith the dreams of people and Pokémon.', 1.1, 60.5, 5, 3, 4, 5, 4, 2),
('Pidove', '519', 'Tiny Pigeon', 'This very forgetful Pokémon will wait for a neworder from its Trainer even though it alreadyhas one.', 0.3, 2.1, 2, 3, 2, 2, 1, 2),
('Tranquill', '520', 'Wild Pigeon', 'Many people believe that, deep in the forest whereTranquill live, there is a peaceful place where thereis no war.', 0.6, 15.0, 3, 4, 3, 2, 2, 4),
('Unfezant', '521', 'Proud', 'Males swing their head plumage to threatenopponents. The females&#39; flying abilities surpassthose of the males.', 1.2, 29.0, 3, 6, 4, 3, 2, 5),
('Blitzle', '522', 'Electrified', 'When thunderclouds cover the sky, it will appear.It can catch lightning with its mane and storethe electricity.', 0.8, 29.8, 2, 3, 2, 2, 1, 4),
('Zebstrika', '523', 'Thunderbolt', 'When this ill-tempered Pokémon runs wild, itshoots lightning from its mane in all directions.', 1.6, 79.5, 3, 5, 3, 4, 3, 6),
('Roggenrola', '524', 'Mantle', 'Its ear is hexagonal in shape. Compressedunderground, its body is as hard as steel.', 0.4, 18.0, 2, 4, 4, 1, 1, 1),
('Boldore', '525', 'Ore', 'Because its energy was too great to be contained,the energy leaked and formed orange crystals.', 0.9, 102.0, 3, 5, 5, 2, 2, 1),
('Gigalith', '526', 'Compressed', 'The solar rays it absorbs are processed in itsenergy core and fired as a ball of light.', 1.7, 260.0, 3, 7, 6, 3, 3, 2),
('Woobat', '527', 'Bat', 'Its habitat is dark forests and caves. It emitsultrasonic waves from its nose to learn aboutits surroundings.', 0.4, 2.1, 2, 2, 2, 3, 2, 4),
('Swoobat', '528', 'Courting', 'It shakes its tail vigorously when it emits ultrasonicwaves strong enough to reduce concrete to rubble.', 0.9, 10.5, 3, 3, 3, 4, 2, 6),
('Drilbur', '529', 'Mole', 'It makes its way swiftly through the soil by puttingboth claws together and rotating at high speed.', 0.3, 8.5, 3, 4, 2, 1, 2, 4),
('Excadrill', '530', 'Subterrene', 'It can help in tunnel construction. Its drill hasevolved into steel strong enough to bore throughiron plates.', 0.7, 40.4, 4, 7, 3, 2, 3, 5),
('Audino', '531', 'Hearing', 'Using the feelers on its ears, it can tell howsomeone is feeling or when an egg might hatch.', 1.1, 31.0, 4, 3, 4, 3, 4, 3),
('Timburr', '532', 'Muscular', 'These Pokémon appear at building sites and helpout with construction. They always carrysquared logs.', 0.6, 12.5, 3, 4, 3, 1, 2, 2),
('Gurdurr', '533', 'Muscular', 'With strengthened bodies, they skillfully wield steelbeams to take down buildings.', 1.2, 40.0, 3, 5, 4, 2, 2, 2),
('Conkeldurr', '534', 'Muscular', 'It is thought that Conkeldurr taught humans how tomake concrete more than 2,000 years ago.', 1.4, 87.0, 4, 7, 4, 3, 3, 3),
('Tympole', '535', 'Tadpole', 'By vibrating its cheeks, it emits sound wavesimperceptible to humans and warns othersof danger.', 0.5, 4.5, 2, 3, 2, 2, 2, 4),
('Palpitoad', '536', 'Vibration', 'When they vibrate the bumps on their heads, theycan make waves in water or earthquake-likevibrations on land.', 0.8, 17.0, 3, 3, 3, 3, 2, 4),
('Seismitoad', '537', 'Vibration', 'It increases the power of its punches by vibratingthe bumps on its fists. It can turn a boulder torubble with one punch.', 1.5, 62.0, 4, 5, 3, 4, 3, 4),
('Throh', '538', 'Judo', 'When it tightens its belt, it becomes stronger. WildThroh use vines to weave their own belts.', 1.3, 55.5, 5, 5, 4, 1, 4, 3),
('Sawk', '539', 'Karate', 'Desiring the strongest karate chop, they secludethemselves in mountains and train without sleeping.', 1.4, 51.0, 3, 6, 3, 1, 3, 5),
('Sewaddle', '540', 'Sewing', 'This Pokémon makes clothes for itself. It chews upleaves and sews them with sticky thread extrudedfrom its mouth.', 0.3, 2.5, 2, 3, 3, 2, 3, 2),
('Swadloon', '541', 'Leaf-Wrapped', 'Forests where Swadloon live have superb foliagebecause the nutrients they make from fallen leavesnourish the plant life.', 0.5, 7.3, 2, 3, 4, 2, 3, 2),
('Leavanny', '542', 'Nurturing', 'Upon finding a small Pokémon, it weaves clothingfor it from leaves by using the sticky silk secretedfrom its mouth.', 1.2, 20.5, 3, 5, 4, 3, 3, 5),
('Venipede', '543', 'Centipede', 'It discovers what is going on around it by using thefeelers on its head and tail. It is brutally aggressive.', 0.4, 5.3, 2, 2, 3, 1, 2, 3),
('Whirlipede', '544', 'Curlipede', 'Protected by a hard shell, it spins its body like awheel and crashes furiously into its enemies.', 1.2, 58.5, 2, 3, 4, 2, 3, 3),
('Scolipede', '545', 'Megapede', 'It clasps its prey with the claws on its neck until itstops moving. Then it finishes it off withdeadly poison.', 2.5, 200.5, 3, 5, 4, 3, 3, 6),
('Cottonee', '546', 'Cotton Puff', 'When attacked, it escapes by shooting cotton fromits body. The cotton serves as a decoy to distractthe attacker.', 0.3, 0.6, 2, 2, 3, 2, 2, 4),
('Whimsicott', '547', 'Windveiled', 'They appear along with whirlwinds. They pullpranks, such as moving furniture and leaving ballsof cotton in homes.', 0.7, 6.6, 3, 4, 4, 4, 3, 6),
('Petilil', '548', 'Bulb', 'The leaves on its head are very bitter. Eating oneof these leaves is known to refresh a tired body.', 0.5, 6.6, 2, 2, 2, 3, 2, 2),
('Lilligant', '549', 'Flowering', 'The fragrance of the garland on its head has arelaxing effect. It withers if a Trainer does not takegood care of it.', 1.1, 16.3, 3, 3, 3, 5, 3, 5),
('Basculin', '550', 'Hostile', 'Red- and blue-striped Basculin are very violent andalways fighting. They are also remarkably tasty.', 1.0, 18.0, 3, 5, 3, 4, 2, 5),
('Sandile', '551', 'Desert Croc', 'It moves along below the sand&#39;s surface, exceptfor its nose and eyes. A dark membrane shields itseyes from the sun.', 0.7, 15.2, 2, 4, 2, 2, 2, 4),
('Krokorok', '552', 'Desert Croc', 'They live in groups of a few individuals. Protectivemembranes shield their eyes from sandstorms.', 1.0, 33.4, 3, 4, 2, 2, 2, 4),
('Krookodile', '553', 'Intimidation', 'Very violent Pokémon, they try to clamp down onanything that moves in front of their eyes.', 1.5, 96.3, 4, 6, 4, 3, 3, 5),
('Darumaka', '554', 'Zen Charm', 'Darumaka&#39;s droppings are hot, so people used toput them in their clothes to keep themselves warm.', 0.6, 37.5, 3, 5, 2, 1, 2, 3),
('Darmanitan', '555', 'Blazing', 'When one is injured in a fierce battle, it hardensinto a stone-like form. Then it meditates andsharpens its mind.', 1.3, 92.9, 4, 7, 3, 1, 2, 5),
('Maractus', '556', 'Cactus', 'It uses an up-tempo song and dance to drive awaythe bird Pokémon that prey on its flower seeds.', 1.0, 28.0, 3, 4, 3, 5, 3, 3),
('Dwebble', '557', 'Rock Inn', 'It makes a hole in a suitable rock. If that rockbreaks, the Pokémon remains agitated until itlocates a replacement.', 0.3, 14.5, 2, 3, 4, 2, 2, 3),
('Crustle', '558', 'Stone Home', 'It possesses legs of enormous strength, enabling itto carry heavy slabs for many days, even whencrossing arid land.', 1.4, 200.0, 3, 5, 5, 3, 3, 3),
('Scraggy', '559', 'Shedding', 'Its skin has a rubbery elasticity, so it can reducedamage by defensively pulling its skin up toits neck.', 0.6, 11.8, 2, 4, 3, 2, 3, 3),
('Scrafty', '560', 'Hoodlum', 'It pulls up its shed skin to protect itself whileit kicks. The bigger the crest, the more respectedit is.', 1.1, 30.0, 3, 5, 5, 2, 5, 3),
('Sigilyph', '561', 'Avianoid', 'The guardians of an ancient city, they use theirpsychic power to attack enemies that invadetheir territory.', 1.4, 14.0, 3, 3, 4, 5, 3, 5),
('Yamask', '562', 'Spirit', 'These Pokémon arose from the spirits of peopleinterred in graves. Each retains memories of itsformer life.', 0.5, 1.5, 2, 2, 4, 3, 3, 2),
('Cofagrigus', '563', 'Coffin', 'It has been said that they swallow those who gettoo close and turn them into mummies. They like toeat gold nuggets.', 1.7, 76.5, 3, 3, 6, 5, 4, 2),
('Tirtouga', '564', 'Prototurtle', 'About 100 million years ago, these Pokémon swamin oceans. It is thought they also went on land toattack prey.', 0.7, 16.5, 2, 4, 4, 3, 2, 1),
('Carracosta', '565', 'Prototurtle', 'They can live both in the ocean and on land. A slapfrom one of them is enough to open a hole in thebottom of a tanker.', 1.2, 81.0, 3, 6, 6, 4, 3, 2),
('Archen', '566', 'First Bird', 'Revived from a fossil, this Pokémon is thought tobe the ancestor of all bird Pokémon.', 0.5, 9.5, 2, 6, 2, 4, 2, 4),
('Archeops', '567', 'First Bird', 'They are intelligent and will cooperate to catchprey. From the ground, they use a running start totake flight.', 1.4, 32.0, 3, 7, 3, 5, 3, 6),
('Trubbish', '568', 'Trash Bag', 'The combination of garbage bags and industrialwaste caused the chemical reaction that createdthis Pokémon.', 0.6, 31.0, 2, 3, 3, 2, 3, 4),
('Garbodor', '569', 'Trash Heap', 'It clenches opponents with its left arm and finishesthem off with foul-smelling poison gas belched fromits mouth.', 1.9, 107.3, 3, 5, 4, 3, 3, 4),
('Zorua', '570', 'Tricky Fox', 'It changes so it looks just like its foe, tricks it, andthen uses that opportunity to flee.', 0.7, 12.5, 2, 3, 2, 4, 2, 4),
('Zoroark', '571', 'Illusion Fox', 'Each has the ability to fool a large group of peoplesimultaneously. They protect their lair withillusory scenery.', 1.6, 81.1, 3, 5, 3, 6, 3, 6),
('Minccino', '572', 'Chinchilla', 'Minccino greet each other by grooming one anotherthoroughly with their tails.', 0.4, 5.8, 2, 3, 2, 2, 2, 4),
('Cinccino', '573', 'Scarf', 'Their white fur feels amazing to touch. Their furrepels dust and prevents static electricity frombuilding up.', 0.5, 7.5, 3, 5, 3, 3, 3, 6),
('Gothita', '574', 'Fixation', 'Their ribbonlike feelers increase their psychicpower. They are always staring at something.', 0.4, 5.8, 2, 2, 2, 3, 3, 3),
('Gothorita', '575', 'Manipulate', 'Starlight is the source of their power. At night,they mark star positions by using psychic powerto float stones.', 0.7, 18.0, 3, 2, 3, 4, 4, 3),
('Gothitelle', '576', 'Astral Body', 'Starry skies thousands of light-years away arevisible in the space distorted by their intensepsychic power.', 1.5, 44.0, 3, 3, 4, 5, 5, 4),
('Solosis', '577', 'Cell', 'Because their bodies are enveloped in a specialliquid, they are fine in any environment, no matterhow severe.', 0.3, 1.0, 2, 2, 2, 5, 2, 1),
('Duosion', '578', 'Mitosis', 'Since they have two divided brains, at times theysuddenly try to take two different actions at once.', 0.6, 8.0, 3, 2, 2, 6, 3, 2),
('Reuniclus', '579', 'Multiplying', 'They use psychic power to control their arms,which are made of a special liquid. They can crushboulders psychically.', 1.0, 20.1, 4, 3, 3, 6, 4, 2),
('Ducklett', '580', 'Water Bird', 'When attacked, it uses its feathers to splash water,escaping under cover of the spray.', 0.5, 5.5, 3, 2, 2, 2, 2, 3),
('Swanna', '581', 'White Bird', 'Despite their elegant appearance, they can flaptheir wings strongly and fly for thousands of miles.', 1.3, 24.2, 3, 4, 3, 4, 3, 5),
('Vanillite', '582', 'Fresh Snow', 'The temperature of their breath is -58 degreesFahrenheit. They create snow crystals and makesnow fall in the areas around them.', 0.4, 5.7, 2, 3, 2, 3, 3, 3),
('Vanillish', '583', 'Icy Snow', 'They cool down the surrounding air and create iceparticles, which they use to freeze their foes.', 1.1, 41.0, 2, 3, 3, 4, 3, 3),
('Vanilluxe', '584', 'Snowstorm', 'If both heads get angry simultaneously, thisPokémon expels a blizzard, burying everythingin snow.', 1.3, 57.5, 3, 5, 4, 5, 4, 4),
('Deerling', '585', 'Season', 'Their coloring changes according to the seasonsand can be slightly affected by the temperature andhumidity as well.', 0.6, 19.5, 3, 3, 2, 2, 2, 4),
('Sawsbuck', '586', 'Season', 'They migrate according to the seasons. People cantell the season by looking at Sawsbuck&#39;s horns.', 1.9, 92.5, 3, 5, 3, 3, 3, 5),
('Emolga', '587', 'Sky Squirrel', 'They live on treetops and glide using the inside ofa cape-like membrane while discharging electricity.', 0.4, 5.0, 2, 4, 3, 4, 3, 6),
('Karrablast', '588', 'Clamping', 'These mysterious Pokémon evolve when theyreceive electrical stimulation while they are in thesame place as Shelmet.', 0.5, 5.9, 2, 4, 2, 2, 2, 3),
('Escavalier', '589', 'Cavalry', 'Wearing the shell covering they stole from Shelmet,they defend themselves and attack with two lances.', 1.0, 33.0, 3, 7, 5, 3, 4, 1),
('Foongus', '590', 'Mushroom', 'It lures people in with its Poké Ball pattern, thenreleases poison spores. Why it resembles aPoké Ball is unknown.', 0.2, 1.0, 3, 3, 2, 3, 2, 1),
('Amoonguss', '591', 'Mushroom', 'They show off their Poké Ball caps to lure prey,but very few Pokémon are fooled by this.', 0.6, 10.5, 5, 4, 3, 4, 3, 2),
('Frillish', '592', 'Floating', 'They paralyze prey with poison, then drag themdown to their lairs, five miles below the surface.', 1.2, 33.0, 2, 2, 2, 3, 4, 2),
('Jellicent', '593', 'Floating', 'Its body is mostly seawater. It&#39;s said there&#39;s acastle of ships Jellicent have sunk on the seafloor.', 2.2, 135.0, 4, 3, 3, 4, 4, 3),
('Alomomola', '594', 'Caring', 'Floating in the open sea is how they live.When they find a wounded Pokémon,they embrace it and bring it to shore.', 1.2, 31.6, 6, 4, 4, 2, 2, 4),
('Joltik', '595', 'Attaching', 'Since it can&#39;t generate its own electricity, it sticksonto large-bodied Pokémon and absorbsstatic electricity.', 0.1, 0.6, 2, 3, 2, 3, 2, 4),
('Galvantula', '596', 'EleSpider', 'They employ an electrically charged web to traptheir prey. While it is immobilized by shock,they leisurely consume it.', 0.8, 14.3, 3, 4, 3, 5, 3, 6),
('Ferroseed', '597', 'Thorn Seed', 'When threatened, it attacks by shooting a barrageof spikes, which gives it a chance to escape byrolling away.', 0.6, 18.8, 2, 3, 4, 1, 4, 1),
('Ferrothorn', '598', 'Thorn Pod', 'By swinging around its three spiky feelers andshooting spikes, it can obliterate an opponent.', 1.0, 110.0, 3, 5, 6, 3, 5, 1),
('Klink', '599', 'Gear', 'Interlocking two bodies and spinning aroundgenerates the energy they need to live.', 0.3, 21.0, 2, 3, 3, 2, 3, 2),
('Klang', '600', 'Gear', 'By changing the direction in which it rotates,it communicates its feelings to others. When angry,it rotates faster.', 0.6, 51.0, 3, 4, 4, 3, 4, 3),
('Klinklang', '601', 'Gear', 'The gear with the red core is rotated at high speedfor a rapid energy charge.', 0.6, 81.0, 3, 5, 5, 3, 4, 5),
('Tynamo', '602', 'EleFish', 'While one alone doesn&#39;t have much power, a chainof many Tynamo can be as powerful as lightning.', 0.2, 0.3, 2, 3, 2, 2, 2, 3),
('Eelektrik', '603', 'EleFish', 'It wraps itself around its prey and paralyzes it withelectricity from the round spots on its sides.Then it chomps.', 1.2, 22.0, 3, 4, 3, 4, 3, 2),
('Eelektross', '604', 'EleFish', 'With their sucker mouths, they suck in prey.Then they use their fangs to shock the preywith electricity.', 2.1, 80.5, 3, 6, 4, 5, 3, 3),
('Elgyem', '605', 'Cerebral', 'It uses its strong psychic power to squeeze itsopponent&#39;s brain, causing unendurable headaches.', 0.5, 9.0, 2, 3, 3, 4, 2, 2),
('Beheeyem', '606', 'Cerebral', 'Apparently, it communicates by flashing its threefingers, but those patterns haven&#39;t been decoded.', 1.0, 34.5, 3, 4, 3, 6, 4, 2),
('Litwick', '607', 'Candle', 'While shining a light and pretending to be a guide,it leeches off the life force of any who follow it.', 0.3, 3.1, 2, 2, 3, 3, 2, 1),
('Lampent', '608', 'Lamp', 'The spirits it absorbs fuel its baleful fire. It hangsaround hospitals waiting for people to pass on.', 0.6, 13.0, 3, 2, 3, 5, 3, 3),
('Chandelure', '609', 'Luring', 'Being consumed in Chandelure&#39;s flame burns upthe spirit, leaving the body behind.', 1.0, 34.3, 3, 3, 4, 7, 4, 4),
('Axew', '610', 'Tusk', 'They use their tusks to crush the berries they eat.Repeated regrowth makes their tusks strongand sharp.', 0.6, 18.0, 2, 4, 3, 1, 2, 3),
('Fraxure', '611', 'Axe Jaw', 'Their tusks can shatter rocks. Territory battlesbetween Fraxure can be intensely violent.', 1.0, 36.0, 3, 6, 3, 2, 2, 4),
('Haxorus', '612', 'Axe Jaw', 'They are kind but can be relentless when defendingterritory. They challenge foes with tusks that cancut steel.', 1.8, 105.5, 3, 7, 4, 3, 3, 5),
('Cubchoo', '613', 'Chill', 'Its nose is always running. It sniffs the snot back upbecause the mucus provides the raw material forits moves.', 0.5, 8.5, 2, 4, 2, 3, 2, 2),
('Beartic', '614', 'Freezing', 'They love the cold seas of the north. They createpathways across the ocean waters by freezing theirown breath.', 2.6, 260.0, 4, 6, 4, 3, 3, 3),
('Cryogonal', '615', 'Crystallizing', 'They are born in snow clouds. They use chainsmade of ice crystals to capture prey.', 1.1, 148.0, 3, 3, 2, 5, 6, 6),
('Shelmet', '616', 'Snail', 'When it and Karrablast are together, and bothreceive electrical stimulation, they both evolve.', 0.4, 7.7, 2, 2, 4, 2, 3, 2),
('Accelgor', '617', 'Shell Out', 'Having removed its heavy shell, it becomes verylight and can fight with ninja-like movements.', 0.8, 25.3, 3, 4, 2, 5, 3, 8),
('Stunfisk', '618', 'Trap', 'Its skin is very hard, so it is unhurt even if steppedon by sumo wrestlers. It smiles whentransmitting electricity.', 0.7, 11.0, 4, 3, 4, 4, 4, 2),
('Mienfoo', '619', 'Martial Arts', 'It takes pride in the speed at which it can usemoves. What it loses in power, it makes up forin quantity.', 0.9, 20.0, 2, 4, 2, 3, 2, 4),
('Mienshao', '620', 'Martial Arts', 'It wields the fur on its arms like a whip. Its armattacks come with such rapidity that they cannoteven be seen.', 1.4, 35.5, 3, 6, 3, 5, 3, 6),
('Druddigon', '621', 'Cave', 'It races through narrow caves, using its sharp clawsto catch prey. The skin on its face is harder thana rock.', 1.6, 139.0, 3, 6, 4, 3, 4, 3),
('Golett', '622', 'Automaton', 'The energy that burns inside it enables it to move,but no one has yet been able to identifythis energy.', 1.0, 92.0, 3, 4, 2, 2, 2, 2),
('Golurk', '623', 'Automaton', 'It is said that Golurk were ordered to protectpeople and Pokémon by the ancient people whomade them.', 2.8, 330.0, 4, 6, 4, 3, 3, 3),
('Pawniard', '624', 'Sharp Blade', 'Blades comprise this Pokémon&#39;s entire body.If battling dulls the blades, it sharpens them onstones by the river.', 0.5, 10.2, 2, 4, 3, 2, 2, 3),
('Bisharp', '625', 'Sword Blade', 'This pitiless Pokémon commands a group ofPawniard to hound prey into immobility. It thenmoves in to finish the prey off.', 1.6, 70.0, 3, 6, 4, 3, 3, 4),
('Bouffalant', '626', 'Bash Buffalo', 'They charge wildly and headbutt everything.Their headbutts have enough destructive force toderail a train.', 1.6, 94.6, 4, 6, 4, 2, 4, 3),
('Rufflet', '627', 'Eaglet', 'They crush berries with their talons. They bravelystand up to any opponent, no matter how strongit is.', 0.5, 10.5, 3, 4, 2, 2, 2, 3),
('Braviary', '628', 'Valiant', 'For the sake of its friends, this brave warrior of thesky will not stop battling, even if injured.', 1.5, 41.0, 4, 6, 3, 3, 3, 4),
('Vullaby', '629', 'Diapered', 'Its wings are too tiny to allow it to fly. As the timeapproaches for it to evolve, it discards the bonesit was wearing.', 0.5, 9.0, 3, 3, 3, 2, 3, 3),
('Mandibuzz', '630', 'Bone Vulture', 'They fly in circles around the sky. When they spotprey, they attack and carry it back to their nestwith ease.', 1.2, 39.5, 4, 3, 5, 3, 4, 4),
('Heatmor', '631', 'Anteater', 'Using their very hot, flame-covered tongues,they burn through Durant&#39;s steel bodies andconsume their insides.', 1.4, 58.0, 3, 5, 3, 5, 3, 4),
('Durant', '632', 'Iron Ant', 'Individuals each play different roles in drivingHeatmor, their natural predator, away fromtheir colony.', 0.3, 33.0, 3, 6, 5, 2, 2, 6),
('Deino', '633', 'Irate', 'They cannot see, so they tackle and bite to learnabout their surroundings. Their bodies are coveredin wounds.', 0.8, 17.3, 2, 3, 2, 2, 2, 2),
('Zweilous', '634', 'Hostile', 'The two heads do not get along. Whichever headeats more than the other gets to be the leader.', 1.4, 50.0, 3, 4, 3, 3, 3, 3),
('Hydreigon', '635', 'Brutal', 'The heads on their arms do not have brains.They use all three heads to consume anddestroy everything.', 1.8, 160.0, 4, 5, 4, 6, 4, 5),
('Larvesta', '636', 'Torch', 'Said to have been born from the sun, it spews firefrom its horns and encases itself in a cocoon of firewhen it evolves.', 1.1, 28.8, 2, 4, 3, 2, 2, 3),
('Volcarona', '637', 'Sun', 'A sea of fire engulfs the surroundings of theirbattles, since they use their six wings to scattertheir ember scales.', 1.6, 46.0, 3, 3, 3, 7, 4, 5),
('Cobalion', '638', 'Iron Will', 'It has a body and heart of steel. Its glare issufficient to make even an unruly Pokémon obey it.', 2.1, 250.0, 4, 5, 5, 4, 3, 6),
('Terrakion', '639', 'Cavern', 'Its charge is strong enough to break through agiant castle wall in one blow. This Pokémon isspoken of in legends.', 1.9, 260.0, 4, 7, 4, 4, 4, 6),
('Virizion', '640', 'Grassland', 'Its head sprouts horns as sharp as blades. Usingwhirlwind-like movements, it confounds and swiftlycuts opponents.', 2.0, 200.0, 4, 5, 3, 4, 5, 6),
('Tornadus', '641', 'Cyclone', 'The lower half of its body is wrapped in a cloud ofenergy. It zooms through the sky at 200 mph.', 1.5, 63.0, 3, 6, 3, 6, 3, 6),
('Thundurus', '642', 'Bolt Strike', 'The spikes on its tail discharge immense bolts oflightning. It flies around the Unova region firing offlightning bolts.', 1.5, 61.0, 3, 6, 3, 6, 3, 6),
('Reshiram', '643', 'Vast White', 'This legendary Pokémon can scorch the world withfire. It helps those who want to build a worldof truth.', 3.2, 330.0, 4, 6, 4, 7, 5, 5),
('Zekrom', '644', 'Deep Black', 'This legendary Pokémon can scorch the world withlightning. It assists those who want to build anideal world.', 2.9, 345.0, 4, 8, 5, 6, 4, 5),
('Landorus', '645', 'Abundance', 'Lands visited by Landorus grant such bountifulcrops that it has been hailed as “The Guardian ofthe Fields.”', 1.5, 68.0, 4, 6, 4, 6, 3, 5),
('Kyurem', '646', 'Boundary', 'This legendary ice Pokémon waits for a hero to fillin the missing parts of its body with truth or ideals.', 3.0, 325.0, 5, 7, 4, 6, 4, 5),
('Keldeo', '647', 'Colt', 'It crosses the world, running over the surfaces ofoceans and rivers. It appears at scenic waterfronts.', 1.4, 48.5, 4, 4, 4, 6, 4, 6),
('Meloetta', '648', 'Melody', 'The melodies sung by Meloetta have the power tomake Pokémon that hear them happy or sad.', 0.6, 6.5, 4, 4, 3, 6, 5, 5),
('Genesect', '649', 'Paleozoic', 'This ancient bug Pokémon was altered by TeamPlasma. They upgraded the cannon on its back.', 1.5, 82.5, 3, 6, 4, 6, 4, 5),
('Chespin', '650', 'Spiny Nut', 'The quills on its head are usually soft.When it flexes them, the points becomeso hard and sharp that they can pierce rock.', 0.4, 9.0, 2, 3, 3, 2, 2, 2),
('Quilladin', '651', 'Spiny Armor', 'It relies on its sturdy shell to deflect predators&#39;attacks. It counterattacks with its sharp quills.', 0.7, 29.0, 3, 4, 4, 3, 2, 3),
('Chesnaught', '652', 'Spiny Armor', 'Its Tackle is forceful enough to flip a 50-ton tank.It shields its allies from danger with its own body.', 1.6, 90.0, 4, 5, 5, 4, 3, 4),
('Fennekin', '653', 'Fox', 'Eating a twig fills it with energy,and its roomy ears give vent to airhotter than 390 degrees Fahrenheit.', 0.4, 9.4, 2, 2, 2, 3, 3, 3),
('Braixen', '654', 'Fox', 'It has a twig stuck in its tail. Withfriction from its tail fur, it sets thetwig on fire and launches into battle.', 1.0, 14.5, 3, 3, 3, 4, 3, 4),
('Delphox', '655', 'Fox', 'It gazes into the flame at the tip ofits branch to achieve a focused state,which allows it to see into the future.', 1.5, 39.0, 3, 4, 3, 6, 4, 6),
('Froakie', '656', 'Bubble Frog', 'It secretes flexible bubbles from its chest and back.The bubbles reduce the damage it would otherwisetake when attacked.', 0.3, 7.0, 2, 3, 2, 3, 2, 4),
('Frogadier', '657', 'Bubble Frog', 'It can throw bubble-covered pebbles with precisecontrol, hitting empty cans up to a hundred feet away.', 0.6, 10.9, 2, 3, 2, 4, 2, 5),
('Greninja', '658', 'Ninja', 'It creates throwing stars out of compressed water.When it spins them and throws them at high speed,these stars can split metal in two.', 1.5, 40.0, 3, 5, 3, 5, 3, 7),
('Bunnelby', '659', 'Digging', 'They use their large ears to dig burrows.They will dig the whole night through.', 0.4, 5.0, 2, 2, 2, 2, 2, 3),
('Diggersby', '660', 'Digging', 'With their powerful ears, they can heftboulders of a ton or more with ease.They can be a big help at construction sites.', 1.0, 42.4, 3, 3, 3, 2, 3, 4),
('Fletchling', '661', 'Tiny Robin', 'These friendly Pokémon send signalsto one another with beautiful chirpsand tail-feather movements.', 0.3, 1.7, 2, 3, 2, 2, 2, 3),
('Fletchinder', '662', 'Ember', 'From its beak, it expels embers that setthe tall grass on fire. Then it pounces onthe bewildered prey that pop out of the grass.', 0.7, 16.0, 3, 4, 3, 3, 2, 5),
('Talonflame', '663', 'Scorching', 'In the fever of an exciting battle, itshowers embers from the gaps betweenits feathers and takes to the air.', 1.2, 24.5, 3, 4, 3, 4, 3, 7),
('Scatterbug', '664', 'Scatterdust', 'When under attack from bird Pokémon,it spews a poisonous black powderthat causes paralysis on contact.', 0.3, 2.5, 2, 2, 2, 1, 1, 2),
('Spewpa', '665', 'Scatterdust', 'It lives hidden within thicket shadows.When predators attack, it quickly bristles the furcovering its body in an effort to threaten them.', 0.3, 8.4, 2, 1, 3, 1, 1, 2),
('Vivillon', '666', 'Scale', 'Vivillon with many different patterns arefound all over the world. These patternsare affected by the climate of their habitat.', 1.2, 17.0, 3, 3, 2, 4, 2, 5),
('Litleo', '667', 'Lion Cub', 'The stronger the opponent it faces,the more heat surges from its maneand the more power flows through its body.', 0.6, 13.5, 3, 3, 3, 4, 2, 4),
('Pyroar', '668', 'Royal', 'The male with the largest mane of fireis the leader of the pride.', 1.5, 81.5, 4, 4, 3, 5, 3, 6),
('Flabébé', '669', 'Single Bloom', 'It draws out and controls the hidden powerof flowers. The flower Flabébé holdsis most likely part of its body.', 0.1, 0.1, 2, 2, 2, 3, 3, 2),
('Floette', '670', 'Single Bloom', 'It flutters around fields of flowers and cares forflowers that are starting to wilt. It drawsout the hidden power of flowers to battle.', 0.2, 0.9, 2, 2, 2, 4, 4, 3),
('Florges', '671', 'Garden', 'It claims exquisite flower gardens as its territory,and it obtains power from basking in the energyemitted by flowering plants.', 1.1, 10.0, 3, 3, 3, 5, 6, 4),
('Skiddo', '672', 'Mount', 'Thought to be one of the first Pokémon to live inharmony with humans, it has a placid disposition.', 0.9, 31.0, 3, 3, 2, 3, 2, 3),
('Gogoat', '673', 'Mount', 'It can tell how its Trainer is feeling bysubtle shifts in the grip on its horns.This empathic sense lets them run as if one being.', 1.7, 91.0, 5, 5, 3, 5, 3, 4),
('Pancham', '674', 'Playful', 'It does its best to be taken seriously by its enemies,but its glare is not sufficiently intimidating.Chewing on a leaf is its trademark.', 0.6, 8.0, 3, 4, 3, 2, 2, 2),
('Pangoro', '675', 'Daunting', 'Although it possesses a violent temperament,it won&#39;t put up with bullying. It uses the leaf inits mouth to sense the movements of its enemies.', 2.1, 136.0, 4, 6, 3, 3, 3, 3),
('Furfrou', '676', 'Poodle', 'Trimming its fluffy fur not only makesit more elegant but also increases theswiftness of its movements.', 1.2, 28.0, 3, 4, 3, 3, 4, 5),
('Espurr', '677', 'Restraint', 'The organ that emits its intense psychic power issheltered by its ears to keep power from leaking out.', 0.3, 3.5, 3, 3, 2, 3, 3, 4),
('Meowstic', '678', 'Constraint', 'When in danger, it raises its ears andreleases enough psychic power togrind a 10-ton truck into dust.', 0.6, 8.5, 3, 3, 3, 4, 3, 6),
('Honedge', '679', 'Sword', 'Apparently this Pokémon is born when adeparted spirit inhabits a sword. It attaches itselfto people and drinks their life force.', 0.8, 2.0, 2, 4, 4, 2, 2, 2),
('Doublade', '680', 'Sword', 'When Honedge evolves, it divides into two swords,which cooperate via telepathy to coordinate attacksand slash their enemies to ribbons.', 0.8, 4.5, 3, 6, 6, 2, 2, 2),
('Aegislash', '681', 'Royal Sword', 'Generations of kings were attended by thesePokémon, which used their spectral power tomanipulate and control people and Pokémon.', 1.7, 53.0, 3, 3, 6, 2, 6, 3),
('Spritzee', '682', 'Perfume', 'It emits a scent that enraptures thosewho smell it. This fragrance changesdepending on what it has eaten.', 0.2, 0.5, 3, 3, 3, 3, 3, 1),
('Aromatisse', '683', 'Fragrance', 'It devises various scents, pleasant and unpleasant,and emits scents that its enemies dislike in orderto gain an edge in battle.', 0.8, 15.5, 4, 4, 3, 5, 4, 2),
('Swirlix', '684', 'Cotton Candy', 'To entangle its opponents in battle, it extrudeswhite threads as sweet and sticky as cotton candy.', 0.4, 3.5, 3, 3, 3, 3, 2, 3),
('Slurpuff', '685', 'Meringue', 'It can distinguish the faintest of scents.It puts its sensitive sense of smell to useby helping pastry chefs in their work.', 0.8, 5.0, 3, 4, 4, 4, 3, 4),
('Inkay', '686', 'Revolving', 'Opponents who stare at the flashing of thelight-emitting spots on its body becomedazed and lose their will to fight.', 0.4, 3.5, 2, 3, 2, 2, 2, 3),
('Malamar', '687', 'Overturning', 'It wields the most compelling hypnotic powersof any Pokémon, and it forces others to dowhatever it wants.', 1.5, 47.0, 4, 5, 4, 3, 3, 4),
('Binacle', '688', 'Two-Handed', 'Two Binacle live together on one rock.When they fight, one of them will moveto a different rock.', 0.5, 31.0, 2, 3, 3, 2, 2, 3),
('Barbaracle', '689', 'Collective', 'When they evolve, two Binacle multiply into seven.They fight with the power of seven Binacle.', 1.3, 96.0, 3, 5, 5, 3, 4, 4),
('Skrelp', '690', 'Mock Kelp', 'Camouflaged as rotten kelp, they sprayliquid poison on prey that approachesunawares and then finish it off.', 0.5, 7.3, 2, 3, 3, 3, 3, 2),
('Dragalge', '691', 'Mock Kelp', 'Their poison is strong enough to eat throughthe hull of a tanker, and they spit it indiscriminatelyat anything that enters their territory.', 1.8, 81.5, 3, 4, 4, 5, 5, 3),
('Clauncher', '692', 'Water Gun', 'They knock down flying prey by firingcompressed water from their massiveclaws like shooting a pistol.', 0.5, 8.3, 2, 3, 3, 3, 3, 3),
('Clawitzer', '693', 'Howitzer', 'Their enormous claws launch cannonballs ofwater powerful enough to pierce tanker hulls.', 1.3, 35.3, 3, 4, 4, 6, 4, 3),
('Helioptile', '694', 'Generator', 'They make their home in deserts. They cangenerate their energy from basking in the sun,so eating food is not a requirement.', 0.5, 6.0, 2, 2, 2, 3, 2, 4),
('Heliolisk', '695', 'Generator', 'They flare their frills and generate energy.A single Heliolisk can generate sufficientelectricity to power a skyscraper.', 1.0, 21.0, 3, 3, 2, 5, 4, 6),
('Tyrunt', '696', 'Royal Heir', 'This Pokémon was restored from a fossil.If something happens that it doesn&#39;t like,it throws a tantrum and runs wild.', 0.8, 26.0, 3, 5, 3, 2, 2, 3),
('Tyrantrum', '697', 'Despot', 'Thanks to its gargantuan jaws, which could shredthick metal plates as if they were paper, it wasinvincible in the ancient world it once inhabited.', 2.5, 270.0, 3, 6, 5, 3, 3, 4),
('Amaura', '698', 'Tundra', 'This ancient Pokémon was restoredfrom part of its body that had beenfrozen in ice for over 100 million years.', 1.3, 25.2, 3, 3, 2, 3, 3, 3),
('Aurorus', '699', 'Tundra', 'The diamond-shaped crystals on its bodyexpel air as cold as -240 degrees Fahrenheit,surrounding its enemies and encasing them in ice.', 2.7, 225.0, 5, 4, 3, 5, 4, 3),
('Sylveon', '700', 'Intertwining', 'It sends a soothing aura from itsribbonlike feelers to calm fights.', 1.0, 23.5, 4, 3, 3, 5, 5, 3),
('Hawlucha', '701', 'Wrestling', 'Although its body is small, its proficientfighting skills enable it to keep up withbig bruisers like Machamp and Hariyama.', 0.8, 21.5, 3, 5, 3, 4, 3, 6),
('Dedenne', '702', 'Antenna', 'Its whiskers serve as antennas. By sending andreceiving electrical waves, it can communicatewith others over vast distances.', 0.2, 2.2, 3, 3, 3, 4, 3, 5),
('Carbink', '703', 'Jewel', 'Born from the temperatures and pressuresdeep underground, it fires beams from thestone in its head.', 0.3, 5.7, 2, 3, 6, 2, 6, 3),
('Goomy', '704', 'Soft Tissue', 'The weakest Dragon-type Pokémon,it lives in damp, shady places, so itsbody doesn&#39;t dry out.', 0.3, 2.8, 2, 3, 2, 3, 3, 2),
('Sliggoo', '705', 'Soft Tissue', 'It drives away opponents by excreting asticky liquid that can dissolve anything.Its eyes devolved, so it can&#39;t see anything.', 0.8, 17.5, 3, 4, 2, 4, 5, 3),
('Goodra', '706', 'Dragon', 'This very friendly Dragon-type Pokémonwill hug its beloved Trainer, leavingthat Trainer covered in sticky slime.', 2.0, 150.5, 4, 5, 3, 5, 6, 4),
('Klefki', '707', 'Key Ring', 'These key collectors threaten any attackersby fiercely jingling their keys at them.', 0.2, 3.0, 2, 4, 4, 4, 4, 4),
('Phantump', '708', 'Stump', 'These Pokémon are created whenspirits possess rotten tree stumps.They prefer to live in abandoned forests.', 0.4, 7.0, 2, 4, 2, 2, 3, 2),
('Trevenant', '709', 'Elder Tree', 'It can control trees at will. It will trap peoplewho harm the forest, so they can never leave.', 1.5, 71.0, 3, 6, 3, 3, 3, 3),
('Pumpkaboo', '710', 'Pumpkin', 'The pumpkin body is inhabited by a spirittrapped in this world. As the sun sets,it becomes restless and active.', 0.4, 5.0, 2, 3, 3, 2, 2, 3),
('Gourgeist', '711', 'Pumpkin', 'Singing in eerie voices, they wandertown streets on the night of the new moon.Anyone who hears their song is cursed.', 0.9, 12.5, 3, 5, 5, 3, 3, 5),
('Bergmite', '712', 'Ice Chunk', 'It blocks opponents&#39; attacks with theice that shields its body. It uses cold airto repair any cracks with new ice.', 1.0, 99.5, 2, 4, 4, 2, 2, 2),
('Avalugg', '713', 'Iceberg', 'Its ice-covered body is as hard as steel.Its cumbersome frame crushes anything thatstands in its way.', 2.0, 505.0, 4, 6, 8, 2, 2, 2),
('Noibat', '714', 'Sound Wave', 'They live in pitch-black caves. Their enormous earscan emit ultrasonic waves of 200,000 hertz.', 0.5, 8.0, 2, 2, 2, 2, 2, 3),
('Noivern', '715', 'Sound Wave', 'They fly around on moonless nightsand attack careless prey. Nothing canbeat them in a battle in the dark.', 1.5, 85.0, 3, 4, 4, 5, 3, 7),
('Xerneas', '716', 'Life', 'Legends say it can share eternal life.It slept for a thousand years in the formof a tree before its revival.', 3.0, 215.0, 5, 7, 4, 6, 4, 5),
('Yveltal', '717', 'Destruction', 'When this legendary Pokémon&#39;s wings andtail feathers spread wide and glow red,it absorbs the life force of living creatures.', 5.8, 203.0, 5, 7, 4, 6, 4, 5),
('Zygarde', '718', 'Order', 'When the Kalos region&#39;s ecosystem falls intodisarray, it appears and reveals its secret power.', 5.0, 305.0, 4, 5, 5, 4, 4, 5),
('Diancie', '719', 'Jewel', 'A sudden transformation of Carbink,its pink, glimmering body is said to bethe loveliest sight in the whole world.', 0.7, 8.8, 2, 5, 6, 5, 6, 3),
('Hoopa', '720', 'Mischief', 'In its true form, it possesses a huge amount of power. Legends of its avarice tell how it once carried off an entire castle to gain the treasure hidden within.', 0.5, 9.0, 4, 6, 3, 6, 5, 4);


--01 Selecione todas as colunas.
	SELECT nome, codigo, categoria, descricao, altura, peso, hp, ataque, defesa, especial_ataque, especial_defesa, velocidade
		FROM pokemons;

--02 Selecione o ataque, ataque especial, defesa e defesa especial.
	SELECT ataque, especial_ataque, defesa, especial_defesa	
		FROM pokemons;

--03 Selecione nome, categoria e ataque ordenado pelo ataque em ordem crescente.
	SELECT nome, categoria, ataque
		FROM pokemons
		ORDER BY ataque ASC;

--04 Selecione altura, peso, com o cálculo do imc.
	ALTER TABLE pokemons ADD imc FLOAT;

	UPDATE pokemons SET imc = (peso / (altura * altura));

	SELECT imc FROM pokemons;

--05 Selecione altura, peso, com o cálculo do imc ordenando o imc em ordem decrescente.
	SELECT altura, peso, imc	
		FROM pokemons
		ORDER BY imc DESC;

--06 Selecione nome e o tamanho do nome em ordem decrescente pelo nome.
	SELECT nome,
		LEN(nome) AS 'Quantidade de caracteres'
		FROM pokemons
		ORDER BY LEN(nome) DESC;
		
--07 Selecione nome, descrição, quando o nome contiver mais que 10 caracteres.
	SELECT nome, descricao
		FROM pokemons
		WHERE
		LEN(nome) > 10;

--08 Selecione nome, categoria, e ataque do pokemon que contém o menor valor de ataque.
	SELECT nome, categoria, ataque
		FROM pokemons
		WHERE ataque = (SELECT MIN(p.ataque) FROM pokemons p);

--09 Selecione o ataque, ataque especial, nome, defesa e defesa especial ordenando pelo ataque.
	SELECT ataque, especial_ataque, defesa, especial_defesa
		FROM pokemons
		ORDER BY ataque DESC;

--10 Selecione a média dos ataques.
	SELECT AVG (ataque) FROM pokemons;

--11 Selecione a somatória dos ataques.
	SELECT SUM (ataque) FROM pokemons;

--12 Selecione a média dos ataques especiais quando o nome do pokemon começar com ‘P’.
	SELECT AVG (especial_ataque), nome
		FROM pokemons
		WHERE nome LIKE 'P%';
		


--13 código estiver no intervalo de 50 a 100 - categoria - Seed
	UPDATE pokemons SET categoria = 'Seed'
		WHERE codigo >= 50 AND
		codigo <= 100;

--14 nome conter ‘inj’ - ataque - 29
	UPDATE pokemons SET ataque = 29
		WHERE 
		nome LIKE '%inj%';

--15 velocidade for 5 - velocidade - 2
	UPDATE pokemons SET velocidade = 2
		WHERE velocidade = 5;
		
--16 código for 100 - categoria - Manipulate
	UPDATE pokemons SET categoria = 'Manipulante'
		WHERE codigo = 100;

--17 nome começar com R - nome - trocar primeira letra por C
	UPDATE pokemons SET nome = 'C%'
		WHERE nome LIKE 'R%';

--18 altura for 0.5 - altura - 0.51
	UPDATE pokemons SET altura = 0.51
		WHERE altura = 0.5;

--19 peso - 0.70
	UPDATE pokemons SET peso = 0.70
		WHERE altura = 0.51;

--20 defesa especial for 3 e ataque especial for 4 - código - 1
	UPDATE pokemons SET codigo = 1
		WHERE 
		especial_ataque = 4 AND 
		especial_defesa = 3;

--21 defesa - 1
	UPDATE pokemons SET defesa = 1
		WHERE
		especial_ataque = 4 AND
		especial_defesa = 3;

--22 ataque - 1
	UPDATE pokemons SET ataque = 1
		WHERE
		especial_ataque = 4 AND
		especial_defesa = 3;

--23 ataque especial - 3
	UPDATE pokemons SET especial_ataque = 3
		WHERE 
		especial_ataque = 4 AND
		especial_defesa = 3;

--24 defesa especial - 4
	UPDATE pokemons SET especial_defesa = 4
		WHERE
		especial_ataque = 3 AND
		especial_defesa = 3;

--25 nome contiver mais 10 caracteres nome obter somente os dez caracteres do nome
	UPDATE pokemons SET nome = CONCAT(SUBSTRING(nome, 0, 10), '...')
		WHERE LEN(nome) = 10; 

--26 descrição contiver flames categoria water
	UPDATE pokemons SET categoria = 'Water'
		WHERE 
		descricao LIKE '%Flames%';

--27 código - 151
	UPDATE pokemons SET codigo = 151
		WHERE codigo = 155;

--28nome for Kabuto - nome - Naruto
	UPDATE pokemons SET nome = 'Naruto'
		WHERE nome = 'Kabuto';

--29 ataque - 1
	UPDATE pokemons SET ataque = 1
		WHERE nome = 'Kabuto';

--30 nome for Mew ou nome for Mewtwo - nome - Sasuke
	UPDATE pokemons SET nome = 'Sasuke',
		especial_ataque = 8002,
		ataque = 8001
		WHERE 
		nome = 'Mew' OR nome = 'Mewtwo';

--31 código que for número par descrição Lorem ipsum.
--nome - Tyranitar
--categoria - Wood Gecko
	--UPDATE pokemons SET descricao = 'Lorem ipsum',
	--	nome = 'Tyranitar',
	--	categoria = 'Wood Gecko'
	--	WHERE
	--	codigo = 0 % 2;


--32 Apagar o(s) pokemon(s) que a categoria seja ‘Seed’.
	DELETE FROM pokemons
		WHERE
		categoria = 'Seed';

--33 Apagar o(s) pokemon(s) que o nome comece com ‘Nid’.
	DELETE FROM pokemons
		WHERE
		nome LIKE 'Nid%';

--34 Apagar o(s) pokemon(s) que a categoria comece com ‘Snow ’.
	DELETE FROM pokemons
		WHERE
		categoria LIKE 'Snow%';

--35 Apagar o(s) pokemon(s) que o ataque seja 2 ou a defesa seja 1.
	DELETE FROM pokemons
		WHERE
		ataque = 2 OR
		defesa = 1;

--36 Apagar o(s) pokemon(s) que o ataque especial seja um número par.
	DELETE FROM pokemons
		WHERE 
		(especial_ataque % 2) = 0;

--37 Apagar o(s) pokemon(s) que o nome contenha dez caracteres.
	DELETE FROM pokemons
		WHERE
		LEN(nome) = 10;

--38 Apagar o(s) pokemon(s) que a categoria contenha menos que 4 caracteres.
	DELETE FROM pokemons	
		WHERE
		LEN(categoria) < 4;

--39 Apagar o(s) pokemon(s) que a velocidade seja um número ímpar.
	DELETE FROM pokemons		
		WHERE
		(velocidade % 2) = 1;

--40 Apagar o(s) pokemon(s) que o nome comece com ‘Uno’ ou ‘Charm’.
	DELETE FROM pokemons
		WHERE
		nome LIKE 'Uno%' OR
		nome LIKE 'Charm%';

--41 Apagar o(s) pokemon(s) que contenham a categoria ‘Flower’ e o código esteja entre 45 e 200.
	DELETE FROM pokemons
		WHERE
		categoria = 'Flower' AND
		codigo >= 45 AND
		codigo < 201;

--42 Apagar o(s) pokemon(s) que a descrição contenha ‘shell’.
	DELETE FROM pokemons
		WHERE
		descricao LIKE '%shell%';

--43 Apagar o(s) pokemon(s) que o peso seja maior ou igual a 100.
	DELETE FROM pokemons
		WHERE
		peso >= 100; 

--44 Apagar o(s) pokemon(s) que a altura seja menor que 1.
	DELETE FROM pokemons
		WHERE
		altura < 1;

--45 Apagar o(s) pokemon(s) que contenham o poder de defesa especial maior que 3.
	DELETE FROM pokemons
		WHERE
		especial_defesa > 3;

--46 Apagar o(s) pokemon(s) que a descrição contenha mais que 150 caracteres.
	--DELETE FROM pokemons
	--	WHERE
	--	LEN(descricao) > 150;

--47 Apagar o(s) pokemon(s) que a descrição contenha ‘good’ em qualquer parte.
	DELETE FROM pokemons 
		WHERE
		descricao LIKE '%good%';
		

--48 Apagar o(s) pokemon(s) que o código seja um número par.
	DELETE FROM pokemons
		WHERE
		(codigo % 2) = 0;

--49 Apagar o(s) pokemon(s) que o nome seja ‘Lileep’.
	DELETE FROM pokemons
		WHERE
		nome = 'Lileep';

		SELECT nome 
			FROM pokemons
			WHERE nome = 'Lileep';

--50 Apagar o(s) pokemon(s) que contenham o poder de ataque especial 5.
	DELETE FROM pokemons
		WHERE
		especial_ataque = 5;

--51 Apagar o(s) pokemon(s) que a código seja menor que 100.
	DELETE FROM pokemons
		WHERE
		codigo < 100;