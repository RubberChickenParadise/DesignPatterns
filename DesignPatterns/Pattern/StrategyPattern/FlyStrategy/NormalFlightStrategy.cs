﻿namespace DesignPatterns.Pattern.StrategyPattern.FlyStrategy {
  public class NormalFlightStrategy : IFlyStrategy {
    public string Fly() => "Normal flight";
  }
}