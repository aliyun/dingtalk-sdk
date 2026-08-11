// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AISaleEntityListResponseBody body;

    public static AISaleEntityListResponse build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityListResponse self = new AISaleEntityListResponse();
        return TeaModel.build(map, self);
    }

    public AISaleEntityListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AISaleEntityListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AISaleEntityListResponse setBody(AISaleEntityListResponseBody body) {
        this.body = body;
        return this;
    }
    public AISaleEntityListResponseBody getBody() {
        return this.body;
    }

}
