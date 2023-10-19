// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateMessageCategoryRequest extends TeaModel {
    @NameInMap("categoryName")
    public String categoryName;

    @NameInMap("groupIds")
    public java.util.List<String> groupIds;

    public static CreateMessageCategoryRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateMessageCategoryRequest self = new CreateMessageCategoryRequest();
        return TeaModel.build(map, self);
    }

    public CreateMessageCategoryRequest setCategoryName(String categoryName) {
        this.categoryName = categoryName;
        return this;
    }
    public String getCategoryName() {
        return this.categoryName;
    }

    public CreateMessageCategoryRequest setGroupIds(java.util.List<String> groupIds) {
        this.groupIds = groupIds;
        return this;
    }
    public java.util.List<String> getGroupIds() {
        return this.groupIds;
    }

}
