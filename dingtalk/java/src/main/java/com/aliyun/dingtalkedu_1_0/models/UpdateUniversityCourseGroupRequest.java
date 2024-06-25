// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateUniversityCourseGroupRequest extends TeaModel {
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
     * <p>高等数学</p>
     */
    @NameInMap("courseGroupIntroduce")
    public String courseGroupIntroduce;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>高等数学</p>
     */
    @NameInMap("courseGroupName")
    public String courseGroupName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("courserGroupItemModels")
    public java.util.List<UpdateUniversityCourseGroupRequestCourserGroupItemModels> courserGroupItemModels;

    /**
     * <strong>example:</strong>
     * <p>{}</p>
     */
    @NameInMap("ext")
    public String ext;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manger1234</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static UpdateUniversityCourseGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateUniversityCourseGroupRequest self = new UpdateUniversityCourseGroupRequest();
        return TeaModel.build(map, self);
    }

    public UpdateUniversityCourseGroupRequest setCourseGroupCode(String courseGroupCode) {
        this.courseGroupCode = courseGroupCode;
        return this;
    }
    public String getCourseGroupCode() {
        return this.courseGroupCode;
    }

    public UpdateUniversityCourseGroupRequest setCourseGroupIntroduce(String courseGroupIntroduce) {
        this.courseGroupIntroduce = courseGroupIntroduce;
        return this;
    }
    public String getCourseGroupIntroduce() {
        return this.courseGroupIntroduce;
    }

    public UpdateUniversityCourseGroupRequest setCourseGroupName(String courseGroupName) {
        this.courseGroupName = courseGroupName;
        return this;
    }
    public String getCourseGroupName() {
        return this.courseGroupName;
    }

    public UpdateUniversityCourseGroupRequest setCourserGroupItemModels(java.util.List<UpdateUniversityCourseGroupRequestCourserGroupItemModels> courserGroupItemModels) {
        this.courserGroupItemModels = courserGroupItemModels;
        return this;
    }
    public java.util.List<UpdateUniversityCourseGroupRequestCourserGroupItemModels> getCourserGroupItemModels() {
        return this.courserGroupItemModels;
    }

    public UpdateUniversityCourseGroupRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public UpdateUniversityCourseGroupRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate extends TeaModel {
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

        public static UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate build(java.util.Map<String, ?> map) throws Exception {
            UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate self = new UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate();
            return TeaModel.build(map, self);
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

    }

    public static class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate extends TeaModel {
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

        public static UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate build(java.util.Map<String, ?> map) throws Exception {
            UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate self = new UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate();
            return TeaModel.build(map, self);
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

    }

    public static class UpdateUniversityCourseGroupRequestCourserGroupItemModels extends TeaModel {
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
         * <p>1:音视频直播\2:线下课程\4:音视频及线下</p>
         */
        @NameInMap("classroomId")
        public Long classroomId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("courseType")
        public Integer courseType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("courserGroupItemEndDate")
        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate courserGroupItemEndDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("courserGroupItemStartDate")
        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate courserGroupItemStartDate;

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

        public static UpdateUniversityCourseGroupRequestCourserGroupItemModels build(java.util.Map<String, ?> map) throws Exception {
            UpdateUniversityCourseGroupRequestCourserGroupItemModels self = new UpdateUniversityCourseGroupRequestCourserGroupItemModels();
            return TeaModel.build(map, self);
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setClassPeriodType(Integer classPeriodType) {
            this.classPeriodType = classPeriodType;
            return this;
        }
        public Integer getClassPeriodType() {
            return this.classPeriodType;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setClassroomId(Long classroomId) {
            this.classroomId = classroomId;
            return this;
        }
        public Long getClassroomId() {
            return this.classroomId;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setCourseType(Integer courseType) {
            this.courseType = courseType;
            return this;
        }
        public Integer getCourseType() {
            return this.courseType;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setCourserGroupItemEndDate(UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate courserGroupItemEndDate) {
            this.courserGroupItemEndDate = courserGroupItemEndDate;
            return this;
        }
        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate getCourserGroupItemEndDate() {
            return this.courserGroupItemEndDate;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setCourserGroupItemStartDate(UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate courserGroupItemStartDate) {
            this.courserGroupItemStartDate = courserGroupItemStartDate;
            return this;
        }
        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate getCourserGroupItemStartDate() {
            return this.courserGroupItemStartDate;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setDayOfWeek(Integer dayOfWeek) {
            this.dayOfWeek = dayOfWeek;
            return this;
        }
        public Integer getDayOfWeek() {
            return this.dayOfWeek;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setSectionIndex(java.util.List<Integer> sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public java.util.List<Integer> getSectionIndex() {
            return this.sectionIndex;
        }

    }

}
