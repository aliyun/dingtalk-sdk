// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InsertSectionConfigRequest extends TeaModel {
    // 节次模型
    @NameInMap("sectionModels")
    public java.util.List<InsertSectionConfigRequestSectionModels> sectionModels;

    // 开始日期
    @NameInMap("start")
    public InsertSectionConfigRequestStart start;

    // 结束日期
    @NameInMap("end")
    public InsertSectionConfigRequestEnd end;

    // 课程表名称
    @NameInMap("scheduleName")
    public String scheduleName;

    // 操作人的userid。
    @NameInMap("opUserId")
    public String opUserId;

    public static InsertSectionConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        InsertSectionConfigRequest self = new InsertSectionConfigRequest();
        return TeaModel.build(map, self);
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

    public InsertSectionConfigRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class InsertSectionConfigRequestSectionModelsStart extends TeaModel {
        // 分钟
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static InsertSectionConfigRequestSectionModelsStart build(java.util.Map<String, ?> map) throws Exception {
            InsertSectionConfigRequestSectionModelsStart self = new InsertSectionConfigRequestSectionModelsStart();
            return TeaModel.build(map, self);
        }

        public InsertSectionConfigRequestSectionModelsStart setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public InsertSectionConfigRequestSectionModelsStart setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

    }

    public static class InsertSectionConfigRequestSectionModelsEnd extends TeaModel {
        // 分钟
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static InsertSectionConfigRequestSectionModelsEnd build(java.util.Map<String, ?> map) throws Exception {
            InsertSectionConfigRequestSectionModelsEnd self = new InsertSectionConfigRequestSectionModelsEnd();
            return TeaModel.build(map, self);
        }

        public InsertSectionConfigRequestSectionModelsEnd setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public InsertSectionConfigRequestSectionModelsEnd setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

    }

    public static class InsertSectionConfigRequestSectionModels extends TeaModel {
        // 节次类型
        @NameInMap("sectionType")
        public String sectionType;

        // 开始时间
        @NameInMap("start")
        public InsertSectionConfigRequestSectionModelsStart start;

        // 节次序号
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        // 结束时间
        @NameInMap("end")
        public InsertSectionConfigRequestSectionModelsEnd end;

        // 节次名称
        @NameInMap("sectionName")
        public String sectionName;

        public static InsertSectionConfigRequestSectionModels build(java.util.Map<String, ?> map) throws Exception {
            InsertSectionConfigRequestSectionModels self = new InsertSectionConfigRequestSectionModels();
            return TeaModel.build(map, self);
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

        public InsertSectionConfigRequestSectionModels setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
        }

        public InsertSectionConfigRequestSectionModels setEnd(InsertSectionConfigRequestSectionModelsEnd end) {
            this.end = end;
            return this;
        }
        public InsertSectionConfigRequestSectionModelsEnd getEnd() {
            return this.end;
        }

        public InsertSectionConfigRequestSectionModels setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

    }

    public static class InsertSectionConfigRequestStart extends TeaModel {
        // 月份
        @NameInMap("month")
        public Integer month;

        // 年份
        @NameInMap("year")
        public Integer year;

        // 一月中的第几天
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static InsertSectionConfigRequestStart build(java.util.Map<String, ?> map) throws Exception {
            InsertSectionConfigRequestStart self = new InsertSectionConfigRequestStart();
            return TeaModel.build(map, self);
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

        public InsertSectionConfigRequestStart setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class InsertSectionConfigRequestEnd extends TeaModel {
        // 月份
        @NameInMap("month")
        public Integer month;

        // 年份
        @NameInMap("year")
        public Integer year;

        // 一月中的第几天
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static InsertSectionConfigRequestEnd build(java.util.Map<String, ?> map) throws Exception {
            InsertSectionConfigRequestEnd self = new InsertSectionConfigRequestEnd();
            return TeaModel.build(map, self);
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

        public InsertSectionConfigRequestEnd setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

}
