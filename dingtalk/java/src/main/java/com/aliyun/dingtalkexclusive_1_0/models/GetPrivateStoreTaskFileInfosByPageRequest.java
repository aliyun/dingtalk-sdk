// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreTaskFileInfosByPageRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>12dfewfg</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("taskId")
    public Long taskId;

    public static GetPrivateStoreTaskFileInfosByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreTaskFileInfosByPageRequest self = new GetPrivateStoreTaskFileInfosByPageRequest();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreTaskFileInfosByPageRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetPrivateStoreTaskFileInfosByPageRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetPrivateStoreTaskFileInfosByPageRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
