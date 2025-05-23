// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class PatchEventRequest extends TeaModel {
    @NameInMap("attendees")
    public java.util.List<PatchEventRequestAttendees> attendees;

    @NameInMap("cardInstances")
    public java.util.List<PatchEventRequestCardInstances> cardInstances;

    @NameInMap("categories")
    public java.util.List<PatchEventRequestCategories> categories;

    @NameInMap("description")
    public String description;

    @NameInMap("end")
    public PatchEventRequestEnd end;

    @NameInMap("extra")
    public java.util.Map<String, String> extra;

    @NameInMap("freeBusyStatus")
    public String freeBusyStatus;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("id")
    public String id;

    @NameInMap("isAllDay")
    public Boolean isAllDay;

    @NameInMap("location")
    public PatchEventRequestLocation location;

    @NameInMap("onlineMeetingInfo")
    public PatchEventRequestOnlineMeetingInfo onlineMeetingInfo;

    @NameInMap("recurrence")
    public PatchEventRequestRecurrence recurrence;

    @NameInMap("reminders")
    public java.util.List<PatchEventRequestReminders> reminders;

    @NameInMap("richTextDescription")
    public PatchEventRequestRichTextDescription richTextDescription;

    @NameInMap("start")
    public PatchEventRequestStart start;

    @NameInMap("summary")
    public String summary;

    @NameInMap("uiConfigs")
    public java.util.List<PatchEventRequestUiConfigs> uiConfigs;

    public static PatchEventRequest build(java.util.Map<String, ?> map) throws Exception {
        PatchEventRequest self = new PatchEventRequest();
        return TeaModel.build(map, self);
    }

    public PatchEventRequest setAttendees(java.util.List<PatchEventRequestAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<PatchEventRequestAttendees> getAttendees() {
        return this.attendees;
    }

    public PatchEventRequest setCardInstances(java.util.List<PatchEventRequestCardInstances> cardInstances) {
        this.cardInstances = cardInstances;
        return this;
    }
    public java.util.List<PatchEventRequestCardInstances> getCardInstances() {
        return this.cardInstances;
    }

    public PatchEventRequest setCategories(java.util.List<PatchEventRequestCategories> categories) {
        this.categories = categories;
        return this;
    }
    public java.util.List<PatchEventRequestCategories> getCategories() {
        return this.categories;
    }

    public PatchEventRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public PatchEventRequest setEnd(PatchEventRequestEnd end) {
        this.end = end;
        return this;
    }
    public PatchEventRequestEnd getEnd() {
        return this.end;
    }

    public PatchEventRequest setExtra(java.util.Map<String, String> extra) {
        this.extra = extra;
        return this;
    }
    public java.util.Map<String, String> getExtra() {
        return this.extra;
    }

    public PatchEventRequest setFreeBusyStatus(String freeBusyStatus) {
        this.freeBusyStatus = freeBusyStatus;
        return this;
    }
    public String getFreeBusyStatus() {
        return this.freeBusyStatus;
    }

    public PatchEventRequest setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public PatchEventRequest setIsAllDay(Boolean isAllDay) {
        this.isAllDay = isAllDay;
        return this;
    }
    public Boolean getIsAllDay() {
        return this.isAllDay;
    }

    public PatchEventRequest setLocation(PatchEventRequestLocation location) {
        this.location = location;
        return this;
    }
    public PatchEventRequestLocation getLocation() {
        return this.location;
    }

    public PatchEventRequest setOnlineMeetingInfo(PatchEventRequestOnlineMeetingInfo onlineMeetingInfo) {
        this.onlineMeetingInfo = onlineMeetingInfo;
        return this;
    }
    public PatchEventRequestOnlineMeetingInfo getOnlineMeetingInfo() {
        return this.onlineMeetingInfo;
    }

    public PatchEventRequest setRecurrence(PatchEventRequestRecurrence recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public PatchEventRequestRecurrence getRecurrence() {
        return this.recurrence;
    }

    public PatchEventRequest setReminders(java.util.List<PatchEventRequestReminders> reminders) {
        this.reminders = reminders;
        return this;
    }
    public java.util.List<PatchEventRequestReminders> getReminders() {
        return this.reminders;
    }

    public PatchEventRequest setRichTextDescription(PatchEventRequestRichTextDescription richTextDescription) {
        this.richTextDescription = richTextDescription;
        return this;
    }
    public PatchEventRequestRichTextDescription getRichTextDescription() {
        return this.richTextDescription;
    }

    public PatchEventRequest setStart(PatchEventRequestStart start) {
        this.start = start;
        return this;
    }
    public PatchEventRequestStart getStart() {
        return this.start;
    }

    public PatchEventRequest setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public PatchEventRequest setUiConfigs(java.util.List<PatchEventRequestUiConfigs> uiConfigs) {
        this.uiConfigs = uiConfigs;
        return this;
    }
    public java.util.List<PatchEventRequestUiConfigs> getUiConfigs() {
        return this.uiConfigs;
    }

    public static class PatchEventRequestAttendees extends TeaModel {
        @NameInMap("email")
        public String email;

        @NameInMap("id")
        public String id;

        @NameInMap("isOptional")
        public Boolean isOptional;

        public static PatchEventRequestAttendees build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestAttendees self = new PatchEventRequestAttendees();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestAttendees setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public PatchEventRequestAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PatchEventRequestAttendees setIsOptional(Boolean isOptional) {
            this.isOptional = isOptional;
            return this;
        }
        public Boolean getIsOptional() {
            return this.isOptional;
        }

    }

    public static class PatchEventRequestCardInstances extends TeaModel {
        @NameInMap("outTrackId")
        public String outTrackId;

        @NameInMap("scenario")
        public String scenario;

        public static PatchEventRequestCardInstances build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestCardInstances self = new PatchEventRequestCardInstances();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestCardInstances setOutTrackId(String outTrackId) {
            this.outTrackId = outTrackId;
            return this;
        }
        public String getOutTrackId() {
            return this.outTrackId;
        }

        public PatchEventRequestCardInstances setScenario(String scenario) {
            this.scenario = scenario;
            return this;
        }
        public String getScenario() {
            return this.scenario;
        }

    }

    public static class PatchEventRequestCategories extends TeaModel {
        @NameInMap("categoryId")
        public String categoryId;

        @NameInMap("displayName")
        public String displayName;

        public static PatchEventRequestCategories build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestCategories self = new PatchEventRequestCategories();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestCategories setCategoryId(String categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public String getCategoryId() {
            return this.categoryId;
        }

        public PatchEventRequestCategories setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class PatchEventRequestEnd extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static PatchEventRequestEnd build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestEnd self = new PatchEventRequestEnd();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public PatchEventRequestEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public PatchEventRequestEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class PatchEventRequestLocation extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        public static PatchEventRequestLocation build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestLocation self = new PatchEventRequestLocation();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class PatchEventRequestOnlineMeetingInfo extends TeaModel {
        @NameInMap("type")
        public String type;

        public static PatchEventRequestOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestOnlineMeetingInfo self = new PatchEventRequestOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class PatchEventRequestRecurrencePattern extends TeaModel {
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

        public static PatchEventRequestRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestRecurrencePattern self = new PatchEventRequestRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public PatchEventRequestRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public PatchEventRequestRecurrencePattern setFirstDayOfWeek(String firstDayOfWeek) {
            this.firstDayOfWeek = firstDayOfWeek;
            return this;
        }
        public String getFirstDayOfWeek() {
            return this.firstDayOfWeek;
        }

        public PatchEventRequestRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public PatchEventRequestRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public PatchEventRequestRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class PatchEventRequestRecurrenceRange extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        @NameInMap("type")
        public String type;

        public static PatchEventRequestRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestRecurrenceRange self = new PatchEventRequestRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public PatchEventRequestRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

        public PatchEventRequestRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class PatchEventRequestRecurrence extends TeaModel {
        @NameInMap("pattern")
        public PatchEventRequestRecurrencePattern pattern;

        @NameInMap("range")
        public PatchEventRequestRecurrenceRange range;

        public static PatchEventRequestRecurrence build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestRecurrence self = new PatchEventRequestRecurrence();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestRecurrence setPattern(PatchEventRequestRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public PatchEventRequestRecurrencePattern getPattern() {
            return this.pattern;
        }

        public PatchEventRequestRecurrence setRange(PatchEventRequestRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public PatchEventRequestRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class PatchEventRequestReminders extends TeaModel {
        @NameInMap("method")
        public String method;

        @NameInMap("minutes")
        public Integer minutes;

        public static PatchEventRequestReminders build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestReminders self = new PatchEventRequestReminders();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestReminders setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public PatchEventRequestReminders setMinutes(Integer minutes) {
            this.minutes = minutes;
            return this;
        }
        public Integer getMinutes() {
            return this.minutes;
        }

    }

    public static class PatchEventRequestRichTextDescription extends TeaModel {
        @NameInMap("text")
        public String text;

        public static PatchEventRequestRichTextDescription build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestRichTextDescription self = new PatchEventRequestRichTextDescription();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestRichTextDescription setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class PatchEventRequestStart extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static PatchEventRequestStart build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestStart self = new PatchEventRequestStart();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public PatchEventRequestStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public PatchEventRequestStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class PatchEventRequestUiConfigs extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("uiName")
        public String uiName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("uiStatus")
        public String uiStatus;

        public static PatchEventRequestUiConfigs build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestUiConfigs self = new PatchEventRequestUiConfigs();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestUiConfigs setUiName(String uiName) {
            this.uiName = uiName;
            return this;
        }
        public String getUiName() {
            return this.uiName;
        }

        public PatchEventRequestUiConfigs setUiStatus(String uiStatus) {
            this.uiStatus = uiStatus;
            return this;
        }
        public String getUiStatus() {
            return this.uiStatus;
        }

    }

}
