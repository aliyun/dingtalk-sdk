// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCoursesOfClassRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("courses")
    public java.util.List<UpdateCoursesOfClassRequestCourses> courses;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sectionConfig")
    public UpdateCoursesOfClassRequestSectionConfig sectionConfig;

    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("month")
        public Integer month;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("year")
        public Integer year;

        public static UpdateCoursesOfClassRequestCoursesDateModel build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestCoursesDateModel self = new UpdateCoursesOfClassRequestCoursesDateModel();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestCoursesDateModel setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
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

    }

    public static class UpdateCoursesOfClassRequestCoursesSectionModel extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("sectionName")
        public String sectionName;

        @NameInMap("sectionType")
        public String sectionType;

        public static UpdateCoursesOfClassRequestCoursesSectionModel build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestCoursesSectionModel self = new UpdateCoursesOfClassRequestCoursesSectionModel();
            return TeaModel.build(map, self);
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

        public UpdateCoursesOfClassRequestCoursesSectionModel setSectionType(String sectionType) {
            this.sectionType = sectionType;
            return this;
        }
        public String getSectionType() {
            return this.sectionType;
        }

    }

    public static class UpdateCoursesOfClassRequestCourses extends TeaModel {
        @NameInMap("courseCode")
        public String courseCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("courseGroupCode")
        public String courseGroupCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("courseName")
        public String courseName;

        @NameInMap("creatorName")
        public String creatorName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dateModel")
        public UpdateCoursesOfClassRequestCoursesDateModel dateModel;

        @NameInMap("deleteTag")
        public Boolean deleteTag;

        @NameInMap("location")
        public String location;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("sectionModel")
        public UpdateCoursesOfClassRequestCoursesSectionModel sectionModel;

        @NameInMap("teacherStaffIds")
        public java.util.List<String> teacherStaffIds;

        public static UpdateCoursesOfClassRequestCourses build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestCourses self = new UpdateCoursesOfClassRequestCourses();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestCourses setCourseCode(String courseCode) {
            this.courseCode = courseCode;
            return this;
        }
        public String getCourseCode() {
            return this.courseCode;
        }

        public UpdateCoursesOfClassRequestCourses setCourseGroupCode(String courseGroupCode) {
            this.courseGroupCode = courseGroupCode;
            return this;
        }
        public String getCourseGroupCode() {
            return this.courseGroupCode;
        }

        public UpdateCoursesOfClassRequestCourses setCourseName(String courseName) {
            this.courseName = courseName;
            return this;
        }
        public String getCourseName() {
            return this.courseName;
        }

        public UpdateCoursesOfClassRequestCourses setCreatorName(String creatorName) {
            this.creatorName = creatorName;
            return this;
        }
        public String getCreatorName() {
            return this.creatorName;
        }

        public UpdateCoursesOfClassRequestCourses setDateModel(UpdateCoursesOfClassRequestCoursesDateModel dateModel) {
            this.dateModel = dateModel;
            return this;
        }
        public UpdateCoursesOfClassRequestCoursesDateModel getDateModel() {
            return this.dateModel;
        }

        public UpdateCoursesOfClassRequestCourses setDeleteTag(Boolean deleteTag) {
            this.deleteTag = deleteTag;
            return this;
        }
        public Boolean getDeleteTag() {
            return this.deleteTag;
        }

        public UpdateCoursesOfClassRequestCourses setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public UpdateCoursesOfClassRequestCourses setSectionModel(UpdateCoursesOfClassRequestCoursesSectionModel sectionModel) {
            this.sectionModel = sectionModel;
            return this;
        }
        public UpdateCoursesOfClassRequestCoursesSectionModel getSectionModel() {
            return this.sectionModel;
        }

        public UpdateCoursesOfClassRequestCourses setTeacherStaffIds(java.util.List<String> teacherStaffIds) {
            this.teacherStaffIds = teacherStaffIds;
            return this;
        }
        public java.util.List<String> getTeacherStaffIds() {
            return this.teacherStaffIds;
        }

    }

    public static class UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("hour")
        public Integer hour;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("min")
        public Integer min;

        public static UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd self = new UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

    }

    public static class UpdateCoursesOfClassRequestSectionConfigSectionModelsStart extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("hour")
        public Integer hour;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("min")
        public Integer min;

        public static UpdateCoursesOfClassRequestSectionConfigSectionModelsStart build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestSectionConfigSectionModelsStart self = new UpdateCoursesOfClassRequestSectionConfigSectionModelsStart();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModelsStart setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModelsStart setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

    }

    public static class UpdateCoursesOfClassRequestSectionConfigSectionModels extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("end")
        public UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd end;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        @NameInMap("sectionType")
        public String sectionType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("start")
        public UpdateCoursesOfClassRequestSectionConfigSectionModelsStart start;

        public static UpdateCoursesOfClassRequestSectionConfigSectionModels build(java.util.Map<String, ?> map) throws Exception {
            UpdateCoursesOfClassRequestSectionConfigSectionModels self = new UpdateCoursesOfClassRequestSectionConfigSectionModels();
            return TeaModel.build(map, self);
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModels setEnd(UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd end) {
            this.end = end;
            return this;
        }
        public UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd getEnd() {
            return this.end;
        }

        public UpdateCoursesOfClassRequestSectionConfigSectionModels setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
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

    }

    public static class UpdateCoursesOfClassRequestSectionConfig extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
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
