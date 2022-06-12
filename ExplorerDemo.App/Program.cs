namespace ExplorerDemo.App
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var disks = DriveInfo.GetDrives();
            foreach (var disk in disks)
            {
                Console.Write($"{disk.Name} {disk.VolumeLabel}, ");
                Console.Write($"{disk.DriveFormat}, {disk.DriveType}, ");
                Console.WriteLine($"{disk.TotalSize} - {disk.TotalFreeSpace}");

                var root = disk.RootDirectory;
                foreach (var directory in root.GetDirectories())
                {
                    Console.WriteLine($"{directory.Name}, {directory.CreationTimeUtc:g}");
                }
            }
        }
    }
}