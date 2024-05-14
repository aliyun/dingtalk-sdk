// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class ListDentriesRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("order")
    public String order;

    @NameInMap("orderBy")
    public String orderBy;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("parentId")
    public String parentId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    @NameInMap("withThumbnail")
    public Boolean withThumbnail;

    public static ListDentriesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDentriesRequest self = new ListDentriesRequest();
        return TeaModel.build(map, self);
    }

    public ListDentriesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListDentriesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListDentriesRequest setOrder(String order) {
        this.order = order;
        return this;
    }
    public String getOrder() {
        return this.order;
    }

    public ListDentriesRequest setOrderBy(String orderBy) {
        this.orderBy = orderBy;
        return this;
    }
    public String getOrderBy() {
        return this.orderBy;
    }

    public ListDentriesRequest setParentId(String parentId) {
        this.parentId = parentId;
        return this;
    }
    public String getParentId() {
        return this.parentId;
    }

    public ListDentriesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public ListDentriesRequest setWithThumbnail(Boolean withThumbnail) {
        this.withThumbnail = withThumbnail;
        return this;
    }
    public Boolean getWithThumbnail() {
        return this.withThumbnail;
    }

}
