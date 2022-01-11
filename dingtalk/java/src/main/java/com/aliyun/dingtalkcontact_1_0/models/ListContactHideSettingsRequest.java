// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListContactHideSettingsRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public Long nextToken;

    public static ListContactHideSettingsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListContactHideSettingsRequest self = new ListContactHideSettingsRequest();
        return TeaModel.build(map, self);
    }

    public ListContactHideSettingsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListContactHideSettingsRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
