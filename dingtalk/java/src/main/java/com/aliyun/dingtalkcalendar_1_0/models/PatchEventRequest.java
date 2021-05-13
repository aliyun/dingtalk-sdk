// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class PatchEventRequest extends TeaModel {
    // 日程标题
    @NameInMap("summary")
    public String summary;

    // 日程id
    @NameInMap("id")
    public String id;

    @NameInMap("description")
    public String description;

    // 日程开始时间
    @NameInMap("start")
    public PatchEventRequestStart start;

    @NameInMap("end")
    public PatchEventRequestEnd end;

    @NameInMap("isAllDay")
    public Boolean isAllDay;

    @NameInMap("recurrence")
    public PatchEventRequestRecurrence recurrence;

    @NameInMap("attendees")
    public java.util.List<PatchEventRequestAttendees> attendees;

    @NameInMap("location")
    public PatchEventRequestLocation location;

    // 扩展信息
    @NameInMap("extra")
    public java.util.Map<String, String> extra;

    public static PatchEventRequest build(java.util.Map<String, ?> map) throws Exception {
        PatchEventRequest self = new PatchEventRequest();
        return TeaModel.build(map, self);
    }

    public PatchEventRequest setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public PatchEventRequest setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public PatchEventRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public PatchEventRequest setStart(PatchEventRequestStart start) {
        this.start = start;
        return this;
    }
    public PatchEventRequestStart getStart() {
        return this.start;
    }

    public PatchEventRequest setEnd(PatchEventRequestEnd end) {
        this.end = end;
        return this;
    }
    public PatchEventRequestEnd getEnd() {
        return this.end;
    }

    public PatchEventRequest setIsAllDay(Boolean isAllDay) {
        this.isAllDay = isAllDay;
        return this;
    }
    public Boolean getIsAllDay() {
        return this.isAllDay;
    }

    public PatchEventRequest setRecurrence(PatchEventRequestRecurrence recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public PatchEventRequestRecurrence getRecurrence() {
        return this.recurrence;
    }

    public PatchEventRequest setAttendees(java.util.List<PatchEventRequestAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<PatchEventRequestAttendees> getAttendees() {
        return this.attendees;
    }

    public PatchEventRequest setLocation(PatchEventRequestLocation location) {
        this.location = location;
        return this;
    }
    public PatchEventRequestLocation getLocation() {
        return this.location;
    }

    public PatchEventRequest setExtra(java.util.Map<String, String> extra) {
        this.extra = extra;
        return this;
    }
    public java.util.Map<String, String> getExtra() {
        return this.extra;
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

    public static class PatchEventRequestRecurrencePattern extends TeaModel {
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

        public static PatchEventRequestRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestRecurrencePattern self = new PatchEventRequestRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
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

    }

    public static class PatchEventRequestRecurrenceRange extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        public static PatchEventRequestRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestRecurrenceRange self = new PatchEventRequestRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
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

    public static class PatchEventRequestAttendees extends TeaModel {
        @NameInMap("id")
        public String id;

        public static PatchEventRequestAttendees build(java.util.Map<String, ?> map) throws Exception {
            PatchEventRequestAttendees self = new PatchEventRequestAttendees();
            return TeaModel.build(map, self);
        }

        public PatchEventRequestAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
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

}
