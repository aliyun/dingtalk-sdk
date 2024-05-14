// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AddLeaveTypeResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
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
        @NameInMap("duration")
        public Double duration;

        @NameInMap("enable")
        public Boolean enable;

        @NameInMap("promptInformation")
        public String promptInformation;

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
        @NameInMap("enableTimeLimit")
        public Boolean enableTimeLimit;

        @NameInMap("timeType")
        public String timeType;

        @NameInMap("timeUnit")
        public String timeUnit;

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
        @NameInMap("type")
        public String type;

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
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("hoursInPerDay")
        public Long hoursInPerDay;

        @NameInMap("leaveCertificate")
        public AddLeaveTypeResponseBodyResultLeaveCertificate leaveCertificate;

        @NameInMap("leaveCode")
        public String leaveCode;

        @NameInMap("leaveName")
        public String leaveName;

        @NameInMap("leaveViewUnit")
        public String leaveViewUnit;

        @NameInMap("naturalDayLeave")
        public Boolean naturalDayLeave;

        @NameInMap("submitTimeRule")
        public AddLeaveTypeResponseBodyResultSubmitTimeRule submitTimeRule;

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
