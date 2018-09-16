﻿namespace DesignPatterns.AbstractFactory {
  // Should only be used to create objects
  // These objects should be under a family
  // Should be used by DI
  interface IAbstractFactory {
    IProductA CreateProductA();
    IProductB CreateProductB();
  }
}
