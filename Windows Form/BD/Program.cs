/*Modelagem Lógica do Sistema de Vendas

Cliente(codCliente, nome, rua, numero, complemento, cep, cidade, estado, fone)

Vendedor(codVendedor, nome, fone, senha)

Prateleira(codPrateleira, localizacao)

Produto(codProduto, codigoBarras, descricao, codPrateleira)
    codPrateleira referencia Prateleira

Venda(dataNotafiscal, numeroNotaFiscal, codProduto, codVendedor, codCliente)
    codProduto referencia Produto
    codVendedor referencia Vendedor
    codCliente referencia Cliente


Entidade = classe
Atributo/Coluna se for uma chave estrangeira, no diagrama fica subentendido
Relacionamento indica quem visita quem (chave primária visita outra entidade  
                                        como chave estrangeira)
    - Uma chave estrangeira deve ser uma chave primária na sua entidade/classe
    de origem
Cardinalidade: mostra como se dará a visita (quem terá a chave estrangeira)
/*


