// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUserViewGroupLastMessageTimeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidc4iLyQBuHFQRvxxxnz204Q==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static QueryUserViewGroupLastMessageTimeRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserViewGroupLastMessageTimeRequest self = new QueryUserViewGroupLastMessageTimeRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserViewGroupLastMessageTimeRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
