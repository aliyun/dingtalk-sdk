// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class AddApproveDentryAuthResponseBody extends TeaModel {
    // 请求ID。
    @NameInMap("requestId")
    public String requestId;

    // 返回结果。
    @NameInMap("result")
    public Boolean result;

    // 接口调用是否成功。
    @NameInMap("success")
    public Boolean success;

    public static AddApproveDentryAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddApproveDentryAuthResponseBody self = new AddApproveDentryAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public AddApproveDentryAuthResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AddApproveDentryAuthResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AddApproveDentryAuthResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
