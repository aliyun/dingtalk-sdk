// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateCategoryAndBindingGroupsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("id")
    public Long id;

    public static CreateCategoryAndBindingGroupsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCategoryAndBindingGroupsResponseBody self = new CreateCategoryAndBindingGroupsResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCategoryAndBindingGroupsResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

}
