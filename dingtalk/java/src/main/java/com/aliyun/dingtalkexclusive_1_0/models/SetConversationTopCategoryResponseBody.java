// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetConversationTopCategoryResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SetConversationTopCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetConversationTopCategoryResponseBody self = new SetConversationTopCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public SetConversationTopCategoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
