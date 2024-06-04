// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateConversationTypeResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static UpdateConversationTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateConversationTypeResponseBody self = new UpdateConversationTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateConversationTypeResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public UpdateConversationTypeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
