static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idEmployee = id == null ? "" : $"[{id}] - ";
        string departmentEmployee = department == null
            ? "OWNER"
            : department.ToUpper();

        return $"{idEmployee}{name} - {departmentEmployee}";
    }
}
