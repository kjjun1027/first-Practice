using System;
using UnityEngine;

public class Practice0103 : MonoBehaviour
{
    //enum PlayerState { Idie, Move, Attack }
    private void Awake()
    {
        int? intValue;

        intValue = null;
        Debug.Log(intValue.HasValue);

        intValue = 30;
        Debug.Log(intValue.HasValue);
        Debug.Log(intValue.Value);

        var ValueInt = 33;
        var ValueFloat = 33.4567f;
        var ValueString = "���ڿ�";
        Debug.Log("���� : " + ValueInt);
        Debug.Log("�Ǽ� : " + ValueFloat);
        Debug.Log("���ڿ� : " + ValueString);


        /*13.�������� �̿��� �÷��̾� ���� ����
        PlayerState playerState = PlayerState.Idie;

        switch (playerState)
        {
            case PlayerIdie:
                Debug.Log("�÷��̾� ���� : ���");
                break;
            case PlayerMove:
                Debug.Log("�÷��̾� ���� : �̵�");
                break;
            case PlayerAttack:
                Debug.Log("�÷��̾� ���� : ����");
                break;
        }
        /* 12. ����� �̿��� Ǯ���̾� ���� ����
        const int PlayerIdie = 0;
        const int PlayerMove = 1;
        const int PlayerAttack = 2;

        int playerState = PlayerAttack;

        switch(playerState) 
        {
            case PlayerIdie:
                Debug.Log("�÷��̾� ���� : ���");
                break;
            case PlayerMove:
                Debug.Log("�÷��̾� ���� : �̵�");
                break;
            case PlayerAttack:
                Debug.Log("�÷��̾� ���� : ����");
                break;
        }
        /* 11. ���ڸ� ���ڿ��� �� ��ȯ - ToString()
        string srtingValue = "�ʱ�ȭ";
        int intValue = 33;
        float floatValue = 12.3456f;

        Debug.Log("stringValue : " + srtingValue);

        srtingValue = intValue.ToString();
        Debug.Log("stringValue : " + srtingValue);

        srtingValue = floatValue.ToString();
        Debug.Log("stringValue : " + srtingValue);

        /*10.���ڿ��� ���ڷ� �� ��ȯ 2 - TryParse()
        string srtingValue = "���ڰ� �ƴմϴ�";
        int intValue = 10;

        bool isConversion = int.TryParse(srtingValue, out intValue);
        if(isConversion ==true)
        {
            Debug.Log("stringValue : " + srtingValue);
            Debug.Log("intValue : " + intValue);
        }
        else
        {
            Debug.Log("stringValue ������ ����ִ� ������ ���ڰ� �ƴϾ ����ȯ�� �����Ͽ����ϴ�");
        }

        /*09. ���ڿ��� ���ڷ� �� ��ȯ 1-Parse()
        int intValue = 10;
        float floatValue = 12.3456f;
        string srtingValue = "33";

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("string Data : " + srtingValue);

        intValue = int.Parse(srtingValue);
        srtingValue = "33.4567";
        floatValue = float.Parse(srtingValue);

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("string Data : " + srtingValue);

        /* 08. �ε� �Ҽ����� ���� ������ �� ��ȯ
        float floatValue = 0.9f;
        int intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);

        floatValue = 1.1f;
        intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);

        /*07.ũ�Ⱑ ���� �ٸ� �ε� �Ҽ��� ������ �� ��ȯ
        float floatValue = 69.6875f;
        double doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);

        floatValue = 0.1f;
        doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);

        /* 06. ��ȣ �ִ� ������ ��ȣ ���� ���� ������ �� ��ȯ
        sbyte sbyteValue = 31;
        byte byteValue = (byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        sbyteValue = -31;
        byteValue = (byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        byteValue = 200;
        sbyteValue = (sbyte)byteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);


        /* 05. ũ�Ⱑ ���� �ٸ� ����(int, sbyte) ������ �� ��ȯ
        sbyte sbyteValue = 10;
        int intValue = (int)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);

        intValue = 130;
        sbyteValue = (sbyte)intValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);

        /* 04. ������Ʈ ����
        object ValueInt = 31;
        object ValueFloat = 3.14159265358979f;
        object ValueString = "��ü���� ���α׷���";
        object ValueBool = false;

        Debug.Log("���� : " +  ValueInt);
        Debug.Log("�Ǽ� : " + ValueFloat);
        Debug.Log("���ڿ� : " + ValueString);
        Debug.Log("�� : " + ValueBool);


        /* 03. ���ڿ�, ��
        string srtingValue = "�ȳ��ϼ���. ��ڻ��Դϴ�.";
        bool boolValue = true;

        Debug.Log("string Data : " + srtingValue);
        Debug.Log("bool Data : " + boolValue);
        /* 02.�Ǽ�
        float floatValue01 = 3.141592653589793238462643383279f;
        float floatValue02 = 31.141592653589793238462643383279f;
        double doubleValue = 3.141592653589793238462643383279;
        decimal decimalValue = 3.141592653589793238462643383279m;

        Debug.Log("float Data : " + floatValue01);
        Debug.Log("float Data : " + floatValue02);
        Debug.Log("double Data : " + doubleValue);
        Debug.Log("decimal Data : " + decimalValue);

        /* 01.����
        sbyte byteValue = -128;
        byte ubyteValue = 255;
        short shortValue = -32768;
        ushort ushortValue = 65535;
        int intValue = -2147483648;
        uint uintValue = 4294967295;
        long longValue = -9223372036854775808;
        ulong ulongValue = 18446744073709551615;
        char charValue = 'K';

        Debug.Log("byte Data : " + byteValue);
        Debug.Log("ubyte Data : " + ubyteValue);
        Debug.Log("short Data : " + shortValue);
        Debug.Log("ushort Data : " + ushortValue);
        Debug.Log("int Data : " + intValue);
        Debug.Log("uint Data : " + uintValue);
        Debug.Log("long Data : " + longValue);
        Debug.Log("ulong Data : " + ulongValue);
        Debug.Log("char Data : " + charValue);*/
    }
}