// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class UpdateLeaveTypeResponseBody extends TeaModel {
    /**
     * <p>返回参数</p>
     */
    @NameInMap("result")
    public UpdateLeaveTypeResponseBodyResult result;

    public static UpdateLeaveTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateLeaveTypeResponseBody self = new UpdateLeaveTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateLeaveTypeResponseBody setResult(UpdateLeaveTypeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateLeaveTypeResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateLeaveTypeResponseBodyResultLeaveCertificate extends TeaModel {
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

        public static UpdateLeaveTypeResponseBodyResultLeaveCertificate build(java.util.Map<String, ?> map) throws Exception {
            UpdateLeaveTypeResponseBodyResultLeaveCertificate self = new UpdateLeaveTypeResponseBodyResultLeaveCertificate();
            return TeaModel.build(map, self);
        }

        public UpdateLeaveTypeResponseBodyResultLeaveCertificate setDuration(Double duration) {
            this.duration = duration;
            return this;
        }
        public Double getDuration() {
            return this.duration;
        }

        public UpdateLeaveTypeResponseBodyResultLeaveCertificate setEnable(Boolean enable) {
            this.enable = enable;
            return this;
        }
        public Boolean getEnable() {
            return this.enable;
        }

        public UpdateLeaveTypeResponseBodyResultLeaveCertificate setPromptInformation(String promptInformation) {
            this.promptInformation = promptInformation;
            return this;
        }
        public String getPromptInformation() {
            return this.promptInformation;
        }

        public UpdateLeaveTypeResponseBodyResultLeaveCertificate setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class UpdateLeaveTypeResponseBodyResultSubmitTimeRule extends TeaModel {
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

        public static UpdateLeaveTypeResponseBodyResultSubmitTimeRule build(java.util.Map<String, ?> map) throws Exception {
            UpdateLeaveTypeResponseBodyResultSubmitTimeRule self = new UpdateLeaveTypeResponseBodyResultSubmitTimeRule();
            return TeaModel.build(map, self);
        }

        public UpdateLeaveTypeResponseBodyResultSubmitTimeRule setEnableTimeLimit(Boolean enableTimeLimit) {
            this.enableTimeLimit = enableTimeLimit;
            return this;
        }
        public Boolean getEnableTimeLimit() {
            return this.enableTimeLimit;
        }

        public UpdateLeaveTypeResponseBodyResultSubmitTimeRule setTimeType(String timeType) {
            this.timeType = timeType;
            return this;
        }
        public String getTimeType() {
            return this.timeType;
        }

        public UpdateLeaveTypeResponseBodyResultSubmitTimeRule setTimeUnit(String timeUnit) {
            this.timeUnit = timeUnit;
            return this;
        }
        public String getTimeUnit() {
            return this.timeUnit;
        }

        public UpdateLeaveTypeResponseBodyResultSubmitTimeRule setTimeValue(Long timeValue) {
            this.timeValue = timeValue;
            return this;
        }
        public Long getTimeValue() {
            return this.timeValue;
        }

    }

    public static class UpdateLeaveTypeResponseBodyResultVisibilityRules extends TeaModel {
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

        public static UpdateLeaveTypeResponseBodyResultVisibilityRules build(java.util.Map<String, ?> map) throws Exception {
            UpdateLeaveTypeResponseBodyResultVisibilityRules self = new UpdateLeaveTypeResponseBodyResultVisibilityRules();
            return TeaModel.build(map, self);
        }

        public UpdateLeaveTypeResponseBodyResultVisibilityRules setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public UpdateLeaveTypeResponseBodyResultVisibilityRules setVisible(java.util.List<String> visible) {
            this.visible = visible;
            return this;
        }
        public java.util.List<String> getVisible() {
            return this.visible;
        }

    }

    public static class UpdateLeaveTypeResponseBodyResult extends TeaModel {
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
        public UpdateLeaveTypeResponseBodyResultLeaveCertificate leaveCertificate;

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
        public UpdateLeaveTypeResponseBodyResultSubmitTimeRule submitTimeRule;

        /**
         * <p>适用范围规则列表：哪些部门/员工可以使用该假期类型，不传默认为全公司</p>
         */
        @NameInMap("visibilityRules")
        public java.util.List<UpdateLeaveTypeResponseBodyResultVisibilityRules> visibilityRules;

        public static UpdateLeaveTypeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateLeaveTypeResponseBodyResult self = new UpdateLeaveTypeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateLeaveTypeResponseBodyResult setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public UpdateLeaveTypeResponseBodyResult setHoursInPerDay(Long hoursInPerDay) {
            this.hoursInPerDay = hoursInPerDay;
            return this;
        }
        public Long getHoursInPerDay() {
            return this.hoursInPerDay;
        }

        public UpdateLeaveTypeResponseBodyResult setLeaveCertificate(UpdateLeaveTypeResponseBodyResultLeaveCertificate leaveCertificate) {
            this.leaveCertificate = leaveCertificate;
            return this;
        }
        public UpdateLeaveTypeResponseBodyResultLeaveCertificate getLeaveCertificate() {
            return this.leaveCertificate;
        }

        public UpdateLeaveTypeResponseBodyResult setLeaveCode(String leaveCode) {
            this.leaveCode = leaveCode;
            return this;
        }
        public String getLeaveCode() {
            return this.leaveCode;
        }

        public UpdateLeaveTypeResponseBodyResult setLeaveName(String leaveName) {
            this.leaveName = leaveName;
            return this;
        }
        public String getLeaveName() {
            return this.leaveName;
        }

        public UpdateLeaveTypeResponseBodyResult setLeaveViewUnit(String leaveViewUnit) {
            this.leaveViewUnit = leaveViewUnit;
            return this;
        }
        public String getLeaveViewUnit() {
            return this.leaveViewUnit;
        }

        public UpdateLeaveTypeResponseBodyResult setNaturalDayLeave(Boolean naturalDayLeave) {
            this.naturalDayLeave = naturalDayLeave;
            return this;
        }
        public Boolean getNaturalDayLeave() {
            return this.naturalDayLeave;
        }

        public UpdateLeaveTypeResponseBodyResult setSubmitTimeRule(UpdateLeaveTypeResponseBodyResultSubmitTimeRule submitTimeRule) {
            this.submitTimeRule = submitTimeRule;
            return this;
        }
        public UpdateLeaveTypeResponseBodyResultSubmitTimeRule getSubmitTimeRule() {
            return this.submitTimeRule;
        }

        public UpdateLeaveTypeResponseBodyResult setVisibilityRules(java.util.List<UpdateLeaveTypeResponseBodyResultVisibilityRules> visibilityRules) {
            this.visibilityRules = visibilityRules;
            return this;
        }
        public java.util.List<UpdateLeaveTypeResponseBodyResultVisibilityRules> getVisibilityRules() {
            return this.visibilityRules;
        }

    }

}
