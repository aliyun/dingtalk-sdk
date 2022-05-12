// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class SendCardResponseBody extends TeaModel {
    // result
    @NameInMap("result")
    public String result;

    // success
    @NameInMap("success")
    public Boolean success;

    public static SendCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendCardResponseBody self = new SendCardResponseBody();
        return TeaModel.build(map, self);
    }

    public SendCardResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public SendCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
