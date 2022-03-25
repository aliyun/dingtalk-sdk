// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerTracksByRelationIdRequest extends TeaModel {
    // 每页返回的结果集个数，默认10。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 第一页不传，下一页传入上一页返回的nextToken
    @NameInMap("nextToken")
    public String nextToken;

    // 关系id。
    @NameInMap("relationId")
    public String relationId;

    // 动态类型分组。
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
