// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class DissolveGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static DissolveGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DissolveGroupResponseBody self = new DissolveGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public DissolveGroupResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public DissolveGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
