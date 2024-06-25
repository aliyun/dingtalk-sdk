// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateJobDeliverRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>channelOuterId</p>
     */
    @NameInMap("channelOuterId")
    public String channelOuterId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>27016066248xxxxx</p>
     */
    @NameInMap("deliverUserId")
    public String deliverUserId;

    /**
     * <strong>example:</strong>
     * <p>ATS001</p>
     */
    @NameInMap("errorCode")
    public String errorCode;

    /**
     * <strong>example:</strong>
     * <p>职位审核不通过</p>
     */
    @NameInMap("errorMsg")
    public String errorMsg;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1666780239981</p>
     */
    @NameInMap("opTime")
    public Long opTime;

    /**
     * <strong>example:</strong>
     * <p>27016066248xxxxx</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>jobId23ed0d46548f4e88a7b808d3f3057xxx</p>
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
