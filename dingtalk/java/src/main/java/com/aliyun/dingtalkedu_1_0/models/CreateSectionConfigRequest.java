// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateSectionConfigRequest extends TeaModel {
    @NameInMap("ext")
    public String ext;

    @NameInMap("sectionConfigs")
    public java.util.List<CreateSectionConfigRequestSectionConfigs> sectionConfigs;

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

    public static class CreateSectionConfigRequestSectionConfigsSectionEndDate extends TeaModel {
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("month")
        public Integer month;

        @NameInMap("year")
        public Integer year;

        public static CreateSectionConfigRequestSectionConfigsSectionEndDate build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionEndDate self = new CreateSectionConfigRequestSectionConfigsSectionEndDate();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionEndDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
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

    }

    public static class CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime extends TeaModel {
        @NameInMap("hour")
        public Integer hour;

        @NameInMap("min")
        public Integer min;

        public static CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime self = new CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime extends TeaModel {
        @NameInMap("hour")
        public Integer hour;

        @NameInMap("min")
        public Integer min;

        public static CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime self = new CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime setHour(Integer hour) {
            this.hour = hour;
            return this;
        }
        public Integer getHour() {
            return this.hour;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime setMin(Integer min) {
            this.min = min;
            return this;
        }
        public Integer getMin() {
            return this.min;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSectionModels extends TeaModel {
        @NameInMap("sectionEndTime")
        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime sectionEndTime;

        @NameInMap("sectionIndex")
        public Integer sectionIndex;

        @NameInMap("sectionName")
        public String sectionName;

        @NameInMap("sectionStartTime")
        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime sectionStartTime;

        @NameInMap("sectionType")
        public String sectionType;

        public static CreateSectionConfigRequestSectionConfigsSectionModels build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionModels self = new CreateSectionConfigRequestSectionConfigsSectionModels();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionEndTime(CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime sectionEndTime) {
            this.sectionEndTime = sectionEndTime;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime getSectionEndTime() {
            return this.sectionEndTime;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionIndex(Integer sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Integer getSectionIndex() {
            return this.sectionIndex;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionStartTime(CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime sectionStartTime) {
            this.sectionStartTime = sectionStartTime;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime getSectionStartTime() {
            return this.sectionStartTime;
        }

        public CreateSectionConfigRequestSectionConfigsSectionModels setSectionType(String sectionType) {
            this.sectionType = sectionType;
            return this;
        }
        public String getSectionType() {
            return this.sectionType;
        }

    }

    public static class CreateSectionConfigRequestSectionConfigsSectionStartDate extends TeaModel {
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("month")
        public Integer month;

        @NameInMap("year")
        public Integer year;

        public static CreateSectionConfigRequestSectionConfigsSectionStartDate build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSectionStartDate self = new CreateSectionConfigRequestSectionConfigsSectionStartDate();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSectionStartDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
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

    }

    public static class CreateSectionConfigRequestSectionConfigsSemesterEndDate extends TeaModel {
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("month")
        public Integer month;

        @NameInMap("year")
        public Integer year;

        public static CreateSectionConfigRequestSectionConfigsSemesterEndDate build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSemesterEndDate self = new CreateSectionConfigRequestSectionConfigsSemesterEndDate();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSemesterEndDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
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

    }

    public static class CreateSectionConfigRequestSectionConfigsSemesterStartDate extends TeaModel {
        @NameInMap("dayOfMonth")
        public Integer dayOfMonth;

        @NameInMap("month")
        public Integer month;

        @NameInMap("year")
        public Integer year;

        public static CreateSectionConfigRequestSectionConfigsSemesterStartDate build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigsSemesterStartDate self = new CreateSectionConfigRequestSectionConfigsSemesterStartDate();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigsSemesterStartDate setDayOfMonth(Integer dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Integer getDayOfMonth() {
            return this.dayOfMonth;
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

    }

    public static class CreateSectionConfigRequestSectionConfigs extends TeaModel {
        @NameInMap("scheduleName")
        public String scheduleName;

        @NameInMap("schoolYear")
        public String schoolYear;

        @NameInMap("sectionEndDate")
        public CreateSectionConfigRequestSectionConfigsSectionEndDate sectionEndDate;

        @NameInMap("sectionModels")
        public java.util.List<CreateSectionConfigRequestSectionConfigsSectionModels> sectionModels;

        @NameInMap("sectionStartDate")
        public CreateSectionConfigRequestSectionConfigsSectionStartDate sectionStartDate;

        @NameInMap("semester")
        public Integer semester;

        @NameInMap("semesterEndDate")
        public CreateSectionConfigRequestSectionConfigsSemesterEndDate semesterEndDate;

        @NameInMap("semesterStartDate")
        public CreateSectionConfigRequestSectionConfigsSemesterStartDate semesterStartDate;

        public static CreateSectionConfigRequestSectionConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreateSectionConfigRequestSectionConfigs self = new CreateSectionConfigRequestSectionConfigs();
            return TeaModel.build(map, self);
        }

        public CreateSectionConfigRequestSectionConfigs setScheduleName(String scheduleName) {
            this.scheduleName = scheduleName;
            return this;
        }
        public String getScheduleName() {
            return this.scheduleName;
        }

        public CreateSectionConfigRequestSectionConfigs setSchoolYear(String schoolYear) {
            this.schoolYear = schoolYear;
            return this;
        }
        public String getSchoolYear() {
            return this.schoolYear;
        }

        public CreateSectionConfigRequestSectionConfigs setSectionEndDate(CreateSectionConfigRequestSectionConfigsSectionEndDate sectionEndDate) {
            this.sectionEndDate = sectionEndDate;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSectionEndDate getSectionEndDate() {
            return this.sectionEndDate;
        }

        public CreateSectionConfigRequestSectionConfigs setSectionModels(java.util.List<CreateSectionConfigRequestSectionConfigsSectionModels> sectionModels) {
            this.sectionModels = sectionModels;
            return this;
        }
        public java.util.List<CreateSectionConfigRequestSectionConfigsSectionModels> getSectionModels() {
            return this.sectionModels;
        }

        public CreateSectionConfigRequestSectionConfigs setSectionStartDate(CreateSectionConfigRequestSectionConfigsSectionStartDate sectionStartDate) {
            this.sectionStartDate = sectionStartDate;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSectionStartDate getSectionStartDate() {
            return this.sectionStartDate;
        }

        public CreateSectionConfigRequestSectionConfigs setSemester(Integer semester) {
            this.semester = semester;
            return this;
        }
        public Integer getSemester() {
            return this.semester;
        }

        public CreateSectionConfigRequestSectionConfigs setSemesterEndDate(CreateSectionConfigRequestSectionConfigsSemesterEndDate semesterEndDate) {
            this.semesterEndDate = semesterEndDate;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSemesterEndDate getSemesterEndDate() {
            return this.semesterEndDate;
        }

        public CreateSectionConfigRequestSectionConfigs setSemesterStartDate(CreateSectionConfigRequestSectionConfigsSemesterStartDate semesterStartDate) {
            this.semesterStartDate = semesterStartDate;
            return this;
        }
        public CreateSectionConfigRequestSectionConfigsSemesterStartDate getSemesterStartDate() {
            return this.semesterStartDate;
        }

    }

}
