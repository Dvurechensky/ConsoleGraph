/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 01:05:12
 * Version: 1.0.6
 */

namespace GraphCustomSearcher.Data;

/// <summary>
/// Узел
/// </summary>
public class Verticle
{
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Статус посещения узла
    /// </summary>
    public bool IsVisited { get; set; }

    public Verticle(string name)
    {
        Name = name;
    }
}
