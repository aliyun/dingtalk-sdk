// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CancelCorpAuthResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CancelCorpAuthResponseBody body;

    public static CancelCorpAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        CancelCorpAuthResponse self = new CancelCorpAuthResponse();
        return TeaModel.build(map, self);
    }

    public CancelCorpAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CancelCorpAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CancelCorpAuthResponse setBody(CancelCorpAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public CancelCorpAuthResponseBody getBody() {
        return this.body;
    }

}
