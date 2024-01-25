// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class UpdateCardWithDelegateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static UpdateCardWithDelegateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCardWithDelegateResponseBody self = new UpdateCardWithDelegateResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCardWithDelegateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public UpdateCardWithDelegateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
