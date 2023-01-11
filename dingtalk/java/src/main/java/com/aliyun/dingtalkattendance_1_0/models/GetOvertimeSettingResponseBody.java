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
        /**
         * <p>后一日类型</p>
         */
        @NameInMap("nextDayType")
        public String nextDayType;

        /**
         * <p>前一日类型</p>
         */
        @NameInMap("previousDayType")
        public String previousDayType;

        /**
         * <p>分割时间点</p>
         */
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
        /**
         * <p>风险预警 或 最大加班时间</p>
         */
        @NameInMap("action")
        public String action;

        /**
         * <p>提醒阈值</p>
         */
        @NameInMap("threshold")
        public Long threshold;

        /**
         * <p>预警类型</p>
         */
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
        /**
         * <p>是否默认</p>
         */
        @NameInMap("default")
        public Boolean _default;

        @NameInMap("durationSettings")
        public java.util.Map<String, ResultDurationSettingsValue> durationSettings;

        /**
         * <p>历史加班规则设置id</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>规则名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>时间分割规则</p>
         */
        @NameInMap("overtimeDivisions")
        public java.util.List<GetOvertimeSettingResponseBodyResultOvertimeDivisions> overtimeDivisions;

        /**
         * <p>设置id</p>
         */
        @NameInMap("settingId")
        public Long settingId;

        /**
         * <p>加班时长单位</p>
         */
        @NameInMap("stepType")
        public Integer stepType;

        /**
         * <p>加班时长是否取整 单位 小时</p>
         */
        @NameInMap("stepValue")
        public Float stepValue;

        @NameInMap("warningSettings")
        public java.util.List<GetOvertimeSettingResponseBodyResultWarningSettings> warningSettings;

        /**
         * <p>日折算时长 单位：分钟</p>
         */
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
