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

    public static class CreateSectionConfigRequestSectionConfigsSectionStartDate extends TeaModel {
        // 月份。
        @NameInMap("month")
        public Integer month;

        // 年份。
        @NameInMap("year")
        public Integer year;

        // 每个月的第几天。
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static CreateSectionConfigRequestSectionConfigsSectionStartDate build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionStartDate self = new CreateSectionConfigRequestSectionConfigsSectionStartDate();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionStartDate setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public CreateSectionConfigRequestSectionConfigsSectionStartDate setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public CreateSectionConfigRequestSectionConfigsSectionStartDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime extends TeaModel {
        // 分
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime self = new CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime extends TeaModel {
        // 分
        @NameInMap("min")
        public Integer min;

        // 小时
        @NameInMap("hour")
        public Integer hour;

        public static CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime self = new CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime setHour(Integer hour) {
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
        @NameInMap("sectionStartTime")
        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime sectionStartTime;

        // 第几节。
        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        // 结束时间
        @NameInMap("sectionEndTime")
        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime sectionEndTime;

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

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionStartTime(CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime sectionStartTime) {
            this.sectionStartTime = sectionStartTime;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime getSectionStartTime() {
            return this.sectionStartTime;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionEndTime(CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime sectionEndTime) {
            this.sectionEndTime = sectionEndTime;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime getSectionEndTime() {
            return this.sectionEndTime;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSectionEndDate extends TeaModel {
        // 月
        @NameInMap("month")
        public Integer month;

        // 年
        @NameInMap("year")
        public Integer year;

        // 日
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static CreateSectionConfigRequestSectionConfigsSectionEndDate build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionEndDate self = new CreateSectionConfigRequestSectionConfigsSectionEndDate();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionEndDate setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public CreateSectionConfigRequestSectionConfigsSectionEndDate setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public CreateSectionConfigRequestSectionConfigsSectionEndDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSemesterStartDate extends TeaModel {
        // 月
        @NameInMap("month")
        public Integer month;

        // 年
        @NameInMap("year")
        public Integer year;

        // 日
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static CreateSectionConfigRequestSectionConfigsSemesterStartDate build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSemesterStartDate self = new CreateSectionConfigRequestSectionConfigsSemesterStartDate();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSemesterStartDate setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public CreateSectionConfigRequestSectionConfigsSemesterStartDate setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public CreateSectionConfigRequestSectionConfigsSemesterStartDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSemesterEndDate extends TeaModel {
        // 月
        @NameInMap("month")
        public Integer month;

        // 年
        @NameInMap("year")
        public Integer year;

        // 每月第几天
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        public static CreateSectionConfigRequestSectionConfigsSemesterEndDate build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSemesterEndDate self = new CreateSectionConfigRequestSectionConfigsSemesterEndDate();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSemesterEndDate setMonth(Integer month) {
            this.month = month;
            return this;
        }
        public Integer getMonth() {
            return this.month;
        }

        public CreateSectionConfigRequestSectionConfigsSemesterEndDate setYear(Integer year) {
            this.year = year;
            return this;
        }
        public Integer getYear() {
            return this.year;
        }

        public CreateSectionConfigRequestSectionConfigsSemesterEndDate setDayOfMonth(Integer dayOfMonth) {
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
        @NameInMap("sectionStartDate")
        public CreateSectionConfigRequestSectionConfigsSectionStartDate sectionStartDate;

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
        @NameInMap("sectionEndDate")
        public CreateSectionConfigRequestSectionConfigsSectionEndDate sectionEndDate;

        // 学期开始时间
        @NameInMap("semesterStartDate")
        public CreateSectionConfigRequestSectionConfigsSemesterStartDate semesterStartDate;

        // 学期结束时间
        @NameInMap("semesterEndDate")
        public CreateSectionConfigRequestSectionConfigsSemesterEndDate semesterEndDate;

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

        public CreateSectionConfigRequestSectionConfigs setSectionStartDate(CreateSectionConfigRequestSectionConfigsSectionStartDate sectionStartDate) {
            this.sectionStartDate = sectionStartDate;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSectionStartDate getSectionStartDate() {
            return this.sectionStartDate;
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

        public CreateSectionConfigRequestSectionConfigs setSectionEndDate(CreateSectionConfigRequestSectionConfigsSectionEndDate sectionEndDate) {
            this.sectionEndDate = sectionEndDate;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSectionEndDate getSectionEndDate() {
            return this.sectionEndDate;
        }

        public CreateSectionConfigRequestSectionConfigs setSemesterStartDate(CreateSectionConfigRequestSectionConfigsSemesterStartDate semesterStartDate) {
            this.semesterStartDate = semesterStartDate;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSemesterStartDate getSemesterStartDate() {
            return this.semesterStartDate;
        }

        public CreateSectionConfigRequestSectionConfigs setSemesterEndDate(CreateSectionConfigRequestSectionConfigsSemesterEndDate semesterEndDate) {
            this.semesterEndDate = semesterEndDate;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSemesterEndDate getSemesterEndDate() {
            return this.semesterEndDate;
        }

    }

}
