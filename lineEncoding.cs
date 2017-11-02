string lineEncoding(string s) {
    s+="#";
int tam=1;
    StringBuilder res=new StringBuilder();
    for(int i=1;i<s.Length;i++){
        if(s[i]==s[i-1]){
            tam++;
        }
        else
        {
            if(tam>1)
            {
                res.Append(tam);
}
        res.Append(s[i-1]);
        tam=1;
        }
    }
    return res.ToString();
}
