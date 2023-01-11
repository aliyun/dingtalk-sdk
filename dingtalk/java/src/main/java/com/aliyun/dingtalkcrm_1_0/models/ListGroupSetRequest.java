// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListGroupSetRequest extends TeaModel {
    /**
     * <p>每页返回的结果集个数</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>第一页不传，下一页传入上一页返回的nextToken</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>查询DSL</p>
     */
    @NameInMap("queryDsl")
    public String queryDsl;

    /**
     * <p>关系类型</p>
     */
    @NameInMap("relationType")
    public String relationType;

    public static ListGroupSetRequest build(java.util.Map<String, ?> map) throws Exception {
        ListGroupSetRequest self = new ListGroupSetRequest();
        return TeaModel.build(map, self);
    }

    public ListGroupSetRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListGroupSetRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
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
