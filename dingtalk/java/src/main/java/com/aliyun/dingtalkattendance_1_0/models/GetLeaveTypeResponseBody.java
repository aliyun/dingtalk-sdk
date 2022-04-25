// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetLeaveTypeResponseBody extends TeaModel {
    // 返回参数
    @NameInMap("result")
    public java.util.List<GetLeaveTypeResponseBodyResult> result;

    public static GetLeaveTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetLeaveTypeResponseBody self = new GetLeaveTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetLeaveTypeResponseBody setResult(java.util.List<GetLeaveTypeResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetLeaveTypeResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetLeaveTypeResponseBodyResultLeaveCertificate extends TeaModel {
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

        public static GetLeaveTypeResponseBodyResultLeaveCertificate build(java.util.Map<String, ?> map) throws Exception {
            GetLeaveTypeResponseBodyResultLeaveCertificate self = new GetLeaveTypeResponseBodyResultLeaveCertificate();
            return TeaModel.build(map, self);
        }

        public GetLeaveTypeResponseBodyResultLeaveCertificate setDuration(Double duration) {
            this.duration = duration;
            return this;
        }
        public Double getDuration() {
            return this.duration;
        }

        public GetLeaveTypeResponseBodyResultLeaveCertificate setEnable(Boolean enable) {
            this.enable = enable;
            return this;
        }
        public Boolean getEnable() {
            return this.enable;
        }

        public GetLeaveTypeResponseBodyResultLeaveCertificate setPromptInformation(String promptInformation) {
            this.promptInformation = promptInformation;
            return this;
        }
        public String getPromptInformation() {
            return this.promptInformation;
        }

        public GetLeaveTypeResponseBodyResultLeaveCertificate setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class GetLeaveTypeResponseBodyResultSubmitTimeRule extends TeaModel {
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

        public static GetLeaveTypeResponseBodyResultSubmitTimeRule build(java.util.Map<String, ?> map) throws Exception {
            GetLeaveTypeResponseBodyResultSubmitTimeRule self = new GetLeaveTypeResponseBodyResultSubmitTimeRule();
            return TeaModel.build(map, self);
        }

        public GetLeaveTypeResponseBodyResultSubmitTimeRule setEnableTimeLimit(Boolean enableTimeLimit) {
            this.enableTimeLimit = enableTimeLimit;
            return this;
        }
        public Boolean getEnableTimeLimit() {
            return this.enableTimeLimit;
        }

        public GetLeaveTypeResponseBodyResultSubmitTimeRule setTimeType(String timeType) {
            this.timeType = timeType;
            return this;
        }
        public String getTimeType() {
            return this.timeType;
        }

        public GetLeaveTypeResponseBodyResultSubmitTimeRule setTimeUnit(String timeUnit) {
            this.timeUnit = timeUnit;
            return this;
        }
        public String getTimeUnit() {
            return this.timeUnit;
        }

        public GetLeaveTypeResponseBodyResultSubmitTimeRule setTimeValue(Long timeValue) {
            this.timeValue = timeValue;
            return this;
        }
        public Long getTimeValue() {
            return this.timeValue;
        }

    }

    public static class GetLeaveTypeResponseBodyResult extends TeaModel {
        // 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
        @NameInMap("bizType")
        public String bizType;

        // 每天折算的工作时长(百分之一 例如1天=10小时=1000)
        @NameInMap("hoursInPerDay")
        public Long hoursInPerDay;

        // 请假证明
        @NameInMap("leaveCertificate")
        public GetLeaveTypeResponseBodyResultLeaveCertificate leaveCertificate;

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

        // 开放接口自定义的:external oa后台新建的：inner
        @NameInMap("source")
        public String source;

        // 限时提交规则
        @NameInMap("submitTimeRule")
        public GetLeaveTypeResponseBodyResultSubmitTimeRule submitTimeRule;

        // 有效类型 absolute_time(绝对时间)、relative_time(相对时间)其中一种
        @NameInMap("validityType")
        public String validityType;

        // 延长日期(当validity_type为absolute_time该值该值不为空且满足yy-mm格式 validity_type为relative_time该值为大于1的整数)
        @NameInMap("validityValue")
        public String validityValue;

        public static GetLeaveTypeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetLeaveTypeResponseBodyResult self = new GetLeaveTypeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetLeaveTypeResponseBodyResult setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public GetLeaveTypeResponseBodyResult setHoursInPerDay(Long hoursInPerDay) {
            this.hoursInPerDay = hoursInPerDay;
            return this;
        }
        public Long getHoursInPerDay() {
            return this.hoursInPerDay;
        }

        public GetLeaveTypeResponseBodyResult setLeaveCertificate(GetLeaveTypeResponseBodyResultLeaveCertificate leaveCertificate) {
            this.leaveCertificate = leaveCertificate;
            return this;
        }
        public GetLeaveTypeResponseBodyResultLeaveCertificate getLeaveCertificate() {
            return this.leaveCertificate;
        }

        public GetLeaveTypeResponseBodyResult setLeaveCode(String leaveCode) {
            this.leaveCode = leaveCode;
            return this;
        }
        public String getLeaveCode() {
            return this.leaveCode;
        }

        public GetLeaveTypeResponseBodyResult setLeaveName(String leaveName) {
            this.leaveName = leaveName;
            return this;
        }
        public String getLeaveName() {
            return this.leaveName;
        }

        public GetLeaveTypeResponseBodyResult setLeaveViewUnit(String leaveViewUnit) {
            this.leaveViewUnit = leaveViewUnit;
            return this;
        }
        public String getLeaveViewUnit() {
            return this.leaveViewUnit;
        }

        public GetLeaveTypeResponseBodyResult setNaturalDayLeave(Boolean naturalDayLeave) {
            this.naturalDayLeave = naturalDayLeave;
            return this;
        }
        public Boolean getNaturalDayLeave() {
            return this.naturalDayLeave;
        }

        public GetLeaveTypeResponseBodyResult setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public GetLeaveTypeResponseBodyResult setSubmitTimeRule(GetLeaveTypeResponseBodyResultSubmitTimeRule submitTimeRule) {
            this.submitTimeRule = submitTimeRule;
            return this;
        }
        public GetLeaveTypeResponseBodyResultSubmitTimeRule getSubmitTimeRule() {
            return this.submitTimeRule;
        }

        public GetLeaveTypeResponseBodyResult setValidityType(String validityType) {
            this.validityType = validityType;
            return this;
        }
        public String getValidityType() {
            return this.validityType;
        }

        public GetLeaveTypeResponseBodyResult setValidityValue(String validityValue) {
            this.validityValue = validityValue;
            return this;
        }
        public String getValidityValue() {
            return this.validityValue;
        }

    }

}
