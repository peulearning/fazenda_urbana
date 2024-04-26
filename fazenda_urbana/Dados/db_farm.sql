-- Primeiramente Criando o Banco de Dados Chamado Fazenda Urbana -- 
CREATE SCHEMA `fazenda_urbana`;
-- Utilizando o banco de dados para válidar as informaçõe a seguir -- 
USE fazenda_urbana;
-- Criando a tabela "CATEGORIA" --
CREATE TABLE Categoria (
    Id_Categoria INT AUTO_INCREMENT PRIMARY KEY,
    desc_categoria VARCHAR(255)
);
-- Criando a tabela "Produtos" --
CREATE TABLE Produtos (
    id_produto INT AUTO_INCREMENT PRIMARY KEY,
    desc_produto VARCHAR(255),
    valor DECIMAL(5,2),
    Id_categoria INT,
    FOREIGN KEY (Id_categoria) REFERENCES Categoria(Id_Categoria)
);
-- Criando a tabela "Pessoas" --
CREATE TABLE Pessoas (
    id INT PRIMARY KEY AUTO_INCREMENT,
    cpf VARCHAR(14),
    cnpj VARCHAR(18),
    nome VARCHAR(100) NOT NULL,
    telefone VARCHAR(20),
    email VARCHAR(100),
    cargo VARCHAR(50)
);
-- Criando a tabela "Vendas" --
CREATE TABLE Vendas (
    id_venda INT AUTO_INCREMENT PRIMARY KEY,
    id_produto INT,
    cliente_id INT,
    cliente_tipo ENUM('CPF', 'CNPJ'),
    quantidade INT,
    data_venda DATE,
    FOREIGN KEY (id_produto) REFERENCES Produtos(id_produto),
    FOREIGN KEY (cliente_id) REFERENCES Pessoas(id)
);
-- Populando a tabela Categorias --
INSERT INTO categoria (Id_Categoria, desc_categoria) VALUES 
(1, "Orgânico"),
(2, "Ervas"),
(3, "Hortaliças"),
(4, "Verduras"),
(5, "Lactícinios");
-- Populando a tabela Produtos --
INSERT INTO Produtos (desc_produto, valor, Id_categoria) VALUES 
('Maçã', 2.50, 1), 
('Banana', 3.00, 1),
('Alface', 1.80, 2),
('Cenoura', 2.00, 2),
('Manjericão', 1.50, 3),
('Salsa', 1.20, 3),
('Arroz', 5.50, 4),
('Feijão', 4.80, 4),
('Leite', 3.00, 5),
('Queijo', 6.50, 5);
-- Populando a tabela de Pessoas --
INSERT INTO Pessoas (cpf, cnpj, nome, telefone, email, cargo, endereco) VALUES 
(NULL, '99.999.999/0001-99', 'Empresa A', '(00) 1234-5678', 'empresa_a@example.com', 'Diretor'),
('123.456.789-10', NULL, 'João da Silva', '(00) 1234-5678', 'joao@example.com', 'Gerente'),
(NULL, '98.765.432/0001-11', 'Empresa B', '(00) 8765-4321', 'empresa_b@example.com', 'Vendedor'),
('987.654.321-98', NULL, 'Maria Oliveira', '(00) 8765-4321', 'maria@example.com', 'Vendedor'),
('111.222.333-44', NULL, 'José Santos', '(00) 5555-5555', 'jose@example.com', 'Atendente'),
('555.666.777-88', NULL, 'Ana Souza', '(00) 9999-9999', 'ana@example.com', 'Estoquista'),
('222.333.444-55', NULL, 'Pedro Almeida', '(00) 3333-3333', 'pedro@example.com', 'Contador', 'Rua das Pedras, 888'),
(NULL, '97.654.321/0001-12', 'Empresa C', '(00) 9876-5432', 'empresa_c@example.com', 'Assistente', 'Av. das Árvores, 456'),
('333.444.555-66', NULL, 'Carla Lima', '(00) 4444-4444', 'carla@example.com', 'Analista de Marketing', 'Rua das Flores, 123'),
('444.555.666-77', NULL, 'Fernando Santos', '(00) 5678-9876', 'fernando@example.com', 'Desenvolvedor', 'Av. dos Estados, 987');

-- Populando a tabela de Vendas com referência ao CPF ou CNPJ da pessoa --
-- Populando a tabela de Vendas --
INSERT INTO Vendas (id_produto, cliente_id, cliente_tipo, quantidade, data_venda) VALUES 
(1, 1, 'CPF', 5, '2024-04-01'), 
(2, 2, 'CPF', 10, '2024-04-02'), 
(3, 3, 'CNPJ', 8, '2024-04-03'), 
(4, 4, 'CNPJ', 12, '2024-04-04'),
(5, 5, 'CPF', 3, '2024-04-05'), 
(6, 6, 'CPF', 7, '2024-04-06'), 
(7, 7, 'CNPJ', 6, '2024-04-07'), 
(8, 8, 'CNPJ', 9, '2024-04-08');


 -- Produto 1 vendido para cliente com ID 1 (CPF) em 01 de abril de 2024
 -- Produto 2 vendido para cliente com ID 2 (CPF) em 02 de abril de 2024
 -- Produto 3 vendido para cliente com ID 3 (CNPJ) em 03 de abril de 2024
-- Produto 4 vendido para cliente com ID 4 (CNPJ) em 04 de abril de 2024
-- 10 Maçãs vendidas por João da Silva em 01 de abril de 2024
-- 15 Bananas vendidas por Maria Oliveira em 03 de abril de 2024
-- 5 Alfaces vendidas por José Santos em 05 de abril de 2024
-- 8 Cenouras vendidas por Ana Souza em 07 de abril de 2024
-- 12 Manjericões vendidos por Pedro Almeida em 09 de abril de 2024
-- 20 Salsas vendidas por Empresa C em 11 de abril de 2024
-- 25 Arrozes vendidos por Carla Lima em 13 de abril de 2024
-- 18 Feijões vendidos por Fernando Santos em 15 de abril de 2024
 -- 30 Leites vendidos por Empresa A em 17 de abril de 2024
 -- 22 Queijos vendidos por Empresa B em 19 de abril de 2024
  
-- Pesquisa Rápida
select * from categoria;
select * from produtos;
select * from pessoas;
select * from vendas;
