
namespace QuickSort
{
    class QuickSort
    {

        //declaramos un arreglo de enteros

      //  private int[] vector;
        public producto[] vector;
        public QuickSort(){}
        public void ordenarVector(producto[] vector, int primero, int ultimo)
        {
                int i,j, central;
                int pivote;
                central =(primero +ultimo)/2;//identificamos el elemento central del arreglo
                pivote = vector[central].IdProducto;
                i = primero;
                j = ultimo;
                do
                {
                    while (vector[i].IdProducto < pivote) i++;

                    while (vector[j].IdProducto > pivote) j--;
                    if (i <= j)
                    {
                        producto temp;
                        temp =vector[i];
                        vector[i]=vector[j];
                        vector[j]=temp;
                        i++;
                        j--;
                    } 

                } while (i <= j);

                if (primero < j) ordenarVector(vector, primero, j);

                if (i < ultimo) ordenarVector(vector, i, ultimo);
               

                this.vector = vector;

        }

        public producto[] devolverVector()
        {
            return vector;
        }
    }
}
