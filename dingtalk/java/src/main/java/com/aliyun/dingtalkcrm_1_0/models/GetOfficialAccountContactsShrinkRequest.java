// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactsShrinkRequest extends TeaModel {
    @NameInMap("context")
    public String contextShrink;

    // 取数游标，第一次传0
    @NameInMap("nextToken")
    public String nextToken;

    // 分页大小，最大不超过10
    @NameInMap("maxResults")
    public Long maxResults;

    public static GetOfficialAccountContactsShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountContactsShrinkRequest self = new GetOfficialAccountContactsShrinkRequest();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountContactsShrinkRequest setContextShrink(String contextShrink) {
        this.contextShrink = contextShrink;
        return this;
    }
    public String getContextShrink() {
        return this.contextShrink;
    }

    public GetOfficialAccountContactsShrinkRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetOfficialAccountContactsShrinkRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

}
