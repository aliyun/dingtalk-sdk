// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SignOutResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SignOutResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SignOutResponseBody self = new SignOutResponseBody();
        return TeaModel.build(map, self);
    }

    public SignOutResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
