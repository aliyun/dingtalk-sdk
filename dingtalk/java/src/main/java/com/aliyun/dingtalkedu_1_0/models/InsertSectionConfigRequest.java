// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InsertSectionConfigRequest extends TeaModel {
    @NameInMap("end")
    public InsertSectionConfigRequestEnd end;

    @NameInMap("scheduleName")
    public String scheduleName;

    @NameInMap("sectionModels")
    public java.util.List<InsertSectionConfigRequestSectionModels> sectionModels;

    @NameInMap("start")
    public InsertSectionConfigRequestStart start;

    @NameInMap("opUserId")
    public String opUserId;

    public static InsertSectionConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        InsertSectionConfigRequest self = new InsertSectionConfigRequest();
        return TeaModel.build(map, self);
    }

    public InsertSectionConfigRequest setEnd(InsertSectionConfigRequestEnd end) {
        this.end = end;
        return this;
    }
    public InsertSectionConfigRequestEnd getEnd() {
        return this.end;
    }

    public InsertSectionConfigRequest setScheduleName(String scheduleName) {
        this.scheduleName = scheduleName;
        return this;
    }
    public String getScheduleName() {
        return this.scheduleName;
    }

    public InsertSectionConfigRequest setSectionModels(java.util.List<InsertSectionConfigRequestSectionModels> sectionModels) {
        this.sectionModels = sectionModels;
        return this;
    }
    public java.util.List<InsertSectionConfigRequestSectionModels> getSectionModels() {
        return this.sectionModels;
    }

    public InsertSectionConfigRequest setStart(InsertSectionConfigRequestStart start) {
        this.start = start;
        return this;
    }
    public InsertSectionConfigRequestStart getStart() {
        return this.start;
    }

    public InsertSectionConfigRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class InsertSectionConfigRequestEnd extends TeaModel {
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("month")
        public Integer month;

        @NameInMap("year")
        public Integer year;

        public static InsertSectionConfigRequestEnd build(java.util.Map<String, ?> map) throws Exception {
            InsertSectionConfigRequestEnd self = new InsertSectionConfigRequestEnd();
            return TeaModel.build(map, self);
        }

        public InsertSectionConfigRequestEnd setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public InsertSectionConfigRequestEnd setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public InsertSectionConfigRequestEnd setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

    }

    public static class InsertSectionConfigRequestSectionModelsEnd extends TeaModel {
        @NameInMap("hour")
        public Integer hour;

        @NameInMap("min")
        public Integer min;

        public static InsertSectionConfigRequestSectionModelsEnd build(java.util.Map<String, ?> map) throws Exception {
            InsertSectionConfigRequestSectionModelsEnd self = new InsertSectionConfigRequestSectionModelsEnd();
            return TeaModel.build(map, self);
        }

        public InsertSectionConfigRequestSectionModelsEnd setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

        public InsertSectionConfigRequestSectionModelsEnd setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

    }

    public static class InsertSectionConfigRequestSectionModelsStart extends TeaModel {
        @NameInMap("hour")
        public Integer hour;

        @NameInMap("min")
        public Integer min;

        public static InsertSectionConfigRequestSectionModelsStart build(java.util.Map<String, ?> map) throws Exception {
            InsertSectionConfigRequestSectionModelsStart self = new InsertSectionConfigRequestSectionModelsStart();
            return TeaModel.build(map, self);
        }

        public InsertSectionConfigRequestSectionModelsStart setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

        public InsertSectionConfigRequestSectionModelsStart setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

    }

    public static class InsertSectionConfigRequestSectionModels extends TeaModel {
        @NameInMap("end")
        public InsertSectionConfigRequestSectionModelsEnd end;

        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        @NameInMap("sectionName")
        public String sectionName;

        @NameInMap("sectionType")
        public String sectionType;

        @NameInMap("start")
        public InsertSectionConfigRequestSectionModelsStart start;

        public static InsertSectionConfigRequestSectionModels build(java.util.Map<String, ?> map) throws Exception {
            InsertSectionConfigRequestSectionModels self = new InsertSectionConfigRequestSectionModels();
            return TeaModel.build(map, self);
        }

        public InsertSectionConfigRequestSectionModels setEnd(InsertSectionConfigRequestSectionModelsEnd end) {
            this.end = end;
            return this;
        }
        public InsertSectionConfigRequestSectionModelsEnd getEnd() {
            return this.end;
        }

        public InsertSectionConfigRequestSectionModels setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
        }

        public InsertSectionConfigRequestSectionModels setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

        public InsertSectionConfigRequestSectionModels setSectionType(String sectionType) {
            this.sectionType = sectionType;
            return this;
        }
        public String getSectionType() {
            return this.sectionType;
        }

        public InsertSectionConfigRequestSectionModels setStart(InsertSectionConfigRequestSectionModelsStart start) {
            this.start = start;
            return this;
        }
        public InsertSectionConfigRequestSectionModelsStart getStart() {
            return this.start;
        }

    }

    public static class InsertSectionConfigRequestStart extends TeaModel {
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("month")
        public Integer month;

        @NameInMap("year")
        public Integer year;

        public static InsertSectionConfigRequestStart build(java.util.Map<String, ?> map) throws Exception {
            InsertSectionConfigRequestStart self = new InsertSectionConfigRequestStart();
            return TeaModel.build(map, self);
        }

        public InsertSectionConfigRequestStart setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public InsertSectionConfigRequestStart setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public InsertSectionConfigRequestStart setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

    }

}
