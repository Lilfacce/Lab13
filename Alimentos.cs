namespace Lab13
{
    public class Alimentos : General
    {
        public int F_Vencimiento {  get; set; }
        public string Medida {  get; set; }
        public Alimentos()
        {
            Medida = string.Empty;
        }

    }
}
