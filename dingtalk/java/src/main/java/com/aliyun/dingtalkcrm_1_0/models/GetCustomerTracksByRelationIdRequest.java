// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerTracksByRelationIdRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("relationId")
    public String relationId;

    @NameInMap("typeGroup")
    public Integer typeGroup;

    public static GetCustomerTracksByRelationIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerTracksByRelationIdRequest self = new GetCustomerTracksByRelationIdRequest();
        return TeaModel.build(map, self);
    }

    public GetCustomerTracksByRelationIdRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetCustomerTracksByRelationIdRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetCustomerTracksByRelationIdRequest setRelationId(String relationId) {
        this.relationId = relationId;
        return this;
    }
    public String getRelationId() {
        return this.relationId;
    }

    public GetCustomerTracksByRelationIdRequest setTypeGroup(Integer typeGroup) {
        this.typeGroup = typeGroup;
        return this;
    }
    public Integer getTypeGroup() {
        return this.typeGroup;
    }

}
