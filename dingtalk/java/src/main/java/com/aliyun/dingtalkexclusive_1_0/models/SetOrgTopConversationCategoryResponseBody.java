// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetOrgTopConversationCategoryResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static SetOrgTopConversationCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetOrgTopConversationCategoryResponseBody self = new SetOrgTopConversationCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public SetOrgTopConversationCategoryResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public SetOrgTopConversationCategoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
