namespace EquipmentRequest.Models {
    public static class Repository {

        private static int _nextId = 1;
        private static List<UserRequest> requests = new();
        public static IEnumerable<UserRequest> Requests => requests;
        public static void AddRequests(UserRequest request) {
            Console.WriteLine(request);
            request.ID = _nextId++;
            requests.Add(request);
        }
    }
}