
namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
        /* Modificamos esta interfaz cambiando el tipo Recipe de recipe por IRecipe para
        poder aplicar el principio de inversion de dependencias (DIP). IPrinter depende de una
        abstraccion IRecipe, asi abstrayendose de la clase Recipe. Al depender de una abstraccion 
        el programa se hace mas movible y deja de ser fragil a los cambios dentro de los que
        implementa el tipo, ademas deja de ser rigido porque hace al diseño mas facil de cambiar.
        */
         void PrintRecipe(IRecipe recipe);
    }
}