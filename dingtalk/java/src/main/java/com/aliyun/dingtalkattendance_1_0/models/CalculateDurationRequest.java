// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CalculateDurationRequest extends TeaModel {
    @NameInMap("bizType")
    public Long bizType;

    @NameInMap("calculateModel")
    public Long calculateModel;

    @NameInMap("durationUnit")
    public String durationUnit;

    @NameInMap("fromTime")
    public String fromTime;

    @NameInMap("leaveCode")
    public String leaveCode;

    @NameInMap("toTime")
    public String toTime;

    @NameInMap("userId")
    public String userId;

    public static CalculateDurationRequest build(java.util.Map<String, ?> map) throws Exception {
        CalculateDurationRequest self = new CalculateDurationRequest();
        return TeaModel.build(map, self);
    }

    public CalculateDurationRequest setBizType(Long bizType) {
        this.bizType = bizType;
        return this;
    }
    public Long getBizType() {
        return this.bizType;
    }

    public CalculateDurationRequest setCalculateModel(Long calculateModel) {
        this.calculateModel = calculateModel;
        return this;
    }
    public Long getCalculateModel() {
        return this.calculateModel;
    }

    public CalculateDurationRequest setDurationUnit(String durationUnit) {
        this.durationUnit = durationUnit;
        return this;
    }
    public String getDurationUnit() {
        return this.durationUnit;
    }

    public CalculateDurationRequest setFromTime(String fromTime) {
        this.fromTime = fromTime;
        return this;
    }
    public String getFromTime() {
        return this.fromTime;
    }

    public CalculateDurationRequest setLeaveCode(String leaveCode) {
        this.leaveCode = leaveCode;
        return this;
    }
    public String getLeaveCode() {
        return this.leaveCode;
    }

    public CalculateDurationRequest setToTime(String toTime) {
        this.toTime = toTime;
        return this;
    }
    public String getToTime() {
        return this.toTime;
    }

    public CalculateDurationRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
