// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetConversationCategoryResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static SetConversationCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetConversationCategoryResponseBody self = new SetConversationCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public SetConversationCategoryResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public SetConversationCategoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
