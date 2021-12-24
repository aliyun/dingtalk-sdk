// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListGroupSetRequest extends TeaModel {
    // 第一页不传，下一页传入上一页返回的nextToken
    @NameInMap("nextToken")
    public String nextToken;

    // 每页返回的结果集个数
    @NameInMap("maxResults")
    public Integer maxResults;

    // 查询DSL
    @NameInMap("queryDsl")
    public String queryDsl;

    // 关系类型
    @NameInMap("relationType")
    public String relationType;

    public static ListGroupSetRequest build(java.util.Map<String, ?> map) throws Exception {
        ListGroupSetRequest self = new ListGroupSetRequest();
        return TeaModel.build(map, self);
    }

    public ListGroupSetRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListGroupSetRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListGroupSetRequest setQueryDsl(String queryDsl) {
        this.queryDsl = queryDsl;
        return this;
    }
    public String getQueryDsl() {
        return this.queryDsl;
    }

    public ListGroupSetRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}
