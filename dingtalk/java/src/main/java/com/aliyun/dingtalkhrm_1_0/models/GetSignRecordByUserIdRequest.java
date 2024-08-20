// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetSignRecordByUserIdRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("signStatus")
    public java.util.List<String> signStatus;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>660658</p>
     */
    @NameInMap("signUserId")
    public String signUserId;

    public static GetSignRecordByUserIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSignRecordByUserIdRequest self = new GetSignRecordByUserIdRequest();
        return TeaModel.build(map, self);
    }

    public GetSignRecordByUserIdRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetSignRecordByUserIdRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetSignRecordByUserIdRequest setSignStatus(java.util.List<String> signStatus) {
        this.signStatus = signStatus;
        return this;
    }
    public java.util.List<String> getSignStatus() {
        return this.signStatus;
    }

    public GetSignRecordByUserIdRequest setSignUserId(String signUserId) {
        this.signUserId = signUserId;
        return this;
    }
    public String getSignUserId() {
        return this.signUserId;
    }

}
