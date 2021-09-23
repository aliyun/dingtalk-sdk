// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RegisterDeviceResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static RegisterDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RegisterDeviceResponseBody self = new RegisterDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public RegisterDeviceResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
