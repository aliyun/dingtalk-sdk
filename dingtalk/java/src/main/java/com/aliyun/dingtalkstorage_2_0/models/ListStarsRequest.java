// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ListStarsRequest extends TeaModel {
    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("orderBy")
    public String orderBy;

    @NameInMap("sortType")
    public String sortType;

    @NameInMap("supportResourceTypes")
    public java.util.List<String> supportResourceTypes;

    public static ListStarsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListStarsRequest self = new ListStarsRequest();
        return TeaModel.build(map, self);
    }

    public ListStarsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public ListStarsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListStarsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public ListStarsRequest setOrderBy(String orderBy) {
        this.orderBy = orderBy;
        return this;
    }
    public String getOrderBy() {
        return this.orderBy;
    }

    public ListStarsRequest setSortType(String sortType) {
        this.sortType = sortType;
        return this;
    }
    public String getSortType() {
        return this.sortType;
    }

    public ListStarsRequest setSupportResourceTypes(java.util.List<String> supportResourceTypes) {
        this.supportResourceTypes = supportResourceTypes;
        return this;
    }
    public java.util.List<String> getSupportResourceTypes() {
        return this.supportResourceTypes;
    }

}
