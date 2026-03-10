// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SortConvNavTabRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidc4iLyQBuHFQRvzxznz204Q</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("sortedIds")
    public java.util.List<String> sortedIds;

    public static SortConvNavTabRequest build(java.util.Map<String, ?> map) throws Exception {
        SortConvNavTabRequest self = new SortConvNavTabRequest();
        return TeaModel.build(map, self);
    }

    public SortConvNavTabRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SortConvNavTabRequest setSortedIds(java.util.List<String> sortedIds) {
        this.sortedIds = sortedIds;
        return this;
    }
    public java.util.List<String> getSortedIds() {
        return this.sortedIds;
    }

}
