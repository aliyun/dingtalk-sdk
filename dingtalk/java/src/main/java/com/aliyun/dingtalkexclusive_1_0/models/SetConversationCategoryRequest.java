// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetConversationCategoryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>-1</p>
     */
    @NameInMap("categoryId")
    public Long categoryId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static SetConversationCategoryRequest build(java.util.Map<String, ?> map) throws Exception {
        SetConversationCategoryRequest self = new SetConversationCategoryRequest();
        return TeaModel.build(map, self);
    }

    public SetConversationCategoryRequest setCategoryId(Long categoryId) {
        this.categoryId = categoryId;
        return this;
    }
    public Long getCategoryId() {
        return this.categoryId;
    }

    public SetConversationCategoryRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
