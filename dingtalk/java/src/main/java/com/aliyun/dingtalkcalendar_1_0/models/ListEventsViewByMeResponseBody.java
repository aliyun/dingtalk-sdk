// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListEventsViewByMeResponseBody extends TeaModel {
    @NameInMap("events")
    public java.util.List<ListEventsViewByMeResponseBodyEvents> events;

    @NameInMap("nextToken")
    public String nextToken;

    public static ListEventsViewByMeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListEventsViewByMeResponseBody self = new ListEventsViewByMeResponseBody();
        return TeaModel.build(map, self);
    }

    public ListEventsViewByMeResponseBody setEvents(java.util.List<ListEventsViewByMeResponseBodyEvents> events) {
        this.events = events;
        return this;
    }
    public java.util.List<ListEventsViewByMeResponseBodyEvents> getEvents() {
        return this.events;
    }

    public ListEventsViewByMeResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListEventsViewByMeResponseBodyEventsAttendees extends TeaModel {
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

        public static ListEventsViewByMeResponseBodyEventsAttendees build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsAttendees self = new ListEventsViewByMeResponseBodyEventsAttendees();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsViewByMeResponseBodyEventsAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsViewByMeResponseBodyEventsAttendees setIsOptional(Boolean isOptional) {
            this.isOptional = isOptional;
            return this;
        }
        public Boolean getIsOptional() {
            return this.isOptional;
        }

        public ListEventsViewByMeResponseBodyEventsAttendees setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListEventsViewByMeResponseBodyEventsAttendees setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsCategories extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        public static ListEventsViewByMeResponseBodyEventsCategories build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsCategories self = new ListEventsViewByMeResponseBodyEventsCategories();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsCategories setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsEnd extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static ListEventsViewByMeResponseBodyEventsEnd build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsEnd self = new ListEventsViewByMeResponseBodyEventsEnd();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public ListEventsViewByMeResponseBodyEventsEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public ListEventsViewByMeResponseBodyEventsEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties extends TeaModel {
        @NameInMap("belongCorpId")
        public String belongCorpId;

        @NameInMap("sourceOpenCid")
        public String sourceOpenCid;

        public static ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties self = new ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties setBelongCorpId(String belongCorpId) {
            this.belongCorpId = belongCorpId;
            return this;
        }
        public String getBelongCorpId() {
            return this.belongCorpId;
        }

        public ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties setSourceOpenCid(String sourceOpenCid) {
            this.sourceOpenCid = sourceOpenCid;
            return this;
        }
        public String getSourceOpenCid() {
            return this.sourceOpenCid;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsExtendedProperties extends TeaModel {
        @NameInMap("sharedProperties")
        public ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties sharedProperties;

        public static ListEventsViewByMeResponseBodyEventsExtendedProperties build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsExtendedProperties self = new ListEventsViewByMeResponseBodyEventsExtendedProperties();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsExtendedProperties setSharedProperties(ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties sharedProperties) {
            this.sharedProperties = sharedProperties;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties getSharedProperties() {
            return this.sharedProperties;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsLocation extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("meetingRooms")
        public java.util.List<String> meetingRooms;

        public static ListEventsViewByMeResponseBodyEventsLocation build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsLocation self = new ListEventsViewByMeResponseBodyEventsLocation();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsViewByMeResponseBodyEventsLocation setMeetingRooms(java.util.List<String> meetingRooms) {
            this.meetingRooms = meetingRooms;
            return this;
        }
        public java.util.List<String> getMeetingRooms() {
            return this.meetingRooms;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsMeetingRooms extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("roomId")
        public String roomId;

        public static ListEventsViewByMeResponseBodyEventsMeetingRooms build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsMeetingRooms self = new ListEventsViewByMeResponseBodyEventsMeetingRooms();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsMeetingRooms setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsViewByMeResponseBodyEventsMeetingRooms setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListEventsViewByMeResponseBodyEventsMeetingRooms setRoomId(String roomId) {
            this.roomId = roomId;
            return this;
        }
        public String getRoomId() {
            return this.roomId;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo extends TeaModel {
        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("extraInfo")
        public java.util.Map<String, ?> extraInfo;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo self = new ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo setExtraInfo(java.util.Map<String, ?> extraInfo) {
            this.extraInfo = extraInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtraInfo() {
            return this.extraInfo;
        }

        public ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsOrganizer extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("id")
        public String id;

        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("self")
        public Boolean self;

        public static ListEventsViewByMeResponseBodyEventsOrganizer build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsOrganizer self = new ListEventsViewByMeResponseBodyEventsOrganizer();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsOrganizer setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListEventsViewByMeResponseBodyEventsOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsViewByMeResponseBodyEventsOrganizer setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public ListEventsViewByMeResponseBodyEventsOrganizer setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsOriginStart extends TeaModel {
        @NameInMap("dateTime")
        public String dateTime;

        public static ListEventsViewByMeResponseBodyEventsOriginStart build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsOriginStart self = new ListEventsViewByMeResponseBodyEventsOriginStart();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsOriginStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsRecurrencePattern extends TeaModel {
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

        public static ListEventsViewByMeResponseBodyEventsRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsRecurrencePattern self = new ListEventsViewByMeResponseBodyEventsRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public ListEventsViewByMeResponseBodyEventsRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public ListEventsViewByMeResponseBodyEventsRecurrencePattern setFirstDayOfWeek(String firstDayOfWeek) {
            this.firstDayOfWeek = firstDayOfWeek;
            return this;
        }
        public String getFirstDayOfWeek() {
            return this.firstDayOfWeek;
        }

        public ListEventsViewByMeResponseBodyEventsRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public ListEventsViewByMeResponseBodyEventsRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public ListEventsViewByMeResponseBodyEventsRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsRecurrenceRange extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        @NameInMap("type")
        public String type;

        public static ListEventsViewByMeResponseBodyEventsRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsRecurrenceRange self = new ListEventsViewByMeResponseBodyEventsRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public ListEventsViewByMeResponseBodyEventsRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

        public ListEventsViewByMeResponseBodyEventsRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsRecurrence extends TeaModel {
        @NameInMap("pattern")
        public ListEventsViewByMeResponseBodyEventsRecurrencePattern pattern;

        @NameInMap("range")
        public ListEventsViewByMeResponseBodyEventsRecurrenceRange range;

        public static ListEventsViewByMeResponseBodyEventsRecurrence build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsRecurrence self = new ListEventsViewByMeResponseBodyEventsRecurrence();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsRecurrence setPattern(ListEventsViewByMeResponseBodyEventsRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsRecurrencePattern getPattern() {
            return this.pattern;
        }

        public ListEventsViewByMeResponseBodyEventsRecurrence setRange(ListEventsViewByMeResponseBodyEventsRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsRichTextDescription extends TeaModel {
        @NameInMap("text")
        public String text;

        public static ListEventsViewByMeResponseBodyEventsRichTextDescription build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsRichTextDescription self = new ListEventsViewByMeResponseBodyEventsRichTextDescription();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsRichTextDescription setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class ListEventsViewByMeResponseBodyEventsStart extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static ListEventsViewByMeResponseBodyEventsStart build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEventsStart self = new ListEventsViewByMeResponseBodyEventsStart();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEventsStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public ListEventsViewByMeResponseBodyEventsStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public ListEventsViewByMeResponseBodyEventsStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class ListEventsViewByMeResponseBodyEvents extends TeaModel {
        @NameInMap("attendees")
        public java.util.List<ListEventsViewByMeResponseBodyEventsAttendees> attendees;

        @NameInMap("categories")
        public java.util.List<ListEventsViewByMeResponseBodyEventsCategories> categories;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("description")
        public String description;

        @NameInMap("end")
        public ListEventsViewByMeResponseBodyEventsEnd end;

        @NameInMap("extendedProperties")
        public ListEventsViewByMeResponseBodyEventsExtendedProperties extendedProperties;

        @NameInMap("id")
        public String id;

        @NameInMap("isAllDay")
        public Boolean isAllDay;

        @NameInMap("location")
        public ListEventsViewByMeResponseBodyEventsLocation location;

        @NameInMap("meetingRooms")
        public java.util.List<ListEventsViewByMeResponseBodyEventsMeetingRooms> meetingRooms;

        @NameInMap("onlineMeetingInfo")
        public ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo onlineMeetingInfo;

        @NameInMap("organizer")
        public ListEventsViewByMeResponseBodyEventsOrganizer organizer;

        @NameInMap("originStart")
        public ListEventsViewByMeResponseBodyEventsOriginStart originStart;

        @NameInMap("recurrence")
        public ListEventsViewByMeResponseBodyEventsRecurrence recurrence;

        @NameInMap("richTextDescription")
        public ListEventsViewByMeResponseBodyEventsRichTextDescription richTextDescription;

        @NameInMap("seriesMasterId")
        public String seriesMasterId;

        @NameInMap("start")
        public ListEventsViewByMeResponseBodyEventsStart start;

        @NameInMap("status")
        public String status;

        @NameInMap("summary")
        public String summary;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("updateTime")
        public String updateTime;

        public static ListEventsViewByMeResponseBodyEvents build(java.util.Map<String, ?> map) throws Exception {
            ListEventsViewByMeResponseBodyEvents self = new ListEventsViewByMeResponseBodyEvents();
            return TeaModel.build(map, self);
        }

        public ListEventsViewByMeResponseBodyEvents setAttendees(java.util.List<ListEventsViewByMeResponseBodyEventsAttendees> attendees) {
            this.attendees = attendees;
            return this;
        }
        public java.util.List<ListEventsViewByMeResponseBodyEventsAttendees> getAttendees() {
            return this.attendees;
        }

        public ListEventsViewByMeResponseBodyEvents setCategories(java.util.List<ListEventsViewByMeResponseBodyEventsCategories> categories) {
            this.categories = categories;
            return this;
        }
        public java.util.List<ListEventsViewByMeResponseBodyEventsCategories> getCategories() {
            return this.categories;
        }

        public ListEventsViewByMeResponseBodyEvents setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListEventsViewByMeResponseBodyEvents setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListEventsViewByMeResponseBodyEvents setEnd(ListEventsViewByMeResponseBodyEventsEnd end) {
            this.end = end;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsEnd getEnd() {
            return this.end;
        }

        public ListEventsViewByMeResponseBodyEvents setExtendedProperties(ListEventsViewByMeResponseBodyEventsExtendedProperties extendedProperties) {
            this.extendedProperties = extendedProperties;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsExtendedProperties getExtendedProperties() {
            return this.extendedProperties;
        }

        public ListEventsViewByMeResponseBodyEvents setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListEventsViewByMeResponseBodyEvents setIsAllDay(Boolean isAllDay) {
            this.isAllDay = isAllDay;
            return this;
        }
        public Boolean getIsAllDay() {
            return this.isAllDay;
        }

        public ListEventsViewByMeResponseBodyEvents setLocation(ListEventsViewByMeResponseBodyEventsLocation location) {
            this.location = location;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsLocation getLocation() {
            return this.location;
        }

        public ListEventsViewByMeResponseBodyEvents setMeetingRooms(java.util.List<ListEventsViewByMeResponseBodyEventsMeetingRooms> meetingRooms) {
            this.meetingRooms = meetingRooms;
            return this;
        }
        public java.util.List<ListEventsViewByMeResponseBodyEventsMeetingRooms> getMeetingRooms() {
            return this.meetingRooms;
        }

        public ListEventsViewByMeResponseBodyEvents setOnlineMeetingInfo(ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo onlineMeetingInfo) {
            this.onlineMeetingInfo = onlineMeetingInfo;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo getOnlineMeetingInfo() {
            return this.onlineMeetingInfo;
        }

        public ListEventsViewByMeResponseBodyEvents setOrganizer(ListEventsViewByMeResponseBodyEventsOrganizer organizer) {
            this.organizer = organizer;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsOrganizer getOrganizer() {
            return this.organizer;
        }

        public ListEventsViewByMeResponseBodyEvents setOriginStart(ListEventsViewByMeResponseBodyEventsOriginStart originStart) {
            this.originStart = originStart;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsOriginStart getOriginStart() {
            return this.originStart;
        }

        public ListEventsViewByMeResponseBodyEvents setRecurrence(ListEventsViewByMeResponseBodyEventsRecurrence recurrence) {
            this.recurrence = recurrence;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsRecurrence getRecurrence() {
            return this.recurrence;
        }

        public ListEventsViewByMeResponseBodyEvents setRichTextDescription(ListEventsViewByMeResponseBodyEventsRichTextDescription richTextDescription) {
            this.richTextDescription = richTextDescription;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsRichTextDescription getRichTextDescription() {
            return this.richTextDescription;
        }

        public ListEventsViewByMeResponseBodyEvents setSeriesMasterId(String seriesMasterId) {
            this.seriesMasterId = seriesMasterId;
            return this;
        }
        public String getSeriesMasterId() {
            return this.seriesMasterId;
        }

        public ListEventsViewByMeResponseBodyEvents setStart(ListEventsViewByMeResponseBodyEventsStart start) {
            this.start = start;
            return this;
        }
        public ListEventsViewByMeResponseBodyEventsStart getStart() {
            return this.start;
        }

        public ListEventsViewByMeResponseBodyEvents setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListEventsViewByMeResponseBodyEvents setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public ListEventsViewByMeResponseBodyEvents setUpdateTime(String updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public String getUpdateTime() {
            return this.updateTime;
        }

    }

}
