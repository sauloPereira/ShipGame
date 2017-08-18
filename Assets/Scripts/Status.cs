using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Status {
    /*
    private int nivel;
    private int life;
    private int fuel;
    private int endurence;
    private int speed;
    private int force;
    private int resistance;
    */

    private int hp;
    private int hpMax;
    private int mp;
    private int mpMax;
    private float fuel;
    private float fuelMax;
    private int ataque;
    private int currentPoints;
    private int points;
    private int exp = 1;
    private int nivel = 1;

    public Status() { }

    public Status(int newHP, int newAttack, float newFuel, int newPoints) {

        this.hpMax = this.hp = newHP;
        this.fuelMax = this.fuel = newFuel;
        this.ataque = newAttack;
        this.points = newPoints;

    }

    public int getHP() {
        return hp;
    }

    public int getHPMax() {
        return hpMax;
    }

    public float getFuel() {
        return fuel;
    }

    public float getFuelMax() {
        return fuelMax;
    }

    public int getAttack() {
        return ataque;
    }

    public int getCurrentPoints() {
        return currentPoints;
    }

    public int getPoints() {
        return points;
    }

    //=====================

    public void setHP(int hp) {
        if (hp > this.hpMax) {
            hp = this.hpMax;
        }
        this.hp = hp;
    }

    public void setHPMax(int hpMax) {
        this.hpMax = hpMax;

    }

    public void setFuel(float fuel) {
        if (fuel > this.fuelMax) {
            fuel = this.fuelMax;
        }
        this.fuel = fuel;
    }

    public void setFuelMax(float fuelMax) {
        this.fuelMax = fuelMax;

    }

    public void setAttack(int ataque) {
        this.ataque = ataque;

    }

    public void inDamage(int damage) {
        this.hp -= (damage + ataque);
        Debug.Log(damage + ataque);
        if (this.hp < 0)
            this.hp = 0;
    }

    public void recoverHP(int valor) {
        this.hp += valor;
        if (this.hp > this.hpMax)
            this.hp = this.hpMax;
    }

    public void consumeFuel(float fuel) {
        this.fuel -= fuel;
        if (this.fuel < 0) {
            this.fuel = 0;

        }
    }

    public void recoverFuel(float valor) {
        this.fuel += valor;
        if (this.fuel > this.fuelMax)
            this.fuel = this.fuelMax;

    }

    public void addPoints(int points) {
        this.currentPoints += points;

    }

    public void recoverPoints(int valor) {
        valor = this.points;
    }

    public void addExp(int valor) {
        exp += valor;
        nivel = (int)System.Math.Ceiling(exp / 100.00);
    }

    public bool isDead() {
        return this.hp == 0;
    }

}
