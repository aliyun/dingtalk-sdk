// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListContactRestrictSettingRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public Long nextToken;

    public static ListContactRestrictSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        ListContactRestrictSettingRequest self = new ListContactRestrictSettingRequest();
        return TeaModel.build(map, self);
    }

    public ListContactRestrictSettingRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListContactRestrictSettingRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
