// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class ModifyFeedWhiteListShrinkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("action")
    public Long action;

    @NameInMap("modifyUserList")
    public String modifyUserListShrink;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1206186351746728</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ModifyFeedWhiteListShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        ModifyFeedWhiteListShrinkRequest self = new ModifyFeedWhiteListShrinkRequest();
        return TeaModel.build(map, self);
    }

    public ModifyFeedWhiteListShrinkRequest setAction(Long action) {
        this.action = action;
        return this;
    }
    public Long getAction() {
        return this.action;
    }

    public ModifyFeedWhiteListShrinkRequest setModifyUserListShrink(String modifyUserListShrink) {
        this.modifyUserListShrink = modifyUserListShrink;
        return this;
    }
    public String getModifyUserListShrink() {
        return this.modifyUserListShrink;
    }

    public ModifyFeedWhiteListShrinkRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
