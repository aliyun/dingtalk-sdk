// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRecognizeRecordsRequest extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    @NameInMap("faceCompareResult")
    public Integer faceCompareResult;

    @NameInMap("fromTime")
    public Long fromTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

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
