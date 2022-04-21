// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AddLeaveTypeResponseBody extends TeaModel {
    // 返回参数
    @NameInMap("result")
    public AddLeaveTypeResponseBodyResult result;

    public static AddLeaveTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddLeaveTypeResponseBody self = new AddLeaveTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public AddLeaveTypeResponseBody setResult(AddLeaveTypeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddLeaveTypeResponseBodyResult getResult() {
        return this.result;
    }

    public static class AddLeaveTypeResponseBodyResultLeaveCertificate extends TeaModel {
        // 超过多长时间需提供请假证明
        @NameInMap("duration")
        public Double duration;

        // 是否开启请假证明
        @NameInMap("enable")
        public Boolean enable;

        // 请假提示文案
        @NameInMap("promptInformation")
        public String promptInformation;

        // 请假证明单位hour，day
        @NameInMap("unit")
        public String unit;

        public static AddLeaveTypeResponseBodyResultLeaveCertificate build(java.util.Map<String, ?> map) throws Exception {
            AddLeaveTypeResponseBodyResultLeaveCertificate self = new AddLeaveTypeResponseBodyResultLeaveCertificate();
            return TeaModel.build(map, self);
        }

        public AddLeaveTypeResponseBodyResultLeaveCertificate setDuration(Double duration) {
            this.duration = duration;
            return this;
        }
        public Double getDuration() {
            return this.duration;
        }

        public AddLeaveTypeResponseBodyResultLeaveCertificate setEnable(Boolean enable) {
            this.enable = enable;
            return this;
        }
        public Boolean getEnable() {
            return this.enable;
        }

        public AddLeaveTypeResponseBodyResultLeaveCertificate setPromptInformation(String promptInformation) {
            this.promptInformation = promptInformation;
            return this;
        }
        public String getPromptInformation() {
            return this.promptInformation;
        }

        public AddLeaveTypeResponseBodyResultLeaveCertificate setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class AddLeaveTypeResponseBodyResultSubmitTimeRule extends TeaModel {
        // 是否开启限时提交功能：仅且为true时开启
        @NameInMap("enableTimeLimit")
        public Boolean enableTimeLimit;

        // 限制类型：before-提前；after-补交
        @NameInMap("timeType")
        public String timeType;

        // 时间单位：day-天；hour-小时
        @NameInMap("timeUnit")
        public String timeUnit;

        // 限制值：timeUnit=day时，有效值范围[0~30] 天；timeUnit=hour时，有效值范围[0~24] 小时
        @NameInMap("timeValue")
        public Long timeValue;

        public static AddLeaveTypeResponseBodyResultSubmitTimeRule build(java.util.Map<String, ?> map) throws Exception {
            AddLeaveTypeResponseBodyResultSubmitTimeRule self = new AddLeaveTypeResponseBodyResultSubmitTimeRule();
            return TeaModel.build(map, self);
        }

        public AddLeaveTypeResponseBodyResultSubmitTimeRule setEnableTimeLimit(Boolean enableTimeLimit) {
            this.enableTimeLimit = enableTimeLimit;
            return this;
        }
        public Boolean getEnableTimeLimit() {
            return this.enableTimeLimit;
        }

        public AddLeaveTypeResponseBodyResultSubmitTimeRule setTimeType(String timeType) {
            this.timeType = timeType;
            return this;
        }
        public String getTimeType() {
            return this.timeType;
        }

        public AddLeaveTypeResponseBodyResultSubmitTimeRule setTimeUnit(String timeUnit) {
            this.timeUnit = timeUnit;
            return this;
        }
        public String getTimeUnit() {
            return this.timeUnit;
        }

        public AddLeaveTypeResponseBodyResultSubmitTimeRule setTimeValue(Long timeValue) {
            this.timeValue = timeValue;
            return this;
        }
        public Long getTimeValue() {
            return this.timeValue;
        }

    }

    public static class AddLeaveTypeResponseBodyResult extends TeaModel {
        // 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
        @NameInMap("bizType")
        public String bizType;

        // 每天折算的工作时长(百分之一 例如1天=10小时=1000)
        @NameInMap("hoursInPerDay")
        public Long hoursInPerDay;

        // 请假证明
        @NameInMap("leaveCertificate")
        public AddLeaveTypeResponseBodyResultLeaveCertificate leaveCertificate;

        // 假期类型唯一标识
        @NameInMap("leaveCode")
        public String leaveCode;

        // 假期名称
        @NameInMap("leaveName")
        public String leaveName;

        // 请假单位，可以按照天半天或者小时请假。(day、halfDay、hour其中一种)
        @NameInMap("leaveViewUnit")
        public String leaveViewUnit;

        // 是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
        @NameInMap("naturalDayLeave")
        public Boolean naturalDayLeave;

        // 限时提交规则
        @NameInMap("submitTimeRule")
        public AddLeaveTypeResponseBodyResultSubmitTimeRule submitTimeRule;

        public static AddLeaveTypeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddLeaveTypeResponseBodyResult self = new AddLeaveTypeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddLeaveTypeResponseBodyResult setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public AddLeaveTypeResponseBodyResult setHoursInPerDay(Long hoursInPerDay) {
            this.hoursInPerDay = hoursInPerDay;
            return this;
        }
        public Long getHoursInPerDay() {
            return this.hoursInPerDay;
        }

        public AddLeaveTypeResponseBodyResult setLeaveCertificate(AddLeaveTypeResponseBodyResultLeaveCertificate leaveCertificate) {
            this.leaveCertificate = leaveCertificate;
            return this;
        }
        public AddLeaveTypeResponseBodyResultLeaveCertificate getLeaveCertificate() {
            return this.leaveCertificate;
        }

        public AddLeaveTypeResponseBodyResult setLeaveCode(String leaveCode) {
            this.leaveCode = leaveCode;
            return this;
        }
        public String getLeaveCode() {
            return this.leaveCode;
        }

        public AddLeaveTypeResponseBodyResult setLeaveName(String leaveName) {
            this.leaveName = leaveName;
            return this;
        }
        public String getLeaveName() {
            return this.leaveName;
        }

        public AddLeaveTypeResponseBodyResult setLeaveViewUnit(String leaveViewUnit) {
            this.leaveViewUnit = leaveViewUnit;
            return this;
        }
        public String getLeaveViewUnit() {
            return this.leaveViewUnit;
        }

        public AddLeaveTypeResponseBodyResult setNaturalDayLeave(Boolean naturalDayLeave) {
            this.naturalDayLeave = naturalDayLeave;
            return this;
        }
        public Boolean getNaturalDayLeave() {
            return this.naturalDayLeave;
        }

        public AddLeaveTypeResponseBodyResult setSubmitTimeRule(AddLeaveTypeResponseBodyResultSubmitTimeRule submitTimeRule) {
            this.submitTimeRule = submitTimeRule;
            return this;
        }
        public AddLeaveTypeResponseBodyResultSubmitTimeRule getSubmitTimeRule() {
            return this.submitTimeRule;
        }

    }

}
