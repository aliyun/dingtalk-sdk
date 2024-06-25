// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleConfigResponseBody extends TeaModel {
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
         * <strong>example:</strong>
         * <p>30</p>
         */
        @NameInMap("dayOfMonth")
        public Long dayOfMonth;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("month")
        public Long month;

        /**
         * <strong>example:</strong>
         * <p>2020</p>
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
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("hour")
        public Integer hour;

        /**
         * <strong>example:</strong>
         * <p>45</p>
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
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("hour")
        public Integer hour;

        /**
         * <strong>example:</strong>
         * <p>0</p>
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
        @NameInMap("end")
        public QueryClassScheduleConfigResponseBodyResultSectionModelsEnd end;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        /**
         * <strong>example:</strong>
         * <p>第一节</p>
         */
        @NameInMap("sectionName")
        public String sectionName;

        @NameInMap("sectionType")
        public String sectionType;

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
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("month")
        public Integer month;

        /**
         * <strong>example:</strong>
         * <p>2020</p>
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
         * <strong>example:</strong>
         * <p>2345</p>
         */
        @NameInMap("classId")
        public Long classId;

        @NameInMap("end")
        public QueryClassScheduleConfigResponseBodyResultEnd end;

        @NameInMap("sectionModels")
        public java.util.List<QueryClassScheduleConfigResponseBodyResultSectionModels> sectionModels;

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
