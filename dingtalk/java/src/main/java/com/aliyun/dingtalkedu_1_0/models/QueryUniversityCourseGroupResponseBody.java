// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryUniversityCourseGroupResponseBody extends TeaModel {
    // 课程组信息
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

    public static class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsStart extends TeaModel {
        // 年
        @NameInMap("year")
        public Integer year;

        // 月
        @NameInMap("month")
        public Integer month;

        // 日
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsStart build(java.util.Map<String, ?> map) throws Exception {
            QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsStart self = new QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsStart();
            return TeaModel.build(map, self);
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsStart setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsStart setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsStart setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsEnd extends TeaModel {
        // 年
        @NameInMap("year")
        public Integer year;

        // 月
        @NameInMap("month")
        public Integer month;

        // 日
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsEnd build(java.util.Map<String, ?> map) throws Exception {
            QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsEnd self = new QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsEnd();
            return TeaModel.build(map, self);
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsEnd setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsEnd setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsEnd setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels extends TeaModel {
        // 教室主键
        @NameInMap("classroomId")
        public Long classroomId;

        // 上课周期
        @NameInMap("classPeriodType")
        public Integer classPeriodType;

        // 一周的第几天
        @NameInMap("dayOfWeek")
        public Integer dayOfWeek;

        // 课节
        @NameInMap("sectionIndex")
        public java.util.List<Integer> sectionIndex;

        // 开始时间
        @NameInMap("start")
        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsStart start;

        // 结束时间
        @NameInMap("end")
        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsEnd end;

        // 课程类型
        @NameInMap("courseType")
        public Integer courseType;

        public static QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels build(java.util.Map<String, ?> map) throws Exception {
            QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels self = new QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels();
            return TeaModel.build(map, self);
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setClassroomId(Long classroomId) {
            this.classroomId = classroomId;
            return this;
        }
        public Long getClassroomId() {
            return this.classroomId;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setClassPeriodType(Integer classPeriodType) {
            this.classPeriodType = classPeriodType;
            return this;
        }
        public Integer getClassPeriodType() {
            return this.classPeriodType;
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

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setStart(QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsStart start) {
            this.start = start;
            return this;
        }
        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsStart getStart() {
            return this.start;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setEnd(QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsEnd end) {
            this.end = end;
            return this;
        }
        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsEnd getEnd() {
            return this.end;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels setCourseType(Integer courseType) {
            this.courseType = courseType;
            return this;
        }
        public Integer getCourseType() {
            return this.courseType;
        }

    }

    public static class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo extends TeaModel {
        // 合作方课程组code
        @NameInMap("isvCourseGroupCode")
        public String isvCourseGroupCode;

        // 课程组编码
        @NameInMap("courseGroupCode")
        public String courseGroupCode;

        // 课程组名称
        @NameInMap("courseGroupName")
        public String courseGroupName;

        // 课程组介绍
        @NameInMap("courseGroupIntroduce")
        public String courseGroupIntroduce;

        // 学年
        @NameInMap("schoolYear")
        public String schoolYear;

        // 学期
        @NameInMap("semester")
        public Integer semester;

        // 学段编码
        @NameInMap("periodCode")
        public String periodCode;

        // 学科名称
        @NameInMap("subjectName")
        public String subjectName;

        // 课程组详细
        @NameInMap("courserGroupItemModels")
        public java.util.List<QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels> courserGroupItemModels;

        public static QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo self = new QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo();
            return TeaModel.build(map, self);
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setIsvCourseGroupCode(String isvCourseGroupCode) {
            this.isvCourseGroupCode = isvCourseGroupCode;
            return this;
        }
        public String getIsvCourseGroupCode() {
            return this.isvCourseGroupCode;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setCourseGroupCode(String courseGroupCode) {
            this.courseGroupCode = courseGroupCode;
            return this;
        }
        public String getCourseGroupCode() {
            return this.courseGroupCode;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setCourseGroupName(String courseGroupName) {
            this.courseGroupName = courseGroupName;
            return this;
        }
        public String getCourseGroupName() {
            return this.courseGroupName;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setCourseGroupIntroduce(String courseGroupIntroduce) {
            this.courseGroupIntroduce = courseGroupIntroduce;
            return this;
        }
        public String getCourseGroupIntroduce() {
            return this.courseGroupIntroduce;
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

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setPeriodCode(String periodCode) {
            this.periodCode = periodCode;
            return this;
        }
        public String getPeriodCode() {
            return this.periodCode;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setSubjectName(String subjectName) {
            this.subjectName = subjectName;
            return this;
        }
        public String getSubjectName() {
            return this.subjectName;
        }

        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo setCourserGroupItemModels(java.util.List<QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels> courserGroupItemModels) {
            this.courserGroupItemModels = courserGroupItemModels;
            return this;
        }
        public java.util.List<QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels> getCourserGroupItemModels() {
            return this.courserGroupItemModels;
        }

    }

}
