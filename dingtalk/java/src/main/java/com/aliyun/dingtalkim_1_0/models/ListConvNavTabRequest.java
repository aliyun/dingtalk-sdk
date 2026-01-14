// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ListConvNavTabRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidc4iLyQBuHFQRvzxznz204Q==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static ListConvNavTabRequest build(java.util.Map<String, ?> map) throws Exception {
        ListConvNavTabRequest self = new ListConvNavTabRequest();
        return TeaModel.build(map, self);
    }

    public ListConvNavTabRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
