using MongoDB.Bson;
using MongoDB.Driver;
using System.Reflection.Metadata.Ecma335;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MongoDB_Lesson_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* readonly MongoClient dbClient = new("mongodb+srv://salih:1234@salih.9nr1q92.mongodb.net/?retryWrites=true&w=majority");
         string DBName = "SalihDB";
         string CollectionName = "SalihCol";*/

        readonly MongoClient dbClient = new("mongodb+srv://admin:Shelter2023.admin@sheltercluster.8ounr2h.mongodb.net/?retryWrites=true&w=majority");
        string DBName = "TestDB";
        string CollectionName = "TestCol";
        int newid = 0;
        List<string> IDList = new List<string>();




        private void deleteBT_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(idTB.Text);
            IMongoDatabase db = dbClient.GetDatabase(DBName);
            var builder = Builders<BsonDocument>.Filter;
            var col = db.GetCollection<BsonDocument>(CollectionName);
            var filter = builder.Eq("ID", id);
            DialogResult diaresult = MessageBox.Show("Silmek istediğinizden eminmisiniz", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaresult == DialogResult.Yes)
            {
                col.DeleteOne(filter);
            }

            fillIDListBox();
        }

        private void updateBT_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(idTB.Text);
            IMongoDatabase db = dbClient.GetDatabase(DBName);
            var builder = Builders<BsonDocument>.Filter;
            var col = db.GetCollection<BsonDocument>(CollectionName);
            var filter = builder.Eq("ID", id);
            var update = Builders<BsonDocument>.Update.Set("Text", updateTB.Text);

            DialogResult diaresult = MessageBox.Show("Güncellemek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaresult == DialogResult.Yes)
            {
                col.UpdateOne(filter, update);
            }

            updateTB.Text = String.Empty;
            fillIDListBox();
        }

        private void readBT_Click(object sender, EventArgs e)
        {


            var id = Convert.ToInt32(idTB.Text);
            IMongoDatabase db = dbClient.GetDatabase(DBName);
            var builder = Builders<BsonDocument>.Filter;
            var col = db.GetCollection<BsonDocument>(CollectionName);
            var filter = builder.Eq("ID", id);

            var docs = col.Find(filter).ToList();
            try
            {
                var lastelement = docs.Last();

                readTB.Text = lastelement[2].ToString();
            }catch(Exception ex) { MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                readTB.Text = "";
            }
           
            fillIDListBox();


        }

        private void insertBT_Click(object sender, EventArgs e)
        {
            IMongoDatabase db = dbClient.GetDatabase(DBName);
            
            var col = db.GetCollection<BsonDocument>(CollectionName);
            var element = new BsonDocument
              {
              {"ID",  newid},
              {"Text", insertTB.Text }
               };
            col.InsertOne(element);
            insertTB.Text = String.Empty;
            fillIDListBox();
        }

        public void fillIDListBox()
        {
            IDList.Clear();
            IDListBox.Items.Clear();
            IMongoDatabase db = dbClient.GetDatabase(DBName);
            var col = db.GetCollection<BsonDocument>(CollectionName);

            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Empty;

            var docs = col.Find(filter).ToList();

            docs.ForEach(doc =>
            {
                IDList.Add(doc[1].ToString());

                IDListBox.Items.Add(doc[1].ToString());
            });
            newid = Convert.ToInt32(IDList[IDList.Count - 1])+1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillIDListBox();
        }
    }
}