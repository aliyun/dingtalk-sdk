// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityCourseGroupRequest extends TeaModel {
    // 操作人
    @NameInMap("opUserId")
    public String opUserId;

    // 合作方课程组code
    @NameInMap("isvCourseGroupCode")
    public String isvCourseGroupCode;

    // 扩展参数
    @NameInMap("ext")
    public String ext;

    // 课程组介绍
    @NameInMap("courseGroupIntroduce")
    public String courseGroupIntroduce;

    // 学期
    @NameInMap("semester")
    public Integer semester;

    // 学科
    @NameInMap("subjectName")
    public String subjectName;

    // 课程组名称
    @NameInMap("courseGroupName")
    public String courseGroupName;

    // 学年
    @NameInMap("schoolYear")
    public String schoolYear;

    // 学段code
    @NameInMap("periodCode")
    public String periodCode;

    // 教师信息
    @NameInMap("teacherInfos")
    public java.util.List<CreateUniversityCourseGroupRequestTeacherInfos> teacherInfos;

    // 课程详细
    @NameInMap("courserGroupItemModels")
    public java.util.List<CreateUniversityCourseGroupRequestCourserGroupItemModels> courserGroupItemModels;

    public static CreateUniversityCourseGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateUniversityCourseGroupRequest self = new CreateUniversityCourseGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateUniversityCourseGroupRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public CreateUniversityCourseGroupRequest setIsvCourseGroupCode(String isvCourseGroupCode) {
        this.isvCourseGroupCode = isvCourseGroupCode;
        return this;
    }
    public String getIsvCourseGroupCode() {
        return this.isvCourseGroupCode;
    }

    public CreateUniversityCourseGroupRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public CreateUniversityCourseGroupRequest setCourseGroupIntroduce(String courseGroupIntroduce) {
        this.courseGroupIntroduce = courseGroupIntroduce;
        return this;
    }
    public String getCourseGroupIntroduce() {
        return this.courseGroupIntroduce;
    }

    public CreateUniversityCourseGroupRequest setSemester(Integer semester) {
        this.semester = semester;
        return this;
    }
    public Integer getSemester() {
        return this.semester;
    }

    public CreateUniversityCourseGroupRequest setSubjectName(String subjectName) {
        this.subjectName = subjectName;
        return this;
    }
    public String getSubjectName() {
        return this.subjectName;
    }

    public CreateUniversityCourseGroupRequest setCourseGroupName(String courseGroupName) {
        this.courseGroupName = courseGroupName;
        return this;
    }
    public String getCourseGroupName() {
        return this.courseGroupName;
    }

    public CreateUniversityCourseGroupRequest setSchoolYear(String schoolYear) {
        this.schoolYear = schoolYear;
        return this;
    }
    public String getSchoolYear() {
        return this.schoolYear;
    }

    public CreateUniversityCourseGroupRequest setPeriodCode(String periodCode) {
        this.periodCode = periodCode;
        return this;
    }
    public String getPeriodCode() {
        return this.periodCode;
    }

    public CreateUniversityCourseGroupRequest setTeacherInfos(java.util.List<CreateUniversityCourseGroupRequestTeacherInfos> teacherInfos) {
        this.teacherInfos = teacherInfos;
        return this;
    }
    public java.util.List<CreateUniversityCourseGroupRequestTeacherInfos> getTeacherInfos() {
        return this.teacherInfos;
    }

    public CreateUniversityCourseGroupRequest setCourserGroupItemModels(java.util.List<CreateUniversityCourseGroupRequestCourserGroupItemModels> courserGroupItemModels) {
        this.courserGroupItemModels = courserGroupItemModels;
        return this;
    }
    public java.util.List<CreateUniversityCourseGroupRequestCourserGroupItemModels> getCourserGroupItemModels() {
        return this.courserGroupItemModels;
    }

    public static class CreateUniversityCourseGroupRequestTeacherInfos extends TeaModel {
        // 用户id
        @NameInMap("userId")
        public String userId;

        // 角色类型
        @NameInMap("participantRole")
        public String participantRole;

        public static CreateUniversityCourseGroupRequestTeacherInfos build(java.util.Map<String, ?> map) throws Exception {
            CreateUniversityCourseGroupRequestTeacherInfos self = new CreateUniversityCourseGroupRequestTeacherInfos();
            return TeaModel.build(map, self);
        }

        public CreateUniversityCourseGroupRequestTeacherInfos setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public CreateUniversityCourseGroupRequestTeacherInfos setParticipantRole(String participantRole) {
            this.participantRole = participantRole;
            return this;
        }
        public String getParticipantRole() {
            return this.participantRole;
        }

    }

    public static class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate extends TeaModel {
        // 月
        @NameInMap("month")
        public Integer month;

        // 年
        @NameInMap("year")
        public Integer year;

        // 一月的第几天
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate build(java.util.Map<String, ?> map) throws Exception {
            CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate self = new CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate();
            return TeaModel.build(map, self);
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate extends TeaModel {
        // 月
        @NameInMap("month")
        public Integer month;

        // 年
        @NameInMap("year")
        public Integer year;

        // 一月的第几天
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate build(java.util.Map<String, ?> map) throws Exception {
            CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate self = new CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate();
            return TeaModel.build(map, self);
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class CreateUniversityCourseGroupRequestCourserGroupItemModels extends TeaModel {
        // 一周的第几天
        @NameInMap("dayOfWeek")
        public Integer dayOfWeek;

        // 上课周期
        @NameInMap("classPeriodType")
        public Integer classPeriodType;

        // 课程组详细开始时间
        @NameInMap("courserGroupItemStartDate")
        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate courserGroupItemStartDate;

        // 课节
        @NameInMap("sectionIndex")
        public java.util.List<Integer> sectionIndex;

        // 课程组详细结束时间
        @NameInMap("courserGroupItemEndDate")
        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate courserGroupItemEndDate;

        // 课程类型
        @NameInMap("courseType")
        public Integer courseType;

        // 教室id
        @NameInMap("classroomId")
        public Long classroomId;

        public static CreateUniversityCourseGroupRequestCourserGroupItemModels build(java.util.Map<String, ?> map) throws Exception {
            CreateUniversityCourseGroupRequestCourserGroupItemModels self = new CreateUniversityCourseGroupRequestCourserGroupItemModels();
            return TeaModel.build(map, self);
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setDayOfWeek(Integer dayOfWeek) {
            this.dayOfWeek = dayOfWeek;
            return this;
        }
        public Integer getDayOfWeek() {
            return this.dayOfWeek;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setClassPeriodType(Integer classPeriodType) {
            this.classPeriodType = classPeriodType;
            return this;
        }
        public Integer getClassPeriodType() {
            return this.classPeriodType;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setCourserGroupItemStartDate(CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate courserGroupItemStartDate) {
            this.courserGroupItemStartDate = courserGroupItemStartDate;
            return this;
        }
        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate getCourserGroupItemStartDate() {
            return this.courserGroupItemStartDate;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setSectionIndex(java.util.List<Integer> sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public java.util.List<Integer> getSectionIndex() {
            return this.sectionIndex;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setCourserGroupItemEndDate(CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate courserGroupItemEndDate) {
            this.courserGroupItemEndDate = courserGroupItemEndDate;
            return this;
        }
        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate getCourserGroupItemEndDate() {
            return this.courserGroupItemEndDate;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setCourseType(Integer courseType) {
            this.courseType = courseType;
            return this;
        }
        public Integer getCourseType() {
            return this.courseType;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setClassroomId(Long classroomId) {
            this.classroomId = classroomId;
            return this;
        }
        public Long getClassroomId() {
            return this.classroomId;
        }

    }

}
