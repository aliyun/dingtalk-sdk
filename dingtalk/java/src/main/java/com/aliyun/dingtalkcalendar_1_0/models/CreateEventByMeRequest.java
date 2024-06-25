// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateEventByMeRequest extends TeaModel {
    @NameInMap("attendees")
    public java.util.List<CreateEventByMeRequestAttendees> attendees;

    @NameInMap("description")
    public String description;

    @NameInMap("end")
    public CreateEventByMeRequestEnd end;

    @NameInMap("extra")
    public java.util.Map<String, String> extra;

    @NameInMap("isAllDay")
    public Boolean isAllDay;

    @NameInMap("location")
    public CreateEventByMeRequestLocation location;

    @NameInMap("onlineMeetingInfo")
    public CreateEventByMeRequestOnlineMeetingInfo onlineMeetingInfo;

    @NameInMap("recurrence")
    public CreateEventByMeRequestRecurrence recurrence;

    @NameInMap("reminders")
    public java.util.List<CreateEventByMeRequestReminders> reminders;

    @NameInMap("richTextDescription")
    public CreateEventByMeRequestRichTextDescription richTextDescription;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("start")
    public CreateEventByMeRequestStart start;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("summary")
    public String summary;

    @NameInMap("uiConfigs")
    public java.util.List<CreateEventByMeRequestUiConfigs> uiConfigs;

    public static CreateEventByMeRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateEventByMeRequest self = new CreateEventByMeRequest();
        return TeaModel.build(map, self);
    }

    public CreateEventByMeRequest setAttendees(java.util.List<CreateEventByMeRequestAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<CreateEventByMeRequestAttendees> getAttendees() {
        return this.attendees;
    }

    public CreateEventByMeRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateEventByMeRequest setEnd(CreateEventByMeRequestEnd end) {
        this.end = end;
        return this;
    }
    public CreateEventByMeRequestEnd getEnd() {
        return this.end;
    }

    public CreateEventByMeRequest setExtra(java.util.Map<String, String> extra) {
        this.extra = extra;
        return this;
    }
    public java.util.Map<String, String> getExtra() {
        return this.extra;
    }

    public CreateEventByMeRequest setIsAllDay(Boolean isAllDay) {
        this.isAllDay = isAllDay;
        return this;
    }
    public Boolean getIsAllDay() {
        return this.isAllDay;
    }

    public CreateEventByMeRequest setLocation(CreateEventByMeRequestLocation location) {
        this.location = location;
        return this;
    }
    public CreateEventByMeRequestLocation getLocation() {
        return this.location;
    }

    public CreateEventByMeRequest setOnlineMeetingInfo(CreateEventByMeRequestOnlineMeetingInfo onlineMeetingInfo) {
        this.onlineMeetingInfo = onlineMeetingInfo;
        return this;
    }
    public CreateEventByMeRequestOnlineMeetingInfo getOnlineMeetingInfo() {
        return this.onlineMeetingInfo;
    }

    public CreateEventByMeRequest setRecurrence(CreateEventByMeRequestRecurrence recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public CreateEventByMeRequestRecurrence getRecurrence() {
        return this.recurrence;
    }

    public CreateEventByMeRequest setReminders(java.util.List<CreateEventByMeRequestReminders> reminders) {
        this.reminders = reminders;
        return this;
    }
    public java.util.List<CreateEventByMeRequestReminders> getReminders() {
        return this.reminders;
    }

    public CreateEventByMeRequest setRichTextDescription(CreateEventByMeRequestRichTextDescription richTextDescription) {
        this.richTextDescription = richTextDescription;
        return this;
    }
    public CreateEventByMeRequestRichTextDescription getRichTextDescription() {
        return this.richTextDescription;
    }

    public CreateEventByMeRequest setStart(CreateEventByMeRequestStart start) {
        this.start = start;
        return this;
    }
    public CreateEventByMeRequestStart getStart() {
        return this.start;
    }

    public CreateEventByMeRequest setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public CreateEventByMeRequest setUiConfigs(java.util.List<CreateEventByMeRequestUiConfigs> uiConfigs) {
        this.uiConfigs = uiConfigs;
        return this;
    }
    public java.util.List<CreateEventByMeRequestUiConfigs> getUiConfigs() {
        return this.uiConfigs;
    }

    public static class CreateEventByMeRequestAttendees extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("isOptional")
        public Boolean isOptional;

        public static CreateEventByMeRequestAttendees build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeRequestAttendees self = new CreateEventByMeRequestAttendees();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeRequestAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CreateEventByMeRequestAttendees setIsOptional(Boolean isOptional) {
            this.isOptional = isOptional;
            return this;
        }
        public Boolean getIsOptional() {
            return this.isOptional;
        }

    }

    public static class CreateEventByMeRequestEnd extends TeaModel {
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

        public static CreateEventByMeRequestEnd build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeRequestEnd self = new CreateEventByMeRequestEnd();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeRequestEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CreateEventByMeRequestEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public CreateEventByMeRequestEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class CreateEventByMeRequestLocation extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        public static CreateEventByMeRequestLocation build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeRequestLocation self = new CreateEventByMeRequestLocation();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeRequestLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class CreateEventByMeRequestOnlineMeetingInfo extends TeaModel {
        @NameInMap("type")
        public String type;

        public static CreateEventByMeRequestOnlineMeetingInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeRequestOnlineMeetingInfo self = new CreateEventByMeRequestOnlineMeetingInfo();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeRequestOnlineMeetingInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreateEventByMeRequestRecurrencePattern extends TeaModel {
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

        public static CreateEventByMeRequestRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeRequestRecurrencePattern self = new CreateEventByMeRequestRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeRequestRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public CreateEventByMeRequestRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public CreateEventByMeRequestRecurrencePattern setFirstDayOfWeek(String firstDayOfWeek) {
            this.firstDayOfWeek = firstDayOfWeek;
            return this;
        }
        public String getFirstDayOfWeek() {
            return this.firstDayOfWeek;
        }

        public CreateEventByMeRequestRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public CreateEventByMeRequestRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

        public CreateEventByMeRequestRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreateEventByMeRequestRecurrenceRange extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        @NameInMap("type")
        public String type;

        public static CreateEventByMeRequestRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeRequestRecurrenceRange self = new CreateEventByMeRequestRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeRequestRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public CreateEventByMeRequestRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

        public CreateEventByMeRequestRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreateEventByMeRequestRecurrence extends TeaModel {
        @NameInMap("pattern")
        public CreateEventByMeRequestRecurrencePattern pattern;

        @NameInMap("range")
        public CreateEventByMeRequestRecurrenceRange range;

        public static CreateEventByMeRequestRecurrence build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeRequestRecurrence self = new CreateEventByMeRequestRecurrence();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeRequestRecurrence setPattern(CreateEventByMeRequestRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public CreateEventByMeRequestRecurrencePattern getPattern() {
            return this.pattern;
        }

        public CreateEventByMeRequestRecurrence setRange(CreateEventByMeRequestRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public CreateEventByMeRequestRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class CreateEventByMeRequestReminders extends TeaModel {
        @NameInMap("method")
        public String method;

        @NameInMap("minutes")
        public Integer minutes;

        public static CreateEventByMeRequestReminders build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeRequestReminders self = new CreateEventByMeRequestReminders();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeRequestReminders setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public CreateEventByMeRequestReminders setMinutes(Integer minutes) {
            this.minutes = minutes;
            return this;
        }
        public Integer getMinutes() {
            return this.minutes;
        }

    }

    public static class CreateEventByMeRequestRichTextDescription extends TeaModel {
        @NameInMap("text")
        public String text;

        public static CreateEventByMeRequestRichTextDescription build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeRequestRichTextDescription self = new CreateEventByMeRequestRichTextDescription();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeRequestRichTextDescription setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

    public static class CreateEventByMeRequestStart extends TeaModel {
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

        public static CreateEventByMeRequestStart build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeRequestStart self = new CreateEventByMeRequestStart();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeRequestStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CreateEventByMeRequestStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public CreateEventByMeRequestStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class CreateEventByMeRequestUiConfigs extends TeaModel {
        @NameInMap("uiName")
        public String uiName;

        @NameInMap("uiStatus")
        public String uiStatus;

        public static CreateEventByMeRequestUiConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateEventByMeRequestUiConfigs self = new CreateEventByMeRequestUiConfigs();
            return TeaModel.build(map, self);
        }

        public CreateEventByMeRequestUiConfigs setUiName(String uiName) {
            this.uiName = uiName;
            return this;
        }
        public String getUiName() {
            return this.uiName;
        }

        public CreateEventByMeRequestUiConfigs setUiStatus(String uiStatus) {
            this.uiStatus = uiStatus;
            return this;
        }
        public String getUiStatus() {
            return this.uiStatus;
        }

    }

}
