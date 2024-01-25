// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class AppendSpaceWithDelegateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static AppendSpaceWithDelegateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AppendSpaceWithDelegateResponseBody self = new AppendSpaceWithDelegateResponseBody();
        return TeaModel.build(map, self);
    }

    public AppendSpaceWithDelegateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AppendSpaceWithDelegateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
