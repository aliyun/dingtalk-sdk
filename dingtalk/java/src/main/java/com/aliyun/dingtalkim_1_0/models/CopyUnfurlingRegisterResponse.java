// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CopyUnfurlingRegisterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CopyUnfurlingRegisterResponseBody body;

    public static CopyUnfurlingRegisterResponse build(java.util.Map<String, ?> map) throws Exception {
        CopyUnfurlingRegisterResponse self = new CopyUnfurlingRegisterResponse();
        return TeaModel.build(map, self);
    }

    public CopyUnfurlingRegisterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CopyUnfurlingRegisterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CopyUnfurlingRegisterResponse setBody(CopyUnfurlingRegisterResponseBody body) {
        this.body = body;
        return this;
    }
    public CopyUnfurlingRegisterResponseBody getBody() {
        return this.body;
    }

}
