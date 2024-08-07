// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class OpenOemMicroAppResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static OpenOemMicroAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenOemMicroAppResponseBody self = new OpenOemMicroAppResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenOemMicroAppResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public OpenOemMicroAppResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
