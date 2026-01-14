// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DeleteConvNavTabRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidc4iLyQBuHFQRvzxznz204Q</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("tabIds")
    public java.util.List<String> tabIds;

    public static DeleteConvNavTabRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteConvNavTabRequest self = new DeleteConvNavTabRequest();
        return TeaModel.build(map, self);
    }

    public DeleteConvNavTabRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public DeleteConvNavTabRequest setTabIds(java.util.List<String> tabIds) {
        this.tabIds = tabIds;
        return this;
    }
    public java.util.List<String> getTabIds() {
        return this.tabIds;
    }

}
