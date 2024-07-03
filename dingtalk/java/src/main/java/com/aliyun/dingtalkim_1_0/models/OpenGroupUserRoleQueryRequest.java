// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupUserRoleQueryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("viewedUserId")
    public String viewedUserId;

    public static OpenGroupUserRoleQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupUserRoleQueryRequest self = new OpenGroupUserRoleQueryRequest();
        return TeaModel.build(map, self);
    }

    public OpenGroupUserRoleQueryRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public OpenGroupUserRoleQueryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public OpenGroupUserRoleQueryRequest setViewedUserId(String viewedUserId) {
        this.viewedUserId = viewedUserId;
        return this;
    }
    public String getViewedUserId() {
        return this.viewedUserId;
    }

}
