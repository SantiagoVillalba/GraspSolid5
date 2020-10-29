namespace Full_GRASP_And_SOLID
{
    public interface IRecipe
    {
        // Creamos la interfaz IRecipe para que la clase ConsolePrinter y FilePrinter
        // Dependan de una abstraccion y no de una clase baja como indica el
        // el principio de inversion de dependencias (DIP).
        // Tambien el codigo se hace extensible ya que tener una abstraccion
        // IRecipe permite extender nuestro programa a varios tipos de recetas
        // y no depender de una clase baja en particular.
        string GetTextToPrint();
    }
}