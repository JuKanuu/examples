using System;

namespace SignalRClientExample;

/// <summary>
///     Access control system event object
/// </summary>
public class Event
{
    /// <summary>
    ///     Unique id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Event name
    /// </summary>
    public DateTime Time { get; set; }

    /// <summary>
    ///     Time event appeared in system
    /// </summary>
    public DateTime InsertTime { get; set; }

    /// <summary>
    ///     First name of user that is related to event
    /// </summary>
    public string SourceFirstName { get; set; }

    /// <summary>
    ///     Last name of user that is related to event
    /// </summary>
    public string SourceLastName { get; set; }

    /// <summary>
    ///     Company
    /// </summary>
    public string SourceCompany { get; set; }

    /// <summary>
    ///     User department
    /// </summary>
    public string SourceDepartment { get; set; }

    /// <summary>
    ///     Source device name
    /// </summary>
    public string SourceDeviceName { get; set; }

    /// <summary>
    ///     Source device id
    /// </summary>
    public int? DeviceId { get; set; }

    /// <summary>
    ///     Module identifier
    /// </summary>
    public string DeviceModuleName { get; set; }

    /// <summary>
    ///     Door id
    /// </summary>
    public int? DoorId { get; set; }

    /// <summary>
    ///     Event user id
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    ///     Source door name
    /// </summary>
    public string SourceDoorName { get; set; }

    /// <summary>
    ///     Event type
    /// </summary>
    public Guid TypeUid { get; set; }

    /// <summary>
    ///     Localized name of event type
    /// </summary>
    public string LocalizedTypeName { get; set; }

    /// <summary>
    ///     Category
    /// </summary>
    public string LocalizedCategoryName { get; set; }

    /// <summary>
    ///     Reason
    /// </summary>
    public string LocalizedReasonName { get; set; }

    /// <summary>
    /// Localized door device type
    /// </summary>
    public string LocalizedDoorDeviceTypeName { get; set; }

    /// <summary>
    ///     Door device type
    /// </summary>
    public short? SourceDoorDeviceTypeId { get; set; }

    /// <summary>
    ///     Event reason
    /// </summary>
    public EventReason ReasonId { get; set; }

    /// <summary>
    ///     Event category
    /// </summary>
    public EventCategory CategoryId { get; set; }

    /// <summary>
    ///     Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Event update if set
    /// </summary>
    public bool IsUpdate { get; set; }

    /// <summary>
    ///     Group name
    /// </summary>
    public string GroupName { get; set; }

    /// <summary>
    ///     Input name
    /// </summary>
    public string DeviceInputName { get; set; }

    /// <summary>
    ///     Output name
    /// </summary>
    public string DeviceOutputName { get; set; }

    /// <summary>
    /// Input Id
    /// </summary>
    public int? InputId { get; set; }

    /// <summary>
    /// Output Id
    /// </summary>
    public int? OutputId { get; set; }

    /// <summary>
    /// Group Id
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// TnA mode Id
    /// </summary>
    public int? DoorTnAModeId { get; set; }
}