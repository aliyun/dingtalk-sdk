// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateSectionConfigRequest extends TeaModel {
    // 扩展参数
    @NameInMap("ext")
    public String ext;

    // 课表模板信息
    @NameInMap("sectionConfigs")
    public java.util.List<CreateSectionConfigRequestSectionConfigs> sectionConfigs;

    // 操作人的userid。
    @NameInMap("opUserId")
    public String opUserId;

    public static CreateSectionConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSectionConfigRequest self = new CreateSectionConfigRequest();
        return TeaModel.build(map, self);
    }

    public CreateSectionConfigRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public CreateSectionConfigRequest setSectionConfigs(java.util.List<CreateSectionConfigRequestSectionConfigs> sectionConfigs) {
        this.sectionConfigs = sectionConfigs;
        return this;
    }
    public java.util.List<CreateSectionConfigRequestSectionConfigs> getSectionConfigs() {
        return this.sectionConfigs;
    }

    public CreateSectionConfigRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class CreateSectionConfigRequestSectionConfigsStart extends TeaModel {
        // 月份。
        @NameInMap("month")
        public Integer month;

        // 年份。
        @NameInMap("year")
        public Integer year;

        // 每个月的第几天。
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static CreateSectionConfigRequestSectionConfigsStart build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsStart self = new CreateSectionConfigRequestSectionConfigsStart();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsStart setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public CreateSectionConfigRequestSectionConfigsStart setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public CreateSectionConfigRequestSectionConfigsStart setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSectionModelsStart extends TeaModel {
        // 分
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static CreateSectionConfigRequestSectionConfigsSectionModelsStart build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionModelsStart self = new CreateSectionConfigRequestSectionConfigsSectionModelsStart();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsStart setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsStart setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSectionModelsEnd extends TeaModel {
        // 分
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static CreateSectionConfigRequestSectionConfigsSectionModelsEnd build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionModelsEnd self = new CreateSectionConfigRequestSectionConfigsSectionModelsEnd();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsEnd setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsEnd setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSectionModels extends TeaModel {
        // 节次类型枚举：COURSE/REST
        @NameInMap("sectionType")
        public String sectionType;

        // 开始时间
        @NameInMap("start")
        public CreateSectionConfigRequestSectionConfigsSectionModelsStart start;

        // 第几节。
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        // 结束时间
        @NameInMap("end")
        public CreateSectionConfigRequestSectionConfigsSectionModelsEnd end;

        // 节次名称
        @NameInMap("sectionName")
        public String sectionName;

        public static CreateSectionConfigRequestSectionConfigsSectionModels build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionModels self = new CreateSectionConfigRequestSectionConfigsSectionModels();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionType(String sectionType) {
            this.sectionType = sectionType;
            return this;
        }
        public String getSectionType() {
            return this.sectionType;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setStart(CreateSectionConfigRequestSectionConfigsSectionModelsStart start) {
            this.start = start;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSectionModelsStart getStart() {
            return this.start;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setEnd(CreateSectionConfigRequestSectionConfigsSectionModelsEnd end) {
            this.end = end;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSectionModelsEnd getEnd() {
            return this.end;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsEnd extends TeaModel {
        // 月
        @NameInMap("month")
        public Integer month;

        // 年
        @NameInMap("year")
        public Integer year;

        // 日
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static CreateSectionConfigRequestSectionConfigsEnd build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsEnd self = new CreateSectionConfigRequestSectionConfigsEnd();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsEnd setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public CreateSectionConfigRequestSectionConfigsEnd setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public CreateSectionConfigRequestSectionConfigsEnd setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSemesterStart extends TeaModel {
        // 月
        @NameInMap("month")
        public Integer month;

        // 年
        @NameInMap("year")
        public Integer year;

        // 日
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static CreateSectionConfigRequestSectionConfigsSemesterStart build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSemesterStart self = new CreateSectionConfigRequestSectionConfigsSemesterStart();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSemesterStart setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public CreateSectionConfigRequestSectionConfigsSemesterStart setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public CreateSectionConfigRequestSectionConfigsSemesterStart setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSemesterEnd extends TeaModel {
        // 月
        @NameInMap("month")
        public Integer month;

        // 年
        @NameInMap("year")
        public Integer year;

        // 每月第几天
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static CreateSectionConfigRequestSectionConfigsSemesterEnd build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSemesterEnd self = new CreateSectionConfigRequestSectionConfigsSemesterEnd();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSemesterEnd setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public CreateSectionConfigRequestSectionConfigsSemesterEnd setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public CreateSectionConfigRequestSectionConfigsSemesterEnd setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigs extends TeaModel {
        // 学期
        @NameInMap("semester")
        public Integer semester;

        // 开始时间（精确到日）
        @NameInMap("start")
        public CreateSectionConfigRequestSectionConfigsStart start;

        // 学年
        @NameInMap("schoolYear")
        public String schoolYear;

        // 课表名称
        @NameInMap("scheduleName")
        public String scheduleName;

        // 节次模型
        @NameInMap("sectionModels")
        public java.util.List<CreateSectionConfigRequestSectionConfigsSectionModels> sectionModels;

        // 结束时间
        @NameInMap("end")
        public CreateSectionConfigRequestSectionConfigsEnd end;

        // 学期开始时间
        @NameInMap("semesterStart")
        public CreateSectionConfigRequestSectionConfigsSemesterStart semesterStart;

        // 学期结束时间
        @NameInMap("semesterEnd")
        public CreateSectionConfigRequestSectionConfigsSemesterEnd semesterEnd;

        public static CreateSectionConfigRequestSectionConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigs self = new CreateSectionConfigRequestSectionConfigs();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigs setSemester(Integer semester) {
            this.semester = semester;
            return this;
        }
        public Integer getSemester() {
            return this.semester;
        }

        public CreateSectionConfigRequestSectionConfigs setStart(CreateSectionConfigRequestSectionConfigsStart start) {
            this.start = start;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsStart getStart() {
            return this.start;
        }

        public CreateSectionConfigRequestSectionConfigs setSchoolYear(String schoolYear) {
            this.schoolYear = schoolYear;
            return this;
        }
        public String getSchoolYear() {
            return this.schoolYear;
        }

        public CreateSectionConfigRequestSectionConfigs setScheduleName(String scheduleName) {
            this.scheduleName = scheduleName;
            return this;
        }
        public String getScheduleName() {
            return this.scheduleName;
        }

        public CreateSectionConfigRequestSectionConfigs setSectionModels(java.util.List<CreateSectionConfigRequestSectionConfigsSectionModels> sectionModels) {
            this.sectionModels = sectionModels;
            return this;
        }
        public java.util.List<CreateSectionConfigRequestSectionConfigsSectionModels> getSectionModels() {
            return this.sectionModels;
        }

        public CreateSectionConfigRequestSectionConfigs setEnd(CreateSectionConfigRequestSectionConfigsEnd end) {
            this.end = end;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsEnd getEnd() {
            return this.end;
        }

        public CreateSectionConfigRequestSectionConfigs setSemesterStart(CreateSectionConfigRequestSectionConfigsSemesterStart semesterStart) {
            this.semesterStart = semesterStart;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSemesterStart getSemesterStart() {
            return this.semesterStart;
        }

        public CreateSectionConfigRequestSectionConfigs setSemesterEnd(CreateSectionConfigRequestSectionConfigsSemesterEnd semesterEnd) {
            this.semesterEnd = semesterEnd;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSemesterEnd getSemesterEnd() {
            return this.semesterEnd;
        }

    }

}
