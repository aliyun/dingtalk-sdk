// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateEventRequest extends TeaModel {
    @NameInMap("attendees")
    public java.util.List<CreateEventRequestAttendees> attendees;

    @NameInMap("cardInstances")
    public java.util.List<CreateEventRequestCardInstances> cardInstances;

    @NameInMap("categories")
    public java.util.List<CreateEventRequestCategories> categories;

    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("end")
    public CreateEventRequestEnd end;

    @NameInMap("extra")
    public java.util.Map<String, String> extra;

    @NameInMap("freeBusyStatus")
    public String freeBusyStatus;

    @NameInMap("isAllDay")
    public Boolean isAllDay;

    @NameInMap("location")
    public CreateEventRequestLocation location;

    @NameInMap("onlineMeetingInfo")
    public CreateEventRequestOnlineMeetingInfo onlineMeetingInfo;

    @NameInMap("recurrence")
    public CreateEventRequestRecurrence recurrence;

    @NameInMap("reminders")
    public java.util.List<CreateEventRequestReminders> reminders;

    @NameInMap("richTextDescription")
    public CreateEventRequestRichTextDescription richTextDescription;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("start")
    public CreateEventRequestStart start;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("summary")
    public String summary;

    @NameInMap("uiConfigs")
    public java.util.List<CreateEventRequestUiConfigs> uiConfigs;

    public static CreateEventRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateEventRequest self = new CreateEventRequest();
        return TeaModel.build(map, self);
    }

    public CreateEventRequest setAttendees(java.util.List<CreateEventRequestAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<CreateEventRequestAttendees> getAttendees() {
        return this.attendees;
    }

    public CreateEventRequest setCardInstances(java.util.List<CreateEventRequestCardInstances> cardInstances) {
        this.cardInstances = cardInstances;
        return this;
    }
    public java.util.List<CreateEventRequestCardInstances> getCardInstances() {
        return this.cardInstances;
    }

    public CreateEventRequest setCategories(java.util.List<CreateEventRequestCategories> categories) {
        this.categories = categories;
        return this;
    }
    public java.util.List<CreateEventRequestCategories> getCategories() {
        return this.categories;
    }

    public CreateEventRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateEventRequest setEnd(CreateEventRequestEnd end) {
        this.end = end;
        return this;
    }
    public CreateEventRequestEnd getEnd() {
        return this.end;
    }

    public CreateEventRequest setExtra(java.util.Map<String, String> extra) {
        this.extra = extra;
        return this;
    }
    public java.util.Map<String, String> getExtra() {
        return this.extra;
    }

    public CreateEventRequest setFreeBusyStatus(String freeBusyStatus) {
        this.freeBusyStatus = freeBusyStatus;
        return this;
    }
    public String getFreeBusyStatus() {
        return this.freeBusyStatus;
    }

    public CreateEventRequest setIsAllDay(Boolean isAllDay) {
        this.isAllDay = isAllDay;
        return this;
    }
    public Boolean getIsAllDay() {
        return this.isAllDay;
    }

    public CreateEventRequest setLocation(CreateEventRequestLocation location) {
        this.location = location;
        return this;
    }
    public CreateEventRequestLocation getLocation() {
        return this.location;
    }

    public CreateEventRequest setOnlineMeetingInfo(CreateEventRequestOnlineMeetingInfo onlineMeetingInfo) {
        this.onlineMeetingInfo = onlineMeetingInfo;
        return this;
    }
    public CreateEventRequestOnlineMeetingInfo getOnlineMeetingInfo() {
        return this.onlineMeetingInfo;
    }

    public CreateEventRequest setRecurrence(CreateEventRequestRecurrence recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public CreateEventRequestRecurrence getRecurrence() {
        return this.recurrence;
    }

    public CreateEventRequest setReminders(java.util.List<CreateEventRequestReminders> reminders) {
        this.reminders = reminders;
        return this;
    }
    public java.util.List<CreateEventRequestReminders> getReminders() {
        return this.reminders;
    }

    public CreateEventRequest setRichTextDescription(CreateEventRequestRichTextDescription richTextDescription) {
        this.richTextDescription = richTextDescription;
        return this;
    }
    public CreateEventRequestRichTextDescription getRichTextDescription() {
        return this.richTextDescription;
    }

    public CreateEventRequest setStart(CreateEventRequestStart start) {
        this.start = start;
        return this;
    }
    public CreateEventRequestStart getStart() {
        return this.start;
    }

    public CreateEventRequest setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public CreateEventRequest setUiConfigs(java.util.List<CreateEventRequestUiConfigs> uiConfigs) {
        this.uiConfigs = uiConfigs;
        return this;
    }
    public java.util.List<CreateEventRequestUiConfigs> getUiConfigs() {
        return this.uiConfigs;
    }

    public static class CreateEventRequestAttendees extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("isOptional")
        public Boolean isOptional;

        public static CreateEventRequestAttendees build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestAttendees self = new CreateEventRequestAttendees();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateEventRequestAttendees setIsOptional(Boolean isOptional) {
            this.isOptional = isOptional;
            return this;
        }
        public Boolean getIsOptional() {
            return this.isOptional;
        }

    }

    public static class CreateEventRequestCardInstances extends TeaModel {
        @NameInMap("outTrackId")
        public String outTrackId;

        @NameInMap("scenario")
        public String scenario;

        public static CreateEventRequestCardInstances build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestCardInstances self = new CreateEventRequestCardInstances();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestCardInstances setOutTrackId(String outTrackId) {
            this.outTrackId = outTrackId;
            return this;
        }
        public String getOutTrackId() {
            return this.outTrackId;
        }

        public CreateEventRequestCardInstances setScenario(String scenario) {
            this.scenario = scenario;
            return this;
        }
        public String getScenario() {
            return this.scenario;
        }

    }

    public static class CreateEventRequestCategories extends TeaModel {
        @NameInMap("categoryId")
        public String categoryId;

        @NameInMap("displayName")
        public String displayName;

        public static CreateEventRequestCategories build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestCategories self = new CreateEventRequestCategories();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestCategories setCategoryId(String categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public String getCategoryId() {
            return this.categoryId;
        }

        public CreateEventRequestCategories setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class CreateEventRequestEnd extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2020-01-01</p>
         */
        @NameInMap("date")
        public String date;

        /**
         * <strong>example:</strong>
         * <p>2020-01-01T10:15:30+08:00</p>
         */
        @NameInMap("dateTime")
        public String dateTime;

        /**
         * <strong>example:</strong>
         * <p>Asia/Shanghai</p>
         */
        @NameInMap("timeZone")
        public String timeZone;

        public static CreateEventRequestEnd build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestEnd self = new CreateEventRequestEnd();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CreateEventRequestEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public CreateEventRequestEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class CreateEventRequestLocation extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        public static CreateEventRequestLocation build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestLocation self = new CreateEventRequestLocation();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class CreateEventRequestOnlineMeetingInfo extends TeaModel {
        @NameInMap("type")
        public String type;

        public static CreateEventRequestOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestOnlineMeetingInfo self = new CreateEventRequestOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreateEventRequestRecurrencePattern extends TeaModel {
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

        public static CreateEventRequestRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestRecurrencePattern self = new CreateEventRequestRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public CreateEventRequestRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public CreateEventRequestRecurrencePattern setFirstDayOfWeek(String firstDayOfWeek) {
            this.firstDayOfWeek = firstDayOfWeek;
            return this;
        }
        public String getFirstDayOfWeek() {
            return this.firstDayOfWeek;
        }

        public CreateEventRequestRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public CreateEventRequestRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public CreateEventRequestRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreateEventRequestRecurrenceRange extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        @NameInMap("type")
        public String type;

        public static CreateEventRequestRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestRecurrenceRange self = new CreateEventRequestRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public CreateEventRequestRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

        public CreateEventRequestRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreateEventRequestRecurrence extends TeaModel {
        @NameInMap("pattern")
        public CreateEventRequestRecurrencePattern pattern;

        @NameInMap("range")
        public CreateEventRequestRecurrenceRange range;

        public static CreateEventRequestRecurrence build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestRecurrence self = new CreateEventRequestRecurrence();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestRecurrence setPattern(CreateEventRequestRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public CreateEventRequestRecurrencePattern getPattern() {
            return this.pattern;
        }

        public CreateEventRequestRecurrence setRange(CreateEventRequestRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public CreateEventRequestRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class CreateEventRequestReminders extends TeaModel {
        @NameInMap("method")
        public String method;

        @NameInMap("minutes")
        public Integer minutes;

        public static CreateEventRequestReminders build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestReminders self = new CreateEventRequestReminders();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestReminders setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public CreateEventRequestReminders setMinutes(Integer minutes) {
            this.minutes = minutes;
            return this;
        }
        public Integer getMinutes() {
            return this.minutes;
        }

    }

    public static class CreateEventRequestRichTextDescription extends TeaModel {
        @NameInMap("text")
        public String text;

        public static CreateEventRequestRichTextDescription build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestRichTextDescription self = new CreateEventRequestRichTextDescription();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestRichTextDescription setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class CreateEventRequestStart extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2020-01-01</p>
         */
        @NameInMap("date")
        public String date;

        /**
         * <strong>example:</strong>
         * <p>2020-01-01T10:15:30+08:00</p>
         */
        @NameInMap("dateTime")
        public String dateTime;

        /**
         * <strong>example:</strong>
         * <p>Asia/Shanghai</p>
         */
        @NameInMap("timeZone")
        public String timeZone;

        public static CreateEventRequestStart build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestStart self = new CreateEventRequestStart();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CreateEventRequestStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public CreateEventRequestStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class CreateEventRequestUiConfigs extends TeaModel {
        @NameInMap("uiName")
        public String uiName;

        @NameInMap("uiStatus")
        public String uiStatus;

        public static CreateEventRequestUiConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestUiConfigs self = new CreateEventRequestUiConfigs();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestUiConfigs setUiName(String uiName) {
            this.uiName = uiName;
            return this;
        }
        public String getUiName() {
            return this.uiName;
        }

        public CreateEventRequestUiConfigs setUiStatus(String uiStatus) {
            this.uiStatus = uiStatus;
            return this;
        }
        public String getUiStatus() {
            return this.uiStatus;
        }

    }

}
