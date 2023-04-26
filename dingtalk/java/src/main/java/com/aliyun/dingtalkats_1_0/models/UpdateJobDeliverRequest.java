// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateJobDeliverRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("channelOuterId")
    public String channelOuterId;

    @NameInMap("deliverUserId")
    public String deliverUserId;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("opTime")
    public Long opTime;

    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("status")
    public Integer status;

    @NameInMap("jobId")
    public String jobId;

    public static UpdateJobDeliverRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateJobDeliverRequest self = new UpdateJobDeliverRequest();
        return TeaModel.build(map, self);
    }

    public UpdateJobDeliverRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public UpdateJobDeliverRequest setChannelOuterId(String channelOuterId) {
        this.channelOuterId = channelOuterId;
        return this;
    }
    public String getChannelOuterId() {
        return this.channelOuterId;
    }

    public UpdateJobDeliverRequest setDeliverUserId(String deliverUserId) {
        this.deliverUserId = deliverUserId;
        return this;
    }
    public String getDeliverUserId() {
        return this.deliverUserId;
    }

    public UpdateJobDeliverRequest setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public UpdateJobDeliverRequest setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public UpdateJobDeliverRequest setOpTime(Long opTime) {
        this.opTime = opTime;
        return this;
    }
    public Long getOpTime() {
        return this.opTime;
    }

    public UpdateJobDeliverRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public UpdateJobDeliverRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public UpdateJobDeliverRequest setJobId(String jobId) {
        this.jobId = jobId;
        return this;
    }
    public String getJobId() {
        return this.jobId;
    }

}
