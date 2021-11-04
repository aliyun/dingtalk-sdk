// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateUniversityCourseGroupRequest extends TeaModel {
    // opUserId
    @NameInMap("opUserId")
    public String opUserId;

    // 扩展信息
    @NameInMap("ext")
    public String ext;

    // 课程组编码
    @NameInMap("courseGroupCode")
    public String courseGroupCode;

    // 课程组介绍
    @NameInMap("courseGroupIntroduce")
    public String courseGroupIntroduce;

    // 课程组名称
    @NameInMap("courseGroupName")
    public String courseGroupName;

    // 课程组详细
    @NameInMap("courserGroupItemModels")
    public java.util.List<UpdateUniversityCourseGroupRequestCourserGroupItemModels> courserGroupItemModels;

    public static UpdateUniversityCourseGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateUniversityCourseGroupRequest self = new UpdateUniversityCourseGroupRequest();
        return TeaModel.build(map, self);
    }

    public UpdateUniversityCourseGroupRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public UpdateUniversityCourseGroupRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
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

    public static class UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart extends TeaModel {
        // 月
        @NameInMap("month")
        public Integer month;

        // 年
        @NameInMap("year")
        public Integer year;

        // 一月的第几天
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart build(java.util.Map<String, ?> map) throws Exception {
            UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart self = new UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart();
            return TeaModel.build(map, self);
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd extends TeaModel {
        // 月
        @NameInMap("month")
        public Integer month;

        // 年
        @NameInMap("year")
        public Integer year;

        // 一月的第几天
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd build(java.util.Map<String, ?> map) throws Exception {
            UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd self = new UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd();
            return TeaModel.build(map, self);
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class UpdateUniversityCourseGroupRequestCourserGroupItemModels extends TeaModel {
        // 一周的第几天
        @NameInMap("dayOfWeek")
        public Integer dayOfWeek;

        // 上课周期
        @NameInMap("classPeriodType")
        public Integer classPeriodType;

        // 开始时间
        @NameInMap("start")
        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart start;

        // 课节
        @NameInMap("sectionIndex")
        public java.util.List<Integer> sectionIndex;

        // 结束时间
        @NameInMap("end")
        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd end;

        // 课程类型
        @NameInMap("courseType")
        public Integer courseType;

        // classroomId
        @NameInMap("classroomId")
        public Long classroomId;

        public static UpdateUniversityCourseGroupRequestCourserGroupItemModels build(java.util.Map<String, ?> map) throws Exception {
            UpdateUniversityCourseGroupRequestCourserGroupItemModels self = new UpdateUniversityCourseGroupRequestCourserGroupItemModels();
            return TeaModel.build(map, self);
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setDayOfWeek(Integer dayOfWeek) {
            this.dayOfWeek = dayOfWeek;
            return this;
        }
        public Integer getDayOfWeek() {
            return this.dayOfWeek;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setClassPeriodType(Integer classPeriodType) {
            this.classPeriodType = classPeriodType;
            return this;
        }
        public Integer getClassPeriodType() {
            return this.classPeriodType;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setStart(UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart start) {
            this.start = start;
            return this;
        }
        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart getStart() {
            return this.start;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setSectionIndex(java.util.List<Integer> sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public java.util.List<Integer> getSectionIndex() {
            return this.sectionIndex;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setEnd(UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd end) {
            this.end = end;
            return this;
        }
        public UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd getEnd() {
            return this.end;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setCourseType(Integer courseType) {
            this.courseType = courseType;
            return this;
        }
        public Integer getCourseType() {
            return this.courseType;
        }

        public UpdateUniversityCourseGroupRequestCourserGroupItemModels setClassroomId(Long classroomId) {
            this.classroomId = classroomId;
            return this;
        }
        public Long getClassroomId() {
            return this.classroomId;
        }

    }

}
