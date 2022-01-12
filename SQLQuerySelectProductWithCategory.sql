-- Установить базу данных storedb в качестве текущей
USE storedb;

-- Создание таблицы продуктов
CREATE TABLE Products
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(30)
)

-- Создание таблицы категорий
CREATE TABLE Categories
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(30)
)

-- Создание таблицы соответветсвия продукта и категории
CREATE TABLE Marketplace
(
	id INT IDENTITY PRIMARY KEY,
	product_id INT,
	category_id INT,

	FOREIGN KEY (product_id) REFERENCES Products (id) ON DELETE CASCADE,
	FOREIGN KEY (category_id) REFERENCES Categories (id) ON DELETE CASCADE
)

-- Добавление продуктов
INSERT Products VALUES ('Milk')
INSERT Products VALUES ('Yogurt')
INSERT Products VALUES ('Cauliflower')
INSERT Products VALUES ('Onion')
INSERT Products VALUES ('Tomato')
INSERT Products VALUES ('Apple')
INSERT Products VALUES ('Apricot')
INSERT Products VALUES ('Cherry')
INSERT Products VALUES ('Mango')
INSERT Products VALUES ('Beef')
INSERT Products VALUES ('Pork')
INSERT Products VALUES ('Mutton')
INSERT Products VALUES ('Hazelnut')
INSERT Products VALUES ('Peanut')

-- Добавление категорий
INSERT Categories VALUES ('Milk products')
INSERT Categories VALUES ('Vegetables')
INSERT Categories VALUES ('Fruits')
INSERT Categories VALUES ('Meat')

-- Добавление продуктов и категорий (продукт соотносится с соответствующей категорией)
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Milk' AND c.name = 'Milk products';
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Yogurt' AND c.name = 'Milk products';
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Cauliflower' AND c.name = 'Vegetables';
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Onion' AND c.name = 'Vegetables';
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Tomato' AND c.name = 'Vegetables';
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Apple' AND c.name = 'Fruits';
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Apricot' AND c.name = 'Fruits';
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Cherry' AND c.name = 'Fruits';
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Mango' AND c.name = 'Fruits';
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Beef' AND c.name = 'Meat';
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Pork' AND c.name = 'Meat';
INSERT Marketplace (product_id, category_id)
SELECT p.id, c.id FROM Products p, Categories c WHERE p.name = 'Mutton' AND c.name = 'Meat';

-- Запрос для выбора всех пар "Имя продукта - Имя категории"
SELECT (p.name + ' - ' + CASE WHEN c.name IS NULL THEN 'NULL' ELSE c.name END) AS res FROM Products p
LEFT JOIN Marketplace m ON m.product_id = p.id
LEFT JOIN Categories c ON c.id = m.category_id
