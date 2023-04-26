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
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("month")
        public Integer month;

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
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("month")
        public Integer month;

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
        @NameInMap("classPeriodType")
        public Integer classPeriodType;

        @NameInMap("classroomId")
        public Long classroomId;

        @NameInMap("courseType")
        public Integer courseType;

        @NameInMap("courserGroupItemEndDate")
        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate courserGroupItemEndDate;

        @NameInMap("courserGroupItemStartDate")
        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate courserGroupItemStartDate;

        @NameInMap("dayOfWeek")
        public Integer dayOfWeek;

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
        @NameInMap("courseGroupCode")
        public String courseGroupCode;

        @NameInMap("courseGroupIntroduce")
        public String courseGroupIntroduce;

        @NameInMap("courseGroupName")
        public String courseGroupName;

        @NameInMap("courserGroupItemModels")
        public java.util.List<QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels> courserGroupItemModels;

        @NameInMap("isvCourseGroupCode")
        public String isvCourseGroupCode;

        @NameInMap("periodCode")
        public String periodCode;

        @NameInMap("schoolYear")
        public String schoolYear;

        @NameInMap("semester")
        public Integer semester;

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
