// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMemberRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>14da****2760</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static QueryGroupMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMemberRequest self = new QueryGroupMemberRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupMemberRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
