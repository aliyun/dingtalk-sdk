// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendTopBoxInteractiveOTOMessageResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    public static SendTopBoxInteractiveOTOMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendTopBoxInteractiveOTOMessageResponseBody self = new SendTopBoxInteractiveOTOMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendTopBoxInteractiveOTOMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SendTopBoxInteractiveOTOMessageResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
