// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkactivity_1_0.models;

import com.aliyun.tea.*;

public class ListActivityRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static ListActivityRequest build(java.util.Map<String, ?> map) throws Exception {
        ListActivityRequest self = new ListActivityRequest();
        return TeaModel.build(map, self);
    }

    public ListActivityRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListActivityRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
