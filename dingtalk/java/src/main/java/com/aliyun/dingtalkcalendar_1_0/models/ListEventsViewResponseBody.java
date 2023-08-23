// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsViewResponseBody extends TeaModel {
    @NameInMap("events")
    public java.util.List<ListEventsViewResponseBodyEvents> events;

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

    public static class ListEventsViewResponseBodyEventsCategories extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        public static ListEventsViewResponseBodyEventsCategories build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsCategories self = new ListEventsViewResponseBodyEventsCategories();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsCategories setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
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
        @NameInMap("belongCorpId")
        public String belongCorpId;

        @NameInMap("sourceOpenCid")
        public String sourceOpenCid;

        public static ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties self = new ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties setBelongCorpId(String belongCorpId) {
            this.belongCorpId = belongCorpId;
            return this;
        }
        public String getBelongCorpId() {
            return this.belongCorpId;
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

    public static class ListEventsViewResponseBodyEventsMeetingRooms extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("roomId")
        public String roomId;

        public static ListEventsViewResponseBodyEventsMeetingRooms build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsMeetingRooms self = new ListEventsViewResponseBodyEventsMeetingRooms();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsMeetingRooms setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsViewResponseBodyEventsMeetingRooms setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListEventsViewResponseBodyEventsMeetingRooms setRoomId(String roomId) {
            this.roomId = roomId;
            return this;
        }
        public String getRoomId() {
            return this.roomId;
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
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("id")
        public String id;

        @NameInMap("responseStatus")
        public String responseStatus;

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

    public static class ListEventsViewResponseBodyEventsOriginStart extends TeaModel {
        @NameInMap("dateTime")
        public String dateTime;

        public static ListEventsViewResponseBodyEventsOriginStart build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsOriginStart self = new ListEventsViewResponseBodyEventsOriginStart();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsOriginStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

    }

    public static class ListEventsViewResponseBodyEventsRecurrencePattern extends TeaModel {
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

        public ListEventsViewResponseBodyEventsRecurrencePattern setFirstDayOfWeek(String firstDayOfWeek) {
            this.firstDayOfWeek = firstDayOfWeek;
            return this;
        }
        public String getFirstDayOfWeek() {
            return this.firstDayOfWeek;
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
        @NameInMap("pattern")
        public ListEventsViewResponseBodyEventsRecurrencePattern pattern;

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

    public static class ListEventsViewResponseBodyEventsRichTextDescription extends TeaModel {
        @NameInMap("text")
        public String text;

        public static ListEventsViewResponseBodyEventsRichTextDescription build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewResponseBodyEventsRichTextDescription self = new ListEventsViewResponseBodyEventsRichTextDescription();
            return TeaModel.build(map, self);
        }

        public ListEventsViewResponseBodyEventsRichTextDescription setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class ListEventsViewResponseBodyEventsStart extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

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
        @NameInMap("attendees")
        public java.util.List<ListEventsViewResponseBodyEventsAttendees> attendees;

        @NameInMap("categories")
        public java.util.List<ListEventsViewResponseBodyEventsCategories> categories;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("description")
        public String description;

        @NameInMap("end")
        public ListEventsViewResponseBodyEventsEnd end;

        @NameInMap("extendedProperties")
        public ListEventsViewResponseBodyEventsExtendedProperties extendedProperties;

        @NameInMap("id")
        public String id;

        @NameInMap("isAllDay")
        public Boolean isAllDay;

        @NameInMap("location")
        public ListEventsViewResponseBodyEventsLocation location;

        @NameInMap("meetingRooms")
        public java.util.List<ListEventsViewResponseBodyEventsMeetingRooms> meetingRooms;

        @NameInMap("onlineMeetingInfo")
        public ListEventsViewResponseBodyEventsOnlineMeetingInfo onlineMeetingInfo;

        @NameInMap("organizer")
        public ListEventsViewResponseBodyEventsOrganizer organizer;

        @NameInMap("originStart")
        public ListEventsViewResponseBodyEventsOriginStart originStart;

        @NameInMap("recurrence")
        public ListEventsViewResponseBodyEventsRecurrence recurrence;

        @NameInMap("richTextDescription")
        public ListEventsViewResponseBodyEventsRichTextDescription richTextDescription;

        @NameInMap("seriesMasterId")
        public String seriesMasterId;

        @NameInMap("start")
        public ListEventsViewResponseBodyEventsStart start;

        @NameInMap("status")
        public String status;

        @NameInMap("summary")
        public String summary;

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

        public ListEventsViewResponseBodyEvents setCategories(java.util.List<ListEventsViewResponseBodyEventsCategories> categories) {
            this.categories = categories;
            return this;
        }
        public java.util.List<ListEventsViewResponseBodyEventsCategories> getCategories() {
            return this.categories;
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

        public ListEventsViewResponseBodyEvents setMeetingRooms(java.util.List<ListEventsViewResponseBodyEventsMeetingRooms> meetingRooms) {
            this.meetingRooms = meetingRooms;
            return this;
        }
        public java.util.List<ListEventsViewResponseBodyEventsMeetingRooms> getMeetingRooms() {
            return this.meetingRooms;
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

        public ListEventsViewResponseBodyEvents setOriginStart(ListEventsViewResponseBodyEventsOriginStart originStart) {
            this.originStart = originStart;
            return this;
        }
        public ListEventsViewResponseBodyEventsOriginStart getOriginStart() {
            return this.originStart;
        }

        public ListEventsViewResponseBodyEvents setRecurrence(ListEventsViewResponseBodyEventsRecurrence recurrence) {
            this.recurrence = recurrence;
            return this;
        }
        public ListEventsViewResponseBodyEventsRecurrence getRecurrence() {
            return this.recurrence;
        }

        public ListEventsViewResponseBodyEvents setRichTextDescription(ListEventsViewResponseBodyEventsRichTextDescription richTextDescription) {
            this.richTextDescription = richTextDescription;
            return this;
        }
        public ListEventsViewResponseBodyEventsRichTextDescription getRichTextDescription() {
            return this.richTextDescription;
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
