// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RemoveDeviceFromGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static RemoveDeviceFromGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveDeviceFromGroupResponseBody self = new RemoveDeviceFromGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveDeviceFromGroupResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public RemoveDeviceFromGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
