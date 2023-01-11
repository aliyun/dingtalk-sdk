// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncBusinessSignInfoResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static SyncBusinessSignInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncBusinessSignInfoResponseBody self = new SyncBusinessSignInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncBusinessSignInfoResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SyncBusinessSignInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
