// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetLeaveTypeResponseBody extends TeaModel {
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
        @NameInMap("duration")
        public Double duration;

        @NameInMap("enable")
        public Boolean enable;

        @NameInMap("promptInformation")
        public String promptInformation;

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
        @NameInMap("enableTimeLimit")
        public Boolean enableTimeLimit;

        @NameInMap("timeType")
        public String timeType;

        @NameInMap("timeUnit")
        public String timeUnit;

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

    public static class GetLeaveTypeResponseBodyResultVisibilityRules extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("visible")
        public java.util.List<String> visible;

        public static GetLeaveTypeResponseBodyResultVisibilityRules build(java.util.Map<String, ?> map) throws Exception {
            GetLeaveTypeResponseBodyResultVisibilityRules self = new GetLeaveTypeResponseBodyResultVisibilityRules();
            return TeaModel.build(map, self);
        }

        public GetLeaveTypeResponseBodyResultVisibilityRules setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetLeaveTypeResponseBodyResultVisibilityRules setVisible(java.util.List<String> visible) {
            this.visible = visible;
            return this;
        }
        public java.util.List<String> getVisible() {
            return this.visible;
        }

    }

    public static class GetLeaveTypeResponseBodyResult extends TeaModel {
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("hoursInPerDay")
        public Long hoursInPerDay;

        @NameInMap("leaveCertificate")
        public GetLeaveTypeResponseBodyResultLeaveCertificate leaveCertificate;

        @NameInMap("leaveCode")
        public String leaveCode;

        @NameInMap("leaveName")
        public String leaveName;

        @NameInMap("leaveViewUnit")
        public String leaveViewUnit;

        @NameInMap("naturalDayLeave")
        public Boolean naturalDayLeave;

        @NameInMap("source")
        public String source;

        @NameInMap("submitTimeRule")
        public GetLeaveTypeResponseBodyResultSubmitTimeRule submitTimeRule;

        @NameInMap("validityType")
        public String validityType;

        @NameInMap("validityValue")
        public String validityValue;

        @NameInMap("visibilityRules")
        public java.util.List<GetLeaveTypeResponseBodyResultVisibilityRules> visibilityRules;

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

        public GetLeaveTypeResponseBodyResult setVisibilityRules(java.util.List<GetLeaveTypeResponseBodyResultVisibilityRules> visibilityRules) {
            this.visibilityRules = visibilityRules;
            return this;
        }
        public java.util.List<GetLeaveTypeResponseBodyResultVisibilityRules> getVisibilityRules() {
            return this.visibilityRules;
        }

    }

}
