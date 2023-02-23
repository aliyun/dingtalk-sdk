// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUnReadMessageRequest extends TeaModel {
    /**
     * <p>钉外账号在业务系统内的唯一标志。</p>
     */
    @NameInMap("appUserId")
    public String appUserId;

    /**
     * <p>群会话Id列表。</p>
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
