// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class GetSendAndReceiveReportListRequest extends TeaModel {
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
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

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
     * <p>1507564800000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    public static GetSendAndReceiveReportListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSendAndReceiveReportListRequest self = new GetSendAndReceiveReportListRequest();
        return TeaModel.build(map, self);
    }

    public GetSendAndReceiveReportListRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetSendAndReceiveReportListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetSendAndReceiveReportListRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetSendAndReceiveReportListRequest setOperationUserId(String operationUserId) {
        this.operationUserId = operationUserId;
        return this;
    }
    public String getOperationUserId() {
        return this.operationUserId;
    }

    public GetSendAndReceiveReportListRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
