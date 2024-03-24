// Lớp trừu tượng Animal
abstract class Animal
{
    abstract void makeSound();
}

// Lớp con Chicken kế thừa từ lớp Animal và triển khai interface Edible
class Chicken extends Animal implements Edible {
    void makeSound() {
    System.out.println("Chicken: Cluck cluck!");
}

@Override
    public void howToEat()
{
    System.out.println("Chicken: Fry it or grill it!");
}
}

// Lớp con Tiger kế thừa từ lớp Animal
class Tiger extends Animal
{
    void makeSound() {
        System.out.println("Tiger: Roar!");
    }
}

// Interface Edible
interface Edible
{
    void howToEat();
}

// Lớp trừu tượng Fruit
abstract class Fruit implements Edible
{
    // Empty implementation of howToEat() method in Edible interface
}

// Lớp con Orange kế thừa từ lớp Fruit
class Orange extends Fruit
{
    @Override
    public void howToEat()
{
    System.out.println("Orange: Peel it and eat it!");
}
}

// Lớp con Apple kế thừa từ lớp Fruit
class Apple extends Fruit
{
    @Override
    public void howToEat()
{
    System.out.println("Apple: Wash it and bite it!");
}
}

public class Main
{
    public static void main(String[] args)
    {
        Animal chicken = new Chicken();
        chicken.makeSound();

        Edible chickenAsEdible = new Chicken();
        chickenAsEdible.howToEat();

        Animal tiger = new Tiger();
        tiger.makeSound();

        Fruit orange = new Orange();
        orange.howToEat();

        Fruit apple = new Apple();
        apple.howToEat();
    }
}