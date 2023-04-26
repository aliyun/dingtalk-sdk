// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DIgitalStoreMessagePushResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DIgitalStoreMessagePushResponseBody body;

    public static DIgitalStoreMessagePushResponse build(java.util.Map<String, ?> map) throws Exception {
        DIgitalStoreMessagePushResponse self = new DIgitalStoreMessagePushResponse();
        return TeaModel.build(map, self);
    }

    public DIgitalStoreMessagePushResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DIgitalStoreMessagePushResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DIgitalStoreMessagePushResponse setBody(DIgitalStoreMessagePushResponseBody body) {
        this.body = body;
        return this;
    }
    public DIgitalStoreMessagePushResponseBody getBody() {
        return this.body;
    }

}
