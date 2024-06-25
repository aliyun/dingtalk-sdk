// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListDentryVersionsRequest extends TeaModel {
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
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ListDentryVersionsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDentryVersionsRequest self = new ListDentryVersionsRequest();
        return TeaModel.build(map, self);
    }

    public ListDentryVersionsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListDentryVersionsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListDentryVersionsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
