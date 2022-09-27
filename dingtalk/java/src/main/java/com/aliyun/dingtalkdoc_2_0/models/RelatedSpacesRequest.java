// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RelatedSpacesRequest extends TeaModel {
    // 每页最大条目数，最大值100。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页游标，第一页可不传。
    @NameInMap("nextToken")
    public String nextToken;

    // 操作用户unionId。
    @NameInMap("operatorId")
    public String operatorId;

    // 小组id。
    @NameInMap("teamId")
    public String teamId;

    public static RelatedSpacesRequest build(java.util.Map<String, ?> map) throws Exception {
        RelatedSpacesRequest self = new RelatedSpacesRequest();
        return TeaModel.build(map, self);
    }

    public RelatedSpacesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public RelatedSpacesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public RelatedSpacesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public RelatedSpacesRequest setTeamId(String teamId) {
        this.teamId = teamId;
        return this;
    }
    public String getTeamId() {
        return this.teamId;
    }

}
