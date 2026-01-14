// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class SendCentralControlResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SendCentralControlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendCentralControlResponseBody self = new SendCentralControlResponseBody();
        return TeaModel.build(map, self);
    }

    public SendCentralControlResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
