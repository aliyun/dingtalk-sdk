// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateMessageCategoryResponseBody extends TeaModel {
    @NameInMap("id")
    public Long id;

    public static CreateMessageCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateMessageCategoryResponseBody self = new CreateMessageCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateMessageCategoryResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

}
