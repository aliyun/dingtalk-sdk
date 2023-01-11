// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class CloseTopBoxInteractiveOTOMessageResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    public static CloseTopBoxInteractiveOTOMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CloseTopBoxInteractiveOTOMessageResponseBody self = new CloseTopBoxInteractiveOTOMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public CloseTopBoxInteractiveOTOMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CloseTopBoxInteractiveOTOMessageResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
