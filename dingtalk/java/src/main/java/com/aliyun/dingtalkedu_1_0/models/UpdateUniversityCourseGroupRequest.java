// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateUniversityCourseGroupRequest extends TeaModel {
    /**
     * <p>课程组编码</p>
     */
    @NameInMap("courseGroupCode")
    public String courseGroupCode;

    /**
     * <p>课程组介绍</p>
     */
    @NameInMap("courseGroupIntroduce")
    public String courseGroupIntroduce;

    /**
     * <p>课程组名称</p>
     */
    @NameInMap("courseGroupName")
    public String courseGroupName;

    /**
     * <p>课程组详细</p>
     */
    @NameInMap("courserGroupItemModels")
    public java.util.List<UpdateUniversityCourseGroupRequestCourserGroupItemModels> courserGroupItemModels;

    /**
     * <p>扩展信息</p>
     */
    @NameInMap("ext")
    public String ext;

    /**
     * <p>opUserId</p>
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
         * <p>一月的第几天</p>
         */
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        /**
         * <p>月</p>
         */
        @NameInMap("month")
        public Integer month;

        /**
         * <p>年</p>
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
         * <p>一月的第几天</p>
         */
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        /**
         * <p>月</p>
         */
        @NameInMap("month")
        public Integer month;

        /**
         * <p>年</p>
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
         * <p>上课周期</p>
         */
        @NameInMap("classPeriodType")
        public Integer classPeriodType;

        /**
         * <p>classroomId</p>
         */
        @NameInMap("classroomId")
        public Long classroomId;

        /**
         * <p>课程类型</p>
         */
        @NameInMap("courseType")
        public Integer courseType;

        /**
         * <p>结束时间</p>
         */
        @NameInMap("courserGroupItemEndDate")
        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate courserGroupItemEndDate;

        /**
         * <p>开始时间</p>
         */
        @NameInMap("courserGroupItemStartDate")
        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate courserGroupItemStartDate;

        /**
         * <p>一周的第几天</p>
         */
        @NameInMap("dayOfWeek")
        public Integer dayOfWeek;

        /**
         * <p>课节</p>
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
