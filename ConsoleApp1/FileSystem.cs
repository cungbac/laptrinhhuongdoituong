using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTruong
{
    public abstract class FileSystem
    {
        public string Name {  get; set; }
        public abstract long GetSize();
    }

    public class Files : FileSystem
    {
        public long Length { get; set;}
        public Files(string name, long length)
        {
            Name = name;
            Length = length;
        }
        public override long GetSize()
        {
            return Length;
        }
    }

    public class Folder : FileSystem
    {
        private List<FileSystem> _childs;
        public Folder (string name)
        {
            Name = name;
            _childs = new List<FileSystem>();
        }
        public void Add(FileSystem child)
        {
            _childs.Add(child);
        }
        public void Remove(FileSystem child)
        {
            _childs.Remove(child);
        }
        public override long GetSize()
        {
            long total = 0;
            foreach (FileSystem child in _childs)
            {
                total += child.GetSize();
            }
            return total;
        }
    }
}
