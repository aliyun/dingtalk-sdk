// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateEventRequest extends TeaModel {
    // 日程标题
    @NameInMap("summary")
    public String summary;

    // 日程描述
    @NameInMap("description")
    public String description;

    // 日程开始时间
    @NameInMap("start")
    public CreateEventRequestStart start;

    // 日程结束时间
    @NameInMap("end")
    public CreateEventRequestEnd end;

    // 是否为全天日程
    @NameInMap("isAllDay")
    public Boolean isAllDay;

    // 日程循环规则
    @NameInMap("recurrence")
    public CreateEventRequestRecurrence recurrence;

    @NameInMap("attendees")
    public java.util.List<CreateEventRequestAttendees> attendees;

    @NameInMap("location")
    public CreateEventRequestLocation location;

    public static CreateEventRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateEventRequest self = new CreateEventRequest();
        return TeaModel.build(map, self);
    }

    public CreateEventRequest setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public CreateEventRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateEventRequest setStart(CreateEventRequestStart start) {
        this.start = start;
        return this;
    }
    public CreateEventRequestStart getStart() {
        return this.start;
    }

    public CreateEventRequest setEnd(CreateEventRequestEnd end) {
        this.end = end;
        return this;
    }
    public CreateEventRequestEnd getEnd() {
        return this.end;
    }

    public CreateEventRequest setIsAllDay(Boolean isAllDay) {
        this.isAllDay = isAllDay;
        return this;
    }
    public Boolean getIsAllDay() {
        return this.isAllDay;
    }

    public CreateEventRequest setRecurrence(CreateEventRequestRecurrence recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public CreateEventRequestRecurrence getRecurrence() {
        return this.recurrence;
    }

    public CreateEventRequest setAttendees(java.util.List<CreateEventRequestAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<CreateEventRequestAttendees> getAttendees() {
        return this.attendees;
    }

    public CreateEventRequest setLocation(CreateEventRequestLocation location) {
        this.location = location;
        return this;
    }
    public CreateEventRequestLocation getLocation() {
        return this.location;
    }

    public static class CreateEventRequestStart extends TeaModel {
        // 日程开始日期，如果是全天日程必须有值，非全天日程必须留空，格式：yyyy-MM-dd
        @NameInMap("date")
        public String date;

        // 日程开始时间，非全天日程必须有值，全天日程必须留空，格式为ISO-8601的date-time格式
        @NameInMap("dateTime")
        public String dateTime;

        // 日程开始时间所属时区，非全天日程必须有值，全天日程必须留空，tz database name格式，参考：https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
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

    public static class CreateEventRequestEnd extends TeaModel {
        // 日程结束日期，如果是全天日程必须有值，非全天日程必须留空，格式：yyyy-MM-dd
        @NameInMap("date")
        public String date;

        // 日程结束时间，非全天日程必须有值，全天日程必须留空，格式为ISO-8601的date-time格式
        @NameInMap("dateTime")
        public String dateTime;

        // 日程结束时间所属时区，非全天日程必须有值，全天日程必须留空，tz database name格式，参考：https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
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

    public static class CreateEventRequestRecurrencePattern extends TeaModel {
        // 循环规则类型：  daily：每interval天 weekly：每interval周的第daysOfWeek天 absoluteMonthly：每interval月的第dayOfMonth天 relativeMonthly：每interval月的第index周的第daysOfWeek天 absoluteYearly：每interval年
        // 
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

        public static CreateEventRequestRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestRecurrencePattern self = new CreateEventRequestRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
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

    }

    public static class CreateEventRequestRecurrenceRange extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        public static CreateEventRequestRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            CreateEventRequestRecurrenceRange self = new CreateEventRequestRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public CreateEventRequestRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
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

    }

    public static class CreateEventRequestRecurrence extends TeaModel {
        // 循环规则
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

    public static class CreateEventRequestAttendees extends TeaModel {
        @NameInMap("id")
        public String id;

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

}
