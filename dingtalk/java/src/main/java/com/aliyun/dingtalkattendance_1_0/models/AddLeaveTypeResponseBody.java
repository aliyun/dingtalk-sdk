// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AddLeaveTypeResponseBody extends TeaModel {
    /**
     * <p>返回参数</p>
     */
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
        /**
         * <p>超过多长时间需提供请假证明</p>
         */
        @NameInMap("duration")
        public Double duration;

        /**
         * <p>是否开启请假证明</p>
         */
        @NameInMap("enable")
        public Boolean enable;

        /**
         * <p>请假提示文案</p>
         */
        @NameInMap("promptInformation")
        public String promptInformation;

        /**
         * <p>请假证明单位hour，day</p>
         */
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
        /**
         * <p>是否开启限时提交功能：仅且为true时开启</p>
         */
        @NameInMap("enableTimeLimit")
        public Boolean enableTimeLimit;

        /**
         * <p>限制类型：before-提前；after-补交</p>
         */
        @NameInMap("timeType")
        public String timeType;

        /**
         * <p>时间单位：day-天；hour-小时</p>
         */
        @NameInMap("timeUnit")
        public String timeUnit;

        /**
         * <p>限制值：timeUnit=day时，有效值范围[0~30] 天；timeUnit=hour时，有效值范围[0~24] 小时</p>
         */
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

    public static class AddLeaveTypeResponseBodyResultVisibilityRules extends TeaModel {
        /**
         * <p>规则类型：dept-部门；staff-员工；label-角色</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>规则数据：当type=staff时，传员工userId列表；当type=dept时，传部门id列表；当type=label时，传角色id列表</p>
         */
        @NameInMap("visible")
        public java.util.List<String> visible;

        public static AddLeaveTypeResponseBodyResultVisibilityRules build(java.util.Map<String, ?> map) throws Exception {
            AddLeaveTypeResponseBodyResultVisibilityRules self = new AddLeaveTypeResponseBodyResultVisibilityRules();
            return TeaModel.build(map, self);
        }

        public AddLeaveTypeResponseBodyResultVisibilityRules setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public AddLeaveTypeResponseBodyResultVisibilityRules setVisible(java.util.List<String> visible) {
            this.visible = visible;
            return this;
        }
        public java.util.List<String> getVisible() {
            return this.visible;
        }

    }

    public static class AddLeaveTypeResponseBodyResult extends TeaModel {
        /**
         * <p>假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>每天折算的工作时长(百分之一 例如1天=10小时=1000)</p>
         */
        @NameInMap("hoursInPerDay")
        public Long hoursInPerDay;

        /**
         * <p>请假证明</p>
         */
        @NameInMap("leaveCertificate")
        public AddLeaveTypeResponseBodyResultLeaveCertificate leaveCertificate;

        /**
         * <p>假期类型唯一标识</p>
         */
        @NameInMap("leaveCode")
        public String leaveCode;

        /**
         * <p>假期名称</p>
         */
        @NameInMap("leaveName")
        public String leaveName;

        /**
         * <p>请假单位，可以按照天半天或者小时请假。(day、halfDay、hour其中一种)</p>
         */
        @NameInMap("leaveViewUnit")
        public String leaveViewUnit;

        /**
         * <p>是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。</p>
         */
        @NameInMap("naturalDayLeave")
        public Boolean naturalDayLeave;

        /**
         * <p>限时提交规则</p>
         */
        @NameInMap("submitTimeRule")
        public AddLeaveTypeResponseBodyResultSubmitTimeRule submitTimeRule;

        /**
         * <p>适用范围规则列表：哪些部门/员工可以使用该假期类型，不传默认为全公司</p>
         */
        @NameInMap("visibilityRules")
        public java.util.List<AddLeaveTypeResponseBodyResultVisibilityRules> visibilityRules;

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

        public AddLeaveTypeResponseBodyResult setVisibilityRules(java.util.List<AddLeaveTypeResponseBodyResultVisibilityRules> visibilityRules) {
            this.visibilityRules = visibilityRules;
            return this;
        }
        public java.util.List<AddLeaveTypeResponseBodyResultVisibilityRules> getVisibilityRules() {
            return this.visibilityRules;
        }

    }

}
