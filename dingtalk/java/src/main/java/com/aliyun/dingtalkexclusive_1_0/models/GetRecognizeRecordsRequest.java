// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRecognizeRecordsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>123333</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("faceCompareResult")
    public Integer faceCompareResult;

    /**
     * <strong>example:</strong>
     * <p>1667000000</p>
     */
    @NameInMap("fromTime")
    public Long fromTime;

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
     * <strong>example:</strong>
     * <p>1669000000</p>
     */
    @NameInMap("toTime")
    public Long toTime;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetRecognizeRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRecognizeRecordsRequest self = new GetRecognizeRecordsRequest();
        return TeaModel.build(map, self);
    }

    public GetRecognizeRecordsRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public GetRecognizeRecordsRequest setFaceCompareResult(Integer faceCompareResult) {
        this.faceCompareResult = faceCompareResult;
        return this;
    }
    public Integer getFaceCompareResult() {
        return this.faceCompareResult;
    }

    public GetRecognizeRecordsRequest setFromTime(Long fromTime) {
        this.fromTime = fromTime;
        return this;
    }
    public Long getFromTime() {
        return this.fromTime;
    }

    public GetRecognizeRecordsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetRecognizeRecordsRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetRecognizeRecordsRequest setToTime(Long toTime) {
        this.toTime = toTime;
        return this;
    }
    public Long getToTime() {
        return this.toTime;
    }

    public GetRecognizeRecordsRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
