public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public T? Data { get; set; }  // Properti ini diubah menjadi tipe nullable

    public ApiResponse(bool success, string message, T? data)
    {
        Success = success;
        Message = message;
        Data = data;
    }
}
/*
disini api response untuk mengidentifikasi berhasil atau tidak nya saat penggunaan web api
dengan keterangan status, pesan, dan datanya, bisa di lihat pada body postman
*/
// ketika open terminal dotnet run akan listening localhost dan port nya 