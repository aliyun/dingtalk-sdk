// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListInstancesResponseBody extends TeaModel {
    @NameInMap("events")
    public java.util.List<ListInstancesResponseBodyEvents> events;

    @NameInMap("nextToken")
    public String nextToken;

    public static ListInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListInstancesResponseBody self = new ListInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListInstancesResponseBody setEvents(java.util.List<ListInstancesResponseBodyEvents> events) {
        this.events = events;
        return this;
    }
    public java.util.List<ListInstancesResponseBodyEvents> getEvents() {
        return this.events;
    }

    public ListInstancesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListInstancesResponseBodyEventsAttendees extends TeaModel {
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

        public static ListInstancesResponseBodyEventsAttendees build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsAttendees self = new ListInstancesResponseBodyEventsAttendees();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListInstancesResponseBodyEventsAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListInstancesResponseBodyEventsAttendees setIsOptional(Boolean isOptional) {
            this.isOptional = isOptional;
            return this;
        }
        public Boolean getIsOptional() {
            return this.isOptional;
        }

        public ListInstancesResponseBodyEventsAttendees setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListInstancesResponseBodyEventsAttendees setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class ListInstancesResponseBodyEventsEnd extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static ListInstancesResponseBodyEventsEnd build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsEnd self = new ListInstancesResponseBodyEventsEnd();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public ListInstancesResponseBodyEventsEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public ListInstancesResponseBodyEventsEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties extends TeaModel {
        @NameInMap("belongCorpId")
        public String belongCorpId;

        @NameInMap("sourceOpenCid")
        public String sourceOpenCid;

        public static ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties self = new ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties setBelongCorpId(String belongCorpId) {
            this.belongCorpId = belongCorpId;
            return this;
        }
        public String getBelongCorpId() {
            return this.belongCorpId;
        }

        public ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties setSourceOpenCid(String sourceOpenCid) {
            this.sourceOpenCid = sourceOpenCid;
            return this;
        }
        public String getSourceOpenCid() {
            return this.sourceOpenCid;
        }

    }

    public static class ListInstancesResponseBodyEventsExtendedProperties extends TeaModel {
        @NameInMap("sharedProperties")
        public ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties sharedProperties;

        public static ListInstancesResponseBodyEventsExtendedProperties build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsExtendedProperties self = new ListInstancesResponseBodyEventsExtendedProperties();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsExtendedProperties setSharedProperties(ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties sharedProperties) {
            this.sharedProperties = sharedProperties;
            return this;
        }
        public ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties getSharedProperties() {
            return this.sharedProperties;
        }

    }

    public static class ListInstancesResponseBodyEventsLocation extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        public static ListInstancesResponseBodyEventsLocation build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsLocation self = new ListInstancesResponseBodyEventsLocation();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class ListInstancesResponseBodyEventsMeetingRooms extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("roomId")
        public String roomId;

        public static ListInstancesResponseBodyEventsMeetingRooms build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsMeetingRooms self = new ListInstancesResponseBodyEventsMeetingRooms();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsMeetingRooms setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListInstancesResponseBodyEventsMeetingRooms setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListInstancesResponseBodyEventsMeetingRooms setRoomId(String roomId) {
            this.roomId = roomId;
            return this;
        }
        public String getRoomId() {
            return this.roomId;
        }

    }

    public static class ListInstancesResponseBodyEventsOnlineMeetingInfo extends TeaModel {
        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("extraInfo")
        public java.util.Map<String, ?> extraInfo;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static ListInstancesResponseBodyEventsOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsOnlineMeetingInfo self = new ListInstancesResponseBodyEventsOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsOnlineMeetingInfo setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public ListInstancesResponseBodyEventsOnlineMeetingInfo setExtraInfo(java.util.Map<String, ?> extraInfo) {
            this.extraInfo = extraInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtraInfo() {
            return this.extraInfo;
        }

        public ListInstancesResponseBodyEventsOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListInstancesResponseBodyEventsOnlineMeetingInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class ListInstancesResponseBodyEventsOrganizer extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("id")
        public String id;

        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("self")
        public Boolean self;

        public static ListInstancesResponseBodyEventsOrganizer build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsOrganizer self = new ListInstancesResponseBodyEventsOrganizer();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsOrganizer setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListInstancesResponseBodyEventsOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListInstancesResponseBodyEventsOrganizer setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListInstancesResponseBodyEventsOrganizer setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class ListInstancesResponseBodyEventsRecurrencePattern extends TeaModel {
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("daysOfWeek")
        public String daysOfWeek;

        @NameInMap("index")
        public String index;

        @NameInMap("interval")
        public Integer interval;

        @NameInMap("type")
        public String type;

        public static ListInstancesResponseBodyEventsRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsRecurrencePattern self = new ListInstancesResponseBodyEventsRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public ListInstancesResponseBodyEventsRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public ListInstancesResponseBodyEventsRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public ListInstancesResponseBodyEventsRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public ListInstancesResponseBodyEventsRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListInstancesResponseBodyEventsRecurrenceRange extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        @NameInMap("type")
        public String type;

        public static ListInstancesResponseBodyEventsRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsRecurrenceRange self = new ListInstancesResponseBodyEventsRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public ListInstancesResponseBodyEventsRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

        public ListInstancesResponseBodyEventsRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListInstancesResponseBodyEventsRecurrence extends TeaModel {
        @NameInMap("pattern")
        public ListInstancesResponseBodyEventsRecurrencePattern pattern;

        @NameInMap("range")
        public ListInstancesResponseBodyEventsRecurrenceRange range;

        public static ListInstancesResponseBodyEventsRecurrence build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsRecurrence self = new ListInstancesResponseBodyEventsRecurrence();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsRecurrence setPattern(ListInstancesResponseBodyEventsRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public ListInstancesResponseBodyEventsRecurrencePattern getPattern() {
            return this.pattern;
        }

        public ListInstancesResponseBodyEventsRecurrence setRange(ListInstancesResponseBodyEventsRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public ListInstancesResponseBodyEventsRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class ListInstancesResponseBodyEventsReminders extends TeaModel {
        @NameInMap("method")
        public String method;

        @NameInMap("minutes")
        public String minutes;

        public static ListInstancesResponseBodyEventsReminders build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsReminders self = new ListInstancesResponseBodyEventsReminders();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsReminders setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public ListInstancesResponseBodyEventsReminders setMinutes(String minutes) {
            this.minutes = minutes;
            return this;
        }
        public String getMinutes() {
            return this.minutes;
        }

    }

    public static class ListInstancesResponseBodyEventsStart extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static ListInstancesResponseBodyEventsStart build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEventsStart self = new ListInstancesResponseBodyEventsStart();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEventsStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public ListInstancesResponseBodyEventsStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public ListInstancesResponseBodyEventsStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class ListInstancesResponseBodyEvents extends TeaModel {
        @NameInMap("attendees")
        public java.util.List<ListInstancesResponseBodyEventsAttendees> attendees;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("description")
        public String description;

        @NameInMap("end")
        public ListInstancesResponseBodyEventsEnd end;

        @NameInMap("extendedProperties")
        public ListInstancesResponseBodyEventsExtendedProperties extendedProperties;

        @NameInMap("id")
        public String id;

        @NameInMap("isAllDay")
        public Boolean isAllDay;

        @NameInMap("location")
        public ListInstancesResponseBodyEventsLocation location;

        @NameInMap("meetingRooms")
        public java.util.List<ListInstancesResponseBodyEventsMeetingRooms> meetingRooms;

        @NameInMap("onlineMeetingInfo")
        public ListInstancesResponseBodyEventsOnlineMeetingInfo onlineMeetingInfo;

        @NameInMap("organizer")
        public ListInstancesResponseBodyEventsOrganizer organizer;

        @NameInMap("recurrence")
        public ListInstancesResponseBodyEventsRecurrence recurrence;

        @NameInMap("reminders")
        public java.util.List<ListInstancesResponseBodyEventsReminders> reminders;

        @NameInMap("seriesMasterId")
        public String seriesMasterId;

        @NameInMap("start")
        public ListInstancesResponseBodyEventsStart start;

        @NameInMap("status")
        public String status;

        @NameInMap("summary")
        public String summary;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("updateTime")
        public String updateTime;

        public static ListInstancesResponseBodyEvents build(java.util.Map<String, ?> map) throws Exception {
            ListInstancesResponseBodyEvents self = new ListInstancesResponseBodyEvents();
            return TeaModel.build(map, self);
        }

        public ListInstancesResponseBodyEvents setAttendees(java.util.List<ListInstancesResponseBodyEventsAttendees> attendees) {
            this.attendees = attendees;
            return this;
        }
        public java.util.List<ListInstancesResponseBodyEventsAttendees> getAttendees() {
            return this.attendees;
        }

        public ListInstancesResponseBodyEvents setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListInstancesResponseBodyEvents setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListInstancesResponseBodyEvents setEnd(ListInstancesResponseBodyEventsEnd end) {
            this.end = end;
            return this;
        }
        public ListInstancesResponseBodyEventsEnd getEnd() {
            return this.end;
        }

        public ListInstancesResponseBodyEvents setExtendedProperties(ListInstancesResponseBodyEventsExtendedProperties extendedProperties) {
            this.extendedProperties = extendedProperties;
            return this;
        }
        public ListInstancesResponseBodyEventsExtendedProperties getExtendedProperties() {
            return this.extendedProperties;
        }

        public ListInstancesResponseBodyEvents setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListInstancesResponseBodyEvents setIsAllDay(Boolean isAllDay) {
            this.isAllDay = isAllDay;
            return this;
        }
        public Boolean getIsAllDay() {
            return this.isAllDay;
        }

        public ListInstancesResponseBodyEvents setLocation(ListInstancesResponseBodyEventsLocation location) {
            this.location = location;
            return this;
        }
        public ListInstancesResponseBodyEventsLocation getLocation() {
            return this.location;
        }

        public ListInstancesResponseBodyEvents setMeetingRooms(java.util.List<ListInstancesResponseBodyEventsMeetingRooms> meetingRooms) {
            this.meetingRooms = meetingRooms;
            return this;
        }
        public java.util.List<ListInstancesResponseBodyEventsMeetingRooms> getMeetingRooms() {
            return this.meetingRooms;
        }

        public ListInstancesResponseBodyEvents setOnlineMeetingInfo(ListInstancesResponseBodyEventsOnlineMeetingInfo onlineMeetingInfo) {
            this.onlineMeetingInfo = onlineMeetingInfo;
            return this;
        }
        public ListInstancesResponseBodyEventsOnlineMeetingInfo getOnlineMeetingInfo() {
            return this.onlineMeetingInfo;
        }

        public ListInstancesResponseBodyEvents setOrganizer(ListInstancesResponseBodyEventsOrganizer organizer) {
            this.organizer = organizer;
            return this;
        }
        public ListInstancesResponseBodyEventsOrganizer getOrganizer() {
            return this.organizer;
        }

        public ListInstancesResponseBodyEvents setRecurrence(ListInstancesResponseBodyEventsRecurrence recurrence) {
            this.recurrence = recurrence;
            return this;
        }
        public ListInstancesResponseBodyEventsRecurrence getRecurrence() {
            return this.recurrence;
        }

        public ListInstancesResponseBodyEvents setReminders(java.util.List<ListInstancesResponseBodyEventsReminders> reminders) {
            this.reminders = reminders;
            return this;
        }
        public java.util.List<ListInstancesResponseBodyEventsReminders> getReminders() {
            return this.reminders;
        }

        public ListInstancesResponseBodyEvents setSeriesMasterId(String seriesMasterId) {
            this.seriesMasterId = seriesMasterId;
            return this;
        }
        public String getSeriesMasterId() {
            return this.seriesMasterId;
        }

        public ListInstancesResponseBodyEvents setStart(ListInstancesResponseBodyEventsStart start) {
            this.start = start;
            return this;
        }
        public ListInstancesResponseBodyEventsStart getStart() {
            return this.start;
        }

        public ListInstancesResponseBodyEvents setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListInstancesResponseBodyEvents setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public ListInstancesResponseBodyEvents setUpdateTime(String updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public String getUpdateTime() {
            return this.updateTime;
        }

    }

}
