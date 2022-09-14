// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListRelatedTeamsRequest extends TeaModel {
    // 每页最大条目数，最大值50。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页游标，第一页可不传。
    @NameInMap("nextToken")
    public String nextToken;

    // 操作用户unionId。
    @NameInMap("operatorId")
    public String operatorId;

    // 小组类型。
    // 0-默认；1-部门；2-项目组；3-兴趣小组。
    @NameInMap("type")
    public Integer type;

    public static ListRelatedTeamsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListRelatedTeamsRequest self = new ListRelatedTeamsRequest();
        return TeaModel.build(map, self);
    }

    public ListRelatedTeamsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListRelatedTeamsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListRelatedTeamsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public ListRelatedTeamsRequest setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

}
