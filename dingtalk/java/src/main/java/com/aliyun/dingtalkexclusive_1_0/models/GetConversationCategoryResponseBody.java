// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConversationCategoryResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ConversationCategoryModel> result;

    @NameInMap("success")
    public Boolean success;

    public static GetConversationCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConversationCategoryResponseBody self = new GetConversationCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConversationCategoryResponseBody setResult(java.util.List<ConversationCategoryModel> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ConversationCategoryModel> getResult() {
        return this.result;
    }

    public GetConversationCategoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
