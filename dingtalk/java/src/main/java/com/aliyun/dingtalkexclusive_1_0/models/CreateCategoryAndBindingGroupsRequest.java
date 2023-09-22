// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateCategoryAndBindingGroupsRequest extends TeaModel {
    @NameInMap("categoryName")
    public String categoryName;

    @NameInMap("groupIds")
    public java.util.List<Long> groupIds;

    public static CreateCategoryAndBindingGroupsRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCategoryAndBindingGroupsRequest self = new CreateCategoryAndBindingGroupsRequest();
        return TeaModel.build(map, self);
    }

    public CreateCategoryAndBindingGroupsRequest setCategoryName(String categoryName) {
        this.categoryName = categoryName;
        return this;
    }
    public String getCategoryName() {
        return this.categoryName;
    }

    public CreateCategoryAndBindingGroupsRequest setGroupIds(java.util.List<Long> groupIds) {
        this.groupIds = groupIds;
        return this;
    }
    public java.util.List<Long> getGroupIds() {
        return this.groupIds;
    }

}
