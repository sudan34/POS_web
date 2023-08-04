namespace POS_web.Services
{
    public interface IRepository
    {
        string GeneratePONumber();
        string GenerateGRNumber();
        string GenerateSONumber();
        string GenerateInvenTranNumber();
    }
}
