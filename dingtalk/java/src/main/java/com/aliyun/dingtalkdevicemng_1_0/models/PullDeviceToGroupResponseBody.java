// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class PullDeviceToGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static PullDeviceToGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PullDeviceToGroupResponseBody self = new PullDeviceToGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public PullDeviceToGroupResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public PullDeviceToGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
