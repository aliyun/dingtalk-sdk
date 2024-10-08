// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class SaveFormDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveFormDataResponseBody body;

    public static SaveFormDataResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveFormDataResponse self = new SaveFormDataResponse();
        return TeaModel.build(map, self);
    }

    public SaveFormDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveFormDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveFormDataResponse setBody(SaveFormDataResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveFormDataResponseBody getBody() {
        return this.body;
    }

}
