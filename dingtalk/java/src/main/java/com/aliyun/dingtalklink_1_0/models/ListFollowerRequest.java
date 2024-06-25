// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ListFollowerRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ding1234</p>
     */
    @NameInMap("accountId")
    public String accountId;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>Rp3Rqcts7BE08y49Jr6iu6xW4iQ</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static ListFollowerRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFollowerRequest self = new ListFollowerRequest();
        return TeaModel.build(map, self);
    }

    public ListFollowerRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public ListFollowerRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListFollowerRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
