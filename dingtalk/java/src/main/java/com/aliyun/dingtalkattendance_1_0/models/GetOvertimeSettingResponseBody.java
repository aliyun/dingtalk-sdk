// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetOvertimeSettingResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetOvertimeSettingResponseBodyResult> result;

    public static GetOvertimeSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOvertimeSettingResponseBody self = new GetOvertimeSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOvertimeSettingResponseBody setResult(java.util.List<GetOvertimeSettingResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetOvertimeSettingResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetOvertimeSettingResponseBodyResultOvertimeDivisions extends TeaModel {
        @NameInMap("nextDayType")
        public String nextDayType;

        @NameInMap("previousDayType")
        public String previousDayType;

        @NameInMap("timeSplitPoint")
        public String timeSplitPoint;

        public static GetOvertimeSettingResponseBodyResultOvertimeDivisions build(java.util.Map<String, ?> map) throws Exception {
            GetOvertimeSettingResponseBodyResultOvertimeDivisions self = new GetOvertimeSettingResponseBodyResultOvertimeDivisions();
            return TeaModel.build(map, self);
        }

        public GetOvertimeSettingResponseBodyResultOvertimeDivisions setNextDayType(String nextDayType) {
            this.nextDayType = nextDayType;
            return this;
        }
        public String getNextDayType() {
            return this.nextDayType;
        }

        public GetOvertimeSettingResponseBodyResultOvertimeDivisions setPreviousDayType(String previousDayType) {
            this.previousDayType = previousDayType;
            return this;
        }
        public String getPreviousDayType() {
            return this.previousDayType;
        }

        public GetOvertimeSettingResponseBodyResultOvertimeDivisions setTimeSplitPoint(String timeSplitPoint) {
            this.timeSplitPoint = timeSplitPoint;
            return this;
        }
        public String getTimeSplitPoint() {
            return this.timeSplitPoint;
        }

    }

    public static class GetOvertimeSettingResponseBodyResultWarningSettings extends TeaModel {
        @NameInMap("action")
        public String action;

        @NameInMap("threshold")
        public Long threshold;

        @NameInMap("time")
        public String time;

        public static GetOvertimeSettingResponseBodyResultWarningSettings build(java.util.Map<String, ?> map) throws Exception {
            GetOvertimeSettingResponseBodyResultWarningSettings self = new GetOvertimeSettingResponseBodyResultWarningSettings();
            return TeaModel.build(map, self);
        }

        public GetOvertimeSettingResponseBodyResultWarningSettings setAction(String action) {
            this.action = action;
            return this;
        }
        public String getAction() {
            return this.action;
        }

        public GetOvertimeSettingResponseBodyResultWarningSettings setThreshold(Long threshold) {
            this.threshold = threshold;
            return this;
        }
        public Long getThreshold() {
            return this.threshold;
        }

        public GetOvertimeSettingResponseBodyResultWarningSettings setTime(String time) {
            this.time = time;
            return this;
        }
        public String getTime() {
            return this.time;
        }

    }

    public static class GetOvertimeSettingResponseBodyResult extends TeaModel {
        @NameInMap("default")
        public Boolean _default;

        @NameInMap("durationSettings")
        public java.util.Map<String, ResultDurationSettingsValue> durationSettings;

        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

        @NameInMap("overtimeDivisions")
        public java.util.List<GetOvertimeSettingResponseBodyResultOvertimeDivisions> overtimeDivisions;

        @NameInMap("settingId")
        public Long settingId;

        @NameInMap("stepType")
        public Integer stepType;

        @NameInMap("stepValue")
        public Float stepValue;

        @NameInMap("warningSettings")
        public java.util.List<GetOvertimeSettingResponseBodyResultWarningSettings> warningSettings;

        @NameInMap("workMinutesPerDay")
        public Integer workMinutesPerDay;

        public static GetOvertimeSettingResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetOvertimeSettingResponseBodyResult self = new GetOvertimeSettingResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetOvertimeSettingResponseBodyResult set_default(Boolean _default) {
            this._default = _default;
            return this;
        }
        public Boolean get_default() {
            return this._default;
        }

        public GetOvertimeSettingResponseBodyResult setDurationSettings(java.util.Map<String, ResultDurationSettingsValue> durationSettings) {
            this.durationSettings = durationSettings;
            return this;
        }
        public java.util.Map<String, ResultDurationSettingsValue> getDurationSettings() {
            return this.durationSettings;
        }

        public GetOvertimeSettingResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetOvertimeSettingResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetOvertimeSettingResponseBodyResult setOvertimeDivisions(java.util.List<GetOvertimeSettingResponseBodyResultOvertimeDivisions> overtimeDivisions) {
            this.overtimeDivisions = overtimeDivisions;
            return this;
        }
        public java.util.List<GetOvertimeSettingResponseBodyResultOvertimeDivisions> getOvertimeDivisions() {
            return this.overtimeDivisions;
        }

        public GetOvertimeSettingResponseBodyResult setSettingId(Long settingId) {
            this.settingId = settingId;
            return this;
        }
        public Long getSettingId() {
            return this.settingId;
        }

        public GetOvertimeSettingResponseBodyResult setStepType(Integer stepType) {
            this.stepType = stepType;
            return this;
        }
        public Integer getStepType() {
            return this.stepType;
        }

        public GetOvertimeSettingResponseBodyResult setStepValue(Float stepValue) {
            this.stepValue = stepValue;
            return this;
        }
        public Float getStepValue() {
            return this.stepValue;
        }

        public GetOvertimeSettingResponseBodyResult setWarningSettings(java.util.List<GetOvertimeSettingResponseBodyResultWarningSettings> warningSettings) {
            this.warningSettings = warningSettings;
            return this;
        }
        public java.util.List<GetOvertimeSettingResponseBodyResultWarningSettings> getWarningSettings() {
            return this.warningSettings;
        }

        public GetOvertimeSettingResponseBodyResult setWorkMinutesPerDay(Integer workMinutesPerDay) {
            this.workMinutesPerDay = workMinutesPerDay;
            return this;
        }
        public Integer getWorkMinutesPerDay() {
            return this.workMinutesPerDay;
        }

    }

}
