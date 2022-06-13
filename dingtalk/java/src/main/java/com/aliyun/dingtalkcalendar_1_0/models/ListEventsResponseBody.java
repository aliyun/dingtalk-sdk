// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsResponseBody extends TeaModel {
    // 日程
    @NameInMap("events")
    public java.util.List<ListEventsResponseBodyEvents> events;

    // 翻页token
    @NameInMap("nextToken")
    public String nextToken;

    // 增量同步token
    @NameInMap("syncToken")
    public String syncToken;

    public static ListEventsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListEventsResponseBody self = new ListEventsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListEventsResponseBody setEvents(java.util.List<ListEventsResponseBodyEvents> events) {
        this.events = events;
        return this;
    }
    public java.util.List<ListEventsResponseBodyEvents> getEvents() {
        return this.events;
    }

    public ListEventsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListEventsResponseBody setSyncToken(String syncToken) {
        this.syncToken = syncToken;
        return this;
    }
    public String getSyncToken() {
        return this.syncToken;
    }

    public static class ListEventsResponseBodyEventsAttendees extends TeaModel {
        // 用户名
        @NameInMap("displayName")
        public String displayName;

        // 用户id
        @NameInMap("id")
        public String id;

        @NameInMap("isOptional")
        public Boolean isOptional;

        // 回复状态
        @NameInMap("responseStatus")
        public String responseStatus;

        // 是否是当前登陆用户
        @NameInMap("self")
        public Boolean self;

        public static ListEventsResponseBodyEventsAttendees build(java.util.Map<String, ?> map) throws Exception {
            ListEventsResponseBodyEventsAttendees self = new ListEventsResponseBodyEventsAttendees();
            return TeaModel.build(map, self);
        }

        public ListEventsResponseBodyEventsAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsResponseBodyEventsAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsResponseBodyEventsAttendees setIsOptional(Boolean isOptional) {
            this.isOptional = isOptional;
            return this;
        }
        public Boolean getIsOptional() {
            return this.isOptional;
        }

        public ListEventsResponseBodyEventsAttendees setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListEventsResponseBodyEventsAttendees setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class ListEventsResponseBodyEventsEnd extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static ListEventsResponseBodyEventsEnd build(java.util.Map<String, ?> map) throws Exception {
            ListEventsResponseBodyEventsEnd self = new ListEventsResponseBodyEventsEnd();
            return TeaModel.build(map, self);
        }

        public ListEventsResponseBodyEventsEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public ListEventsResponseBodyEventsEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public ListEventsResponseBodyEventsEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class ListEventsResponseBodyEventsLocation extends TeaModel {
        // 展示名称
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("meetingRooms")
        public java.util.List<String> meetingRooms;

        public static ListEventsResponseBodyEventsLocation build(java.util.Map<String, ?> map) throws Exception {
            ListEventsResponseBodyEventsLocation self = new ListEventsResponseBodyEventsLocation();
            return TeaModel.build(map, self);
        }

        public ListEventsResponseBodyEventsLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsResponseBodyEventsLocation setMeetingRooms(java.util.List<String> meetingRooms) {
            this.meetingRooms = meetingRooms;
            return this;
        }
        public java.util.List<String> getMeetingRooms() {
            return this.meetingRooms;
        }

    }

    public static class ListEventsResponseBodyEventsOnlineMeetingInfo extends TeaModel {
        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("extraInfo")
        public java.util.Map<String, ?> extraInfo;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static ListEventsResponseBodyEventsOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            ListEventsResponseBodyEventsOnlineMeetingInfo self = new ListEventsResponseBodyEventsOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public ListEventsResponseBodyEventsOnlineMeetingInfo setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public ListEventsResponseBodyEventsOnlineMeetingInfo setExtraInfo(java.util.Map<String, ?> extraInfo) {
            this.extraInfo = extraInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtraInfo() {
            return this.extraInfo;
        }

        public ListEventsResponseBodyEventsOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListEventsResponseBodyEventsOnlineMeetingInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class ListEventsResponseBodyEventsOrganizer extends TeaModel {
        // 用户名
        @NameInMap("displayName")
        public String displayName;

        // 用户id
        @NameInMap("id")
        public String id;

        // 回复状态
        @NameInMap("responseStatus")
        public String responseStatus;

        // 是否是当前登陆用户
        @NameInMap("self")
        public Boolean self;

        public static ListEventsResponseBodyEventsOrganizer build(java.util.Map<String, ?> map) throws Exception {
            ListEventsResponseBodyEventsOrganizer self = new ListEventsResponseBodyEventsOrganizer();
            return TeaModel.build(map, self);
        }

        public ListEventsResponseBodyEventsOrganizer setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsResponseBodyEventsOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsResponseBodyEventsOrganizer setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListEventsResponseBodyEventsOrganizer setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class ListEventsResponseBodyEventsRecurrencePattern extends TeaModel {
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("daysOfWeek")
        public String daysOfWeek;

        @NameInMap("index")
        public String index;

        @NameInMap("interval")
        public Integer interval;

        // 循环模式类型(type: daily, weekly, absoluteMonthly, relativeMonthly, absoluteYearly, relativeYearly)
        @NameInMap("type")
        public String type;

        public static ListEventsResponseBodyEventsRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            ListEventsResponseBodyEventsRecurrencePattern self = new ListEventsResponseBodyEventsRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public ListEventsResponseBodyEventsRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public ListEventsResponseBodyEventsRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public ListEventsResponseBodyEventsRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public ListEventsResponseBodyEventsRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public ListEventsResponseBodyEventsRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListEventsResponseBodyEventsRecurrenceRange extends TeaModel {
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        // 范围类型(endDate, noEnd, numbered)
        @NameInMap("type")
        public String type;

        public static ListEventsResponseBodyEventsRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            ListEventsResponseBodyEventsRecurrenceRange self = new ListEventsResponseBodyEventsRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public ListEventsResponseBodyEventsRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public ListEventsResponseBodyEventsRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

        public ListEventsResponseBodyEventsRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListEventsResponseBodyEventsRecurrence extends TeaModel {
        // 重复模式
        @NameInMap("pattern")
        public ListEventsResponseBodyEventsRecurrencePattern pattern;

        // 重复范围
        @NameInMap("range")
        public ListEventsResponseBodyEventsRecurrenceRange range;

        public static ListEventsResponseBodyEventsRecurrence build(java.util.Map<String, ?> map) throws Exception {
            ListEventsResponseBodyEventsRecurrence self = new ListEventsResponseBodyEventsRecurrence();
            return TeaModel.build(map, self);
        }

        public ListEventsResponseBodyEventsRecurrence setPattern(ListEventsResponseBodyEventsRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public ListEventsResponseBodyEventsRecurrencePattern getPattern() {
            return this.pattern;
        }

        public ListEventsResponseBodyEventsRecurrence setRange(ListEventsResponseBodyEventsRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public ListEventsResponseBodyEventsRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class ListEventsResponseBodyEventsReminders extends TeaModel {
        @NameInMap("method")
        public String method;

        @NameInMap("minutes")
        public String minutes;

        public static ListEventsResponseBodyEventsReminders build(java.util.Map<String, ?> map) throws Exception {
            ListEventsResponseBodyEventsReminders self = new ListEventsResponseBodyEventsReminders();
            return TeaModel.build(map, self);
        }

        public ListEventsResponseBodyEventsReminders setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public ListEventsResponseBodyEventsReminders setMinutes(String minutes) {
            this.minutes = minutes;
            return this;
        }
        public String getMinutes() {
            return this.minutes;
        }

    }

    public static class ListEventsResponseBodyEventsStart extends TeaModel {
        // 日期，格式：yyyyMMdd
        @NameInMap("date")
        public String date;

        // 时间戳，按照ISO 8601格式
        @NameInMap("dateTime")
        public String dateTime;

        // 时区
        @NameInMap("timeZone")
        public String timeZone;

        public static ListEventsResponseBodyEventsStart build(java.util.Map<String, ?> map) throws Exception {
            ListEventsResponseBodyEventsStart self = new ListEventsResponseBodyEventsStart();
            return TeaModel.build(map, self);
        }

        public ListEventsResponseBodyEventsStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public ListEventsResponseBodyEventsStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public ListEventsResponseBodyEventsStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class ListEventsResponseBodyEvents extends TeaModel {
        // 日程参与人
        @NameInMap("attendees")
        public java.util.List<ListEventsResponseBodyEventsAttendees> attendees;

        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 日程描述
        @NameInMap("description")
        public String description;

        // 日程结束时间
        @NameInMap("end")
        public ListEventsResponseBodyEventsEnd end;

        // 日程事件id
        @NameInMap("id")
        public String id;

        // 是否为全天日程
        @NameInMap("isAllDay")
        public Boolean isAllDay;

        // 日程地点
        @NameInMap("location")
        public ListEventsResponseBodyEventsLocation location;

        @NameInMap("onlineMeetingInfo")
        public ListEventsResponseBodyEventsOnlineMeetingInfo onlineMeetingInfo;

        // 日程组织人
        @NameInMap("organizer")
        public ListEventsResponseBodyEventsOrganizer organizer;

        // 日程重复规则
        @NameInMap("recurrence")
        public ListEventsResponseBodyEventsRecurrence recurrence;

        @NameInMap("reminders")
        public java.util.List<ListEventsResponseBodyEventsReminders> reminders;

        // 重复日程的主日程id，非重复日程为空
        @NameInMap("seriesMasterId")
        public String seriesMasterId;

        // 日程开始时间
        @NameInMap("start")
        public ListEventsResponseBodyEventsStart start;

        // 日程状态
        @NameInMap("status")
        public String status;

        // 日程标题
        @NameInMap("summary")
        public String summary;

        // 更新时间
        @NameInMap("updateTime")
        public String updateTime;

        public static ListEventsResponseBodyEvents build(java.util.Map<String, ?> map) throws Exception {
            ListEventsResponseBodyEvents self = new ListEventsResponseBodyEvents();
            return TeaModel.build(map, self);
        }

        public ListEventsResponseBodyEvents setAttendees(java.util.List<ListEventsResponseBodyEventsAttendees> attendees) {
            this.attendees = attendees;
            return this;
        }
        public java.util.List<ListEventsResponseBodyEventsAttendees> getAttendees() {
            return this.attendees;
        }

        public ListEventsResponseBodyEvents setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListEventsResponseBodyEvents setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListEventsResponseBodyEvents setEnd(ListEventsResponseBodyEventsEnd end) {
            this.end = end;
            return this;
        }
        public ListEventsResponseBodyEventsEnd getEnd() {
            return this.end;
        }

        public ListEventsResponseBodyEvents setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsResponseBodyEvents setIsAllDay(Boolean isAllDay) {
            this.isAllDay = isAllDay;
            return this;
        }
        public Boolean getIsAllDay() {
            return this.isAllDay;
        }

        public ListEventsResponseBodyEvents setLocation(ListEventsResponseBodyEventsLocation location) {
            this.location = location;
            return this;
        }
        public ListEventsResponseBodyEventsLocation getLocation() {
            return this.location;
        }

        public ListEventsResponseBodyEvents setOnlineMeetingInfo(ListEventsResponseBodyEventsOnlineMeetingInfo onlineMeetingInfo) {
            this.onlineMeetingInfo = onlineMeetingInfo;
            return this;
        }
        public ListEventsResponseBodyEventsOnlineMeetingInfo getOnlineMeetingInfo() {
            return this.onlineMeetingInfo;
        }

        public ListEventsResponseBodyEvents setOrganizer(ListEventsResponseBodyEventsOrganizer organizer) {
            this.organizer = organizer;
            return this;
        }
        public ListEventsResponseBodyEventsOrganizer getOrganizer() {
            return this.organizer;
        }

        public ListEventsResponseBodyEvents setRecurrence(ListEventsResponseBodyEventsRecurrence recurrence) {
            this.recurrence = recurrence;
            return this;
        }
        public ListEventsResponseBodyEventsRecurrence getRecurrence() {
            return this.recurrence;
        }

        public ListEventsResponseBodyEvents setReminders(java.util.List<ListEventsResponseBodyEventsReminders> reminders) {
            this.reminders = reminders;
            return this;
        }
        public java.util.List<ListEventsResponseBodyEventsReminders> getReminders() {
            return this.reminders;
        }

        public ListEventsResponseBodyEvents setSeriesMasterId(String seriesMasterId) {
            this.seriesMasterId = seriesMasterId;
            return this;
        }
        public String getSeriesMasterId() {
            return this.seriesMasterId;
        }

        public ListEventsResponseBodyEvents setStart(ListEventsResponseBodyEventsStart start) {
            this.start = start;
            return this;
        }
        public ListEventsResponseBodyEventsStart getStart() {
            return this.start;
        }

        public ListEventsResponseBodyEvents setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListEventsResponseBodyEvents setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public ListEventsResponseBodyEvents setUpdateTime(String updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public String getUpdateTime() {
            return this.updateTime;
        }

    }

}
