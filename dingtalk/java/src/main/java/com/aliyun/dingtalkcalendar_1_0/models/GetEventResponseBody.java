// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetEventResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    // 日程标题
    @NameInMap("summary")
    public String summary;

    // 日程描述
    @NameInMap("description")
    public String description;

    // 日程状态
    @NameInMap("status")
    public String status;

    // 日程开始时间
    @NameInMap("start")
    public GetEventResponseBodyStart start;

    // 日程结束时间
    @NameInMap("end")
    public GetEventResponseBodyEnd end;

    // 是否为全天日程
    @NameInMap("isAllDay")
    public Boolean isAllDay;

    @NameInMap("recurrence")
    public GetEventResponseBodyRecurrence recurrence;

    @NameInMap("attendees")
    public java.util.List<GetEventResponseBodyAttendees> attendees;

    @NameInMap("organizer")
    public GetEventResponseBodyOrganizer organizer;

    @NameInMap("location")
    public GetEventResponseBodyLocation location;

    // 重复日程的主日程id，非重复日程为空
    @NameInMap("seriesMasterId")
    public String seriesMasterId;

    // 创建时间
    @NameInMap("createTime")
    public String createTime;

    // 更新时间
    @NameInMap("updateTime")
    public String updateTime;

    @NameInMap("reminders")
    public java.util.List<GetEventResponseBodyReminders> reminders;

    @NameInMap("onlineMeetingInfo")
    public GetEventResponseBodyOnlineMeetingInfo onlineMeetingInfo;

    public static GetEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetEventResponseBody self = new GetEventResponseBody();
        return TeaModel.build(map, self);
    }

    public GetEventResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetEventResponseBody setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public GetEventResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetEventResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetEventResponseBody setStart(GetEventResponseBodyStart start) {
        this.start = start;
        return this;
    }
    public GetEventResponseBodyStart getStart() {
        return this.start;
    }

    public GetEventResponseBody setEnd(GetEventResponseBodyEnd end) {
        this.end = end;
        return this;
    }
    public GetEventResponseBodyEnd getEnd() {
        return this.end;
    }

    public GetEventResponseBody setIsAllDay(Boolean isAllDay) {
        this.isAllDay = isAllDay;
        return this;
    }
    public Boolean getIsAllDay() {
        return this.isAllDay;
    }

    public GetEventResponseBody setRecurrence(GetEventResponseBodyRecurrence recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public GetEventResponseBodyRecurrence getRecurrence() {
        return this.recurrence;
    }

    public GetEventResponseBody setAttendees(java.util.List<GetEventResponseBodyAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<GetEventResponseBodyAttendees> getAttendees() {
        return this.attendees;
    }

    public GetEventResponseBody setOrganizer(GetEventResponseBodyOrganizer organizer) {
        this.organizer = organizer;
        return this;
    }
    public GetEventResponseBodyOrganizer getOrganizer() {
        return this.organizer;
    }

    public GetEventResponseBody setLocation(GetEventResponseBodyLocation location) {
        this.location = location;
        return this;
    }
    public GetEventResponseBodyLocation getLocation() {
        return this.location;
    }

    public GetEventResponseBody setSeriesMasterId(String seriesMasterId) {
        this.seriesMasterId = seriesMasterId;
        return this;
    }
    public String getSeriesMasterId() {
        return this.seriesMasterId;
    }

    public GetEventResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public GetEventResponseBody setUpdateTime(String updateTime) {
        this.updateTime = updateTime;
        return this;
    }
    public String getUpdateTime() {
        return this.updateTime;
    }

    public GetEventResponseBody setReminders(java.util.List<GetEventResponseBodyReminders> reminders) {
        this.reminders = reminders;
        return this;
    }
    public java.util.List<GetEventResponseBodyReminders> getReminders() {
        return this.reminders;
    }

    public GetEventResponseBody setOnlineMeetingInfo(GetEventResponseBodyOnlineMeetingInfo onlineMeetingInfo) {
        this.onlineMeetingInfo = onlineMeetingInfo;
        return this;
    }
    public GetEventResponseBodyOnlineMeetingInfo getOnlineMeetingInfo() {
        return this.onlineMeetingInfo;
    }

    public static class GetEventResponseBodyStart extends TeaModel {
        // 日期，格式：yyyyMMdd
        @NameInMap("date")
        public String date;

        // 时间戳，按照ISO 8601格式
        @NameInMap("dateTime")
        public String dateTime;

        // 时区
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

    public static class GetEventResponseBodyRecurrencePattern extends TeaModel {
        // 循环模式类型(type: daily, weekly, absoluteMonthly, relativeMonthly, absoluteYearly, relativeYearly)
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

        public static GetEventResponseBodyRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyRecurrencePattern self = new GetEventResponseBodyRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
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

    }

    public static class GetEventResponseBodyRecurrenceRange extends TeaModel {
        // 范围类型(endDate, noEnd, numbered)
        @NameInMap("type")
        public String type;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        public static GetEventResponseBodyRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyRecurrenceRange self = new GetEventResponseBodyRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
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

    }

    public static class GetEventResponseBodyRecurrence extends TeaModel {
        // 重复模式
        @NameInMap("pattern")
        public GetEventResponseBodyRecurrencePattern pattern;

        // 重复范围
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

    public static class GetEventResponseBodyAttendees extends TeaModel {
        @NameInMap("id")
        public String id;

        // 用户名
        @NameInMap("displayName")
        public String displayName;

        // 回复状态
        @NameInMap("responseStatus")
        public String responseStatus;

        // 是否是当前登陆用户
        @NameInMap("self")
        public Boolean self;

        public static GetEventResponseBodyAttendees build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyAttendees self = new GetEventResponseBodyAttendees();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetEventResponseBodyAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
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

    public static class GetEventResponseBodyOrganizer extends TeaModel {
        @NameInMap("id")
        public String id;

        // 用户名
        @NameInMap("displayName")
        public String displayName;

        // 回复状态
        @NameInMap("responseStatus")
        public String responseStatus;

        // 是否是当前登陆用户
        @NameInMap("self")
        public Boolean self;

        public static GetEventResponseBodyOrganizer build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyOrganizer self = new GetEventResponseBodyOrganizer();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetEventResponseBodyOrganizer setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
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

    public static class GetEventResponseBodyLocation extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

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

    public static class GetEventResponseBodyOnlineMeetingInfo extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("url")
        public String url;

        @NameInMap("extraInfo")
        public java.util.Map<String, ?> extraInfo;

        public static GetEventResponseBodyOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            GetEventResponseBodyOnlineMeetingInfo self = new GetEventResponseBodyOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public GetEventResponseBodyOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetEventResponseBodyOnlineMeetingInfo setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public GetEventResponseBodyOnlineMeetingInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetEventResponseBodyOnlineMeetingInfo setExtraInfo(java.util.Map<String, ?> extraInfo) {
            this.extraInfo = extraInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtraInfo() {
            return this.extraInfo;
        }

    }

}
