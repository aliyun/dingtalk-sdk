// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ReduceQuotaWithLeaveRecordRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("leaveCode")
    public String leaveCode;

    @NameInMap("outerId")
    public String outerId;

    @NameInMap("quotaNum")
    public Integer quotaNum;

    @NameInMap("reason")
    public String reason;

    @NameInMap("startTime")
    public Long startTime;

    public static ReduceQuotaWithLeaveRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        ReduceQuotaWithLeaveRecordRequest self = new ReduceQuotaWithLeaveRecordRequest();
        return TeaModel.build(map, self);
    }

    public ReduceQuotaWithLeaveRecordRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public ReduceQuotaWithLeaveRecordRequest setLeaveCode(String leaveCode) {
        this.leaveCode = leaveCode;
        return this;
    }
    public String getLeaveCode() {
        return this.leaveCode;
    }

    public ReduceQuotaWithLeaveRecordRequest setOuterId(String outerId) {
        this.outerId = outerId;
        return this;
    }
    public String getOuterId() {
        return this.outerId;
    }

    public ReduceQuotaWithLeaveRecordRequest setQuotaNum(Integer quotaNum) {
        this.quotaNum = quotaNum;
        return this;
    }
    public Integer getQuotaNum() {
        return this.quotaNum;
    }

    public ReduceQuotaWithLeaveRecordRequest setReason(String reason) {
        this.reason = reason;
        return this;
    }
    public String getReason() {
        return this.reason;
    }

    public ReduceQuotaWithLeaveRecordRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
