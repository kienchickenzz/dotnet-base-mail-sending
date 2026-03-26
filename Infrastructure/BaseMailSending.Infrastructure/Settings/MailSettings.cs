/**
 * Mail configuration settings.
 *
 * <p>Contains SMTP configuration and provider selection.</p>
 */

namespace BaseMailSending.Infrastructure.Settings;

/// <summary>
/// Email provider options.
/// </summary>
public enum EmailProviderEnum
{
    /// <summary>
    /// Fake provider for development (log only, no actual sending).
    /// </summary>
    Fake,

    /// <summary>
    /// SMTP provider using MailKit (production).
    /// </summary>
    Smtp
}

/// <summary>
/// Mail service configuration.
/// </summary>
public class MailSettings
{
    public const string SectionName = "MailSettings";

    /// <summary>
    /// Email provider to use.
    /// </summary>
    public EmailProviderEnum Provider { get; set; } = EmailProviderEnum.Smtp;

    public string? From { get; set; }

    public string? Host { get; set; }

    public int Port { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? DisplayName { get; set; }
}