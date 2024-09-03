// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateHrmVersionRollBackStatusResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static UpdateHrmVersionRollBackStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateHrmVersionRollBackStatusResponseBody self = new UpdateHrmVersionRollBackStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateHrmVersionRollBackStatusResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public UpdateHrmVersionRollBackStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public UpdateHrmVersionRollBackStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
