// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class ListDentriesRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>30</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>next_token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>DESC</p>
     */
    @NameInMap("order")
    public String order;

    /**
     * <strong>example:</strong>
     * <p>2022-01-01T10:00:00Z</p>
     */
    @NameInMap("orderBy")
    public String orderBy;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>parent_id</p>
     */
    @NameInMap("parentId")
    public String parentId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
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
