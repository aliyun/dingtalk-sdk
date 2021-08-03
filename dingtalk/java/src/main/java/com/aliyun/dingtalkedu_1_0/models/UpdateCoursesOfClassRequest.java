// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCoursesOfClassRequest extends TeaModel {
    @NameInMap("courses")
    public java.util.List<UpdateCoursesOfClassRequestCourses> courses;

    // 节次设置
    @NameInMap("sectionConfig")
    public UpdateCoursesOfClassRequestSectionConfig sectionConfig;

    // 操作者id
    @NameInMap("opUserId")
    public String opUserId;

    public static UpdateCoursesOfClassRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCoursesOfClassRequest self = new UpdateCoursesOfClassRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCoursesOfClassRequest setCourses(java.util.List<UpdateCoursesOfClassRequestCourses> courses) {
        this.courses = courses;
        return this;
    }
    public java.util.List<UpdateCoursesOfClassRequestCourses> getCourses() {
        return this.courses;
    }

    public UpdateCoursesOfClassRequest setSectionConfig(UpdateCoursesOfClassRequestSectionConfig sectionConfig) {
        this.sectionConfig = sectionConfig;
        return this;
    }
    public UpdateCoursesOfClassRequestSectionConfig getSectionConfig() {
        return this.sectionConfig;
    }

    public UpdateCoursesOfClassRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class UpdateCoursesOfClassRequestCoursesDateModel extends TeaModel {
        // month
        @NameInMap("month")
        public Integer month;

        // year
        @NameInMap("year")
        public Integer year;

        // dayOfMonth
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static UpdateCoursesOfClassRequestCoursesDateModel build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestCoursesDateModel self = new UpdateCoursesOfClassRequestCoursesDateModel();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestCoursesDateModel setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public UpdateCoursesOfClassRequestCoursesDateModel setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public UpdateCoursesOfClassRequestCoursesDateModel setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class UpdateCoursesOfClassRequestCoursesSectionModel extends TeaModel {
        // sectionType
        @NameInMap("sectionType")
        public String sectionType;

        // 节次index
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        // 节次名称
        @NameInMap("sectionName")
        public String sectionName;

        public static UpdateCoursesOfClassRequestCoursesSectionModel build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestCoursesSectionModel self = new UpdateCoursesOfClassRequestCoursesSectionModel();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestCoursesSectionModel setSectionType(String sectionType) {
            this.sectionType = sectionType;
            return this;
        }
        public String getSectionType() {
            return this.sectionType;
        }

        public UpdateCoursesOfClassRequestCoursesSectionModel setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
        }

        public UpdateCoursesOfClassRequestCoursesSectionModel setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

    }

    public static class UpdateCoursesOfClassRequestCourses extends TeaModel {
        // 老师Staffid
        @NameInMap("teacherStaffIds")
        public java.util.List<String> teacherStaffIds;

        // 课程名称
        @NameInMap("courseName")
        public String courseName;

        // 上课日期
        @NameInMap("dateModel")
        public UpdateCoursesOfClassRequestCoursesDateModel dateModel;

        // 节次模型
        @NameInMap("sectionModel")
        public UpdateCoursesOfClassRequestCoursesSectionModel sectionModel;

        // 创建者名字
        @NameInMap("creatorName")
        public String creatorName;

        // 上课地点
        @NameInMap("location")
        public String location;

        // 删除标记：要删除为ture
        @NameInMap("deleteTag")
        public Boolean deleteTag;

        // 课程code：删除/更新必填
        @NameInMap("courseCode")
        public String courseCode;

        public static UpdateCoursesOfClassRequestCourses build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestCourses self = new UpdateCoursesOfClassRequestCourses();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestCourses setTeacherStaffIds(java.util.List<String> teacherStaffIds) {
            this.teacherStaffIds = teacherStaffIds;
            return this;
        }
        public java.util.List<String> getTeacherStaffIds() {
            return this.teacherStaffIds;
        }

        public UpdateCoursesOfClassRequestCourses setCourseName(String courseName) {
            this.courseName = courseName;
            return this;
        }
        public String getCourseName() {
            return this.courseName;
        }

        public UpdateCoursesOfClassRequestCourses setDateModel(UpdateCoursesOfClassRequestCoursesDateModel dateModel) {
            this.dateModel = dateModel;
            return this;
        }
        public UpdateCoursesOfClassRequestCoursesDateModel getDateModel() {
            return this.dateModel;
        }

        public UpdateCoursesOfClassRequestCourses setSectionModel(UpdateCoursesOfClassRequestCoursesSectionModel sectionModel) {
            this.sectionModel = sectionModel;
            return this;
        }
        public UpdateCoursesOfClassRequestCoursesSectionModel getSectionModel() {
            return this.sectionModel;
        }

        public UpdateCoursesOfClassRequestCourses setCreatorName(String creatorName) {
            this.creatorName = creatorName;
            return this;
        }
        public String getCreatorName() {
            return this.creatorName;
        }

        public UpdateCoursesOfClassRequestCourses setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public UpdateCoursesOfClassRequestCourses setDeleteTag(Boolean deleteTag) {
            this.deleteTag = deleteTag;
            return this;
        }
        public Boolean getDeleteTag() {
            return this.deleteTag;
        }

        public UpdateCoursesOfClassRequestCourses setCourseCode(String courseCode) {
            this.courseCode = courseCode;
            return this;
        }
        public String getCourseCode() {
            return this.courseCode;
        }

    }

    public static class UpdateCoursesOfClassRequestSectionConfigSectionModelsStart extends TeaModel {
        // 分钟
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static UpdateCoursesOfClassRequestSectionConfigSectionModelsStart build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestSectionConfigSectionModelsStart self = new UpdateCoursesOfClassRequestSectionConfigSectionModelsStart();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModelsStart setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModelsStart setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

    }

    public static class UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd extends TeaModel {
        // 分钟
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd self = new UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

    }

    public static class UpdateCoursesOfClassRequestSectionConfigSectionModels extends TeaModel {
        // 节次类型枚举：COURSE/REST
        @NameInMap("sectionType")
        public String sectionType;

        // 开始时间
        @NameInMap("start")
        public UpdateCoursesOfClassRequestSectionConfigSectionModelsStart start;

        // 第几节。
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        // 结束时间
        @NameInMap("end")
        public UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd end;

        public static UpdateCoursesOfClassRequestSectionConfigSectionModels build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestSectionConfigSectionModels self = new UpdateCoursesOfClassRequestSectionConfigSectionModels();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModels setSectionType(String sectionType) {
            this.sectionType = sectionType;
            return this;
        }
        public String getSectionType() {
            return this.sectionType;
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModels setStart(UpdateCoursesOfClassRequestSectionConfigSectionModelsStart start) {
            this.start = start;
            return this;
        }
        public UpdateCoursesOfClassRequestSectionConfigSectionModelsStart getStart() {
            return this.start;
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModels setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModels setEnd(UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd end) {
            this.end = end;
            return this;
        }
        public UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd getEnd() {
            return this.end;
        }

    }

    public static class UpdateCoursesOfClassRequestSectionConfig extends TeaModel {
        // 节次模型
        @NameInMap("sectionModels")
        public java.util.List<UpdateCoursesOfClassRequestSectionConfigSectionModels> sectionModels;

        public static UpdateCoursesOfClassRequestSectionConfig build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestSectionConfig self = new UpdateCoursesOfClassRequestSectionConfig();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestSectionConfig setSectionModels(java.util.List<UpdateCoursesOfClassRequestSectionConfigSectionModels> sectionModels) {
            this.sectionModels = sectionModels;
            return this;
        }
        public java.util.List<UpdateCoursesOfClassRequestSectionConfigSectionModels> getSectionModels() {
            return this.sectionModels;
        }

    }

}
