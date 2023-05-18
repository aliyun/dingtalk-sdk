// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcheck_in_1_0.models;

import com.aliyun.tea.*;

public class GetCheckinRecordByUserRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("operatorUserId")
    public String operatorUserId;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static GetCheckinRecordByUserRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCheckinRecordByUserRequest self = new GetCheckinRecordByUserRequest();
        return TeaModel.build(map, self);
    }

    public GetCheckinRecordByUserRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetCheckinRecordByUserRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public GetCheckinRecordByUserRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetCheckinRecordByUserRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public GetCheckinRecordByUserRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetCheckinRecordByUserRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
