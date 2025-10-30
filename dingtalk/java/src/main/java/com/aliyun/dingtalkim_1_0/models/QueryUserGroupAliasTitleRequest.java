// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUserGroupAliasTitleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxx</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2131231xxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryUserGroupAliasTitleRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserGroupAliasTitleRequest self = new QueryUserGroupAliasTitleRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserGroupAliasTitleRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryUserGroupAliasTitleRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
