// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitCoursesOfClassRequest extends TeaModel {
    // 课程设置。
    @NameInMap("courses")
    public java.util.List<InitCoursesOfClassRequestCourses> courses;

    // 节次设置
    @NameInMap("sectionConfig")
    public InitCoursesOfClassRequestSectionConfig sectionConfig;

    // 操作人的userid。
    @NameInMap("opUserId")
    public String opUserId;

    public static InitCoursesOfClassRequest build(java.util.Map<String, ?> map) throws Exception {
        InitCoursesOfClassRequest self = new InitCoursesOfClassRequest();
        return TeaModel.build(map, self);
    }

    public InitCoursesOfClassRequest setCourses(java.util.List<InitCoursesOfClassRequestCourses> courses) {
        this.courses = courses;
        return this;
    }
    public java.util.List<InitCoursesOfClassRequestCourses> getCourses() {
        return this.courses;
    }

    public InitCoursesOfClassRequest setSectionConfig(InitCoursesOfClassRequestSectionConfig sectionConfig) {
        this.sectionConfig = sectionConfig;
        return this;
    }
    public InitCoursesOfClassRequestSectionConfig getSectionConfig() {
        return this.sectionConfig;
    }

    public InitCoursesOfClassRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class InitCoursesOfClassRequestCoursesDateModel extends TeaModel {
        // 月份。
        @NameInMap("month")
        public Integer month;

        // 年份。
        @NameInMap("year")
        public Integer year;

        // 每个月的第几天。
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static InitCoursesOfClassRequestCoursesDateModel build(java.util.Map<String, ?> map) throws Exception {
            InitCoursesOfClassRequestCoursesDateModel self = new InitCoursesOfClassRequestCoursesDateModel();
            return TeaModel.build(map, self);
        }

        public InitCoursesOfClassRequestCoursesDateModel setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public InitCoursesOfClassRequestCoursesDateModel setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public InitCoursesOfClassRequestCoursesDateModel setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class InitCoursesOfClassRequestCoursesSectionModel extends TeaModel {
        // 节次序列号。
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        // 节次名称。
        @NameInMap("sectionName")
        public String sectionName;

        public static InitCoursesOfClassRequestCoursesSectionModel build(java.util.Map<String, ?> map) throws Exception {
            InitCoursesOfClassRequestCoursesSectionModel self = new InitCoursesOfClassRequestCoursesSectionModel();
            return TeaModel.build(map, self);
        }

        public InitCoursesOfClassRequestCoursesSectionModel setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
        }

        public InitCoursesOfClassRequestCoursesSectionModel setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

    }

    public static class InitCoursesOfClassRequestCourses extends TeaModel {
        // 老师的staffId。
        @NameInMap("teacherStaffIds")
        public java.util.List<String> teacherStaffIds;

        // 课程名称。
        @NameInMap("courseName")
        public String courseName;

        // 上课时间。
        @NameInMap("dateModel")
        public InitCoursesOfClassRequestCoursesDateModel dateModel;

        // 课程节次。
        @NameInMap("sectionModel")
        public InitCoursesOfClassRequestCoursesSectionModel sectionModel;

        // 创建者名称。
        @NameInMap("creatorName")
        public String creatorName;

        // 上课地点
        @NameInMap("location")
        public String location;

        public static InitCoursesOfClassRequestCourses build(java.util.Map<String, ?> map) throws Exception {
            InitCoursesOfClassRequestCourses self = new InitCoursesOfClassRequestCourses();
            return TeaModel.build(map, self);
        }

        public InitCoursesOfClassRequestCourses setTeacherStaffIds(java.util.List<String> teacherStaffIds) {
            this.teacherStaffIds = teacherStaffIds;
            return this;
        }
        public java.util.List<String> getTeacherStaffIds() {
            return this.teacherStaffIds;
        }

        public InitCoursesOfClassRequestCourses setCourseName(String courseName) {
            this.courseName = courseName;
            return this;
        }
        public String getCourseName() {
            return this.courseName;
        }

        public InitCoursesOfClassRequestCourses setDateModel(InitCoursesOfClassRequestCoursesDateModel dateModel) {
            this.dateModel = dateModel;
            return this;
        }
        public InitCoursesOfClassRequestCoursesDateModel getDateModel() {
            return this.dateModel;
        }

        public InitCoursesOfClassRequestCourses setSectionModel(InitCoursesOfClassRequestCoursesSectionModel sectionModel) {
            this.sectionModel = sectionModel;
            return this;
        }
        public InitCoursesOfClassRequestCoursesSectionModel getSectionModel() {
            return this.sectionModel;
        }

        public InitCoursesOfClassRequestCourses setCreatorName(String creatorName) {
            this.creatorName = creatorName;
            return this;
        }
        public String getCreatorName() {
            return this.creatorName;
        }

        public InitCoursesOfClassRequestCourses setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

    }

    public static class InitCoursesOfClassRequestSectionConfigSectionModelsStart extends TeaModel {
        // 分钟
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static InitCoursesOfClassRequestSectionConfigSectionModelsStart build(java.util.Map<String, ?> map) throws Exception {
            InitCoursesOfClassRequestSectionConfigSectionModelsStart self = new InitCoursesOfClassRequestSectionConfigSectionModelsStart();
            return TeaModel.build(map, self);
        }

        public InitCoursesOfClassRequestSectionConfigSectionModelsStart setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public InitCoursesOfClassRequestSectionConfigSectionModelsStart setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

    }

    public static class InitCoursesOfClassRequestSectionConfigSectionModelsEnd extends TeaModel {
        // 分钟
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static InitCoursesOfClassRequestSectionConfigSectionModelsEnd build(java.util.Map<String, ?> map) throws Exception {
            InitCoursesOfClassRequestSectionConfigSectionModelsEnd self = new InitCoursesOfClassRequestSectionConfigSectionModelsEnd();
            return TeaModel.build(map, self);
        }

        public InitCoursesOfClassRequestSectionConfigSectionModelsEnd setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public InitCoursesOfClassRequestSectionConfigSectionModelsEnd setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

    }

    public static class InitCoursesOfClassRequestSectionConfigSectionModels extends TeaModel {
        // 节次类型枚举：COURSE/REST
        @NameInMap("sectionType")
        public String sectionType;

        // 开始时间
        @NameInMap("start")
        public InitCoursesOfClassRequestSectionConfigSectionModelsStart start;

        // 第几节。
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        // 结束时间
        @NameInMap("end")
        public InitCoursesOfClassRequestSectionConfigSectionModelsEnd end;

        public static InitCoursesOfClassRequestSectionConfigSectionModels build(java.util.Map<String, ?> map) throws Exception {
            InitCoursesOfClassRequestSectionConfigSectionModels self = new InitCoursesOfClassRequestSectionConfigSectionModels();
            return TeaModel.build(map, self);
        }

        public InitCoursesOfClassRequestSectionConfigSectionModels setSectionType(String sectionType) {
            this.sectionType = sectionType;
            return this;
        }
        public String getSectionType() {
            return this.sectionType;
        }

        public InitCoursesOfClassRequestSectionConfigSectionModels setStart(InitCoursesOfClassRequestSectionConfigSectionModelsStart start) {
            this.start = start;
            return this;
        }
        public InitCoursesOfClassRequestSectionConfigSectionModelsStart getStart() {
            return this.start;
        }

        public InitCoursesOfClassRequestSectionConfigSectionModels setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
        }

        public InitCoursesOfClassRequestSectionConfigSectionModels setEnd(InitCoursesOfClassRequestSectionConfigSectionModelsEnd end) {
            this.end = end;
            return this;
        }
        public InitCoursesOfClassRequestSectionConfigSectionModelsEnd getEnd() {
            return this.end;
        }

    }

    public static class InitCoursesOfClassRequestSectionConfig extends TeaModel {
        // 节次模型
        @NameInMap("sectionModels")
        public java.util.List<InitCoursesOfClassRequestSectionConfigSectionModels> sectionModels;

        public static InitCoursesOfClassRequestSectionConfig build(java.util.Map<String, ?> map) throws Exception {
            InitCoursesOfClassRequestSectionConfig self = new InitCoursesOfClassRequestSectionConfig();
            return TeaModel.build(map, self);
        }

        public InitCoursesOfClassRequestSectionConfig setSectionModels(java.util.List<InitCoursesOfClassRequestSectionConfigSectionModels> sectionModels) {
            this.sectionModels = sectionModels;
            return this;
        }
        public java.util.List<InitCoursesOfClassRequestSectionConfigSectionModels> getSectionModels() {
            return this.sectionModels;
        }

    }

}
