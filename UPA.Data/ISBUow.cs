using SewingBird.Model;


namespace SewingBird.Data
{
    
    public interface ISBUow
    {
        
        void Commit();

        IRepository<FirstTable> FirstTable { get; }
      
    }
}