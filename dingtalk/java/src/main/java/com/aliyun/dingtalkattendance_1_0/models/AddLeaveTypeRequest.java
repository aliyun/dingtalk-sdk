// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AddLeaveTypeRequest extends TeaModel {
    @NameInMap("bizType")
    public String bizType;

    @NameInMap("extras")
    public String extras;

    @NameInMap("freedomLeave")
    public Boolean freedomLeave;

    @NameInMap("hoursInPerDay")
    public Long hoursInPerDay;

    @NameInMap("leaveCertificate")
    public AddLeaveTypeRequestLeaveCertificate leaveCertificate;

    @NameInMap("leaveHourCeil")
    public String leaveHourCeil;

    @NameInMap("leaveName")
    public String leaveName;

    @NameInMap("leaveTimeCeil")
    public Boolean leaveTimeCeil;

    @NameInMap("leaveTimeCeilMinUnit")
    public String leaveTimeCeilMinUnit;

    @NameInMap("leaveViewUnit")
    public String leaveViewUnit;

    @NameInMap("maxLeaveTime")
    public Long maxLeaveTime;

    @NameInMap("minLeaveHour")
    public Double minLeaveHour;

    @NameInMap("naturalDayLeave")
    public Boolean naturalDayLeave;

    @NameInMap("paidLeave")
    public Boolean paidLeave;

    @NameInMap("submitTimeRule")
    public AddLeaveTypeRequestSubmitTimeRule submitTimeRule;

    @NameInMap("visibilityRules")
    public java.util.List<AddLeaveTypeRequestVisibilityRules> visibilityRules;

    @NameInMap("whenCanLeave")
    public String whenCanLeave;

    @NameInMap("opUserId")
    public String opUserId;

    public static AddLeaveTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        AddLeaveTypeRequest self = new AddLeaveTypeRequest();
        return TeaModel.build(map, self);
    }

    public AddLeaveTypeRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public AddLeaveTypeRequest setExtras(String extras) {
        this.extras = extras;
        return this;
    }
    public String getExtras() {
        return this.extras;
    }

    public AddLeaveTypeRequest setFreedomLeave(Boolean freedomLeave) {
        this.freedomLeave = freedomLeave;
        return this;
    }
    public Boolean getFreedomLeave() {
        return this.freedomLeave;
    }

    public AddLeaveTypeRequest setHoursInPerDay(Long hoursInPerDay) {
        this.hoursInPerDay = hoursInPerDay;
        return this;
    }
    public Long getHoursInPerDay() {
        return this.hoursInPerDay;
    }

    public AddLeaveTypeRequest setLeaveCertificate(AddLeaveTypeRequestLeaveCertificate leaveCertificate) {
        this.leaveCertificate = leaveCertificate;
        return this;
    }
    public AddLeaveTypeRequestLeaveCertificate getLeaveCertificate() {
        return this.leaveCertificate;
    }

    public AddLeaveTypeRequest setLeaveHourCeil(String leaveHourCeil) {
        this.leaveHourCeil = leaveHourCeil;
        return this;
    }
    public String getLeaveHourCeil() {
        return this.leaveHourCeil;
    }

    public AddLeaveTypeRequest setLeaveName(String leaveName) {
        this.leaveName = leaveName;
        return this;
    }
    public String getLeaveName() {
        return this.leaveName;
    }

    public AddLeaveTypeRequest setLeaveTimeCeil(Boolean leaveTimeCeil) {
        this.leaveTimeCeil = leaveTimeCeil;
        return this;
    }
    public Boolean getLeaveTimeCeil() {
        return this.leaveTimeCeil;
    }

    public AddLeaveTypeRequest setLeaveTimeCeilMinUnit(String leaveTimeCeilMinUnit) {
        this.leaveTimeCeilMinUnit = leaveTimeCeilMinUnit;
        return this;
    }
    public String getLeaveTimeCeilMinUnit() {
        return this.leaveTimeCeilMinUnit;
    }

    public AddLeaveTypeRequest setLeaveViewUnit(String leaveViewUnit) {
        this.leaveViewUnit = leaveViewUnit;
        return this;
    }
    public String getLeaveViewUnit() {
        return this.leaveViewUnit;
    }

    public AddLeaveTypeRequest setMaxLeaveTime(Long maxLeaveTime) {
        this.maxLeaveTime = maxLeaveTime;
        return this;
    }
    public Long getMaxLeaveTime() {
        return this.maxLeaveTime;
    }

    public AddLeaveTypeRequest setMinLeaveHour(Double minLeaveHour) {
        this.minLeaveHour = minLeaveHour;
        return this;
    }
    public Double getMinLeaveHour() {
        return this.minLeaveHour;
    }

    public AddLeaveTypeRequest setNaturalDayLeave(Boolean naturalDayLeave) {
        this.naturalDayLeave = naturalDayLeave;
        return this;
    }
    public Boolean getNaturalDayLeave() {
        return this.naturalDayLeave;
    }

    public AddLeaveTypeRequest setPaidLeave(Boolean paidLeave) {
        this.paidLeave = paidLeave;
        return this;
    }
    public Boolean getPaidLeave() {
        return this.paidLeave;
    }

    public AddLeaveTypeRequest setSubmitTimeRule(AddLeaveTypeRequestSubmitTimeRule submitTimeRule) {
        this.submitTimeRule = submitTimeRule;
        return this;
    }
    public AddLeaveTypeRequestSubmitTimeRule getSubmitTimeRule() {
        return this.submitTimeRule;
    }

    public AddLeaveTypeRequest setVisibilityRules(java.util.List<AddLeaveTypeRequestVisibilityRules> visibilityRules) {
        this.visibilityRules = visibilityRules;
        return this;
    }
    public java.util.List<AddLeaveTypeRequestVisibilityRules> getVisibilityRules() {
        return this.visibilityRules;
    }

    public AddLeaveTypeRequest setWhenCanLeave(String whenCanLeave) {
        this.whenCanLeave = whenCanLeave;
        return this;
    }
    public String getWhenCanLeave() {
        return this.whenCanLeave;
    }

    public AddLeaveTypeRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class AddLeaveTypeRequestLeaveCertificate extends TeaModel {
        @NameInMap("duration")
        public Double duration;

        @NameInMap("enable")
        public Boolean enable;

        @NameInMap("promptInformation")
        public String promptInformation;

        @NameInMap("unit")
        public String unit;

        public static AddLeaveTypeRequestLeaveCertificate build(java.util.Map<String, ?> map) throws Exception {
            AddLeaveTypeRequestLeaveCertificate self = new AddLeaveTypeRequestLeaveCertificate();
            return TeaModel.build(map, self);
        }

        public AddLeaveTypeRequestLeaveCertificate setDuration(Double duration) {
            this.duration = duration;
            return this;
        }
        public Double getDuration() {
            return this.duration;
        }

        public AddLeaveTypeRequestLeaveCertificate setEnable(Boolean enable) {
            this.enable = enable;
            return this;
        }
        public Boolean getEnable() {
            return this.enable;
        }

        public AddLeaveTypeRequestLeaveCertificate setPromptInformation(String promptInformation) {
            this.promptInformation = promptInformation;
            return this;
        }
        public String getPromptInformation() {
            return this.promptInformation;
        }

        public AddLeaveTypeRequestLeaveCertificate setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class AddLeaveTypeRequestSubmitTimeRule extends TeaModel {
        @NameInMap("enableTimeLimit")
        public Boolean enableTimeLimit;

        @NameInMap("timeType")
        public String timeType;

        @NameInMap("timeUnit")
        public String timeUnit;

        @NameInMap("timeValue")
        public Long timeValue;

        public static AddLeaveTypeRequestSubmitTimeRule build(java.util.Map<String, ?> map) throws Exception {
            AddLeaveTypeRequestSubmitTimeRule self = new AddLeaveTypeRequestSubmitTimeRule();
            return TeaModel.build(map, self);
        }

        public AddLeaveTypeRequestSubmitTimeRule setEnableTimeLimit(Boolean enableTimeLimit) {
            this.enableTimeLimit = enableTimeLimit;
            return this;
        }
        public Boolean getEnableTimeLimit() {
            return this.enableTimeLimit;
        }

        public AddLeaveTypeRequestSubmitTimeRule setTimeType(String timeType) {
            this.timeType = timeType;
            return this;
        }
        public String getTimeType() {
            return this.timeType;
        }

        public AddLeaveTypeRequestSubmitTimeRule setTimeUnit(String timeUnit) {
            this.timeUnit = timeUnit;
            return this;
        }
        public String getTimeUnit() {
            return this.timeUnit;
        }

        public AddLeaveTypeRequestSubmitTimeRule setTimeValue(Long timeValue) {
            this.timeValue = timeValue;
            return this;
        }
        public Long getTimeValue() {
            return this.timeValue;
        }

    }

    public static class AddLeaveTypeRequestVisibilityRules extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("visible")
        public java.util.List<String> visible;

        public static AddLeaveTypeRequestVisibilityRules build(java.util.Map<String, ?> map) throws Exception {
            AddLeaveTypeRequestVisibilityRules self = new AddLeaveTypeRequestVisibilityRules();
            return TeaModel.build(map, self);
        }

        public AddLeaveTypeRequestVisibilityRules setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public AddLeaveTypeRequestVisibilityRules setVisible(java.util.List<String> visible) {
            this.visible = visible;
            return this;
        }
        public java.util.List<String> getVisible() {
            return this.visible;
        }

    }

}
