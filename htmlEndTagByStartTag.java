For startTag = "<button type='button' disabled>", the output should be
htmlEndTagByStartTag(startTag) = "</button>";
For startTag = "<i>", the output should be
htmlEndTagByStartTag(startTag) = "</i>".
//code
String htmlEndTagByStartTag(String startTag) {

  String result =  "</" ;
  int position = 1;
  while (startTag.charAt(position) != ' ' && startTag.charAt(position) != '>') {
    result += startTag.charAt(position++);
  }
  result += '>';
  return result;
}
