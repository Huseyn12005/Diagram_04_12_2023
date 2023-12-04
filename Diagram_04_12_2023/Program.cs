namespace Diagram_04_12_2023
{
    public interface DataSource
    {
        public void writeData(string data);
        public void readData();

    }

    public class FileDataSource : DataSource
    {
        private string filename;
        public string data;

        public FileDataSource(string filename_)
        {
            filename = filename_;
        }
        public void  readData()
        {
            //readData
        }

        public void writeData(string data)
        {
            //writeData
        }
    }

    public class DataSourceDecorator : DataSource
    {
        private DataSource wrappee;
        public string data;

        public DataSourceDecorator(DataSource wrappee_)
        {
            wrappee = wrappee_;
        }

        public void readData()
        {
            //readData
        }

        public void writeData(string data)
        {
            //writeData
        }

    }

    public class EncrypyionDecorator : DataSourceDecorator
    {
        public string data;
        public EncrypyionDecorator(DataSource wrappee_):base(wrappee_)
        {
            
        }

        public new void writeData(string data)
        {
            //writeData
        }

        public new void readData()
        {
            //readData
        }
    }

    public class CompressionDecorator : DataSourceDecorator
    {
        public string data;
        public CompressionDecorator(DataSource wrappee_) : base(wrappee_)
        {

        }

        public new void writeData(string data)
        {
            //writeData
        }

        public new void readData()
        {
            //readData
        }
    }
}