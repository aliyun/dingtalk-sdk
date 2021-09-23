// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class BatchRegisterDeviceResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("result")
    public String result;

    public static BatchRegisterDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchRegisterDeviceResponseBody self = new BatchRegisterDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchRegisterDeviceResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
