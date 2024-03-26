using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

/*
//메소드 개요(메소드 예)
public class Calculator
{
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }
    public void Multiple(int num1,int num2)
    {
        int result = num1 + num2;
        Debug.Log($"{num1} x {num2} = {result}");
    }
}
//메소드 개요(메소드 장점)
int num1 = 0, num2 = 0, result = 0;

num1 = 3;
num2 = 4;
result = num1 + num2;
Debug.Log($"{num1} x {num2} = {result}");

num1 = 5;
num2 = 8;
result = num1 + num2;
Debug.Log($"{num1} x {num2} = {result}");

num1 = 4;
num2 = 6;
result = num1 + num2;
Debug.Log($"{num1} x {num2} = {result}");

private void Awake()
{
    Multiple(3, 4);
    Multiple(5, 8);
    Multiple(4, 6);
}
public void Multiple(int num1,int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} x {num2} = {result}");
}
//메소드 실행 순서
public int Add(int num1,int num2)
{
    int result = num1 + num2;
    return result;
}
//Return
private void Awake()
{
    int a = Max(10, 20);
    Debug.Log(Max(100, 200));
    Max(5, 10);
}

public int Max(int num1,int num2)
{
    if (num1 > num2)
    {
        return num1;
    }
    return num2;
}
//반환 데이터가 없는 경우
public void Divide(int num1,int num2)
{
    if (num2 == 0)
    {
        Debug.Log("나누려는 값이 0이기 때문에 프로그램 종료");
        return;
    }

    float result = num1 / num2;
    Debug.Log($"{num1} x {num2} = {result}");
}
//매개 변수
private void Awake()
{
    int a =3,b = 4;
    Add(a,b);
}
public void Add(int num1,int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} x {num2} = {result}");
}
//매개 변수 -2
private void Awake()
{
    int a = 3, b = 4;
    Add();
    Add();
}
public void Add()
{
    int result = 10 + 12;
    Debug.Log($"{num1} x {num2} = {result}");
}
private void Awake()
{
    int a = 3, b = 4;
    Add(a, b);
    Add(10, 20);
}
public void Add(int num1, int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} x {num2} = {result}");
}
//값에 의한 전달과 참조에 의한 전달
private void Awake()
{
    int a = 3, b = 4;
    Add(a, b);
}
public void Add(int num1, int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} x {num2} = {result}");
}

private void Awake()
{
    int a=3, b = 4;
    Debug.Log($"Before a={a}, b={b}");
    Swap(a,b);
    Debug.Log($"After a={a}, b={b}");
}
public void Swap(int num1,int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

private void Awake()
{
    int a = 3, b = 4;
    Debug.Log($"a={a}, b={b}");
    Swap(ref a,ref b);
    Debug.Log($"a={a}, b={b}");
}
public void Swap(ref int num1,ref int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}
//출력 전용 매개 변수
private void Awake()
{
    int a = 5, b = 4, result1 = 0, result2  = 0;
    Divide(a,b,ref result1,ref result2 );
    Debug.Log($"몫={result1}, 나머지={result2}");
}
public void Divide(int num1,int num2, ref int result1, ref int result2)
{
    result1 = num1 / num2;
    result2 = num1 % num2;
}
//메소드 오버로딩
public void Addint(int num1,int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} x {num2} = {result}");
}
public void AddFloat(float num1, float num2)
{
    float result = num1 + num2;
    Debug.Log($"{num1} x {num2} = {result}");
}
//가변 길이 매개 변수
public void Sum(params int[] nums)
{
    int sum = 0;
    for(int i = 0; i < nums.Length; ++i)
    {
        sum += nums[i];
    }
    Debug.Log($"합계 : {sum}");
}
//객체 지향 프로그래밍과 클래스
public class Player : MonoBehaviour
{
    private string ID = "고박사";
    private int currentHP = 1000;
    public void TakeDamage(int damage)
    {
        if(currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}
//멤버 함수

public class Player : MonoBehaviour
{
    private string ID = "고박사";
    private int currentHP = 1000;
    private void Awake()
    {
        TakeDamage(100);
    }
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}

//접근 지정자
public class Player : MonoBehaviour
{
    private string ID;
    private int currentHP;

    void RecoverHP(int hp)
    {
        currentHP += hp;
    }
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}

//클래스의 생성과 사용 - 1
public class Player : MonoBehaviour
{
    private string ID = "고박사";
    private int currentHP = 1000;
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}
public class Enemy
{
    private Player player;

    public void AttackToTarget(Player target)
    {
        target.TakeDamage(100);
    }
}
//클래스의 생성과 사용 - 2
public class Gamecontroller : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player01.TakeDamage(100);
        player02.TakeDamage(200);
    }
}
//생성자와 소멸자
public class Player
{
    public string ID;
    private int currentHP;
    private int health;
    public Player()
    {
        ID = "고박사";
        currentHP = 1000;
    }
    public Player(string id,int hp)
    {
        ID = id;
        currentHP = hp;
    }
    ~Player()
    {
        //삭제문구
    }
}
public class Gamecontroller : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player02 = new Player("유니티",10);
    }
}
//얕은복사
public class Gamecontroller : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player("고박사",1000);
        player02 = player01;
        player02.ID = "유니티";

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");
    }
}
//깊은 복사
public class Gamecontroller : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player("고박사", 1000);
        player02 = player01.DeepCopy();
        player02.ID = "유니티";

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");
    }
}
public class Player
{
    public string ID;
    private int currentHP;

    //..

    public Player DeepCopy()
    {
        Player clone = new Player();
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
    }
}
//this 키워드

public class Player
{
    public string ID = "고초아";

    public SetID(string ID)
    {
        Debug.Log($"ID : {ID}");
        Debug.Log($"ID : {this.ID}");
    }
}

public class GameController
{
    private void Awake()
    {
        //..
        player01.SetID("유니티");
    }
}
//this 생성자
public class Player
{
    private string ID;
    private int currentHP;
    private int currentMP;

    public Player()
    {
        ID = "고박사";
    }
    public Player(int hp)
    {
        ID = "고박사";
        currentHP = hp;
    }
    public Player(int hp, int mp)
    {
        ID = "고박사";
        currentHP = hp;
        currentMP = mp;
    }
}

//==>

public class Player
{
    private string ID;
    private int currentHP;
    private int currentMP;

    public Player()
    {
        ID = "고박사";
    }
    public Player(int hp) : this()
    {
        currentHP = hp;
    }
    public Player(int hp, int mp) : this(hp)
    {
        currentMP = mp;
    }
}
//캡슐화
public class Player
{
    private int currentHP;
    public void SetCurrentHP(int hp)
    {
        if(hp < 0)
        {
            currentHP=hp;
        }
    }
    public int GetCurrentHP()
    {
        return currentHP;
    }
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();
        plyaer.currentHP = 100;
        Debug.Log($"HP : {player.CurrentHP}");
        plyaer.SetcurrentHP = 100;
        Debug.Log($"HP : {player.GetCurrentHP()}");
    }
}
//상속
public class Entity
{
    public string ID;
    protected int currentHP;

    private void Initialize()
    {
        ID = "Noname";
    }
    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
}

public class Player : Entity
{
    public Plyaer(string id,int hp)
    {
        ID =id;
        currentHP = hp;
        RecoverHP(1000);

        Initialize();
    }
}
//base
public class Entity
{
    public string ID;
    protected int currentHP;
}

public class Player : Entity
{
    private string ID;
    public Player(string id,int hp)
    {
        base.ID = "Noname";
        ID = id;
        currentHP = hp;
    }
}
//다향성
public class Entity
{
    public void Attack()
    {
        Debug.Log("적을 공격한다.");
    }
    public void Heal()
    {
        Debug.Log("체력을 회복한다.");
    }
}
public class Goblin : Entity
{
    public void Avoid()
    {
        Debug.Log("도망가자!!");
    }
    public void Heal()
    {
        Debug.Log("고블린의 체력 회복!");
    }
    public void TakeDamage(int damage)
    {
        Debug.Log($"고블린 : {damage}만큼 체력 감소");
    }
}

public class Slime
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"슬라임 : {damage}만큼 체력 감소");
    }
}
public class Dragon
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"드래곤 : {damage}만큼 체력 감소");
    }
}

public class Player
{
    private int damage = 10;

    public void Hit(Goblin goblin)
    {
        goblin.TakeDamage(damage);
    }
    public void Hit(Slime slime)
    {
        slime.TakeDamage(damage);
    }
    public void Hit(Dragon dragon)
    {
        dragon.TakeDamage(damage);
    }
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();

        Goblin goblin = new Goblin();
        Slime slime = new Slime();
        Dragon dragon = new Dragon();

        player.Hit(goblin);
        player.Hit(slime);
        player.Hit(dragon);
    }
}
//다형성-2

public class Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"적 : {damage}만큼 체력 감소");
    }
}
public class Goblin : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"고블린 : {damage}만큼 체력 감소");
    }
}
public class Slime : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"슬라임 : {damage}만큼 체력 감소");
    }
}
public class Dragon : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"드래곤 : {damage}만큼 체력 감소");
    }
}
public class Player : MonoBehaviour
{
    private int damage = 10;
    public void Hit(Enemy enemy)
    {
        enemy.TakeDamage(damage);
    }
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();

        Goblin goblin = new Goblin();
        Slime slime = new Slime();
        Dragon dragon = new Dragon();

        player.Hit(goblin);
        player.Hit(slime);
        player.Hit(dragon);
    }
}

//==>

public class GameController : MonoBehaviour
{
    private Goblin goblin;
    private Slime slime;
    private Dragon dragon;
    private void Awake()
    {
        
    }

    private void Update()
    {
        goblin.Attack();
        slime.Attack();
        dragon.Attack();
    }
}

public class GameController : MonoBehaviour
{
    private Enemy[] enemys = new Enemy[100];

    private void Awake()
    {
        enemys[0] = new Goblin();
        enemys[1] = new Slime();
        //..
    }
    private void Update()
    {
        for (int i = 0; i < enemys.Length; ++i)
        {
            enemys[i].Attack();
        }
    }
}
//다형성- 오버라이딩
public class Entity
{
    public virtual void Attack()
    {
        Debug.Log("적을 공격한다.")
    }
}
public class GameController
{
    private Slime slime;
    private Goblin goblin;

    private void Awake()
    {
        //,,
        slime.Attack();
        goblin.Attack();
    }
}
public class Slime : Entity
{
    public override void Attack()
    {
        Debug.Log("슬라임의 몸통 박치기 공격!");
    }
}
public class Goblin : Entity
{
    public override void Attack()
    {
        Debug.Log("고블린의 몸둥이 스매시!!");
    }
}

//다형성 형변환과 is,as연산자
public class Entity
{
    public void Attack()
    {
        Debug.Log("적을 공격한다.");
    }
}
public class Slime : Entity
{
}
public class Goblin : Entity
{ 
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Entity entity = new Slime();
        if(entity is Slime)
        {
            Debug.Log("Entity type is Slime");
        }
        Goblin goblin = entity as Goblin;
        if(goblin == null)
        {
            Debug.Log("goblin is null");
        }
    }
}
//추상화
public abstract class Entity
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity target);
    public void TakeDamage(int damage)
    {
        if(currentHP > damage)
        {
            currentHP -= damage;
            Debug.Log($"체력이 {damage} 감소");
        }
        else
        {
            Debug.Log("Die");
        }
    }
}
public class Goblin : Emtity
{
    public Goblin(int damage, int hp)
    {
        base.damage = damage;
        currentHP = hp;
    }
    public override void Attack(Entity target)
    {
        Debug.Log("고블린의 몽둥이 스매시!");
        target.TakeDamage(damage);
    }
}
public class Slime : Entity
{
    public Slime(int damage, int hp)
    {
        base.damage = damage;
        currentHP = hp;
    }
    public override void Attack(Entity target)
    {
        Debug.Log("슬라임의 몸통 박치기");
        target.TakeDamage(damage);
    }
}
public class GameController : MonoBehaviour
{
    private Entity entity; //인스턴스 생성 불가
    private Entity goblin;
    private Entity slime;

    private void Awake()
    {
        entity = new Entity(); //이거 안됨
        goblin = new Goblin(5, 100);
        slime = new Slime(10, 50);

        goblin.Attack(slime);
        slime.Attack(goblin);
    }
}
//인터페이스

interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}
public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}

public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;
    private IMovingEntity slime;
    private IMovingEntity butterfly;

    private void Awake()
    {
        goblin = new Goblin();
        slime = new Slime();
        butterfly = new Butterfly();

        goblin.MoveTo(new Vector3(1,2,3));
        slime.MoveTo(new Vector3(4,5,6));
        butterfly.MoveTo(new Vector3(7,8,9));
    }
    private void Awake()
    {
        goblin = Method();
    }
    public IMovingEntity Method()
    {
        Goblin goblin = new Goblin();
        return goblin;
    }
}
//상속 인터페이스
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}
interface IPerson : IMovingEntity
{
    void Talk(string word);
}
public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}

public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;
    private IPerson player;

    private void Awake()
    {
        goblin = new Goblin();
        player = new Player();

        goblin.MoveTo(new Vector3(1, 2, 3));
        player.MoveTo(new Vector3(4, 5, 6));
        player.Talk("안녕하세요. 고박사 입니다.");
    }
}
//다중 상속
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}
interface ICombatEntity
{
    void Attack(Entity target);
}
public class Player : IMovingEntity, ICombatEntity
{
    public void Move(Vector3 destination)
    {
        Debug,Log($"{destination}까지 걸어서 이동");
    }
    public void Attack(Entity target)
    {
        Debug.Log($"{target}을 공격합니다.");
    }
}
public abstract class CombatEntity
{
    public abstract void Attack();
}
public class Berserker : CombatEntity
{
    public void Sword() { }
    public void Attack() { Sword(); }
}
public class Archer : CombatEntity
{
    public void Arrow() { }
    public void Attack() { Arrow(); }
}
public class Player : Berserker, Archer
{
}
public class Player
{
    private Berserker berserker;
    private Archer archer;
    private void Awake()
    {
        berserker = new Berserker();
        archer = new Archer();
    }
    public void SwordAttack() { berserker.Attack(); }
    public void ArrowAttack() {  archer.Attack(); }
}
//메소드 숨기기 예
public class Parent
{
    public void Method01()
    {
        Debug.Log("Parent");
    }
}
public class Child : Parent
{
    public new void Method01()
    {
        Debug.Log("Child");
    }
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Parent p = new Parent();
        p.Method01();

        Child c = new Child();
        c.Method01();

        Parent pc = new Child();
        pc.Method01();
    }
}
//오버라이딩 봉인하기
public class Entity
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
}
public class MovingEntity : Entity
{
    public sealed override void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
} //sealed를 사용하면 override 불가
//구조체
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Stats player01 = new Stats();
        Stats player02;

        player02.ID = "고박사";
        player02.currentHP = 100000;
        player02.damage = 99999;
        Debug.Log($"{player01.ID},체력 : {player01.currentHP}, 공격력 : {player01.damage}");
        Debug.Log($"{player02.ID},체력 : {player02.currentHP}, 공격력 : {player02.damage}");
    }
}
public struct Stats
{
    public string ID;
    public int currentHP;
    public int damage;
}
//static 메소드
public class Enemy
{
    public int InstanceRun() { return 1; }
    public static int StaticRun()
    {
        InstanceRun();//호출 불가능
        return 1;
    }
}
public class GameController
{
    private void Awake()
    {
        int j = Enemy.StaticRun();

        Enemy enemy01 = new Enemy();
        int i = enemy01.InstanceRun();

        enemy01.StaticRun();//이건 불가
    }
}
//static 변수
public class Enemy
{
    public int numeric;
    public static string specise;
}
public class GameController
{
    private void Awake()
    {
        Enemy enemy01 = new Enemy();
        enemy01.numeric = 0;
        Enemy enemy02 = new Enemy();
        enemy02.numeric = 1;

        Debug.Log(enemy01.numeric);
        Debug.Log(enemy02.numeric);

        Enemy.specise = "고블린";
        Debug.Log(Entity.specise);
    }
}
//static 클래스

public static class Calculator
{
    public static int num;

    static Calculator()
    {
        num = 1;
    }
    public static int Sum(int a,int b)
    {
        return a + b;
    }
}
public class GameController
{
    private void Awake()
    {
        Debug.Log(Calculator.Sum(20, 55));
        Debug.Log(Calculator.num);
    }
}
//확장 메소드
public static class StringExtension
{
    public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}
public class GaemController : MonoBehaviour
{
    private void Awake()
    {
        string str = "안녕하세요. 고박사입니다.");
        str.PrintData();
    }
}
//프로퍼티 public 선택
public class Player
{
    public int currentHP;
}
public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.currentHP = 100;
        Debug.Log($"Player HP : {player.currentHP}");
    }
}
//private
public class Player
{
    private int currentHP;
    public int GetCurrentHP() { return currentHP; }
    public void SetCurrentHP(int hp) { currentHP = hp; }
}
public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.SetCurrentHP(100);
        Debug.Log($"Player HP : {player.GetCurrentHP()}");
    }
}
//프로퍼티 선언
public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        get => currentHP;
        set
        {
            if(currentHP > 0)
            {
                currentHP = value;
            }
            else
            {
                currentHP = 0;
            }
        }
    }
}
public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.CurrentHP = 100;
        Debug.Log($"Player HP : {player.currentHP}");
        player.CurrentHP = -100;
        Debug.Log($"Player HP : {player.currentHP}");
    }
}
//자동구현 프로퍼티
public class Player
{
    public int CurrentHP
    {
        get; set;
    }
    public string ID
    {
        get;set;
    }
}
public class Gamecontroller
{
    private void Awake()
    {
        Player player = new Player();
        player.ID = "고박사";
        player.CurrentHP= 100;
        Debug.Log($"{Player.ID} HP : {player.currentHP}");
    }
}
//읽기/쓰기 전용 프로퍼티
public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        get => currentHP;
    }
}//읽기
public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        set => currentHP = value;
    }
}//쓰기

public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        private set => currentHP = value;
        get => currentHP;
    }
}
public class Player
{
    public int CurrentHP
    {
        private set;get;
    }
}
//프로퍼티와 생성자
public class Player
{
    public int CurrentHP
    {
        get;set;
    }
    public string ID
    {
        get;set;
    }
}
public class GameController
{
    private void Awake()
    {
        private void Awake()
        {
            Player player = new Player()
            {
                player.ID = "고박사";
                player.CurrentHP = 100
            };
            Debug.Log($"{player.ID} HP : {player.CurrentHP}");
        }
    }
}
//인터페이스의 프로퍼티
interface IBaseEntity
{
    string ID { get; set; }
    int Damage { get; set; }
    int CurrentHP {  get; set; }
}
public class Player : IBaseObject
{
    private string id;
    public string ID
    {
        get => id;
        set => id = value;
    }
    public int Damage { get; set; }
    public int CurrentHP { get; set; }
}
//추상 클래스의 프로퍼티
public abstract class BaseEntity
{
    abstract public int Shield { get; set; }
    public int Defense
    {
        get; set;
    }
}
public class Player : BaseEntity
{
    public override int Shield
    {
        get;set;
    }
    public int ID
    {
        get;set;
    }
}
public class GameController
{
    private void Awake()
    {
        Player player = new Player()
        {
            player.ID = "고박사",
            player.Shield = 50,
            player.Defense = 10,
        };
        Debug.Log($"ID : {player.ID}");
        Debug.Log($"방어력 : {player.Defence},방어막 : {player.Shield}"); 
    }
}*/