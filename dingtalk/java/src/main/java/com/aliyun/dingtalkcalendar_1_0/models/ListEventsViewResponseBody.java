// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsViewResponseBody extends TeaModel {
    // 日程
    @NameInMap("events")
    public java.util.List<ListEventsViewResponseBodyEvents> events;

    // 翻页token
    @NameInMap("nextToken")
    public String nextToken;

    public static ListEventsViewResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListEventsViewResponseBody self = new ListEventsViewResponseBody();
        return TeaModel.build(map, self);
    }

    public ListEventsViewResponseBody setEvents(java.util.List<ListEventsViewResponseBodyEvents> events) {
        this.events = events;
        return this;
    }
    public java.util.List<ListEventsViewResponseBodyEvents> getEvents() {
        return this.events;
    }

    public ListEventsViewResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListEventsViewResponseBodyEventsAttendees extends TeaModel {
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

        public static ListEventsViewResponseBodyEventsAttendees build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsAttendees self = new ListEventsViewResponseBodyEventsAttendees();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsViewResponseBodyEventsAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsViewResponseBodyEventsAttendees setIsOptional(Boolean isOptional) {
            this.isOptional = isOptional;
            return this;
        }
        public Boolean getIsOptional() {
            return this.isOptional;
        }

        public ListEventsViewResponseBodyEventsAttendees setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListEventsViewResponseBodyEventsAttendees setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class ListEventsViewResponseBodyEventsEnd extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static ListEventsViewResponseBodyEventsEnd build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsEnd self = new ListEventsViewResponseBodyEventsEnd();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public ListEventsViewResponseBodyEventsEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public ListEventsViewResponseBodyEventsEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties extends TeaModel {
        @NameInMap("sourceOpenCid")
        public String sourceOpenCid;

        public static ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties self = new ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties setSourceOpenCid(String sourceOpenCid) {
            this.sourceOpenCid = sourceOpenCid;
            return this;
        }
        public String getSourceOpenCid() {
            return this.sourceOpenCid;
        }

    }

    public static class ListEventsViewResponseBodyEventsExtendedProperties extends TeaModel {
        @NameInMap("sharedProperties")
        public ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties sharedProperties;

        public static ListEventsViewResponseBodyEventsExtendedProperties build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsExtendedProperties self = new ListEventsViewResponseBodyEventsExtendedProperties();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsExtendedProperties setSharedProperties(ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties sharedProperties) {
            this.sharedProperties = sharedProperties;
            return this;
        }
        public ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties getSharedProperties() {
            return this.sharedProperties;
        }

    }

    public static class ListEventsViewResponseBodyEventsLocation extends TeaModel {
        // 展示名称
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("meetingRooms")
        public java.util.List<String> meetingRooms;

        public static ListEventsViewResponseBodyEventsLocation build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsLocation self = new ListEventsViewResponseBodyEventsLocation();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsViewResponseBodyEventsLocation setMeetingRooms(java.util.List<String> meetingRooms) {
            this.meetingRooms = meetingRooms;
            return this;
        }
        public java.util.List<String> getMeetingRooms() {
            return this.meetingRooms;
        }

    }

    public static class ListEventsViewResponseBodyEventsOnlineMeetingInfo extends TeaModel {
        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("extraInfo")
        public java.util.Map<String, ?> extraInfo;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static ListEventsViewResponseBodyEventsOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsOnlineMeetingInfo self = new ListEventsViewResponseBodyEventsOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsOnlineMeetingInfo setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public ListEventsViewResponseBodyEventsOnlineMeetingInfo setExtraInfo(java.util.Map<String, ?> extraInfo) {
            this.extraInfo = extraInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtraInfo() {
            return this.extraInfo;
        }

        public ListEventsViewResponseBodyEventsOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListEventsViewResponseBodyEventsOnlineMeetingInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class ListEventsViewResponseBodyEventsOrganizer extends TeaModel {
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

        public static ListEventsViewResponseBodyEventsOrganizer build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsOrganizer self = new ListEventsViewResponseBodyEventsOrganizer();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsOrganizer setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsViewResponseBodyEventsOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsViewResponseBodyEventsOrganizer setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListEventsViewResponseBodyEventsOrganizer setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class ListEventsViewResponseBodyEventsRecurrencePattern extends TeaModel {
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

        public static ListEventsViewResponseBodyEventsRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsRecurrencePattern self = new ListEventsViewResponseBodyEventsRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public ListEventsViewResponseBodyEventsRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public ListEventsViewResponseBodyEventsRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public ListEventsViewResponseBodyEventsRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public ListEventsViewResponseBodyEventsRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListEventsViewResponseBodyEventsRecurrenceRange extends TeaModel {
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        // 范围类型(endDate, noEnd, numbered)
        @NameInMap("type")
        public String type;

        public static ListEventsViewResponseBodyEventsRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsRecurrenceRange self = new ListEventsViewResponseBodyEventsRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public ListEventsViewResponseBodyEventsRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

        public ListEventsViewResponseBodyEventsRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListEventsViewResponseBodyEventsRecurrence extends TeaModel {
        // 重复模式
        @NameInMap("pattern")
        public ListEventsViewResponseBodyEventsRecurrencePattern pattern;

        // 重复范围
        @NameInMap("range")
        public ListEventsViewResponseBodyEventsRecurrenceRange range;

        public static ListEventsViewResponseBodyEventsRecurrence build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsRecurrence self = new ListEventsViewResponseBodyEventsRecurrence();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsRecurrence setPattern(ListEventsViewResponseBodyEventsRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public ListEventsViewResponseBodyEventsRecurrencePattern getPattern() {
            return this.pattern;
        }

        public ListEventsViewResponseBodyEventsRecurrence setRange(ListEventsViewResponseBodyEventsRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public ListEventsViewResponseBodyEventsRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class ListEventsViewResponseBodyEventsStart extends TeaModel {
        // 日期，格式：yyyyMMdd
        @NameInMap("date")
        public String date;

        // 时间戳，按照ISO 8601格式
        @NameInMap("dateTime")
        public String dateTime;

        // 时区
        @NameInMap("timeZone")
        public String timeZone;

        public static ListEventsViewResponseBodyEventsStart build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsStart self = new ListEventsViewResponseBodyEventsStart();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public ListEventsViewResponseBodyEventsStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public ListEventsViewResponseBodyEventsStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class ListEventsViewResponseBodyEvents extends TeaModel {
        // 日程参与人
        @NameInMap("attendees")
        public java.util.List<ListEventsViewResponseBodyEventsAttendees> attendees;

        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 日程描述
        @NameInMap("description")
        public String description;

        // 日程结束时间
        @NameInMap("end")
        public ListEventsViewResponseBodyEventsEnd end;

        @NameInMap("extendedProperties")
        public ListEventsViewResponseBodyEventsExtendedProperties extendedProperties;

        // 日程事件id
        @NameInMap("id")
        public String id;

        // 是否为全天日程
        @NameInMap("isAllDay")
        public Boolean isAllDay;

        // 日程地点
        @NameInMap("location")
        public ListEventsViewResponseBodyEventsLocation location;

        @NameInMap("onlineMeetingInfo")
        public ListEventsViewResponseBodyEventsOnlineMeetingInfo onlineMeetingInfo;

        // 日程组织人
        @NameInMap("organizer")
        public ListEventsViewResponseBodyEventsOrganizer organizer;

        // 日程重复规则
        @NameInMap("recurrence")
        public ListEventsViewResponseBodyEventsRecurrence recurrence;

        // 重复日程的主日程id，非重复日程为空
        @NameInMap("seriesMasterId")
        public String seriesMasterId;

        // 日程开始时间
        @NameInMap("start")
        public ListEventsViewResponseBodyEventsStart start;

        // 日程状态
        @NameInMap("status")
        public String status;

        // 日程标题
        @NameInMap("summary")
        public String summary;

        // 更新时间
        @NameInMap("updateTime")
        public String updateTime;

        public static ListEventsViewResponseBodyEvents build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEvents self = new ListEventsViewResponseBodyEvents();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEvents setAttendees(java.util.List<ListEventsViewResponseBodyEventsAttendees> attendees) {
            this.attendees = attendees;
            return this;
        }
        public java.util.List<ListEventsViewResponseBodyEventsAttendees> getAttendees() {
            return this.attendees;
        }

        public ListEventsViewResponseBodyEvents setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListEventsViewResponseBodyEvents setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListEventsViewResponseBodyEvents setEnd(ListEventsViewResponseBodyEventsEnd end) {
            this.end = end;
            return this;
        }
        public ListEventsViewResponseBodyEventsEnd getEnd() {
            return this.end;
        }

        public ListEventsViewResponseBodyEvents setExtendedProperties(ListEventsViewResponseBodyEventsExtendedProperties extendedProperties) {
            this.extendedProperties = extendedProperties;
            return this;
        }
        public ListEventsViewResponseBodyEventsExtendedProperties getExtendedProperties() {
            return this.extendedProperties;
        }

        public ListEventsViewResponseBodyEvents setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsViewResponseBodyEvents setIsAllDay(Boolean isAllDay) {
            this.isAllDay = isAllDay;
            return this;
        }
        public Boolean getIsAllDay() {
            return this.isAllDay;
        }

        public ListEventsViewResponseBodyEvents setLocation(ListEventsViewResponseBodyEventsLocation location) {
            this.location = location;
            return this;
        }
        public ListEventsViewResponseBodyEventsLocation getLocation() {
            return this.location;
        }

        public ListEventsViewResponseBodyEvents setOnlineMeetingInfo(ListEventsViewResponseBodyEventsOnlineMeetingInfo onlineMeetingInfo) {
            this.onlineMeetingInfo = onlineMeetingInfo;
            return this;
        }
        public ListEventsViewResponseBodyEventsOnlineMeetingInfo getOnlineMeetingInfo() {
            return this.onlineMeetingInfo;
        }

        public ListEventsViewResponseBodyEvents setOrganizer(ListEventsViewResponseBodyEventsOrganizer organizer) {
            this.organizer = organizer;
            return this;
        }
        public ListEventsViewResponseBodyEventsOrganizer getOrganizer() {
            return this.organizer;
        }

        public ListEventsViewResponseBodyEvents setRecurrence(ListEventsViewResponseBodyEventsRecurrence recurrence) {
            this.recurrence = recurrence;
            return this;
        }
        public ListEventsViewResponseBodyEventsRecurrence getRecurrence() {
            return this.recurrence;
        }

        public ListEventsViewResponseBodyEvents setSeriesMasterId(String seriesMasterId) {
            this.seriesMasterId = seriesMasterId;
            return this;
        }
        public String getSeriesMasterId() {
            return this.seriesMasterId;
        }

        public ListEventsViewResponseBodyEvents setStart(ListEventsViewResponseBodyEventsStart start) {
            this.start = start;
            return this;
        }
        public ListEventsViewResponseBodyEventsStart getStart() {
            return this.start;
        }

        public ListEventsViewResponseBodyEvents setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListEventsViewResponseBodyEvents setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public ListEventsViewResponseBodyEvents setUpdateTime(String updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public String getUpdateTime() {
            return this.updateTime;
        }

    }

}
