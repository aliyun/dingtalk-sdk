// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchAddPermissionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchAddPermissionResponseBody body;

    public static BatchAddPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchAddPermissionResponse self = new BatchAddPermissionResponse();
        return TeaModel.build(map, self);
    }

    public BatchAddPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchAddPermissionResponse setBody(BatchAddPermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchAddPermissionResponseBody getBody() {
        return this.body;
    }

}
