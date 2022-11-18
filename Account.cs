class Account
{
  string id;
  string username;
  string password;
  string status;
  public Account(string id, string username, string password, string status)
  {
    this.id = id;
    this.username = username;
    this.password = password;
    this.status = status;
  }
  public override string ToString()
  {
    return $"Account(id: {id}, username: {username}, password: {password}, status: {status})";
  }
  public string getId(){
    return this.id;
  }
}