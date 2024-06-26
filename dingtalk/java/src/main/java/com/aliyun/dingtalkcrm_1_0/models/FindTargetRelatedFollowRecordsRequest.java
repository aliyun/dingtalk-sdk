// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class FindTargetRelatedFollowRecordsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>customerId</p>
     */
    @NameInMap("followTargetDataId")
    public String followTargetDataId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>customer</p>
     */
    @NameInMap("followTargetType")
    public String followTargetType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static FindTargetRelatedFollowRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        FindTargetRelatedFollowRecordsRequest self = new FindTargetRelatedFollowRecordsRequest();
        return TeaModel.build(map, self);
    }

    public FindTargetRelatedFollowRecordsRequest setFollowTargetDataId(String followTargetDataId) {
        this.followTargetDataId = followTargetDataId;
        return this;
    }
    public String getFollowTargetDataId() {
        return this.followTargetDataId;
    }

    public FindTargetRelatedFollowRecordsRequest setFollowTargetType(String followTargetType) {
        this.followTargetType = followTargetType;
        return this;
    }
    public String getFollowTargetType() {
        return this.followTargetType;
    }

    public FindTargetRelatedFollowRecordsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public FindTargetRelatedFollowRecordsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
