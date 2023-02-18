using System;

public class Text
{
    private string _text = "";
    List<string> _textList = new List<string>(){
        "Therefore, I would that ye should be steadfast and immovable, always abounding in good works, that Christ, the Lord God Omnipotent, may seal you his, that you may be brought to heaven, that ye may have everlasting salvation and eternal life, through the wisdom, and power, and justice, and mercy of him who created all things, in heaven and in earth, who is God above all. Amen.",
        "For if there be no faith among the children of men God can do no miracle among them; wherefore, he showed not himself until after their faith.",
        "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.",
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        "For, for this intent have we written these things, that they may know that we knew of Christ, and we had a hope of his glory many hundred years before his coming; and not only we ourselves had a hope of his glory, but also all the holy prophets which were before us."
    };
    
    public string RandText(int index){
        _text = _textList[index];
        return _text;
    }
}