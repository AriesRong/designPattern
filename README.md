# designPattern
<div>
<h2 style="color:FF00FF">1.Strategy Pattern:</h2>
<p><strong>KeyWords</strong>：</p>
<ul>
<li><code>package</code></li>
<li><code>interface</code></li>
<li><code>abstract class</code></li>
</ul>
</div>

<div>
<h2 style="color:#FF00FF">2.Observer Pattern:</h2>
<p><strong>KeyWords:</strong></p>
<ul>
<li>one to many</li>
<li><code>interface</code></li>
<li><code>abstract class</code></li>
<li>Subject</li>
<ul>
<li><code>registerObserver(o)</code></li>
<li><code>removeObserver(o)</code></li>
<li><code>notifyObserver()</code></li>
</ul>
<li>Observer</li>
<ul>
<li><code>update()</code></li>
</ul>
</ul>
</div>

<div>
<h2 style="color:FF00FF">3.Decorator Pattern</h2>
<p><strong>KeyWords:</strong></p>
<ul>
<li>Componet</li>
<ul>
<li>ConcreteComponent</li>
<li>Decorator</li>
<ul>
<li>ConcreteDecorator</li>
</ul>
</ul>
<li>virtual & abstract</li>
<li><code>base</code></li>
<li>inherit</li>
</ul>
</div>

<div>
<h2 style="color:FF00FF">4.Simple Factory Pattern</h2>
<p><strong>KeyWords:</strong></p>
<ul>
<li>swithch{case:default;}</li>
</ul>
<h2 style="color:FF00FF">Factory Pattern</h2>
<p><strong>KeyWords:</strong></p>
<ul>
<li>Product</li>
<ul><li>ConcreteProduct</li></ul>
<li>abstract Product factoryMthod(string type)</li>
<li>Creator(FactoryMthod:return Product)</li>
<ul><li>ConcreteCreator(FactoryMthod:return Product)</li></ul>
</ul>
<h2 style="color:FF00FF">Abstract Factory Pattern</h2>
<p><strong>KeyWords:</strong></p>
<ul>
<li>Product Family</li>
<li>AbstractFactory(return:AbstractProductA,AbstractProductB)</li>
<ul>
<li>AbstractFactory1(return:AbstractProductA,AbstractProductB)</li>
<li>AbstractFactory2(return:AbstractProductA,AbstractProductB)</li>
</ul>
<li>AbstractProductA</li>
<ul>
<li>ProductA1</li><li>ProductA2</li>
</ul>
<li>AbstractProductB</li>
<ul>
<li>ProductB1</li><li>ProductB2</li>
</ul>
</ul>
</div>