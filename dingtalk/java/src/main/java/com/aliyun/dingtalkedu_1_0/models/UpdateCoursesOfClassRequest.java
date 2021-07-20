// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCoursesOfClassRequest extends TeaModel {
    @NameInMap("courses")
    public java.util.List<UpdateCoursesOfClassRequestCourses> courses;

    // opUserId
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

        // sectionIndex
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        // sectionName
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
        // teacherStaffIds
        @NameInMap("teacherStaffIds")
        public java.util.List<String> teacherStaffIds;

        // courseName
        @NameInMap("courseName")
        public String courseName;

        // dateModel
        @NameInMap("dateModel")
        public UpdateCoursesOfClassRequestCoursesDateModel dateModel;

        // sectionModel
        @NameInMap("sectionModel")
        public UpdateCoursesOfClassRequestCoursesSectionModel sectionModel;

        // creatorName
        @NameInMap("creatorName")
        public String creatorName;

        // location
        @NameInMap("location")
        public String location;

        // deleteTag
        @NameInMap("deleteTag")
        public Boolean deleteTag;

        // courseCode
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

}
