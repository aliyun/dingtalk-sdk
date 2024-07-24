// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OfflineUnfurlingRegisterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OfflineUnfurlingRegisterResponseBody body;

    public static OfflineUnfurlingRegisterResponse build(java.util.Map<String, ?> map) throws Exception {
        OfflineUnfurlingRegisterResponse self = new OfflineUnfurlingRegisterResponse();
        return TeaModel.build(map, self);
    }

    public OfflineUnfurlingRegisterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OfflineUnfurlingRegisterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OfflineUnfurlingRegisterResponse setBody(OfflineUnfurlingRegisterResponseBody body) {
        this.body = body;
        return this;
    }
    public OfflineUnfurlingRegisterResponseBody getBody() {
        return this.body;
    }

}
