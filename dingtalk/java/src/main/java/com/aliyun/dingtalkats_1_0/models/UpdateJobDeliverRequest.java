// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateJobDeliverRequest extends TeaModel {
    /**
     * <p>招聘业务标识，目前固定ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>渠道侧职位唯一标识</p>
     */
    @NameInMap("channelOuterId")
    public String channelOuterId;

    /**
     * <p>职位投递人userId</p>
     */
    @NameInMap("deliverUserId")
    public String deliverUserId;

    /**
     * <p>渠道侧错误码</p>
     */
    @NameInMap("errorCode")
    public String errorCode;

    /**
     * <p>渠道侧错误信息</p>
     */
    @NameInMap("errorMsg")
    public String errorMsg;

    /**
     * <p>操作时间</p>
     */
    @NameInMap("opTime")
    public Long opTime;

    /**
     * <p>操作人userId</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>职位投递状态</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>钉钉侧职位唯一标识</p>
     */
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
