// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityCourseGroupRequest extends TeaModel {
    @NameInMap("courseGroupIntroduce")
    public String courseGroupIntroduce;

    @NameInMap("courseGroupName")
    public String courseGroupName;

    @NameInMap("courserGroupItemModels")
    public java.util.List<CreateUniversityCourseGroupRequestCourserGroupItemModels> courserGroupItemModels;

    @NameInMap("ext")
    public String ext;

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

    @NameInMap("teacherInfos")
    public java.util.List<CreateUniversityCourseGroupRequestTeacherInfos> teacherInfos;

    @NameInMap("opUserId")
    public String opUserId;

    public static CreateUniversityCourseGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateUniversityCourseGroupRequest self = new CreateUniversityCourseGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateUniversityCourseGroupRequest setCourseGroupIntroduce(String courseGroupIntroduce) {
        this.courseGroupIntroduce = courseGroupIntroduce;
        return this;
    }
    public String getCourseGroupIntroduce() {
        return this.courseGroupIntroduce;
    }

    public CreateUniversityCourseGroupRequest setCourseGroupName(String courseGroupName) {
        this.courseGroupName = courseGroupName;
        return this;
    }
    public String getCourseGroupName() {
        return this.courseGroupName;
    }

    public CreateUniversityCourseGroupRequest setCourserGroupItemModels(java.util.List<CreateUniversityCourseGroupRequestCourserGroupItemModels> courserGroupItemModels) {
        this.courserGroupItemModels = courserGroupItemModels;
        return this;
    }
    public java.util.List<CreateUniversityCourseGroupRequestCourserGroupItemModels> getCourserGroupItemModels() {
        return this.courserGroupItemModels;
    }

    public CreateUniversityCourseGroupRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public CreateUniversityCourseGroupRequest setIsvCourseGroupCode(String isvCourseGroupCode) {
        this.isvCourseGroupCode = isvCourseGroupCode;
        return this;
    }
    public String getIsvCourseGroupCode() {
        return this.isvCourseGroupCode;
    }

    public CreateUniversityCourseGroupRequest setPeriodCode(String periodCode) {
        this.periodCode = periodCode;
        return this;
    }
    public String getPeriodCode() {
        return this.periodCode;
    }

    public CreateUniversityCourseGroupRequest setSchoolYear(String schoolYear) {
        this.schoolYear = schoolYear;
        return this;
    }
    public String getSchoolYear() {
        return this.schoolYear;
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

    public CreateUniversityCourseGroupRequest setTeacherInfos(java.util.List<CreateUniversityCourseGroupRequestTeacherInfos> teacherInfos) {
        this.teacherInfos = teacherInfos;
        return this;
    }
    public java.util.List<CreateUniversityCourseGroupRequestTeacherInfos> getTeacherInfos() {
        return this.teacherInfos;
    }

    public CreateUniversityCourseGroupRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate extends TeaModel {
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("month")
        public Integer month;

        @NameInMap("year")
        public Integer year;

        public static CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate build(java.util.Map<String, ?> map) throws Exception {
            CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate self = new CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate();
            return TeaModel.build(map, self);
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
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

    }

    public static class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate extends TeaModel {
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("month")
        public Integer month;

        @NameInMap("year")
        public Integer year;

        public static CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate build(java.util.Map<String, ?> map) throws Exception {
            CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate self = new CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate();
            return TeaModel.build(map, self);
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
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

    }

    public static class CreateUniversityCourseGroupRequestCourserGroupItemModels extends TeaModel {
        @NameInMap("classPeriodType")
        public Integer classPeriodType;

        @NameInMap("classroomId")
        public Long classroomId;

        @NameInMap("courseType")
        public Integer courseType;

        @NameInMap("courserGroupItemEndDate")
        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate courserGroupItemEndDate;

        @NameInMap("courserGroupItemStartDate")
        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate courserGroupItemStartDate;

        @NameInMap("dayOfWeek")
        public Integer dayOfWeek;

        @NameInMap("sectionIndex")
        public java.util.List<Integer> sectionIndex;

        public static CreateUniversityCourseGroupRequestCourserGroupItemModels build(java.util.Map<String, ?> map) throws Exception {
            CreateUniversityCourseGroupRequestCourserGroupItemModels self = new CreateUniversityCourseGroupRequestCourserGroupItemModels();
            return TeaModel.build(map, self);
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setClassPeriodType(Integer classPeriodType) {
            this.classPeriodType = classPeriodType;
            return this;
        }
        public Integer getClassPeriodType() {
            return this.classPeriodType;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setClassroomId(Long classroomId) {
            this.classroomId = classroomId;
            return this;
        }
        public Long getClassroomId() {
            return this.classroomId;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setCourseType(Integer courseType) {
            this.courseType = courseType;
            return this;
        }
        public Integer getCourseType() {
            return this.courseType;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setCourserGroupItemEndDate(CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate courserGroupItemEndDate) {
            this.courserGroupItemEndDate = courserGroupItemEndDate;
            return this;
        }
        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate getCourserGroupItemEndDate() {
            return this.courserGroupItemEndDate;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setCourserGroupItemStartDate(CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate courserGroupItemStartDate) {
            this.courserGroupItemStartDate = courserGroupItemStartDate;
            return this;
        }
        public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate getCourserGroupItemStartDate() {
            return this.courserGroupItemStartDate;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setDayOfWeek(Integer dayOfWeek) {
            this.dayOfWeek = dayOfWeek;
            return this;
        }
        public Integer getDayOfWeek() {
            return this.dayOfWeek;
        }

        public CreateUniversityCourseGroupRequestCourserGroupItemModels setSectionIndex(java.util.List<Integer> sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public java.util.List<Integer> getSectionIndex() {
            return this.sectionIndex;
        }

    }

    public static class CreateUniversityCourseGroupRequestTeacherInfos extends TeaModel {
        @NameInMap("participantRole")
        public String participantRole;

        @NameInMap("userId")
        public String userId;

        public static CreateUniversityCourseGroupRequestTeacherInfos build(java.util.Map<String, ?> map) throws Exception {
            CreateUniversityCourseGroupRequestTeacherInfos self = new CreateUniversityCourseGroupRequestTeacherInfos();
            return TeaModel.build(map, self);
        }

        public CreateUniversityCourseGroupRequestTeacherInfos setParticipantRole(String participantRole) {
            this.participantRole = participantRole;
            return this;
        }
        public String getParticipantRole() {
            return this.participantRole;
        }

        public CreateUniversityCourseGroupRequestTeacherInfos setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
