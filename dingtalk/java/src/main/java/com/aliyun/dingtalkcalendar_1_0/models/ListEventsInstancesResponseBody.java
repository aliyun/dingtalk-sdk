// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsInstancesResponseBody extends TeaModel {
    /**
     * <p>日程</p>
     */
    @NameInMap("events")
    public java.util.List<ListEventsInstancesResponseBodyEvents> events;

    public static ListEventsInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListEventsInstancesResponseBody self = new ListEventsInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListEventsInstancesResponseBody setEvents(java.util.List<ListEventsInstancesResponseBodyEvents> events) {
        this.events = events;
        return this;
    }
    public java.util.List<ListEventsInstancesResponseBodyEvents> getEvents() {
        return this.events;
    }

    public static class ListEventsInstancesResponseBodyEventsAttendees extends TeaModel {
        /**
         * <p>用户名</p>
         */
        @NameInMap("displayName")
        public String displayName;

        /**
         * <p>用户id</p>
         */
        @NameInMap("id")
        public String id;

        @NameInMap("isOptional")
        public Boolean isOptional;

        /**
         * <p>回复状态</p>
         */
        @NameInMap("responseStatus")
        public String responseStatus;

        /**
         * <p>是否是当前登陆用户</p>
         */
        @NameInMap("self")
        public Boolean self;

        public static ListEventsInstancesResponseBodyEventsAttendees build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsAttendees self = new ListEventsInstancesResponseBodyEventsAttendees();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsInstancesResponseBodyEventsAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsInstancesResponseBodyEventsAttendees setIsOptional(Boolean isOptional) {
            this.isOptional = isOptional;
            return this;
        }
        public Boolean getIsOptional() {
            return this.isOptional;
        }

        public ListEventsInstancesResponseBodyEventsAttendees setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListEventsInstancesResponseBodyEventsAttendees setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class ListEventsInstancesResponseBodyEventsEnd extends TeaModel {
        /**
         * <p>日期，格式：yyyyMMdd</p>
         */
        @NameInMap("date")
        public String date;

        /**
         * <p>时间戳，按照ISO 8601格式</p>
         */
        @NameInMap("dateTime")
        public String dateTime;

        /**
         * <p>时区</p>
         */
        @NameInMap("timeZone")
        public String timeZone;

        public static ListEventsInstancesResponseBodyEventsEnd build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsEnd self = new ListEventsInstancesResponseBodyEventsEnd();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public ListEventsInstancesResponseBodyEventsEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public ListEventsInstancesResponseBodyEventsEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties extends TeaModel {
        @NameInMap("sourceOpenCid")
        public String sourceOpenCid;

        public static ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties self = new ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties setSourceOpenCid(String sourceOpenCid) {
            this.sourceOpenCid = sourceOpenCid;
            return this;
        }
        public String getSourceOpenCid() {
            return this.sourceOpenCid;
        }

    }

    public static class ListEventsInstancesResponseBodyEventsExtendedProperties extends TeaModel {
        @NameInMap("sharedProperties")
        public ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties sharedProperties;

        public static ListEventsInstancesResponseBodyEventsExtendedProperties build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsExtendedProperties self = new ListEventsInstancesResponseBodyEventsExtendedProperties();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsExtendedProperties setSharedProperties(ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties sharedProperties) {
            this.sharedProperties = sharedProperties;
            return this;
        }
        public ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties getSharedProperties() {
            return this.sharedProperties;
        }

    }

    public static class ListEventsInstancesResponseBodyEventsLocation extends TeaModel {
        /**
         * <p>展示名称</p>
         */
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("meetingRooms")
        public java.util.List<String> meetingRooms;

        public static ListEventsInstancesResponseBodyEventsLocation build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsLocation self = new ListEventsInstancesResponseBodyEventsLocation();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsInstancesResponseBodyEventsLocation setMeetingRooms(java.util.List<String> meetingRooms) {
            this.meetingRooms = meetingRooms;
            return this;
        }
        public java.util.List<String> getMeetingRooms() {
            return this.meetingRooms;
        }

    }

    public static class ListEventsInstancesResponseBodyEventsOnlineMeetingInfo extends TeaModel {
        /**
         * <p>会议ID</p>
         */
        @NameInMap("conferenceId")
        public String conferenceId;

        /**
         * <p>线上会议类型，目前支持：  dingtalk：钉钉视频会议</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>会议url</p>
         */
        @NameInMap("url")
        public String url;

        public static ListEventsInstancesResponseBodyEventsOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsOnlineMeetingInfo self = new ListEventsInstancesResponseBodyEventsOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsOnlineMeetingInfo setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public ListEventsInstancesResponseBodyEventsOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListEventsInstancesResponseBodyEventsOnlineMeetingInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class ListEventsInstancesResponseBodyEventsOrganizer extends TeaModel {
        /**
         * <p>用户名</p>
         */
        @NameInMap("displayName")
        public String displayName;

        /**
         * <p>用户id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>回复状态</p>
         */
        @NameInMap("responseStatus")
        public String responseStatus;

        /**
         * <p>是否是当前登陆用户</p>
         */
        @NameInMap("self")
        public Boolean self;

        public static ListEventsInstancesResponseBodyEventsOrganizer build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsOrganizer self = new ListEventsInstancesResponseBodyEventsOrganizer();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsOrganizer setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsInstancesResponseBodyEventsOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsInstancesResponseBodyEventsOrganizer setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListEventsInstancesResponseBodyEventsOrganizer setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class ListEventsInstancesResponseBodyEventsRecurrencePattern extends TeaModel {
        /**
         * <p>每月的第几天</p>
         */
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        /**
         * <p>每周的第几天</p>
         */
        @NameInMap("daysOfWeek")
        public String daysOfWeek;

        /**
         * <p>指定事件发生在daysOfsWeek中指定的允许天数的哪个实例上，从该月的第一个实例开始计算。取值为:first, second, third, fourth, last。默认是first。如果类型是relativMonthly或relativeYear，则可选并使用</p>
         */
        @NameInMap("index")
        public String index;

        /**
         * <p>循环间隔</p>
         */
        @NameInMap("interval")
        public Integer interval;

        /**
         * <p>循环模式类型(type: daily, weekly, absoluteMonthly, relativeMonthly, absoluteYearly, relativeYearly)</p>
         */
        @NameInMap("type")
        public String type;

        public static ListEventsInstancesResponseBodyEventsRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsRecurrencePattern self = new ListEventsInstancesResponseBodyEventsRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public ListEventsInstancesResponseBodyEventsRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public ListEventsInstancesResponseBodyEventsRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public ListEventsInstancesResponseBodyEventsRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public ListEventsInstancesResponseBodyEventsRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListEventsInstancesResponseBodyEventsRecurrenceRange extends TeaModel {
        /**
         * <p>循环终止日期</p>
         */
        @NameInMap("endDate")
        public String endDate;

        /**
         * <p>循环出现次数</p>
         */
        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        /**
         * <p>范围类型(endDate, noEnd, numbered)</p>
         */
        @NameInMap("type")
        public String type;

        public static ListEventsInstancesResponseBodyEventsRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsRecurrenceRange self = new ListEventsInstancesResponseBodyEventsRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public ListEventsInstancesResponseBodyEventsRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

        public ListEventsInstancesResponseBodyEventsRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListEventsInstancesResponseBodyEventsRecurrence extends TeaModel {
        /**
         * <p>重复模式</p>
         */
        @NameInMap("pattern")
        public ListEventsInstancesResponseBodyEventsRecurrencePattern pattern;

        /**
         * <p>重复范围</p>
         */
        @NameInMap("range")
        public ListEventsInstancesResponseBodyEventsRecurrenceRange range;

        public static ListEventsInstancesResponseBodyEventsRecurrence build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsRecurrence self = new ListEventsInstancesResponseBodyEventsRecurrence();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsRecurrence setPattern(ListEventsInstancesResponseBodyEventsRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public ListEventsInstancesResponseBodyEventsRecurrencePattern getPattern() {
            return this.pattern;
        }

        public ListEventsInstancesResponseBodyEventsRecurrence setRange(ListEventsInstancesResponseBodyEventsRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public ListEventsInstancesResponseBodyEventsRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class ListEventsInstancesResponseBodyEventsReminders extends TeaModel {
        /**
         * <p>提醒方式</p>
         */
        @NameInMap("method")
        public String method;

        /**
         * <p>在日程开始前N分钟发出提醒</p>
         */
        @NameInMap("minutes")
        public String minutes;

        public static ListEventsInstancesResponseBodyEventsReminders build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsReminders self = new ListEventsInstancesResponseBodyEventsReminders();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsReminders setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public ListEventsInstancesResponseBodyEventsReminders setMinutes(String minutes) {
            this.minutes = minutes;
            return this;
        }
        public String getMinutes() {
            return this.minutes;
        }

    }

    public static class ListEventsInstancesResponseBodyEventsStart extends TeaModel {
        /**
         * <p>日期，格式：yyyyMMdd</p>
         */
        @NameInMap("date")
        public String date;

        /**
         * <p>时间戳，按照ISO 8601格式</p>
         */
        @NameInMap("dateTime")
        public String dateTime;

        /**
         * <p>时区</p>
         */
        @NameInMap("timeZone")
        public String timeZone;

        public static ListEventsInstancesResponseBodyEventsStart build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEventsStart self = new ListEventsInstancesResponseBodyEventsStart();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEventsStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public ListEventsInstancesResponseBodyEventsStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public ListEventsInstancesResponseBodyEventsStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class ListEventsInstancesResponseBodyEvents extends TeaModel {
        /**
         * <p>日程参与人</p>
         */
        @NameInMap("attendees")
        public java.util.List<ListEventsInstancesResponseBodyEventsAttendees> attendees;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>日程描述</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>日程结束时间</p>
         */
        @NameInMap("end")
        public ListEventsInstancesResponseBodyEventsEnd end;

        @NameInMap("extendedProperties")
        public ListEventsInstancesResponseBodyEventsExtendedProperties extendedProperties;

        /**
         * <p>日程事件id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>是否为全天日程</p>
         */
        @NameInMap("isAllDay")
        public Boolean isAllDay;

        /**
         * <p>日程地点</p>
         */
        @NameInMap("location")
        public ListEventsInstancesResponseBodyEventsLocation location;

        /**
         * <p>线上会议</p>
         */
        @NameInMap("onlineMeetingInfo")
        public ListEventsInstancesResponseBodyEventsOnlineMeetingInfo onlineMeetingInfo;

        /**
         * <p>日程组织人</p>
         */
        @NameInMap("organizer")
        public ListEventsInstancesResponseBodyEventsOrganizer organizer;

        /**
         * <p>日程重复规则</p>
         */
        @NameInMap("recurrence")
        public ListEventsInstancesResponseBodyEventsRecurrence recurrence;

        /**
         * <p>日程提醒</p>
         */
        @NameInMap("reminders")
        public java.util.List<ListEventsInstancesResponseBodyEventsReminders> reminders;

        /**
         * <p>重复日程的主日程id，非重复日程为空</p>
         */
        @NameInMap("seriesMasterId")
        public String seriesMasterId;

        /**
         * <p>日程开始时间</p>
         */
        @NameInMap("start")
        public ListEventsInstancesResponseBodyEventsStart start;

        /**
         * <p>日程状态</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>日程标题</p>
         */
        @NameInMap("summary")
        public String summary;

        /**
         * <p>更新时间</p>
         */
        @NameInMap("updateTime")
        public String updateTime;

        public static ListEventsInstancesResponseBodyEvents build(java.util.Map<String, ?> map) throws Exception {
            ListEventsInstancesResponseBodyEvents self = new ListEventsInstancesResponseBodyEvents();
            return TeaModel.build(map, self);
        }

        public ListEventsInstancesResponseBodyEvents setAttendees(java.util.List<ListEventsInstancesResponseBodyEventsAttendees> attendees) {
            this.attendees = attendees;
            return this;
        }
        public java.util.List<ListEventsInstancesResponseBodyEventsAttendees> getAttendees() {
            return this.attendees;
        }

        public ListEventsInstancesResponseBodyEvents setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListEventsInstancesResponseBodyEvents setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListEventsInstancesResponseBodyEvents setEnd(ListEventsInstancesResponseBodyEventsEnd end) {
            this.end = end;
            return this;
        }
        public ListEventsInstancesResponseBodyEventsEnd getEnd() {
            return this.end;
        }

        public ListEventsInstancesResponseBodyEvents setExtendedProperties(ListEventsInstancesResponseBodyEventsExtendedProperties extendedProperties) {
            this.extendedProperties = extendedProperties;
            return this;
        }
        public ListEventsInstancesResponseBodyEventsExtendedProperties getExtendedProperties() {
            return this.extendedProperties;
        }

        public ListEventsInstancesResponseBodyEvents setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsInstancesResponseBodyEvents setIsAllDay(Boolean isAllDay) {
            this.isAllDay = isAllDay;
            return this;
        }
        public Boolean getIsAllDay() {
            return this.isAllDay;
        }

        public ListEventsInstancesResponseBodyEvents setLocation(ListEventsInstancesResponseBodyEventsLocation location) {
            this.location = location;
            return this;
        }
        public ListEventsInstancesResponseBodyEventsLocation getLocation() {
            return this.location;
        }

        public ListEventsInstancesResponseBodyEvents setOnlineMeetingInfo(ListEventsInstancesResponseBodyEventsOnlineMeetingInfo onlineMeetingInfo) {
            this.onlineMeetingInfo = onlineMeetingInfo;
            return this;
        }
        public ListEventsInstancesResponseBodyEventsOnlineMeetingInfo getOnlineMeetingInfo() {
            return this.onlineMeetingInfo;
        }

        public ListEventsInstancesResponseBodyEvents setOrganizer(ListEventsInstancesResponseBodyEventsOrganizer organizer) {
            this.organizer = organizer;
            return this;
        }
        public ListEventsInstancesResponseBodyEventsOrganizer getOrganizer() {
            return this.organizer;
        }

        public ListEventsInstancesResponseBodyEvents setRecurrence(ListEventsInstancesResponseBodyEventsRecurrence recurrence) {
            this.recurrence = recurrence;
            return this;
        }
        public ListEventsInstancesResponseBodyEventsRecurrence getRecurrence() {
            return this.recurrence;
        }

        public ListEventsInstancesResponseBodyEvents setReminders(java.util.List<ListEventsInstancesResponseBodyEventsReminders> reminders) {
            this.reminders = reminders;
            return this;
        }
        public java.util.List<ListEventsInstancesResponseBodyEventsReminders> getReminders() {
            return this.reminders;
        }

        public ListEventsInstancesResponseBodyEvents setSeriesMasterId(String seriesMasterId) {
            this.seriesMasterId = seriesMasterId;
            return this;
        }
        public String getSeriesMasterId() {
            return this.seriesMasterId;
        }

        public ListEventsInstancesResponseBodyEvents setStart(ListEventsInstancesResponseBodyEventsStart start) {
            this.start = start;
            return this;
        }
        public ListEventsInstancesResponseBodyEventsStart getStart() {
            return this.start;
        }

        public ListEventsInstancesResponseBodyEvents setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListEventsInstancesResponseBodyEvents setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public ListEventsInstancesResponseBodyEvents setUpdateTime(String updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public String getUpdateTime() {
            return this.updateTime;
        }

    }

}
