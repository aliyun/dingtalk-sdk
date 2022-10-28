// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateJobDeliverRequest extends TeaModel {
    // 招聘业务标识，目前固定ddats
    @NameInMap("bizCode")
    public String bizCode;

    // 渠道侧职位唯一标识
    @NameInMap("channelOuterId")
    public String channelOuterId;

    // 渠道侧错误码
    @NameInMap("errorCode")
    public String errorCode;

    // 渠道侧错误信息
    @NameInMap("errorMsg")
    public String errorMsg;

    // 操作时间
    @NameInMap("opTime")
    public Long opTime;

    // 操作人userId
    @NameInMap("opUserId")
    public String opUserId;

    // 职位投递状态
    @NameInMap("status")
    public Integer status;

    // 企业corpId
    @NameInMap("corpId")
    public String corpId;

    // 钉钉侧职位唯一标识
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

    public UpdateJobDeliverRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UpdateJobDeliverRequest setJobId(String jobId) {
        this.jobId = jobId;
        return this;
    }
    public String getJobId() {
        return this.jobId;
    }

}
