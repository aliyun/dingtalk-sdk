// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ClearResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ClearResponseBody body;

    public static ClearResponse build(java.util.Map<String, ?> map) throws Exception {
        ClearResponse self = new ClearResponse();
        return TeaModel.build(map, self);
    }

    public ClearResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ClearResponse setBody(ClearResponseBody body) {
        this.body = body;
        return this;
    }
    public ClearResponseBody getBody() {
        return this.body;
    }

}
