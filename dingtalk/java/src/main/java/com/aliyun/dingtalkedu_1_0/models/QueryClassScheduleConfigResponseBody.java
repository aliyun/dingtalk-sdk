// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleConfigResponseBody extends TeaModel {
    /**
     * <p>查询结果</p>
     */
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

    public static class QueryClassScheduleConfigResponseBodyResultEnd extends TeaModel {
        /**
         * <p>一个月中第几天</p>
         */
        @NameInMap("dayOfMonth")
        public Long dayOfMonth;

        /**
         * <p>月份</p>
         */
        @NameInMap("month")
        public Long month;

        /**
         * <p>年份</p>
         */
        @NameInMap("year")
        public Long year;

        public static QueryClassScheduleConfigResponseBodyResultEnd build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleConfigResponseBodyResultEnd self = new QueryClassScheduleConfigResponseBodyResultEnd();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleConfigResponseBodyResultEnd setDayOfMonth(Long dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Long getDayOfMonth() {
            return this.dayOfMonth;
        }

        public QueryClassScheduleConfigResponseBodyResultEnd setMonth(Long month) {
            this.month = month;
            return this;
        }
        public Long getMonth() {
            return this.month;
        }

        public QueryClassScheduleConfigResponseBodyResultEnd setYear(Long year) {
            this.year = year;
            return this;
        }
        public Long getYear() {
            return this.year;
        }

    }

    public static class QueryClassScheduleConfigResponseBodyResultSectionModelsEnd extends TeaModel {
        /**
         * <p>小时</p>
         */
        @NameInMap("hour")
        public Integer hour;

        /**
         * <p>分钟</p>
         */
        @NameInMap("min")
        public Integer min;

        public static QueryClassScheduleConfigResponseBodyResultSectionModelsEnd build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleConfigResponseBodyResultSectionModelsEnd self = new QueryClassScheduleConfigResponseBodyResultSectionModelsEnd();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModelsEnd setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModelsEnd setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

    }

    public static class QueryClassScheduleConfigResponseBodyResultSectionModelsStart extends TeaModel {
        /**
         * <p>小时</p>
         */
        @NameInMap("hour")
        public Integer hour;

        /**
         * <p>分钟</p>
         */
        @NameInMap("min")
        public Integer min;

        public static QueryClassScheduleConfigResponseBodyResultSectionModelsStart build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleConfigResponseBodyResultSectionModelsStart self = new QueryClassScheduleConfigResponseBodyResultSectionModelsStart();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModelsStart setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModelsStart setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

    }

    public static class QueryClassScheduleConfigResponseBodyResultSectionModels extends TeaModel {
        /**
         * <p>结束时间</p>
         */
        @NameInMap("end")
        public QueryClassScheduleConfigResponseBodyResultSectionModelsEnd end;

        /**
         * <p>节次设置</p>
         */
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        /**
         * <p>节次名称</p>
         */
        @NameInMap("sectionName")
        public String sectionName;

        /**
         * <p>节次类型：COURSE/REST</p>
         */
        @NameInMap("sectionType")
        public String sectionType;

        /**
         * <p>开始时间（时分）</p>
         */
        @NameInMap("start")
        public QueryClassScheduleConfigResponseBodyResultSectionModelsStart start;

        public static QueryClassScheduleConfigResponseBodyResultSectionModels build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleConfigResponseBodyResultSectionModels self = new QueryClassScheduleConfigResponseBodyResultSectionModels();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModels setEnd(QueryClassScheduleConfigResponseBodyResultSectionModelsEnd end) {
            this.end = end;
            return this;
        }
        public QueryClassScheduleConfigResponseBodyResultSectionModelsEnd getEnd() {
            return this.end;
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModels setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
        }

        public QueryClassScheduleConfigResponseBodyResultSectionModels setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
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

    }

    public static class QueryClassScheduleConfigResponseBodyResultStart extends TeaModel {
        /**
         * <p>一个月中的第几天</p>
         */
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        /**
         * <p>月份</p>
         */
        @NameInMap("month")
        public Integer month;

        /**
         * <p>年份</p>
         */
        @NameInMap("year")
        public Integer year;

        public static QueryClassScheduleConfigResponseBodyResultStart build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleConfigResponseBodyResultStart self = new QueryClassScheduleConfigResponseBodyResultStart();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleConfigResponseBodyResultStart setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public QueryClassScheduleConfigResponseBodyResultStart setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public QueryClassScheduleConfigResponseBodyResultStart setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

    }

    public static class QueryClassScheduleConfigResponseBodyResult extends TeaModel {
        /**
         * <p>班级的Id.</p>
         */
        @NameInMap("classId")
        public Long classId;

        @NameInMap("end")
        public QueryClassScheduleConfigResponseBodyResultEnd end;

        /**
         * <p>节次模型。</p>
         */
        @NameInMap("sectionModels")
        public java.util.List<QueryClassScheduleConfigResponseBodyResultSectionModels> sectionModels;

        /**
         * <p>开始时间</p>
         */
        @NameInMap("start")
        public QueryClassScheduleConfigResponseBodyResultStart start;

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

        public QueryClassScheduleConfigResponseBodyResult setStart(QueryClassScheduleConfigResponseBodyResultStart start) {
            this.start = start;
            return this;
        }
        public QueryClassScheduleConfigResponseBodyResultStart getStart() {
            return this.start;
        }

    }

}
