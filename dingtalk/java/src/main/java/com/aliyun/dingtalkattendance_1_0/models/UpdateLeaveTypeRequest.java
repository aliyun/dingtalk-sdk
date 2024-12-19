// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class UpdateLeaveTypeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>general_leave</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <strong>example:</strong>
     * <p>{&quot;validity_type&quot;:&quot;absolute_time&quot;,&quot;validity_value&quot;:&quot;12-31&quot;}</p>
     */
    @NameInMap("extras")
    public String extras;

    @NameInMap("freedomLeave")
    public Boolean freedomLeave;

    /**
     * <strong>example:</strong>
     * <p>1000</p>
     */
    @NameInMap("hoursInPerDay")
    public Long hoursInPerDay;

    @NameInMap("leaveCertificate")
    public UpdateLeaveTypeRequestLeaveCertificate leaveCertificate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>047477ae-1009-4632-b8e9-e919ae5e7973</p>
     */
    @NameInMap("leaveCode")
    public String leaveCode;

    /**
     * <strong>example:</strong>
     * <p>年假</p>
     */
    @NameInMap("leaveName")
    public String leaveName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>day</p>
     */
    @NameInMap("leaveViewUnit")
    public String leaveViewUnit;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("naturalDayLeave")
    public Boolean naturalDayLeave;

    @NameInMap("submitTimeRule")
    public UpdateLeaveTypeRequestSubmitTimeRule submitTimeRule;

    @NameInMap("visibilityRules")
    public java.util.List<UpdateLeaveTypeRequestVisibilityRules> visibilityRules;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user01</p>
     */
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

    public UpdateLeaveTypeRequest setFreedomLeave(Boolean freedomLeave) {
        this.freedomLeave = freedomLeave;
        return this;
    }
    public Boolean getFreedomLeave() {
        return this.freedomLeave;
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
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("duration")
        public Double duration;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("enable")
        public Boolean enable;

        /**
         * <strong>example:</strong>
         * <p>请假文案</p>
         */
        @NameInMap("promptInformation")
        public String promptInformation;

        /**
         * <strong>example:</strong>
         * <p>hour</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("enableTimeLimit")
        public Boolean enableTimeLimit;

        /**
         * <strong>example:</strong>
         * <p>before</p>
         */
        @NameInMap("timeType")
        public String timeType;

        /**
         * <strong>example:</strong>
         * <p>day</p>
         */
        @NameInMap("timeUnit")
        public String timeUnit;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>staff</p>
         */
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
