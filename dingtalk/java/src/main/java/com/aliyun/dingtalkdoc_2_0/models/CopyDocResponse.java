// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyDocResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CopyDocResponseBody body;

    public static CopyDocResponse build(java.util.Map<String, ?> map) throws Exception {
        CopyDocResponse self = new CopyDocResponse();
        return TeaModel.build(map, self);
    }

    public CopyDocResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CopyDocResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CopyDocResponse setBody(CopyDocResponseBody body) {
        this.body = body;
        return this;
    }
    public CopyDocResponseBody getBody() {
        return this.body;
    }

}
