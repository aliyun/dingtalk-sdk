// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class GetSubmitStatisticsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1507564800000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("operationUserId")
    public String operationUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("remindId")
    public Long remindId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1507564800000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>18xxxxx</p>
     */
    @NameInMap("templateId")
    public String templateId;

    public static GetSubmitStatisticsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSubmitStatisticsRequest self = new GetSubmitStatisticsRequest();
        return TeaModel.build(map, self);
    }

    public GetSubmitStatisticsRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetSubmitStatisticsRequest setOperationUserId(String operationUserId) {
        this.operationUserId = operationUserId;
        return this;
    }
    public String getOperationUserId() {
        return this.operationUserId;
    }

    public GetSubmitStatisticsRequest setRemindId(Long remindId) {
        this.remindId = remindId;
        return this;
    }
    public Long getRemindId() {
        return this.remindId;
    }

    public GetSubmitStatisticsRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetSubmitStatisticsRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
