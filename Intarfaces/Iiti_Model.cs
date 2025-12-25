using System.Data;

namespace Intarfaces
{
    public interface Iiti_Model
    {
        string ConnectionString { get; set; }
        public DataTable ExecuteDisConnectedQuery(string commend);

       bool ExecuteManioulationcommend(string commend);
    }
}
