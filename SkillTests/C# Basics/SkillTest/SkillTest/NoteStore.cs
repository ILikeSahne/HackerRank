using SkillTest;

EmployeesManagement.Main();

public class NotesStore
{
    private readonly Dictionary<string, List<string>> _states;

    public NotesStore()
    {
        _states = new Dictionary<string, List<string>>
        {
            { "completed", new List<string>() },
            { "active", new List<string>() },
            { "others", new List<string>() }
        };
    }
    
    public void AddNote(string state, string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Name cannot be empty");
        if (!_states.ContainsKey(state))
            throw new ArgumentException($"Invalid state {state}");

        _states[state].Add(name);
    }

    public List<string> GetNotes(string state)
    {
        if (!_states.ContainsKey(state))
            throw new ArgumentException($"Invalid state {state}");

        return _states[state];
    }
}