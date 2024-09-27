namespace EquipmentRequest.Models {
    public static class Repository {
        
        private static int _nextId = 1;
        private static List<UserRequest> requests = new();
        private static List<AvailableEquipment> allEquipment = new(); // Changed from availableEquipment to allEquipment

        // Expose requests and equipment lists as IEnumerable
        public static IEnumerable<UserRequest> Requests => requests;
        public static IEnumerable<AvailableEquipment> AllEquipment => allEquipment;

        // Static constructor to initialize predefined data
        static Repository() {
            // Initialize predefined equipment in AllEquipment
            allEquipment.Add(new AvailableEquipment { EquipmentID = 1, Type = "Laptop", Description = "Dell XPS 13", Availability = "Yes" });
            allEquipment.Add(new AvailableEquipment { EquipmentID = 2, Type = "Phone", Description = "Samsung S3", Availability = "No" });
            allEquipment.Add(new AvailableEquipment { EquipmentID = 3, Type = "Tablet", Description = "Ipad", Availability = "Yes" });
        }

        // Method to add user requests
        public static void AddRequests(UserRequest request) {
            request.ID = _nextId++;
            requests.Add(request);
        }

        // Method to add equipment
        public static void AddEquipment(AvailableEquipment equipment) {
            allEquipment.Add(equipment);
        }
    }
}
