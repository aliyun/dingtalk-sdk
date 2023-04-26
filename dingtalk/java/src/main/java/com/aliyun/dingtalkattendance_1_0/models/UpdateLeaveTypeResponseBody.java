// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class UpdateLeaveTypeResponseBody extends TeaModel {
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
        @NameInMap("duration")
        public Double duration;

        @NameInMap("enable")
        public Boolean enable;

        @NameInMap("promptInformation")
        public String promptInformation;

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
        @NameInMap("enableTimeLimit")
        public Boolean enableTimeLimit;

        @NameInMap("timeType")
        public String timeType;

        @NameInMap("timeUnit")
        public String timeUnit;

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
        @NameInMap("type")
        public String type;

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
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("hoursInPerDay")
        public Long hoursInPerDay;

        @NameInMap("leaveCertificate")
        public UpdateLeaveTypeResponseBodyResultLeaveCertificate leaveCertificate;

        @NameInMap("leaveCode")
        public String leaveCode;

        @NameInMap("leaveName")
        public String leaveName;

        @NameInMap("leaveViewUnit")
        public String leaveViewUnit;

        @NameInMap("naturalDayLeave")
        public Boolean naturalDayLeave;

        @NameInMap("submitTimeRule")
        public UpdateLeaveTypeResponseBodyResultSubmitTimeRule submitTimeRule;

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
