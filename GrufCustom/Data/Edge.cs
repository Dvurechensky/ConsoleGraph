/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 01:05:12
 * Version: 1.0.6
 */

namespace GraphCustomSearcher.Data;

/// <summary>
/// Шаблог ребра
/// </summary>
public class Edge
{
    /// <summary>
    /// Узел начала
    /// </summary>
    public Verticle VerticleStart { get; set; }
    /// <summary>
    /// Узел конца
    /// </summary>
    public Verticle VerticleStop { get; set; }

    public Edge(Verticle verticleStart, Verticle verticleStop)
    {
        VerticleStart = verticleStart;
        VerticleStop = verticleStop;
    }
}
