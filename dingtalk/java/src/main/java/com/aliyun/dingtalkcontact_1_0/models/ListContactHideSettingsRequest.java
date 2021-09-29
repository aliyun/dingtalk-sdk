// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListContactHideSettingsRequest extends TeaModel {
    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("maxResults")
    public Integer maxResults;

    public static ListContactHideSettingsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListContactHideSettingsRequest self = new ListContactHideSettingsRequest();
        return TeaModel.build(map, self);
    }

    public ListContactHideSettingsRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public ListContactHideSettingsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

}
