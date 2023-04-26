// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class UpdateLeaveTypeRequest extends TeaModel {
    @NameInMap("bizType")
    public String bizType;

    @NameInMap("extras")
    public String extras;

    @NameInMap("hoursInPerDay")
    public Long hoursInPerDay;

    @NameInMap("leaveCertificate")
    public UpdateLeaveTypeRequestLeaveCertificate leaveCertificate;

    @NameInMap("leaveCode")
    public String leaveCode;

    @NameInMap("leaveName")
    public String leaveName;

    @NameInMap("leaveViewUnit")
    public String leaveViewUnit;

    @NameInMap("naturalDayLeave")
    public Boolean naturalDayLeave;

    @NameInMap("submitTimeRule")
    public UpdateLeaveTypeRequestSubmitTimeRule submitTimeRule;

    @NameInMap("visibilityRules")
    public java.util.List<UpdateLeaveTypeRequestVisibilityRules> visibilityRules;

    @NameInMap("opUserId")
    public String opUserId;

    public static UpdateLeaveTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateLeaveTypeRequest self = new UpdateLeaveTypeRequest();
        return TeaModel.build(map, self);
    }

    public UpdateLeaveTypeRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public UpdateLeaveTypeRequest setExtras(String extras) {
        this.extras = extras;
        return this;
    }
    public String getExtras() {
        return this.extras;
    }

    public UpdateLeaveTypeRequest setHoursInPerDay(Long hoursInPerDay) {
        this.hoursInPerDay = hoursInPerDay;
        return this;
    }
    public Long getHoursInPerDay() {
        return this.hoursInPerDay;
    }

    public UpdateLeaveTypeRequest setLeaveCertificate(UpdateLeaveTypeRequestLeaveCertificate leaveCertificate) {
        this.leaveCertificate = leaveCertificate;
        return this;
    }
    public UpdateLeaveTypeRequestLeaveCertificate getLeaveCertificate() {
        return this.leaveCertificate;
    }

    public UpdateLeaveTypeRequest setLeaveCode(String leaveCode) {
        this.leaveCode = leaveCode;
        return this;
    }
    public String getLeaveCode() {
        return this.leaveCode;
    }

    public UpdateLeaveTypeRequest setLeaveName(String leaveName) {
        this.leaveName = leaveName;
        return this;
    }
    public String getLeaveName() {
        return this.leaveName;
    }

    public UpdateLeaveTypeRequest setLeaveViewUnit(String leaveViewUnit) {
        this.leaveViewUnit = leaveViewUnit;
        return this;
    }
    public String getLeaveViewUnit() {
        return this.leaveViewUnit;
    }

    public UpdateLeaveTypeRequest setNaturalDayLeave(Boolean naturalDayLeave) {
        this.naturalDayLeave = naturalDayLeave;
        return this;
    }
    public Boolean getNaturalDayLeave() {
        return this.naturalDayLeave;
    }

    public UpdateLeaveTypeRequest setSubmitTimeRule(UpdateLeaveTypeRequestSubmitTimeRule submitTimeRule) {
        this.submitTimeRule = submitTimeRule;
        return this;
    }
    public UpdateLeaveTypeRequestSubmitTimeRule getSubmitTimeRule() {
        return this.submitTimeRule;
    }

    public UpdateLeaveTypeRequest setVisibilityRules(java.util.List<UpdateLeaveTypeRequestVisibilityRules> visibilityRules) {
        this.visibilityRules = visibilityRules;
        return this;
    }
    public java.util.List<UpdateLeaveTypeRequestVisibilityRules> getVisibilityRules() {
        return this.visibilityRules;
    }

    public UpdateLeaveTypeRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class UpdateLeaveTypeRequestLeaveCertificate extends TeaModel {
        @NameInMap("duration")
        public Double duration;

        @NameInMap("enable")
        public Boolean enable;

        @NameInMap("promptInformation")
        public String promptInformation;

        @NameInMap("unit")
        public String unit;

        public static UpdateLeaveTypeRequestLeaveCertificate build(java.util.Map<String, ?> map) throws Exception {
            UpdateLeaveTypeRequestLeaveCertificate self = new UpdateLeaveTypeRequestLeaveCertificate();
            return TeaModel.build(map, self);
        }

        public UpdateLeaveTypeRequestLeaveCertificate setDuration(Double duration) {
            this.duration = duration;
            return this;
        }
        public Double getDuration() {
            return this.duration;
        }

        public UpdateLeaveTypeRequestLeaveCertificate setEnable(Boolean enable) {
            this.enable = enable;
            return this;
        }
        public Boolean getEnable() {
            return this.enable;
        }

        public UpdateLeaveTypeRequestLeaveCertificate setPromptInformation(String promptInformation) {
            this.promptInformation = promptInformation;
            return this;
        }
        public String getPromptInformation() {
            return this.promptInformation;
        }

        public UpdateLeaveTypeRequestLeaveCertificate setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class UpdateLeaveTypeRequestSubmitTimeRule extends TeaModel {
        @NameInMap("enableTimeLimit")
        public Boolean enableTimeLimit;

        @NameInMap("timeType")
        public String timeType;

        @NameInMap("timeUnit")
        public String timeUnit;

        @NameInMap("timeValue")
        public Long timeValue;

        public static UpdateLeaveTypeRequestSubmitTimeRule build(java.util.Map<String, ?> map) throws Exception {
            UpdateLeaveTypeRequestSubmitTimeRule self = new UpdateLeaveTypeRequestSubmitTimeRule();
            return TeaModel.build(map, self);
        }

        public UpdateLeaveTypeRequestSubmitTimeRule setEnableTimeLimit(Boolean enableTimeLimit) {
            this.enableTimeLimit = enableTimeLimit;
            return this;
        }
        public Boolean getEnableTimeLimit() {
            return this.enableTimeLimit;
        }

        public UpdateLeaveTypeRequestSubmitTimeRule setTimeType(String timeType) {
            this.timeType = timeType;
            return this;
        }
        public String getTimeType() {
            return this.timeType;
        }

        public UpdateLeaveTypeRequestSubmitTimeRule setTimeUnit(String timeUnit) {
            this.timeUnit = timeUnit;
            return this;
        }
        public String getTimeUnit() {
            return this.timeUnit;
        }

        public UpdateLeaveTypeRequestSubmitTimeRule setTimeValue(Long timeValue) {
            this.timeValue = timeValue;
            return this;
        }
        public Long getTimeValue() {
            return this.timeValue;
        }

    }

    public static class UpdateLeaveTypeRequestVisibilityRules extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("visible")
        public java.util.List<String> visible;

        public static UpdateLeaveTypeRequestVisibilityRules build(java.util.Map<String, ?> map) throws Exception {
            UpdateLeaveTypeRequestVisibilityRules self = new UpdateLeaveTypeRequestVisibilityRules();
            return TeaModel.build(map, self);
        }

        public UpdateLeaveTypeRequestVisibilityRules setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public UpdateLeaveTypeRequestVisibilityRules setVisible(java.util.List<String> visible) {
            this.visible = visible;
            return this;
        }
        public java.util.List<String> getVisible() {
            return this.visible;
        }

    }

}
