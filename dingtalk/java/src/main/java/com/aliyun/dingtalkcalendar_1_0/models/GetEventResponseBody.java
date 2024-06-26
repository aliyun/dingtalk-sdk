// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetEventResponseBody extends TeaModel {
    @NameInMap("attendees")
    public java.util.List<GetEventResponseBodyAttendees> attendees;

    @NameInMap("cardInstances")
    public java.util.List<GetEventResponseBodyCardInstances> cardInstances;

    @NameInMap("categories")
    public java.util.List<GetEventResponseBodyCategories> categories;

    /**
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("createTime")
    public String createTime;

    @NameInMap("description")
    public String description;

    @NameInMap("end")
    public GetEventResponseBodyEnd end;

    @NameInMap("extendedProperties")
    public GetEventResponseBodyExtendedProperties extendedProperties;

    @NameInMap("id")
    public String id;

    @NameInMap("isAllDay")
    public Boolean isAllDay;

    @NameInMap("location")
    public GetEventResponseBodyLocation location;

    @NameInMap("meetingRooms")
    public java.util.List<GetEventResponseBodyMeetingRooms> meetingRooms;

    @NameInMap("onlineMeetingInfo")
    public GetEventResponseBodyOnlineMeetingInfo onlineMeetingInfo;

    @NameInMap("organizer")
    public GetEventResponseBodyOrganizer organizer;

    @NameInMap("originStart")
    public GetEventResponseBodyOriginStart originStart;

    @NameInMap("recurrence")
    public GetEventResponseBodyRecurrence recurrence;

    @NameInMap("reminders")
    public java.util.List<GetEventResponseBodyReminders> reminders;

    @NameInMap("richTextDescription")
    public GetEventResponseBodyRichTextDescription richTextDescription;

    @NameInMap("seriesMasterId")
    public String seriesMasterId;

    @NameInMap("start")
    public GetEventResponseBodyStart start;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>已取消、删除的日程是cancelled</p>
     */
    @NameInMap("status")
    public String status;

    @NameInMap("summary")
    public String summary;

    @NameInMap("uiConfigs")
    public java.util.List<GetEventResponseBodyUiConfigs> uiConfigs;

    /**
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("updateTime")
    public String updateTime;

    public static GetEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetEventResponseBody self = new GetEventResponseBody();
        return TeaModel.build(map, self);
    }

    public GetEventResponseBody setAttendees(java.util.List<GetEventResponseBodyAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<GetEventResponseBodyAttendees> getAttendees() {
        return this.attendees;
    }

    public GetEventResponseBody setCardInstances(java.util.List<GetEventResponseBodyCardInstances> cardInstances) {
        this.cardInstances = cardInstances;
        return this;
    }
    public java.util.List<GetEventResponseBodyCardInstances> getCardInstances() {
        return this.cardInstances;
    }

    public GetEventResponseBody setCategories(java.util.List<GetEventResponseBodyCategories> categories) {
        this.categories = categories;
        return this;
    }
    public java.util.List<GetEventResponseBodyCategories> getCategories() {
        return this.categories;
    }

    public GetEventResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public GetEventResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetEventResponseBody setEnd(GetEventResponseBodyEnd end) {
        this.end = end;
        return this;
    }
    public GetEventResponseBodyEnd getEnd() {
        return this.end;
    }

    public GetEventResponseBody setExtendedProperties(GetEventResponseBodyExtendedProperties extendedProperties) {
        this.extendedProperties = extendedProperties;
        return this;
    }
    public GetEventResponseBodyExtendedProperties getExtendedProperties() {
        return this.extendedProperties;
    }

    public GetEventResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetEventResponseBody setIsAllDay(Boolean isAllDay) {
        this.isAllDay = isAllDay;
        return this;
    }
    public Boolean getIsAllDay() {
        return this.isAllDay;
    }

    public GetEventResponseBody setLocation(GetEventResponseBodyLocation location) {
        this.location = location;
        return this;
    }
    public GetEventResponseBodyLocation getLocation() {
        return this.location;
    }

    public GetEventResponseBody setMeetingRooms(java.util.List<GetEventResponseBodyMeetingRooms> meetingRooms) {
        this.meetingRooms = meetingRooms;
        return this;
    }
    public java.util.List<GetEventResponseBodyMeetingRooms> getMeetingRooms() {
        return this.meetingRooms;
    }

    public GetEventResponseBody setOnlineMeetingInfo(GetEventResponseBodyOnlineMeetingInfo onlineMeetingInfo) {
        this.onlineMeetingInfo = onlineMeetingInfo;
        return this;
    }
    public GetEventResponseBodyOnlineMeetingInfo getOnlineMeetingInfo() {
        return this.onlineMeetingInfo;
    }

    public GetEventResponseBody setOrganizer(GetEventResponseBodyOrganizer organizer) {
        this.organizer = organizer;
        return this;
    }
    public GetEventResponseBodyOrganizer getOrganizer() {
        return this.organizer;
    }

    public GetEventResponseBody setOriginStart(GetEventResponseBodyOriginStart originStart) {
        this.originStart = originStart;
        return this;
    }
    public GetEventResponseBodyOriginStart getOriginStart() {
        return this.originStart;
    }

    public GetEventResponseBody setRecurrence(GetEventResponseBodyRecurrence recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public GetEventResponseBodyRecurrence getRecurrence() {
        return this.recurrence;
    }

    public GetEventResponseBody setReminders(java.util.List<GetEventResponseBodyReminders> reminders) {
        this.reminders = reminders;
        return this;
    }
    public java.util.List<GetEventResponseBodyReminders> getReminders() {
        return this.reminders;
    }

    public GetEventResponseBody setRichTextDescription(GetEventResponseBodyRichTextDescription richTextDescription) {
        this.richTextDescription = richTextDescription;
        return this;
    }
    public GetEventResponseBodyRichTextDescription getRichTextDescription() {
        return this.richTextDescription;
    }

    public GetEventResponseBody setSeriesMasterId(String seriesMasterId) {
        this.seriesMasterId = seriesMasterId;
        return this;
    }
    public String getSeriesMasterId() {
        return this.seriesMasterId;
    }

    public GetEventResponseBody setStart(GetEventResponseBodyStart start) {
        this.start = start;
        return this;
    }
    public GetEventResponseBodyStart getStart() {
        return this.start;
    }

    public GetEventResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetEventResponseBody setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public GetEventResponseBody setUiConfigs(java.util.List<GetEventResponseBodyUiConfigs> uiConfigs) {
        this.uiConfigs = uiConfigs;
        return this;
    }
    public java.util.List<GetEventResponseBodyUiConfigs> getUiConfigs() {
        return this.uiConfigs;
    }

    public GetEventResponseBody setUpdateTime(String updateTime) {
        this.updateTime = updateTime;
        return this;
    }
    public String getUpdateTime() {
        return this.updateTime;
    }

    public static class GetEventResponseBodyAttendees extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("id")
        public String id;

        @NameInMap("isOptional")
        public Boolean isOptional;

        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("self")
        public Boolean self;

        public static GetEventResponseBodyAttendees build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyAttendees self = new GetEventResponseBodyAttendees();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetEventResponseBodyAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetEventResponseBodyAttendees setIsOptional(Boolean isOptional) {
            this.isOptional = isOptional;
            return this;
        }
        public Boolean getIsOptional() {
            return this.isOptional;
        }

        public GetEventResponseBodyAttendees setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public GetEventResponseBodyAttendees setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class GetEventResponseBodyCardInstances extends TeaModel {
        @NameInMap("outTrackId")
        public String outTrackId;

        @NameInMap("scenario")
        public String scenario;

        public static GetEventResponseBodyCardInstances build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyCardInstances self = new GetEventResponseBodyCardInstances();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyCardInstances setOutTrackId(String outTrackId) {
            this.outTrackId = outTrackId;
            return this;
        }
        public String getOutTrackId() {
            return this.outTrackId;
        }

        public GetEventResponseBodyCardInstances setScenario(String scenario) {
            this.scenario = scenario;
            return this;
        }
        public String getScenario() {
            return this.scenario;
        }

    }

    public static class GetEventResponseBodyCategories extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        public static GetEventResponseBodyCategories build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyCategories self = new GetEventResponseBodyCategories();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyCategories setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class GetEventResponseBodyEnd extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static GetEventResponseBodyEnd build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyEnd self = new GetEventResponseBodyEnd();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public GetEventResponseBodyEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public GetEventResponseBodyEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class GetEventResponseBodyExtendedPropertiesSharedProperties extends TeaModel {
        @NameInMap("belongCorpId")
        public String belongCorpId;

        @NameInMap("sourceOpenCid")
        public String sourceOpenCid;

        public static GetEventResponseBodyExtendedPropertiesSharedProperties build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyExtendedPropertiesSharedProperties self = new GetEventResponseBodyExtendedPropertiesSharedProperties();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyExtendedPropertiesSharedProperties setBelongCorpId(String belongCorpId) {
            this.belongCorpId = belongCorpId;
            return this;
        }
        public String getBelongCorpId() {
            return this.belongCorpId;
        }

        public GetEventResponseBodyExtendedPropertiesSharedProperties setSourceOpenCid(String sourceOpenCid) {
            this.sourceOpenCid = sourceOpenCid;
            return this;
        }
        public String getSourceOpenCid() {
            return this.sourceOpenCid;
        }

    }

    public static class GetEventResponseBodyExtendedProperties extends TeaModel {
        @NameInMap("sharedProperties")
        public GetEventResponseBodyExtendedPropertiesSharedProperties sharedProperties;

        public static GetEventResponseBodyExtendedProperties build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyExtendedProperties self = new GetEventResponseBodyExtendedProperties();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyExtendedProperties setSharedProperties(GetEventResponseBodyExtendedPropertiesSharedProperties sharedProperties) {
            this.sharedProperties = sharedProperties;
            return this;
        }
        public GetEventResponseBodyExtendedPropertiesSharedProperties getSharedProperties() {
            return this.sharedProperties;
        }

    }

    public static class GetEventResponseBodyLocation extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("meetingRooms")
        public java.util.List<String> meetingRooms;

        public static GetEventResponseBodyLocation build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyLocation self = new GetEventResponseBodyLocation();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetEventResponseBodyLocation setMeetingRooms(java.util.List<String> meetingRooms) {
            this.meetingRooms = meetingRooms;
            return this;
        }
        public java.util.List<String> getMeetingRooms() {
            return this.meetingRooms;
        }

    }

    public static class GetEventResponseBodyMeetingRooms extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("roomId")
        public String roomId;

        public static GetEventResponseBodyMeetingRooms build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyMeetingRooms self = new GetEventResponseBodyMeetingRooms();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyMeetingRooms setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetEventResponseBodyMeetingRooms setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public GetEventResponseBodyMeetingRooms setRoomId(String roomId) {
            this.roomId = roomId;
            return this;
        }
        public String getRoomId() {
            return this.roomId;
        }

    }

    public static class GetEventResponseBodyOnlineMeetingInfo extends TeaModel {
        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("extraInfo")
        public java.util.Map<String, ?> extraInfo;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static GetEventResponseBodyOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyOnlineMeetingInfo self = new GetEventResponseBodyOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyOnlineMeetingInfo setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public GetEventResponseBodyOnlineMeetingInfo setExtraInfo(java.util.Map<String, ?> extraInfo) {
            this.extraInfo = extraInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtraInfo() {
            return this.extraInfo;
        }

        public GetEventResponseBodyOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetEventResponseBodyOnlineMeetingInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetEventResponseBodyOrganizer extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("id")
        public String id;

        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("self")
        public Boolean self;

        public static GetEventResponseBodyOrganizer build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyOrganizer self = new GetEventResponseBodyOrganizer();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyOrganizer setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetEventResponseBodyOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetEventResponseBodyOrganizer setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public GetEventResponseBodyOrganizer setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class GetEventResponseBodyOriginStart extends TeaModel {
        @NameInMap("dateTime")
        public String dateTime;

        public static GetEventResponseBodyOriginStart build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyOriginStart self = new GetEventResponseBodyOriginStart();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyOriginStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

    }

    public static class GetEventResponseBodyRecurrencePattern extends TeaModel {
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("daysOfWeek")
        public String daysOfWeek;

        @NameInMap("firstDayOfWeek")
        public String firstDayOfWeek;

        @NameInMap("index")
        public String index;

        @NameInMap("interval")
        public Integer interval;

        @NameInMap("type")
        public String type;

        public static GetEventResponseBodyRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyRecurrencePattern self = new GetEventResponseBodyRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public GetEventResponseBodyRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public GetEventResponseBodyRecurrencePattern setFirstDayOfWeek(String firstDayOfWeek) {
            this.firstDayOfWeek = firstDayOfWeek;
            return this;
        }
        public String getFirstDayOfWeek() {
            return this.firstDayOfWeek;
        }

        public GetEventResponseBodyRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public GetEventResponseBodyRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public GetEventResponseBodyRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetEventResponseBodyRecurrenceRange extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        @NameInMap("type")
        public String type;

        public static GetEventResponseBodyRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyRecurrenceRange self = new GetEventResponseBodyRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public GetEventResponseBodyRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

        public GetEventResponseBodyRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetEventResponseBodyRecurrence extends TeaModel {
        @NameInMap("pattern")
        public GetEventResponseBodyRecurrencePattern pattern;

        @NameInMap("range")
        public GetEventResponseBodyRecurrenceRange range;

        public static GetEventResponseBodyRecurrence build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyRecurrence self = new GetEventResponseBodyRecurrence();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyRecurrence setPattern(GetEventResponseBodyRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public GetEventResponseBodyRecurrencePattern getPattern() {
            return this.pattern;
        }

        public GetEventResponseBodyRecurrence setRange(GetEventResponseBodyRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public GetEventResponseBodyRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class GetEventResponseBodyReminders extends TeaModel {
        @NameInMap("method")
        public String method;

        @NameInMap("minutes")
        public String minutes;

        public static GetEventResponseBodyReminders build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyReminders self = new GetEventResponseBodyReminders();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyReminders setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public GetEventResponseBodyReminders setMinutes(String minutes) {
            this.minutes = minutes;
            return this;
        }
        public String getMinutes() {
            return this.minutes;
        }

    }

    public static class GetEventResponseBodyRichTextDescription extends TeaModel {
        @NameInMap("text")
        public String text;

        public static GetEventResponseBodyRichTextDescription build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyRichTextDescription self = new GetEventResponseBodyRichTextDescription();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyRichTextDescription setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class GetEventResponseBodyStart extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static GetEventResponseBodyStart build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyStart self = new GetEventResponseBodyStart();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public GetEventResponseBodyStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public GetEventResponseBodyStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class GetEventResponseBodyUiConfigs extends TeaModel {
        @NameInMap("uiName")
        public String uiName;

        @NameInMap("uiStatus")
        public String uiStatus;

        public static GetEventResponseBodyUiConfigs build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyUiConfigs self = new GetEventResponseBodyUiConfigs();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyUiConfigs setUiName(String uiName) {
            this.uiName = uiName;
            return this;
        }
        public String getUiName() {
            return this.uiName;
        }

        public GetEventResponseBodyUiConfigs setUiStatus(String uiStatus) {
            this.uiStatus = uiStatus;
            return this;
        }
        public String getUiStatus() {
            return this.uiStatus;
        }

    }

}
