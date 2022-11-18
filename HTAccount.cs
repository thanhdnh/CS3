using System.Collections;
class HTAccount
{
  Hashtable infos = new Hashtable();
  public HTAccount(string id, string username, string password, string status)
  {
    infos["id"] = id;
    infos["username"] = username;
    infos.Add("password", password);
    infos.Add("status", status);
  }
  public override string ToString()
  {
    return $"Account[id: {infos["id"]}, username: {infos["username"]}, password: {infos["password"]}, status: {infos["status"]}]";
  }
}