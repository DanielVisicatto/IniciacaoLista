using IniciacaoLista.Entities;

ListItem list = new();

Item item = new(21);

//list.ToInsert(item);
list.ToPrint();

list.ToInsert(item);
list.ToInsert(new Item(23));
list.ToInsert(new Item(53));
list.ToInsert(new Item(223));
list.ToInsert(new Item(3));

list.ToPrint();

/*
No método InsertLast, o erro estva na linha End.Next = End;, onde ele está fazendo 
End.Next apontar para ele mesmo. Isso cria um loop infinito e faz com que a lista nunca 
termine. Em vez disso, você devemos atualizar o Next do antigo End para apontar para o
novo i, e então atualizar o End para o novo i. 
Existem estruturas de dados prontas para uso que incluem métodos de inserção, remoção e
busca, como as Listas Ligadas (LinkedList) ou Listas Duplamente Ligadas 
(DoublyLinkedList). Porém é importante entender como essas estruturas funcionam 
internamente e como implementá-las, pois isso ajuda a entender melhor o funcionamento da
linguagem e a criar soluções personalizadas e otimizadas para problemas específicos.
*/
