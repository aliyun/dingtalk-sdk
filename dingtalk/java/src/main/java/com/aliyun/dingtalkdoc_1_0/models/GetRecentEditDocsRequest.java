// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRecentEditDocsRequest extends TeaModel {
    // 发起操作用户unionId
    @NameInMap("operatorId")
    public String operatorId;

    // 查询size
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static GetRecentEditDocsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRecentEditDocsRequest self = new GetRecentEditDocsRequest();
        return TeaModel.build(map, self);
    }

    public GetRecentEditDocsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
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

}
