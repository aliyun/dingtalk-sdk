// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryAppActiveUsersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("needPositionInfo")
    public Boolean needPositionInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryAppActiveUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAppActiveUsersRequest self = new QueryAppActiveUsersRequest();
        return TeaModel.build(map, self);
    }

    public QueryAppActiveUsersRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryAppActiveUsersRequest setNeedPositionInfo(Boolean needPositionInfo) {
        this.needPositionInfo = needPositionInfo;
        return this;
    }
    public Boolean getNeedPositionInfo() {
        return this.needPositionInfo;
    }

    public QueryAppActiveUsersRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
