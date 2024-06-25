// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListUserVisibleBpmsProcessesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <strong>example:</strong>
     * <p>manager7078</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ListUserVisibleBpmsProcessesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListUserVisibleBpmsProcessesRequest self = new ListUserVisibleBpmsProcessesRequest();
        return TeaModel.build(map, self);
    }

    public ListUserVisibleBpmsProcessesRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public ListUserVisibleBpmsProcessesRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public ListUserVisibleBpmsProcessesRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
