// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryUniversityCourseGroupResponseBody extends TeaModel {
    @NameInMap("universityCourseGroupInfo")
    public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo universityCourseGroupInfo;

    public static QueryUniversityCourseGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUniversityCourseGroupResponseBody self = new QueryUniversityCourseGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUniversityCourseGroupResponseBody setUniversityCourseGroupInfo(QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo universityCourseGroupInfo) {
        this.universityCourseGroupInfo = universityCourseGroupInfo;
        return this;
    }
    public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo getUniversityCourseGroupInfo() {
        return this.universityCourseGroupInfo;
    }

    public static class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>31</p>
         */
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("month")
        public Integer month;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021</p>
         */
        @NameInMap("year")
        public Integer year;

        public static QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate build(java.util.Map<String, ?> map) throws Exception {
            QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate self = new QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate();
            return TeaModel.build(map, self);
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

    }

    public static class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("month")
        public Integer month;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021</p>
         */
        @NameInMap("year")
        public Integer year;

        public static QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate build(java.util.Map<String, ?> map) throws Exception {
            QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate self = new QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate();
            return TeaModel.build(map, self);
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

    }

    public static class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1、单周；2、双周；3、全周</p>
         */
        @NameInMap("classPeriodType")
        public Integer classPeriodType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10001</p>
         */
        @NameInMap("classroomId")
        public Long classroomId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1:音视频直播；2:线下课程；4:音视频及线下</p>
         */
        @NameInMap("courseType")
        public Integer courseType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("courserGroupItemEndDate")
        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate courserGroupItemEndDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("courserGroupItemStartDate")
        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate courserGroupItemStartDate;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>7</p>
         */
        @NameInMap("dayOfWeek")
        public Integer dayOfWeek;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("sectionIndex")
        public java.util.List<Integer> sectionIndex;

        public static QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels build(java.util.Map<String, ?> map) throws Exception {
            QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels self = new QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels();
            return TeaModel.build(map, self);
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setClassPeriodType(Integer classPeriodType) {
            this.classPeriodType = classPeriodType;
            return this;
        }
        public Integer getClassPeriodType() {
            return this.classPeriodType;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setClassroomId(Long classroomId) {
            this.classroomId = classroomId;
            return this;
        }
        public Long getClassroomId() {
            return this.classroomId;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setCourseType(Integer courseType) {
            this.courseType = courseType;
            return this;
        }
        public Integer getCourseType() {
            return this.courseType;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setCourserGroupItemEndDate(QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate courserGroupItemEndDate) {
            this.courserGroupItemEndDate = courserGroupItemEndDate;
            return this;
        }
        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate getCourserGroupItemEndDate() {
            return this.courserGroupItemEndDate;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setCourserGroupItemStartDate(QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate courserGroupItemStartDate) {
            this.courserGroupItemStartDate = courserGroupItemStartDate;
            return this;
        }
        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate getCourserGroupItemStartDate() {
            return this.courserGroupItemStartDate;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setDayOfWeek(Integer dayOfWeek) {
            this.dayOfWeek = dayOfWeek;
            return this;
        }
        public Integer getDayOfWeek() {
            return this.dayOfWeek;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setSectionIndex(java.util.List<Integer> sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public java.util.List<Integer> getSectionIndex() {
            return this.sectionIndex;
        }

    }

    public static class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>GS1001</p>
         */
        @NameInMap("courseGroupCode")
        public String courseGroupCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>高数</p>
         */
        @NameInMap("courseGroupIntroduce")
        public String courseGroupIntroduce;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>高数_李老师</p>
         */
        @NameInMap("courseGroupName")
        public String courseGroupName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("courserGroupItemModels")
        public java.util.List<QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels> courserGroupItemModels;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>GZ1001</p>
         */
        @NameInMap("isvCourseGroupCode")
        public String isvCourseGroupCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>university</p>
         */
        @NameInMap("periodCode")
        public String periodCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-2022</p>
         */
        @NameInMap("schoolYear")
        public String schoolYear;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("semester")
        public Integer semester;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>高等数学</p>
         */
        @NameInMap("subjectName")
        public String subjectName;

        public static QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo self = new QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo();
            return TeaModel.build(map, self);
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setCourseGroupCode(String courseGroupCode) {
            this.courseGroupCode = courseGroupCode;
            return this;
        }
        public String getCourseGroupCode() {
            return this.courseGroupCode;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setCourseGroupIntroduce(String courseGroupIntroduce) {
            this.courseGroupIntroduce = courseGroupIntroduce;
            return this;
        }
        public String getCourseGroupIntroduce() {
            return this.courseGroupIntroduce;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setCourseGroupName(String courseGroupName) {
            this.courseGroupName = courseGroupName;
            return this;
        }
        public String getCourseGroupName() {
            return this.courseGroupName;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setCourserGroupItemModels(java.util.List<QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels> courserGroupItemModels) {
            this.courserGroupItemModels = courserGroupItemModels;
            return this;
        }
        public java.util.List<QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels> getCourserGroupItemModels() {
            return this.courserGroupItemModels;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setIsvCourseGroupCode(String isvCourseGroupCode) {
            this.isvCourseGroupCode = isvCourseGroupCode;
            return this;
        }
        public String getIsvCourseGroupCode() {
            return this.isvCourseGroupCode;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setPeriodCode(String periodCode) {
            this.periodCode = periodCode;
            return this;
        }
        public String getPeriodCode() {
            return this.periodCode;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setSchoolYear(String schoolYear) {
            this.schoolYear = schoolYear;
            return this;
        }
        public String getSchoolYear() {
            return this.schoolYear;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setSemester(Integer semester) {
            this.semester = semester;
            return this;
        }
        public Integer getSemester() {
            return this.semester;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setSubjectName(String subjectName) {
            this.subjectName = subjectName;
            return this;
        }
        public String getSubjectName() {
            return this.subjectName;
        }

    }

}
