// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ResultDurationSettingsValue extends TeaModel {
    @NameInMap("calcType")
    public Integer calcType;

    @NameInMap("durationType")
    public Integer durationType;

    // 加班时长计为调休或加班费开关
    @NameInMap("overtimeRedress")
    public Boolean overtimeRedress;

    // 加班开始时间 或 最小加班时间
    @NameInMap("settings")
    public java.util.Map<String, ?> settings;

    // 加班时长计为方式
    @NameInMap("overtimeRedressBy")
    public String overtimeRedressBy;

    // 调休时长计算
    @NameInMap("vacationRate")
    public Float vacationRate;

    // 扣除休息时间
    @NameInMap("skipTime")
    public String skipTime;

    // 休息时段
    @NameInMap("skipTimeByFrames")
    public java.util.List<ResultDurationSettingsValueSkipTimeByFrames> skipTimeByFrames;

    // 加班时长
    @NameInMap("skipTimeByDurations")
    public java.util.List<ResultDurationSettingsValueSkipTimeByDurations> skipTimeByDurations;

    // 休息日或节假日排班加班时长计为调休或加班费开关
    @NameInMap("holidayPlanOvertimeRedress")
    public Boolean holidayPlanOvertimeRedress;

    // 休息日或节假日排班加班时长计为方式
    @NameInMap("holidayPlanOvertimeRedressBy")
    public String holidayPlanOvertimeRedressBy;

    // 休息日或节假日排班调休时长计算
    @NameInMap("holidayPlanVacationRate")
    public Float holidayPlanVacationRate;

    public static ResultDurationSettingsValue build(java.util.Map<String, ?> map) throws Exception {
        ResultDurationSettingsValue self = new ResultDurationSettingsValue();
        return TeaModel.build(map, self);
    }

    public ResultDurationSettingsValue setCalcType(Integer calcType) {
        this.calcType = calcType;
        return this;
    }
    public Integer getCalcType() {
        return this.calcType;
    }

    public ResultDurationSettingsValue setDurationType(Integer durationType) {
        this.durationType = durationType;
        return this;
    }
    public Integer getDurationType() {
        return this.durationType;
    }

    public ResultDurationSettingsValue setOvertimeRedress(Boolean overtimeRedress) {
        this.overtimeRedress = overtimeRedress;
        return this;
    }
    public Boolean getOvertimeRedress() {
        return this.overtimeRedress;
    }

    public ResultDurationSettingsValue setSettings(java.util.Map<String, ?> settings) {
        this.settings = settings;
        return this;
    }
    public java.util.Map<String, ?> getSettings() {
        return this.settings;
    }

    public ResultDurationSettingsValue setOvertimeRedressBy(String overtimeRedressBy) {
        this.overtimeRedressBy = overtimeRedressBy;
        return this;
    }
    public String getOvertimeRedressBy() {
        return this.overtimeRedressBy;
    }

    public ResultDurationSettingsValue setVacationRate(Float vacationRate) {
        this.vacationRate = vacationRate;
        return this;
    }
    public Float getVacationRate() {
        return this.vacationRate;
    }

    public ResultDurationSettingsValue setSkipTime(String skipTime) {
        this.skipTime = skipTime;
        return this;
    }
    public String getSkipTime() {
        return this.skipTime;
    }

    public ResultDurationSettingsValue setSkipTimeByFrames(java.util.List<ResultDurationSettingsValueSkipTimeByFrames> skipTimeByFrames) {
        this.skipTimeByFrames = skipTimeByFrames;
        return this;
    }
    public java.util.List<ResultDurationSettingsValueSkipTimeByFrames> getSkipTimeByFrames() {
        return this.skipTimeByFrames;
    }

    public ResultDurationSettingsValue setSkipTimeByDurations(java.util.List<ResultDurationSettingsValueSkipTimeByDurations> skipTimeByDurations) {
        this.skipTimeByDurations = skipTimeByDurations;
        return this;
    }
    public java.util.List<ResultDurationSettingsValueSkipTimeByDurations> getSkipTimeByDurations() {
        return this.skipTimeByDurations;
    }

    public ResultDurationSettingsValue setHolidayPlanOvertimeRedress(Boolean holidayPlanOvertimeRedress) {
        this.holidayPlanOvertimeRedress = holidayPlanOvertimeRedress;
        return this;
    }
    public Boolean getHolidayPlanOvertimeRedress() {
        return this.holidayPlanOvertimeRedress;
    }

    public ResultDurationSettingsValue setHolidayPlanOvertimeRedressBy(String holidayPlanOvertimeRedressBy) {
        this.holidayPlanOvertimeRedressBy = holidayPlanOvertimeRedressBy;
        return this;
    }
    public String getHolidayPlanOvertimeRedressBy() {
        return this.holidayPlanOvertimeRedressBy;
    }

    public ResultDurationSettingsValue setHolidayPlanVacationRate(Float holidayPlanVacationRate) {
        this.holidayPlanVacationRate = holidayPlanVacationRate;
        return this;
    }
    public Float getHolidayPlanVacationRate() {
        return this.holidayPlanVacationRate;
    }

    public static class ResultDurationSettingsValueSkipTimeByFrames extends TeaModel {
        // 开始时间，格式为"HH:mm"
        @NameInMap("startTime")
        public String startTime;

        // 结束时间，格式为"HH:mm"
        @NameInMap("endTime")
        public String endTime;

        // 是否生效
        @NameInMap("valid")
        public Boolean valid;

        public static ResultDurationSettingsValueSkipTimeByFrames build(java.util.Map<String, ?> map) throws Exception {
            ResultDurationSettingsValueSkipTimeByFrames self = new ResultDurationSettingsValueSkipTimeByFrames();
            return TeaModel.build(map, self);
        }

        public ResultDurationSettingsValueSkipTimeByFrames setStartTime(String startTime) {
            this.startTime = startTime;
            return this;
        }
        public String getStartTime() {
            return this.startTime;
        }

        public ResultDurationSettingsValueSkipTimeByFrames setEndTime(String endTime) {
            this.endTime = endTime;
            return this;
        }
        public String getEndTime() {
            return this.endTime;
        }

        public ResultDurationSettingsValueSkipTimeByFrames setValid(Boolean valid) {
            this.valid = valid;
            return this;
        }
        public Boolean getValid() {
            return this.valid;
        }

    }

    public static class ResultDurationSettingsValueSkipTimeByDurations extends TeaModel {
        // 每天加班满 x小时，单位 秒
        @NameInMap("duration")
        public Long duration;

        // 扣除 x小时，单位 秒
        @NameInMap("minus")
        public Long minus;

        public static ResultDurationSettingsValueSkipTimeByDurations build(java.util.Map<String, ?> map) throws Exception {
            ResultDurationSettingsValueSkipTimeByDurations self = new ResultDurationSettingsValueSkipTimeByDurations();
            return TeaModel.build(map, self);
        }

        public ResultDurationSettingsValueSkipTimeByDurations setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public ResultDurationSettingsValueSkipTimeByDurations setMinus(Long minus) {
            this.minus = minus;
            return this;
        }
        public Long getMinus() {
            return this.minus;
        }

    }

}
