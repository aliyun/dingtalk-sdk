// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class SendCardResponseBody extends TeaModel {
    /**
     * <p>result</p>
     */
    @NameInMap("result")
    public String result;

    /**
     * <p>success</p>
     */
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
