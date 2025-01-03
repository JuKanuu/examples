namespace SignalRClientExample;

/// <summary>
/// Reason
/// </summary>
public enum EventReason
{
    /// <summary>
    /// No reason
    /// </summary>
    NoReason = 0,

    /// <summary>
    /// No access
    /// </summary>
    NoAccess,

    /// <summary>
    /// Not in schedule
    /// </summary>
    NotInSchedule,

    /// <summary>
    /// Invalid credential
    /// </summary>
    InvalidCredential,

    /// <summary>
    /// Identification not found
    /// </summary>
    IdentificationNotFound,

    /// <summary>
    /// Unknown user
    /// </summary>
    UnknownUser,

    /// <summary>
    /// No access level
    /// </summary>
    NoAccessLevel,

    /// <summary>
    /// Expired access level
    /// </summary>
    ExpiredAccessLevel,

    /// <summary>
    /// Ground fault
    /// </summary>
    GroundFault,

    /// <summary>
    /// Short
    /// </summary>
    Short,

    /// <summary>
    /// Open circuit
    /// </summary>
    OpenCircuit,

    /// <summary>
    /// Foreign voltage
    /// </summary>
    ForeignVoltage,

    /// <summary>
    /// Masked
    /// </summary>
    Masked,

    /// <summary>
    /// Rejected before activation
    /// </summary>
    RejectedBeforeActivation,

    /// <summary>
    /// Rejected after activation
    /// </summary>
    RejectedAfterExpiration,

    /// <summary>
    /// Never allowed
    /// </summary>
    NeverAllowed,

    /// <summary>
    /// Operator action
    /// </summary>
    OperatorAction,

    /// <summary>
    /// Temperature check failed
    /// </summary>
    TemperatureCheckFailed,

    /// <summary>
    /// Door blocked
    /// </summary>
    DoorBlocked,

    /// <summary>
    /// Door unlocked
    /// </summary>
    DoorUnlocked,

    /// <summary>
    /// Momentary unlocked
    /// </summary>
    MomentaryUnlocked,

    /// <summary>
    /// Incomplete card and pin sequence
    /// </summary>
    IncompleteCardAndPinSequence
}