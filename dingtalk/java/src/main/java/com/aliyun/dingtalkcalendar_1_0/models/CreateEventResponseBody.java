// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateEventResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    @NameInMap("summary")
    public String summary;

    @NameInMap("description")
    public String description;

    // 日程开始时间
    @NameInMap("start")
    public CreateEventResponseBodyStart start;

    @NameInMap("end")
    public CreateEventResponseBodyEnd end;

    @NameInMap("isAllDay")
    public Boolean isAllDay;

    @NameInMap("recurrence")
    public CreateEventResponseBodyRecurrence recurrence;

    @NameInMap("attendees")
    public java.util.List<CreateEventResponseBodyAttendees> attendees;

    @NameInMap("organizer")
    public CreateEventResponseBodyOrganizer organizer;

    @NameInMap("location")
    public CreateEventResponseBodyLocation location;

    @NameInMap("reminders")
    public java.util.List<CreateEventResponseBodyReminders> reminders;

    // 创建时间
    @NameInMap("createTime")
    public String createTime;

    // 更新时间
    @NameInMap("updateTime")
    public String updateTime;

    @NameInMap("onlineMeetingInfo")
    public CreateEventResponseBodyOnlineMeetingInfo onlineMeetingInfo;

    public static CreateEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateEventResponseBody self = new CreateEventResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateEventResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateEventResponseBody setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public CreateEventResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateEventResponseBody setStart(CreateEventResponseBodyStart start) {
        this.start = start;
        return this;
    }
    public CreateEventResponseBodyStart getStart() {
        return this.start;
    }

    public CreateEventResponseBody setEnd(CreateEventResponseBodyEnd end) {
        this.end = end;
        return this;
    }
    public CreateEventResponseBodyEnd getEnd() {
        return this.end;
    }

    public CreateEventResponseBody setIsAllDay(Boolean isAllDay) {
        this.isAllDay = isAllDay;
        return this;
    }
    public Boolean getIsAllDay() {
        return this.isAllDay;
    }

    public CreateEventResponseBody setRecurrence(CreateEventResponseBodyRecurrence recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public CreateEventResponseBodyRecurrence getRecurrence() {
        return this.recurrence;
    }

    public CreateEventResponseBody setAttendees(java.util.List<CreateEventResponseBodyAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<CreateEventResponseBodyAttendees> getAttendees() {
        return this.attendees;
    }

    public CreateEventResponseBody setOrganizer(CreateEventResponseBodyOrganizer organizer) {
        this.organizer = organizer;
        return this;
    }
    public CreateEventResponseBodyOrganizer getOrganizer() {
        return this.organizer;
    }

    public CreateEventResponseBody setLocation(CreateEventResponseBodyLocation location) {
        this.location = location;
        return this;
    }
    public CreateEventResponseBodyLocation getLocation() {
        return this.location;
    }

    public CreateEventResponseBody setReminders(java.util.List<CreateEventResponseBodyReminders> reminders) {
        this.reminders = reminders;
        return this;
    }
    public java.util.List<CreateEventResponseBodyReminders> getReminders() {
        return this.reminders;
    }

    public CreateEventResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public CreateEventResponseBody setUpdateTime(String updateTime) {
        this.updateTime = updateTime;
        return this;
    }
    public String getUpdateTime() {
        return this.updateTime;
    }

    public CreateEventResponseBody setOnlineMeetingInfo(CreateEventResponseBodyOnlineMeetingInfo onlineMeetingInfo) {
        this.onlineMeetingInfo = onlineMeetingInfo;
        return this;
    }
    public CreateEventResponseBodyOnlineMeetingInfo getOnlineMeetingInfo() {
        return this.onlineMeetingInfo;
    }

    public static class CreateEventResponseBodyStart extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static CreateEventResponseBodyStart build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyStart self = new CreateEventResponseBodyStart();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CreateEventResponseBodyStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public CreateEventResponseBodyStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class CreateEventResponseBodyEnd extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static CreateEventResponseBodyEnd build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyEnd self = new CreateEventResponseBodyEnd();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CreateEventResponseBodyEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public CreateEventResponseBodyEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class CreateEventResponseBodyRecurrencePattern extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("daysOfWeek")
        public String daysOfWeek;

        @NameInMap("index")
        public String index;

        @NameInMap("interval")
        public Integer interval;

        public static CreateEventResponseBodyRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyRecurrencePattern self = new CreateEventResponseBodyRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CreateEventResponseBodyRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public CreateEventResponseBodyRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public CreateEventResponseBodyRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public CreateEventResponseBodyRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

    }

    public static class CreateEventResponseBodyRecurrenceRange extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        public static CreateEventResponseBodyRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyRecurrenceRange self = new CreateEventResponseBodyRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CreateEventResponseBodyRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public CreateEventResponseBodyRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

    }

    public static class CreateEventResponseBodyRecurrence extends TeaModel {
        @NameInMap("pattern")
        public CreateEventResponseBodyRecurrencePattern pattern;

        @NameInMap("range")
        public CreateEventResponseBodyRecurrenceRange range;

        public static CreateEventResponseBodyRecurrence build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyRecurrence self = new CreateEventResponseBodyRecurrence();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyRecurrence setPattern(CreateEventResponseBodyRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public CreateEventResponseBodyRecurrencePattern getPattern() {
            return this.pattern;
        }

        public CreateEventResponseBodyRecurrence setRange(CreateEventResponseBodyRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public CreateEventResponseBodyRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class CreateEventResponseBodyAttendees extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("displayName")
        public String displayName;

        // 回复状态
        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("self")
        public Boolean self;

        public static CreateEventResponseBodyAttendees build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyAttendees self = new CreateEventResponseBodyAttendees();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateEventResponseBodyAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public CreateEventResponseBodyAttendees setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public CreateEventResponseBodyAttendees setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class CreateEventResponseBodyOrganizer extends TeaModel {
        @NameInMap("id")
        public String id;

        // 用户名
        @NameInMap("displayName")
        public String displayName;

        // 回复状态
        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("self")
        public Boolean self;

        public static CreateEventResponseBodyOrganizer build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyOrganizer self = new CreateEventResponseBodyOrganizer();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateEventResponseBodyOrganizer setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public CreateEventResponseBodyOrganizer setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public CreateEventResponseBodyOrganizer setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class CreateEventResponseBodyLocation extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        public static CreateEventResponseBodyLocation build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyLocation self = new CreateEventResponseBodyLocation();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class CreateEventResponseBodyReminders extends TeaModel {
        @NameInMap("method")
        public String method;

        @NameInMap("minutes")
        public String minutes;

        public static CreateEventResponseBodyReminders build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyReminders self = new CreateEventResponseBodyReminders();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyReminders setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public CreateEventResponseBodyReminders setMinutes(String minutes) {
            this.minutes = minutes;
            return this;
        }
        public String getMinutes() {
            return this.minutes;
        }

    }

    public static class CreateEventResponseBodyOnlineMeetingInfo extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("url")
        public String url;

        @NameInMap("extraInfo")
        public java.util.Map<String, ?> extraInfo;

        public static CreateEventResponseBodyOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyOnlineMeetingInfo self = new CreateEventResponseBodyOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CreateEventResponseBodyOnlineMeetingInfo setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public CreateEventResponseBodyOnlineMeetingInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public CreateEventResponseBodyOnlineMeetingInfo setExtraInfo(java.util.Map<String, ?> extraInfo) {
            this.extraInfo = extraInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtraInfo() {
            return this.extraInfo;
        }

    }

}
