namespace IniciacaoLista.Entities
{
    internal class ListItem
    {
        //Os caras que controlam a lista tem q ser do tipo item
        public Item Begin { get; set; }
        public Item End { get; set; }

        public ListItem()
        {
            Begin = null;
            End = null;
        }
        public void ToInsert(Item i)
        {
            if (IsEmpty())
            {
                Begin = i;
                End = i;
            }
            else if (i.Value < Begin.Value)
            {
                //ToFind(i);                
                InsertFirst(i);
            }
            else if (i.Value > End.Value)
            {

                InsertLast(i);
            }
            else
            {
                InsertMiddle(i);
            }


        }

        public void InsertFirst(Item i)
        {
            i.Next = Begin;
            Begin = i;
        }
        public void InsertLast(Item i)
        {
            if (IsEmpty())
            {
                Begin = i;
                End = i;
            }
            else
            {
                End.Next = i;
                End = i;
            }
        }
        public void InsertMiddle(Item i)
        {
            /*
             Criados dois ponteiros apontando para os dois primeiros nós da lista 
            respectivamente.
            Muda-se o ponteiro para apontar para o nó atual e o segundo ponteiro apotando
            para o próximo.
            O i é inserido após o nó A atualizando os links o B é atualizado e o Next do
            Nó proximo ao inseido é definido como novo item.
            */
            Item ponteiroA = Begin; // salvando o começo da lista
            Item ponteiroB = Begin.Next; // salvando o proximo item

            while (ponteiroB != null && i.Value >= ponteiroB.Value)
            {
                ponteiroA = ponteiroB;
                ponteiroB = ponteiroB.Next;
            }
            i.Next = ponteiroB;
            ponteiroA.Next = i;
        }

        public Item ToFind(int f)
        {
            Item aux = Begin;
            while (aux != null)
            {
                if (aux.Value == f)
                {
                    return aux;
                }
                aux = aux.Next;
            }
            return null;
        }

        public bool IsEmpty()
        {
            return Begin == null && End == null;
        }

        public void ToPrint()
        {
            Item aux = Begin;
            while (aux != null)
            {
                Console.Write($"{aux.Value}");
                if (aux.Next != null)
                {
                    Console.Write(", ");
                }
                aux = aux.Next;
            }
            Console.WriteLine();
        }

    }
}
