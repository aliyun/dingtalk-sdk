// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class RetainLeaveTypesResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<RetainLeaveTypesResponseBodyResult> result;

    public static RetainLeaveTypesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RetainLeaveTypesResponseBody self = new RetainLeaveTypesResponseBody();
        return TeaModel.build(map, self);
    }

    public RetainLeaveTypesResponseBody setResult(java.util.List<RetainLeaveTypesResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<RetainLeaveTypesResponseBodyResult> getResult() {
        return this.result;
    }

    public static class RetainLeaveTypesResponseBodyResultLeaveCertificate extends TeaModel {
        @NameInMap("duration")
        public Double duration;

        @NameInMap("enable")
        public Boolean enable;

        @NameInMap("promptInformation")
        public String promptInformation;

        @NameInMap("unit")
        public String unit;

        public static RetainLeaveTypesResponseBodyResultLeaveCertificate build(java.util.Map<String, ?> map) throws Exception {
            RetainLeaveTypesResponseBodyResultLeaveCertificate self = new RetainLeaveTypesResponseBodyResultLeaveCertificate();
            return TeaModel.build(map, self);
        }

        public RetainLeaveTypesResponseBodyResultLeaveCertificate setDuration(Double duration) {
            this.duration = duration;
            return this;
        }
        public Double getDuration() {
            return this.duration;
        }

        public RetainLeaveTypesResponseBodyResultLeaveCertificate setEnable(Boolean enable) {
            this.enable = enable;
            return this;
        }
        public Boolean getEnable() {
            return this.enable;
        }

        public RetainLeaveTypesResponseBodyResultLeaveCertificate setPromptInformation(String promptInformation) {
            this.promptInformation = promptInformation;
            return this;
        }
        public String getPromptInformation() {
            return this.promptInformation;
        }

        public RetainLeaveTypesResponseBodyResultLeaveCertificate setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class RetainLeaveTypesResponseBodyResultSubmitTimeRule extends TeaModel {
        @NameInMap("enableTimeLimit")
        public Boolean enableTimeLimit;

        @NameInMap("timeType")
        public String timeType;

        @NameInMap("timeUnit")
        public String timeUnit;

        @NameInMap("timeValue")
        public Long timeValue;

        public static RetainLeaveTypesResponseBodyResultSubmitTimeRule build(java.util.Map<String, ?> map) throws Exception {
            RetainLeaveTypesResponseBodyResultSubmitTimeRule self = new RetainLeaveTypesResponseBodyResultSubmitTimeRule();
            return TeaModel.build(map, self);
        }

        public RetainLeaveTypesResponseBodyResultSubmitTimeRule setEnableTimeLimit(Boolean enableTimeLimit) {
            this.enableTimeLimit = enableTimeLimit;
            return this;
        }
        public Boolean getEnableTimeLimit() {
            return this.enableTimeLimit;
        }

        public RetainLeaveTypesResponseBodyResultSubmitTimeRule setTimeType(String timeType) {
            this.timeType = timeType;
            return this;
        }
        public String getTimeType() {
            return this.timeType;
        }

        public RetainLeaveTypesResponseBodyResultSubmitTimeRule setTimeUnit(String timeUnit) {
            this.timeUnit = timeUnit;
            return this;
        }
        public String getTimeUnit() {
            return this.timeUnit;
        }

        public RetainLeaveTypesResponseBodyResultSubmitTimeRule setTimeValue(Long timeValue) {
            this.timeValue = timeValue;
            return this;
        }
        public Long getTimeValue() {
            return this.timeValue;
        }

    }

    public static class RetainLeaveTypesResponseBodyResultVisibilityRules extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("visible")
        public java.util.List<String> visible;

        public static RetainLeaveTypesResponseBodyResultVisibilityRules build(java.util.Map<String, ?> map) throws Exception {
            RetainLeaveTypesResponseBodyResultVisibilityRules self = new RetainLeaveTypesResponseBodyResultVisibilityRules();
            return TeaModel.build(map, self);
        }

        public RetainLeaveTypesResponseBodyResultVisibilityRules setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public RetainLeaveTypesResponseBodyResultVisibilityRules setVisible(java.util.List<String> visible) {
            this.visible = visible;
            return this;
        }
        public java.util.List<String> getVisible() {
            return this.visible;
        }

    }

    public static class RetainLeaveTypesResponseBodyResult extends TeaModel {
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("hoursInPerDay")
        public Long hoursInPerDay;

        @NameInMap("leaveCertificate")
        public RetainLeaveTypesResponseBodyResultLeaveCertificate leaveCertificate;

        @NameInMap("leaveCode")
        public String leaveCode;

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

        @NameInMap("lieuDelayNum")
        public Long lieuDelayNum;

        @NameInMap("lieuDelayUnit")
        public String lieuDelayUnit;

        @NameInMap("maxLeaveTime")
        public Long maxLeaveTime;

        @NameInMap("minLeaveHour")
        public Double minLeaveHour;

        @NameInMap("naturalDayLeave")
        public Boolean naturalDayLeave;

        @NameInMap("paidLeave")
        public Boolean paidLeave;

        @NameInMap("submitTimeRule")
        public RetainLeaveTypesResponseBodyResultSubmitTimeRule submitTimeRule;

        @NameInMap("visibilityRules")
        public java.util.List<RetainLeaveTypesResponseBodyResultVisibilityRules> visibilityRules;

        @NameInMap("whenCanLeave")
        public String whenCanLeave;

        public static RetainLeaveTypesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            RetainLeaveTypesResponseBodyResult self = new RetainLeaveTypesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public RetainLeaveTypesResponseBodyResult setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public RetainLeaveTypesResponseBodyResult setHoursInPerDay(Long hoursInPerDay) {
            this.hoursInPerDay = hoursInPerDay;
            return this;
        }
        public Long getHoursInPerDay() {
            return this.hoursInPerDay;
        }

        public RetainLeaveTypesResponseBodyResult setLeaveCertificate(RetainLeaveTypesResponseBodyResultLeaveCertificate leaveCertificate) {
            this.leaveCertificate = leaveCertificate;
            return this;
        }
        public RetainLeaveTypesResponseBodyResultLeaveCertificate getLeaveCertificate() {
            return this.leaveCertificate;
        }

        public RetainLeaveTypesResponseBodyResult setLeaveCode(String leaveCode) {
            this.leaveCode = leaveCode;
            return this;
        }
        public String getLeaveCode() {
            return this.leaveCode;
        }

        public RetainLeaveTypesResponseBodyResult setLeaveHourCeil(String leaveHourCeil) {
            this.leaveHourCeil = leaveHourCeil;
            return this;
        }
        public String getLeaveHourCeil() {
            return this.leaveHourCeil;
        }

        public RetainLeaveTypesResponseBodyResult setLeaveName(String leaveName) {
            this.leaveName = leaveName;
            return this;
        }
        public String getLeaveName() {
            return this.leaveName;
        }

        public RetainLeaveTypesResponseBodyResult setLeaveTimeCeil(Boolean leaveTimeCeil) {
            this.leaveTimeCeil = leaveTimeCeil;
            return this;
        }
        public Boolean getLeaveTimeCeil() {
            return this.leaveTimeCeil;
        }

        public RetainLeaveTypesResponseBodyResult setLeaveTimeCeilMinUnit(String leaveTimeCeilMinUnit) {
            this.leaveTimeCeilMinUnit = leaveTimeCeilMinUnit;
            return this;
        }
        public String getLeaveTimeCeilMinUnit() {
            return this.leaveTimeCeilMinUnit;
        }

        public RetainLeaveTypesResponseBodyResult setLeaveViewUnit(String leaveViewUnit) {
            this.leaveViewUnit = leaveViewUnit;
            return this;
        }
        public String getLeaveViewUnit() {
            return this.leaveViewUnit;
        }

        public RetainLeaveTypesResponseBodyResult setLieuDelayNum(Long lieuDelayNum) {
            this.lieuDelayNum = lieuDelayNum;
            return this;
        }
        public Long getLieuDelayNum() {
            return this.lieuDelayNum;
        }

        public RetainLeaveTypesResponseBodyResult setLieuDelayUnit(String lieuDelayUnit) {
            this.lieuDelayUnit = lieuDelayUnit;
            return this;
        }
        public String getLieuDelayUnit() {
            return this.lieuDelayUnit;
        }

        public RetainLeaveTypesResponseBodyResult setMaxLeaveTime(Long maxLeaveTime) {
            this.maxLeaveTime = maxLeaveTime;
            return this;
        }
        public Long getMaxLeaveTime() {
            return this.maxLeaveTime;
        }

        public RetainLeaveTypesResponseBodyResult setMinLeaveHour(Double minLeaveHour) {
            this.minLeaveHour = minLeaveHour;
            return this;
        }
        public Double getMinLeaveHour() {
            return this.minLeaveHour;
        }

        public RetainLeaveTypesResponseBodyResult setNaturalDayLeave(Boolean naturalDayLeave) {
            this.naturalDayLeave = naturalDayLeave;
            return this;
        }
        public Boolean getNaturalDayLeave() {
            return this.naturalDayLeave;
        }

        public RetainLeaveTypesResponseBodyResult setPaidLeave(Boolean paidLeave) {
            this.paidLeave = paidLeave;
            return this;
        }
        public Boolean getPaidLeave() {
            return this.paidLeave;
        }

        public RetainLeaveTypesResponseBodyResult setSubmitTimeRule(RetainLeaveTypesResponseBodyResultSubmitTimeRule submitTimeRule) {
            this.submitTimeRule = submitTimeRule;
            return this;
        }
        public RetainLeaveTypesResponseBodyResultSubmitTimeRule getSubmitTimeRule() {
            return this.submitTimeRule;
        }

        public RetainLeaveTypesResponseBodyResult setVisibilityRules(java.util.List<RetainLeaveTypesResponseBodyResultVisibilityRules> visibilityRules) {
            this.visibilityRules = visibilityRules;
            return this;
        }
        public java.util.List<RetainLeaveTypesResponseBodyResultVisibilityRules> getVisibilityRules() {
            return this.visibilityRules;
        }

        public RetainLeaveTypesResponseBodyResult setWhenCanLeave(String whenCanLeave) {
            this.whenCanLeave = whenCanLeave;
            return this;
        }
        public String getWhenCanLeave() {
            return this.whenCanLeave;
        }

    }

}
