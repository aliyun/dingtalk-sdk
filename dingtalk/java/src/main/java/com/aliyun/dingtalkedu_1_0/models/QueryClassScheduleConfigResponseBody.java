// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleConfigResponseBody extends TeaModel {
    // 查询结果
    @NameInMap("result")
    public java.util.List<QueryClassScheduleConfigResponseBodyResult> result;

    public static QueryClassScheduleConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryClassScheduleConfigResponseBody self = new QueryClassScheduleConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryClassScheduleConfigResponseBody setResult(java.util.List<QueryClassScheduleConfigResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryClassScheduleConfigResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryClassScheduleConfigResponseBodyResultStart extends TeaModel {
        // 年份
        @NameInMap("year")
        public Integer year;

        // 月份
        @NameInMap("month")
        public Integer month;

        // 一个月中的第几天
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static QueryClassScheduleConfigResponseBodyResultStart build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleConfigResponseBodyResultStart self = new QueryClassScheduleConfigResponseBodyResultStart();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleConfigResponseBodyResultStart setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public QueryClassScheduleConfigResponseBodyResultStart setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public QueryClassScheduleConfigResponseBodyResultStart setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class QueryClassScheduleConfigResponseBodyResultEnd extends TeaModel {
        // 年份
        @NameInMap("year")
        public Long year;

        // 月份
        @NameInMap("month")
        public Long month;

        // 一个月中第几天
        @NameInMap("dayOfMonth")
        public Long dayOfMonth;

        public static QueryClassScheduleConfigResponseBodyResultEnd build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleConfigResponseBodyResultEnd self = new QueryClassScheduleConfigResponseBodyResultEnd();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleConfigResponseBodyResultEnd setYear(Long year) {
            this.year = year;
            return this;
        }
        public Long getYear() {
            return this.year;
        }

        public QueryClassScheduleConfigResponseBodyResultEnd setMonth(Long month) {
            this.month = month;
            return this;
        }
        public Long getMonth() {
            return this.month;
        }

        public QueryClassScheduleConfigResponseBodyResultEnd setDayOfMonth(Long dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Long getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class QueryClassScheduleConfigResponseBodyResultSectionModelsStart extends TeaModel {
        // 分钟
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static QueryClassScheduleConfigResponseBodyResultSectionModelsStart build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleConfigResponseBodyResultSectionModelsStart self = new QueryClassScheduleConfigResponseBodyResultSectionModelsStart();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModelsStart setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModelsStart setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

    }

    public static class QueryClassScheduleConfigResponseBodyResultSectionModelsEnd extends TeaModel {
        // 分钟
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static QueryClassScheduleConfigResponseBodyResultSectionModelsEnd build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleConfigResponseBodyResultSectionModelsEnd self = new QueryClassScheduleConfigResponseBodyResultSectionModelsEnd();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModelsEnd setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModelsEnd setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

    }

    public static class QueryClassScheduleConfigResponseBodyResultSectionModels extends TeaModel {
        // 节次类型：COURSE/REST
        @NameInMap("sectionType")
        public String sectionType;

        // 开始时间（时分）
        @NameInMap("start")
        public QueryClassScheduleConfigResponseBodyResultSectionModelsStart start;

        // 节次设置
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        // 结束时间
        @NameInMap("end")
        public QueryClassScheduleConfigResponseBodyResultSectionModelsEnd end;

        // 节次名称
        @NameInMap("sectionName")
        public String sectionName;

        public static QueryClassScheduleConfigResponseBodyResultSectionModels build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleConfigResponseBodyResultSectionModels self = new QueryClassScheduleConfigResponseBodyResultSectionModels();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModels setSectionType(String sectionType) {
            this.sectionType = sectionType;
            return this;
        }
        public String getSectionType() {
            return this.sectionType;
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModels setStart(QueryClassScheduleConfigResponseBodyResultSectionModelsStart start) {
            this.start = start;
            return this;
        }
        public QueryClassScheduleConfigResponseBodyResultSectionModelsStart getStart() {
            return this.start;
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModels setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModels setEnd(QueryClassScheduleConfigResponseBodyResultSectionModelsEnd end) {
            this.end = end;
            return this;
        }
        public QueryClassScheduleConfigResponseBodyResultSectionModelsEnd getEnd() {
            return this.end;
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModels setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

    }

    public static class QueryClassScheduleConfigResponseBodyResult extends TeaModel {
        // 班级的Id.
        @NameInMap("classId")
        public Long classId;

        // 开始时间
        @NameInMap("start")
        public QueryClassScheduleConfigResponseBodyResultStart start;

        @NameInMap("end")
        public QueryClassScheduleConfigResponseBodyResultEnd end;

        // 节次模型。
        @NameInMap("sectionModels")
        public java.util.List<QueryClassScheduleConfigResponseBodyResultSectionModels> sectionModels;

        public static QueryClassScheduleConfigResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleConfigResponseBodyResult self = new QueryClassScheduleConfigResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleConfigResponseBodyResult setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public QueryClassScheduleConfigResponseBodyResult setStart(QueryClassScheduleConfigResponseBodyResultStart start) {
            this.start = start;
            return this;
        }
        public QueryClassScheduleConfigResponseBodyResultStart getStart() {
            return this.start;
        }

        public QueryClassScheduleConfigResponseBodyResult setEnd(QueryClassScheduleConfigResponseBodyResultEnd end) {
            this.end = end;
            return this;
        }
        public QueryClassScheduleConfigResponseBodyResultEnd getEnd() {
            return this.end;
        }

        public QueryClassScheduleConfigResponseBodyResult setSectionModels(java.util.List<QueryClassScheduleConfigResponseBodyResultSectionModels> sectionModels) {
            this.sectionModels = sectionModels;
            return this;
        }
        public java.util.List<QueryClassScheduleConfigResponseBodyResultSectionModels> getSectionModels() {
            return this.sectionModels;
        }

    }

}
