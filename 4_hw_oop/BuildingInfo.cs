using System;

namespace Building
{
    public class BuildingInfo
    {
        private static int buildingNumber; //id
        private int buildingHeight; //meters
        private int floorQuantity; //floors
        private int flatQuantity; //flats
        private int hallQuantity; //halls

        internal protected int inc(ref int num)
        {
            return ++num;
        }

        public BuildingInfo()
        {
            buildingNumber = inc(ref buildingNumber);//newnumber;
        }

        public BuildingInfo(int buildingHeight, int floorQuantity, int flatQuantity, int hallQuantity) : this()
        {
            this.buildingHeight = buildingHeight;
            this.floorQuantity = floorQuantity;
            this.flatQuantity = flatQuantity;
            this.hallQuantity = hallQuantity;
        }

        public float getFloorHeight(int buildingHeight, int floorQuantity)
        {
            float floorHeigth = (float)(buildingHeight / (floorQuantity + 0.5*floorQuantity)); //0.5 толщина перекрытия и крыши
            return floorHeigth;
        }

        public int getFlatsOnFloor(int flatQuantity, int floorQuantity, int hallQuantuty)
        {
            int flatsOnFloor = (flatQuantity / (floorQuantity - 1)) / hallQuantity;//первый не жилой
            return flatsOnFloor;
        }

        public int getFlatsInHall(int flatsQuantity, int hallQuantity)
        {
            int flatsInHall = flatsQuantity / hallQuantity;
            return flatsInHall;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Номер здания: {buildingNumber}  Высота в метрах: {this.buildingHeight} Количество этажей: {this.floorQuantity} Количество подъездов: {hallQuantity} Количество квартир {flatQuantity}");
            Console.WriteLine($"Высота квартиры в метрах: {getFloorHeight(buildingHeight, floorQuantity)} Количество квартир на этаже: {getFlatsOnFloor(flatQuantity, floorQuantity, hallQuantity)} Количество квартир в подъезде: {getFlatsInHall(flatQuantity, hallQuantity)}");
        }
    }

}
