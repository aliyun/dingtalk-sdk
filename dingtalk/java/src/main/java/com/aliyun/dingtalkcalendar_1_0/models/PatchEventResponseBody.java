// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class PatchEventResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    @NameInMap("summary")
    public String summary;

    @NameInMap("description")
    public String description;

    // 日程开始时间
    @NameInMap("start")
    public PatchEventResponseBodyStart start;

    @NameInMap("end")
    public PatchEventResponseBodyEnd end;

    @NameInMap("isAllDay")
    public Boolean isAllDay;

    @NameInMap("recurrence")
    public PatchEventResponseBodyRecurrence recurrence;

    @NameInMap("attendees")
    public java.util.List<PatchEventResponseBodyAttendees> attendees;

    @NameInMap("organizer")
    public PatchEventResponseBodyOrganizer organizer;

    @NameInMap("location")
    public PatchEventResponseBodyLocation location;

    // 创建时间
    @NameInMap("createTime")
    public String createTime;

    // 更新时间
    @NameInMap("updateTime")
    public String updateTime;

    public static PatchEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PatchEventResponseBody self = new PatchEventResponseBody();
        return TeaModel.build(map, self);
    }

    public PatchEventResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public PatchEventResponseBody setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public PatchEventResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public PatchEventResponseBody setStart(PatchEventResponseBodyStart start) {
        this.start = start;
        return this;
    }
    public PatchEventResponseBodyStart getStart() {
        return this.start;
    }

    public PatchEventResponseBody setEnd(PatchEventResponseBodyEnd end) {
        this.end = end;
        return this;
    }
    public PatchEventResponseBodyEnd getEnd() {
        return this.end;
    }

    public PatchEventResponseBody setIsAllDay(Boolean isAllDay) {
        this.isAllDay = isAllDay;
        return this;
    }
    public Boolean getIsAllDay() {
        return this.isAllDay;
    }

    public PatchEventResponseBody setRecurrence(PatchEventResponseBodyRecurrence recurrence) {
        this.recurrence = recurrence;
        return this;
    }
    public PatchEventResponseBodyRecurrence getRecurrence() {
        return this.recurrence;
    }

    public PatchEventResponseBody setAttendees(java.util.List<PatchEventResponseBodyAttendees> attendees) {
        this.attendees = attendees;
        return this;
    }
    public java.util.List<PatchEventResponseBodyAttendees> getAttendees() {
        return this.attendees;
    }

    public PatchEventResponseBody setOrganizer(PatchEventResponseBodyOrganizer organizer) {
        this.organizer = organizer;
        return this;
    }
    public PatchEventResponseBodyOrganizer getOrganizer() {
        return this.organizer;
    }

    public PatchEventResponseBody setLocation(PatchEventResponseBodyLocation location) {
        this.location = location;
        return this;
    }
    public PatchEventResponseBodyLocation getLocation() {
        return this.location;
    }

    public PatchEventResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public PatchEventResponseBody setUpdateTime(String updateTime) {
        this.updateTime = updateTime;
        return this;
    }
    public String getUpdateTime() {
        return this.updateTime;
    }

    public static class PatchEventResponseBodyStart extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static PatchEventResponseBodyStart build(java.util.Map<String, ?> map) throws Exception {
            PatchEventResponseBodyStart self = new PatchEventResponseBodyStart();
            return TeaModel.build(map, self);
        }

        public PatchEventResponseBodyStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public PatchEventResponseBodyStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public PatchEventResponseBodyStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class PatchEventResponseBodyEnd extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static PatchEventResponseBodyEnd build(java.util.Map<String, ?> map) throws Exception {
            PatchEventResponseBodyEnd self = new PatchEventResponseBodyEnd();
            return TeaModel.build(map, self);
        }

        public PatchEventResponseBodyEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public PatchEventResponseBodyEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public PatchEventResponseBodyEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class PatchEventResponseBodyRecurrencePattern extends TeaModel {
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

        public static PatchEventResponseBodyRecurrencePattern build(java.util.Map<String, ?> map) throws Exception {
            PatchEventResponseBodyRecurrencePattern self = new PatchEventResponseBodyRecurrencePattern();
            return TeaModel.build(map, self);
        }

        public PatchEventResponseBodyRecurrencePattern setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public PatchEventResponseBodyRecurrencePattern setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public PatchEventResponseBodyRecurrencePattern setDaysOfWeek(String daysOfWeek) {
            this.daysOfWeek = daysOfWeek;
            return this;
        }
        public String getDaysOfWeek() {
            return this.daysOfWeek;
        }

        public PatchEventResponseBodyRecurrencePattern setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public PatchEventResponseBodyRecurrencePattern setInterval(Integer interval) {
            this.interval = interval;
            return this;
        }
        public Integer getInterval() {
            return this.interval;
        }

    }

    public static class PatchEventResponseBodyRecurrenceRange extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("numberOfOccurrences")
        public Integer numberOfOccurrences;

        public static PatchEventResponseBodyRecurrenceRange build(java.util.Map<String, ?> map) throws Exception {
            PatchEventResponseBodyRecurrenceRange self = new PatchEventResponseBodyRecurrenceRange();
            return TeaModel.build(map, self);
        }

        public PatchEventResponseBodyRecurrenceRange setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public PatchEventResponseBodyRecurrenceRange setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public PatchEventResponseBodyRecurrenceRange setNumberOfOccurrences(Integer numberOfOccurrences) {
            this.numberOfOccurrences = numberOfOccurrences;
            return this;
        }
        public Integer getNumberOfOccurrences() {
            return this.numberOfOccurrences;
        }

    }

    public static class PatchEventResponseBodyRecurrence extends TeaModel {
        @NameInMap("pattern")
        public PatchEventResponseBodyRecurrencePattern pattern;

        @NameInMap("range")
        public PatchEventResponseBodyRecurrenceRange range;

        public static PatchEventResponseBodyRecurrence build(java.util.Map<String, ?> map) throws Exception {
            PatchEventResponseBodyRecurrence self = new PatchEventResponseBodyRecurrence();
            return TeaModel.build(map, self);
        }

        public PatchEventResponseBodyRecurrence setPattern(PatchEventResponseBodyRecurrencePattern pattern) {
            this.pattern = pattern;
            return this;
        }
        public PatchEventResponseBodyRecurrencePattern getPattern() {
            return this.pattern;
        }

        public PatchEventResponseBodyRecurrence setRange(PatchEventResponseBodyRecurrenceRange range) {
            this.range = range;
            return this;
        }
        public PatchEventResponseBodyRecurrenceRange getRange() {
            return this.range;
        }

    }

    public static class PatchEventResponseBodyAttendees extends TeaModel {
        @NameInMap("id")
        public String id;

        // 用户名
        @NameInMap("displayName")
        public String displayName;

        // 回复状态
        @NameInMap("responseStatus")
        public String responseStatus;

        // 是否是当前登陆用户
        @NameInMap("self")
        public Boolean self;

        public static PatchEventResponseBodyAttendees build(java.util.Map<String, ?> map) throws Exception {
            PatchEventResponseBodyAttendees self = new PatchEventResponseBodyAttendees();
            return TeaModel.build(map, self);
        }

        public PatchEventResponseBodyAttendees setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PatchEventResponseBodyAttendees setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public PatchEventResponseBodyAttendees setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public PatchEventResponseBodyAttendees setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class PatchEventResponseBodyOrganizer extends TeaModel {
        @NameInMap("id")
        public String id;

        // 用户名
        @NameInMap("displayName")
        public String displayName;

        // 回复状态
        @NameInMap("responseStatus")
        public String responseStatus;

        // 是否是当前登陆用户
        @NameInMap("self")
        public Boolean self;

        public static PatchEventResponseBodyOrganizer build(java.util.Map<String, ?> map) throws Exception {
            PatchEventResponseBodyOrganizer self = new PatchEventResponseBodyOrganizer();
            return TeaModel.build(map, self);
        }

        public PatchEventResponseBodyOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PatchEventResponseBodyOrganizer setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public PatchEventResponseBodyOrganizer setResponseStatus(String responseStatus) {
            this.responseStatus = responseStatus;
            return this;
        }
        public String getResponseStatus() {
            return this.responseStatus;
        }

        public PatchEventResponseBodyOrganizer setSelf(Boolean self) {
            this.self = self;
            return this;
        }
        public Boolean getSelf() {
            return this.self;
        }

    }

    public static class PatchEventResponseBodyLocation extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        public static PatchEventResponseBodyLocation build(java.util.Map<String, ?> map) throws Exception {
            PatchEventResponseBodyLocation self = new PatchEventResponseBodyLocation();
            return TeaModel.build(map, self);
        }

        public PatchEventResponseBodyLocation setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

}
