// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateEventByMeResponseBody extends TeaModel {
    @NameInMap("attendees")
    public java.util.List<CreateEventByMeResponseBodyAttendees> attendees;

    @NameInMap("createTime")
    public String createTime;

    @NameInMap("description")
    public String description;

    @NameInMap("end")
    public CreateEventByMeResponseBodyEnd end;

    @NameInMap("id")
    public String id;

    @NameInMap("isAllDay")
    public Boolean isAllDay;

    @NameInMap("location")
    public CreateEventByMeResponseBodyLocation location;

    @NameInMap("onlineMeetingInfo")
    public CreateEventByMeResponseBodyOnlineMeetingInfo onlineMeetingInfo;

    @NameInMap("organizer")
    public CreateEventByMeResponseBodyOrganizer organizer;

    @NameInMap("recurrence")
    public CreateEventByMeResponseBodyRecurrence recurrence;

    @NameInMap("reminders")
    public java.util.List<CreateEventByMeResponseBodyReminders> reminders;

    @NameInMap("richTextDescription")
    public CreateEventByMeResponseBodyRichTextDescription richTextDescription;

    @NameInMap("start")
    public CreateEventByMeResponseBodyStart start;

    @NameInMap("summary")
    public String summary;

    @NameInMap("uiConfigs")
    public java.util.List<CreateEventByMeResponseBodyUiConfigs> uiConfigs;

    @NameInMap("updateTime")
    public String updateTime;

    public static CreateEventByMeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateEventByMeResponseBody self = new CreateEventByMeResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateEventByMeResponseBody setAttendees(java.util.List<CreateEventByMeResponseBodyAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<CreateEventByMeResponseBodyAttendees> getAttendees() {
        return this.attendees;
    }

    public CreateEventByMeResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public CreateEventByMeResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateEventByMeResponseBody setEnd(CreateEventByMeResponseBodyEnd end) {
        this.end = end;
        return this;
    }
    public CreateEventByMeResponseBodyEnd getEnd() {
        return this.end;
    }

    public CreateEventByMeResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateEventByMeResponseBody setIsAllDay(Boolean isAllDay) {
        this.isAllDay = isAllDay;
        return this;
    }
    public Boolean getIsAllDay() {
        return this.isAllDay;
    }

    public CreateEventByMeResponseBody setLocation(CreateEventByMeResponseBodyLocation location) {
        this.location = location;
        return this;
    }
    public CreateEventByMeResponseBodyLocation getLocation() {
        return this.location;
    }

    public CreateEventByMeResponseBody setOnlineMeetingInfo(CreateEventByMeResponseBodyOnlineMeetingInfo onlineMeetingInfo) {
        this.onlineMeetingInfo = onlineMeetingInfo;
        return this;
    }
    public CreateEventByMeResponseBodyOnlineMeetingInfo getOnlineMeetingInfo() {
        return this.onlineMeetingInfo;
    }

    public CreateEventByMeResponseBody setOrganizer(CreateEventByMeResponseBodyOrganizer organizer) {
        this.organizer = organizer;
        return this;
    }
    public CreateEventByMeResponseBodyOrganizer getOrganizer() {
        return this.organizer;
    }

    public CreateEventByMeResponseBody setRecurrence(CreateEventByMeResponseBodyRecurrence recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public CreateEventByMeResponseBodyRecurrence getRecurrence() {
        return this.recurrence;
    }

    public CreateEventByMeResponseBody setReminders(java.util.List<CreateEventByMeResponseBodyReminders> reminders) {
        this.reminders = reminders;
        return this;
    }
    public java.util.List<CreateEventByMeResponseBodyReminders> getReminders() {
        return this.reminders;
    }

    public CreateEventByMeResponseBody setRichTextDescription(CreateEventByMeResponseBodyRichTextDescription richTextDescription) {
        this.richTextDescription = richTextDescription;
        return this;
    }
    public CreateEventByMeResponseBodyRichTextDescription getRichTextDescription() {
        return this.richTextDescription;
    }

    public CreateEventByMeResponseBody setStart(CreateEventByMeResponseBodyStart start) {
        this.start = start;
        return this;
    }
    public CreateEventByMeResponseBodyStart getStart() {
        return this.start;
    }

    public CreateEventByMeResponseBody setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public CreateEventByMeResponseBody setUiConfigs(java.util.List<CreateEventByMeResponseBodyUiConfigs> uiConfigs) {
        this.uiConfigs = uiConfigs;
        return this;
    }
    public java.util.List<CreateEventByMeResponseBodyUiConfigs> getUiConfigs() {
        return this.uiConfigs;
    }

    public CreateEventByMeResponseBody setUpdateTime(String updateTime) {
        this.updateTime = updateTime;
        return this;
    }
    public String getUpdateTime() {
        return this.updateTime;
    }

    public static class CreateEventByMeResponseBodyAttendees extends TeaModel {
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

        public static CreateEventByMeResponseBodyAttendees build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyAttendees self = new CreateEventByMeResponseBodyAttendees();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public CreateEventByMeResponseBodyAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateEventByMeResponseBodyAttendees setIsOptional(Boolean isOptional) {
            this.isOptional = isOptional;
            return this;
        }
        public Boolean getIsOptional() {
            return this.isOptional;
        }

        public CreateEventByMeResponseBodyAttendees setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public CreateEventByMeResponseBodyAttendees setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class CreateEventByMeResponseBodyEnd extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static CreateEventByMeResponseBodyEnd build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyEnd self = new CreateEventByMeResponseBodyEnd();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CreateEventByMeResponseBodyEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public CreateEventByMeResponseBodyEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class CreateEventByMeResponseBodyLocation extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        public static CreateEventByMeResponseBodyLocation build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyLocation self = new CreateEventByMeResponseBodyLocation();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class CreateEventByMeResponseBodyOnlineMeetingInfo extends TeaModel {
        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("extraInfo")
        public java.util.Map<String, ?> extraInfo;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static CreateEventByMeResponseBodyOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyOnlineMeetingInfo self = new CreateEventByMeResponseBodyOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyOnlineMeetingInfo setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public CreateEventByMeResponseBodyOnlineMeetingInfo setExtraInfo(java.util.Map<String, ?> extraInfo) {
            this.extraInfo = extraInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtraInfo() {
            return this.extraInfo;
        }

        public CreateEventByMeResponseBodyOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CreateEventByMeResponseBodyOnlineMeetingInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class CreateEventByMeResponseBodyOrganizer extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("id")
        public String id;

        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("self")
        public Boolean self;

        public static CreateEventByMeResponseBodyOrganizer build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyOrganizer self = new CreateEventByMeResponseBodyOrganizer();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyOrganizer setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public CreateEventByMeResponseBodyOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateEventByMeResponseBodyOrganizer setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public CreateEventByMeResponseBodyOrganizer setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class CreateEventByMeResponseBodyRecurrencePattern extends TeaModel {
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

        public static CreateEventByMeResponseBodyRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyRecurrencePattern self = new CreateEventByMeResponseBodyRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public CreateEventByMeResponseBodyRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public CreateEventByMeResponseBodyRecurrencePattern setFirstDayOfWeek(String firstDayOfWeek) {
            this.firstDayOfWeek = firstDayOfWeek;
            return this;
        }
        public String getFirstDayOfWeek() {
            return this.firstDayOfWeek;
        }

        public CreateEventByMeResponseBodyRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public CreateEventByMeResponseBodyRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public CreateEventByMeResponseBodyRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreateEventByMeResponseBodyRecurrenceRange extends TeaModel {
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        @NameInMap("type")
        public String type;

        public static CreateEventByMeResponseBodyRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyRecurrenceRange self = new CreateEventByMeResponseBodyRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public CreateEventByMeResponseBodyRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

        public CreateEventByMeResponseBodyRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreateEventByMeResponseBodyRecurrence extends TeaModel {
        @NameInMap("pattern")
        public CreateEventByMeResponseBodyRecurrencePattern pattern;

        @NameInMap("range")
        public CreateEventByMeResponseBodyRecurrenceRange range;

        public static CreateEventByMeResponseBodyRecurrence build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyRecurrence self = new CreateEventByMeResponseBodyRecurrence();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyRecurrence setPattern(CreateEventByMeResponseBodyRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public CreateEventByMeResponseBodyRecurrencePattern getPattern() {
            return this.pattern;
        }

        public CreateEventByMeResponseBodyRecurrence setRange(CreateEventByMeResponseBodyRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public CreateEventByMeResponseBodyRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class CreateEventByMeResponseBodyReminders extends TeaModel {
        @NameInMap("method")
        public String method;

        @NameInMap("minutes")
        public String minutes;

        public static CreateEventByMeResponseBodyReminders build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyReminders self = new CreateEventByMeResponseBodyReminders();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyReminders setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public CreateEventByMeResponseBodyReminders setMinutes(String minutes) {
            this.minutes = minutes;
            return this;
        }
        public String getMinutes() {
            return this.minutes;
        }

    }

    public static class CreateEventByMeResponseBodyRichTextDescription extends TeaModel {
        @NameInMap("text")
        public String text;

        public static CreateEventByMeResponseBodyRichTextDescription build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyRichTextDescription self = new CreateEventByMeResponseBodyRichTextDescription();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyRichTextDescription setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class CreateEventByMeResponseBodyStart extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static CreateEventByMeResponseBodyStart build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyStart self = new CreateEventByMeResponseBodyStart();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CreateEventByMeResponseBodyStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public CreateEventByMeResponseBodyStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class CreateEventByMeResponseBodyUiConfigs extends TeaModel {
        @NameInMap("uiName")
        public String uiName;

        @NameInMap("uiStatus")
        public String uiStatus;

        public static CreateEventByMeResponseBodyUiConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeResponseBodyUiConfigs self = new CreateEventByMeResponseBodyUiConfigs();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeResponseBodyUiConfigs setUiName(String uiName) {
            this.uiName = uiName;
            return this;
        }
        public String getUiName() {
            return this.uiName;
        }

        public CreateEventByMeResponseBodyUiConfigs setUiStatus(String uiStatus) {
            this.uiStatus = uiStatus;
            return this;
        }
        public String getUiStatus() {
            return this.uiStatus;
        }

    }

}
