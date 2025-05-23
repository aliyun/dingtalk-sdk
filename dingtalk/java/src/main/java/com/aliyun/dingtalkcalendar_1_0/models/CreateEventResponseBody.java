// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateEventResponseBody extends TeaModel {
    @NameInMap("attendees")
    public java.util.List<CreateEventResponseBodyAttendees> attendees;

    @NameInMap("cardInstances")
    public java.util.List<CreateEventResponseBodyCardInstances> cardInstances;

    @NameInMap("categories")
    public java.util.List<CreateEventResponseBodyCategories> categories;

    /**
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("createTime")
    public String createTime;

    @NameInMap("description")
    public String description;

    @NameInMap("end")
    public CreateEventResponseBodyEnd end;

    @NameInMap("id")
    public String id;

    @NameInMap("isAllDay")
    public Boolean isAllDay;

    @NameInMap("location")
    public CreateEventResponseBodyLocation location;

    @NameInMap("onlineMeetingInfo")
    public CreateEventResponseBodyOnlineMeetingInfo onlineMeetingInfo;

    @NameInMap("organizer")
    public CreateEventResponseBodyOrganizer organizer;

    @NameInMap("recurrence")
    public CreateEventResponseBodyRecurrence recurrence;

    @NameInMap("reminders")
    public java.util.List<CreateEventResponseBodyReminders> reminders;

    @NameInMap("richTextDescription")
    public CreateEventResponseBodyRichTextDescription richTextDescription;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("start")
    public CreateEventResponseBodyStart start;

    @NameInMap("summary")
    public String summary;

    @NameInMap("uiConfigs")
    public java.util.List<CreateEventResponseBodyUiConfigs> uiConfigs;

    /**
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("updateTime")
    public String updateTime;

    public static CreateEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateEventResponseBody self = new CreateEventResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateEventResponseBody setAttendees(java.util.List<CreateEventResponseBodyAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<CreateEventResponseBodyAttendees> getAttendees() {
        return this.attendees;
    }

    public CreateEventResponseBody setCardInstances(java.util.List<CreateEventResponseBodyCardInstances> cardInstances) {
        this.cardInstances = cardInstances;
        return this;
    }
    public java.util.List<CreateEventResponseBodyCardInstances> getCardInstances() {
        return this.cardInstances;
    }

    public CreateEventResponseBody setCategories(java.util.List<CreateEventResponseBodyCategories> categories) {
        this.categories = categories;
        return this;
    }
    public java.util.List<CreateEventResponseBodyCategories> getCategories() {
        return this.categories;
    }

    public CreateEventResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public CreateEventResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateEventResponseBody setEnd(CreateEventResponseBodyEnd end) {
        this.end = end;
        return this;
    }
    public CreateEventResponseBodyEnd getEnd() {
        return this.end;
    }

    public CreateEventResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateEventResponseBody setIsAllDay(Boolean isAllDay) {
        this.isAllDay = isAllDay;
        return this;
    }
    public Boolean getIsAllDay() {
        return this.isAllDay;
    }

    public CreateEventResponseBody setLocation(CreateEventResponseBodyLocation location) {
        this.location = location;
        return this;
    }
    public CreateEventResponseBodyLocation getLocation() {
        return this.location;
    }

    public CreateEventResponseBody setOnlineMeetingInfo(CreateEventResponseBodyOnlineMeetingInfo onlineMeetingInfo) {
        this.onlineMeetingInfo = onlineMeetingInfo;
        return this;
    }
    public CreateEventResponseBodyOnlineMeetingInfo getOnlineMeetingInfo() {
        return this.onlineMeetingInfo;
    }

    public CreateEventResponseBody setOrganizer(CreateEventResponseBodyOrganizer organizer) {
        this.organizer = organizer;
        return this;
    }
    public CreateEventResponseBodyOrganizer getOrganizer() {
        return this.organizer;
    }

    public CreateEventResponseBody setRecurrence(CreateEventResponseBodyRecurrence recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public CreateEventResponseBodyRecurrence getRecurrence() {
        return this.recurrence;
    }

    public CreateEventResponseBody setReminders(java.util.List<CreateEventResponseBodyReminders> reminders) {
        this.reminders = reminders;
        return this;
    }
    public java.util.List<CreateEventResponseBodyReminders> getReminders() {
        return this.reminders;
    }

    public CreateEventResponseBody setRichTextDescription(CreateEventResponseBodyRichTextDescription richTextDescription) {
        this.richTextDescription = richTextDescription;
        return this;
    }
    public CreateEventResponseBodyRichTextDescription getRichTextDescription() {
        return this.richTextDescription;
    }

    public CreateEventResponseBody setStart(CreateEventResponseBodyStart start) {
        this.start = start;
        return this;
    }
    public CreateEventResponseBodyStart getStart() {
        return this.start;
    }

    public CreateEventResponseBody setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public CreateEventResponseBody setUiConfigs(java.util.List<CreateEventResponseBodyUiConfigs> uiConfigs) {
        this.uiConfigs = uiConfigs;
        return this;
    }
    public java.util.List<CreateEventResponseBodyUiConfigs> getUiConfigs() {
        return this.uiConfigs;
    }

    public CreateEventResponseBody setUpdateTime(String updateTime) {
        this.updateTime = updateTime;
        return this;
    }
    public String getUpdateTime() {
        return this.updateTime;
    }

    public static class CreateEventResponseBodyAttendees extends TeaModel {
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

        public static CreateEventResponseBodyAttendees build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyAttendees self = new CreateEventResponseBodyAttendees();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public CreateEventResponseBodyAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateEventResponseBodyAttendees setIsOptional(Boolean isOptional) {
            this.isOptional = isOptional;
            return this;
        }
        public Boolean getIsOptional() {
            return this.isOptional;
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

    public static class CreateEventResponseBodyCardInstances extends TeaModel {
        @NameInMap("outTrackId")
        public String outTrackId;

        @NameInMap("scenario")
        public String scenario;

        public static CreateEventResponseBodyCardInstances build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyCardInstances self = new CreateEventResponseBodyCardInstances();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyCardInstances setOutTrackId(String outTrackId) {
            this.outTrackId = outTrackId;
            return this;
        }
        public String getOutTrackId() {
            return this.outTrackId;
        }

        public CreateEventResponseBodyCardInstances setScenario(String scenario) {
            this.scenario = scenario;
            return this;
        }
        public String getScenario() {
            return this.scenario;
        }

    }

    public static class CreateEventResponseBodyCategories extends TeaModel {
        @NameInMap("categoryId")
        public String categoryId;

        @NameInMap("displayName")
        public String displayName;

        public static CreateEventResponseBodyCategories build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyCategories self = new CreateEventResponseBodyCategories();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyCategories setCategoryId(String categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public String getCategoryId() {
            return this.categoryId;
        }

        public CreateEventResponseBodyCategories setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
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

    public static class CreateEventResponseBodyOnlineMeetingInfo extends TeaModel {
        @NameInMap("conferenceId")
        public String conferenceId;

        @NameInMap("extraInfo")
        public java.util.Map<String, ?> extraInfo;

        @NameInMap("type")
        public String type;

        @NameInMap("url")
        public String url;

        public static CreateEventResponseBodyOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyOnlineMeetingInfo self = new CreateEventResponseBodyOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyOnlineMeetingInfo setConferenceId(String conferenceId) {
            this.conferenceId = conferenceId;
            return this;
        }
        public String getConferenceId() {
            return this.conferenceId;
        }

        public CreateEventResponseBodyOnlineMeetingInfo setExtraInfo(java.util.Map<String, ?> extraInfo) {
            this.extraInfo = extraInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtraInfo() {
            return this.extraInfo;
        }

        public CreateEventResponseBodyOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CreateEventResponseBodyOnlineMeetingInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class CreateEventResponseBodyOrganizer extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("id")
        public String id;

        @NameInMap("responseStatus")
        public String responseStatus;

        @NameInMap("self")
        public Boolean self;

        public static CreateEventResponseBodyOrganizer build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyOrganizer self = new CreateEventResponseBodyOrganizer();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyOrganizer setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public CreateEventResponseBodyOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
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

    public static class CreateEventResponseBodyRecurrencePattern extends TeaModel {
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

        public static CreateEventResponseBodyRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyRecurrencePattern self = new CreateEventResponseBodyRecurrencePattern();
            return TeaModel.build(map, self);
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

        public CreateEventResponseBodyRecurrencePattern setFirstDayOfWeek(String firstDayOfWeek) {
            this.firstDayOfWeek = firstDayOfWeek;
            return this;
        }
        public String getFirstDayOfWeek() {
            return this.firstDayOfWeek;
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

        public CreateEventResponseBodyRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreateEventResponseBodyRecurrenceRange extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        @NameInMap("type")
        public String type;

        public static CreateEventResponseBodyRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyRecurrenceRange self = new CreateEventResponseBodyRecurrenceRange();
            return TeaModel.build(map, self);
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

        public CreateEventResponseBodyRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
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

    public static class CreateEventResponseBodyRichTextDescription extends TeaModel {
        @NameInMap("text")
        public String text;

        public static CreateEventResponseBodyRichTextDescription build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyRichTextDescription self = new CreateEventResponseBodyRichTextDescription();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyRichTextDescription setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

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

    public static class CreateEventResponseBodyUiConfigs extends TeaModel {
        @NameInMap("uiName")
        public String uiName;

        @NameInMap("uiStatus")
        public String uiStatus;

        public static CreateEventResponseBodyUiConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateEventResponseBodyUiConfigs self = new CreateEventResponseBodyUiConfigs();
            return TeaModel.build(map, self);
        }

        public CreateEventResponseBodyUiConfigs setUiName(String uiName) {
            this.uiName = uiName;
            return this;
        }
        public String getUiName() {
            return this.uiName;
        }

        public CreateEventResponseBodyUiConfigs setUiStatus(String uiStatus) {
            this.uiStatus = uiStatus;
            return this;
        }
        public String getUiStatus() {
            return this.uiStatus;
        }

    }

}
