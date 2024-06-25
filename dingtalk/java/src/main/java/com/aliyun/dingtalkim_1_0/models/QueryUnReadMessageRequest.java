// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUnReadMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1107****2120</p>
     */
    @NameInMap("appUserId")
    public String appUserId;

    /**
     * <strong>example:</strong>
     * <p>1745****8777</p>
     */
    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    public static QueryUnReadMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUnReadMessageRequest self = new QueryUnReadMessageRequest();
        return TeaModel.build(map, self);
    }

    public QueryUnReadMessageRequest setAppUserId(String appUserId) {
        this.appUserId = appUserId;
        return this;
    }
    public String getAppUserId() {
        return this.appUserId;
    }

    public QueryUnReadMessageRequest setOpenConversationIds(java.util.List<String> openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public java.util.List<String> getOpenConversationIds() {
        return this.openConversationIds;
    }

}
