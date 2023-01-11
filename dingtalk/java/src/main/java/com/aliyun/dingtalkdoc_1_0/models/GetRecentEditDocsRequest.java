// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRecentEditDocsRequest extends TeaModel {
    /**
     * <p>查询size</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>发起操作用户unionId</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetRecentEditDocsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRecentEditDocsRequest self = new GetRecentEditDocsRequest();
        return TeaModel.build(map, self);
    }

    public GetRecentEditDocsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetRecentEditDocsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetRecentEditDocsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
