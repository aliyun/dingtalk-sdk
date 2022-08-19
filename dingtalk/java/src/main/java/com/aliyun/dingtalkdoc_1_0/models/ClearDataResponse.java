// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ClearDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ClearDataResponseBody body;

    public static ClearDataResponse build(java.util.Map<String, ?> map) throws Exception {
        ClearDataResponse self = new ClearDataResponse();
        return TeaModel.build(map, self);
    }

    public ClearDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ClearDataResponse setBody(ClearDataResponseBody body) {
        this.body = body;
        return this;
    }
    public ClearDataResponseBody getBody() {
        return this.body;
    }

}
