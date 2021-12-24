// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmGroupChatsRequest extends TeaModel {
    // 关系类型
    @NameInMap("relationType")
    public String relationType;

    // 第一页不传，下一页传入上一页返回的nextToken
    @NameInMap("nextToken")
    public String nextToken;

    // 每页返回的结果集个数
    @NameInMap("maxResults")
    public Integer maxResults;

    // 查询DSL
    @NameInMap("queryDsl")
    public String queryDsl;

    public static QueryCrmGroupChatsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCrmGroupChatsRequest self = new QueryCrmGroupChatsRequest();
        return TeaModel.build(map, self);
    }

    public QueryCrmGroupChatsRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public QueryCrmGroupChatsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryCrmGroupChatsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryCrmGroupChatsRequest setQueryDsl(String queryDsl) {
        this.queryDsl = queryDsl;
        return this;
    }
    public String getQueryDsl() {
        return this.queryDsl;
    }

}
