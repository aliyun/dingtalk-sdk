// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRecognizeRecordsRequest extends TeaModel {
    /**
     * <p>应用唯一标识</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>人脸对比结果 1-成功 2-失败</p>
     */
    @NameInMap("faceCompareResult")
    public Integer faceCompareResult;

    /**
     * <p>记录开始时间(毫秒时间戳)</p>
     */
    @NameInMap("fromTime")
    public Long fromTime;

    /**
     * <p>一页最大值（最大50）</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>查询数据的起始位置，0表示从头开始。</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>记录结束时间(毫秒时间戳)</p>
     */
    @NameInMap("toTime")
    public Long toTime;

    /**
     * <p>员工userIds</p>
     */
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
