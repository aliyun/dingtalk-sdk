// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListEmpAttributeVisibilityRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public Long nextToken;

    public static ListEmpAttributeVisibilityRequest build(java.util.Map<String, ?> map) throws Exception {
        ListEmpAttributeVisibilityRequest self = new ListEmpAttributeVisibilityRequest();
        return TeaModel.build(map, self);
    }

    public ListEmpAttributeVisibilityRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListEmpAttributeVisibilityRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
