// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class LoginCodeGenResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static LoginCodeGenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LoginCodeGenResponseBody self = new LoginCodeGenResponseBody();
        return TeaModel.build(map, self);
    }

    public LoginCodeGenResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
