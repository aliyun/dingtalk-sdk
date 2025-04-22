// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ReadPersonalMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ReadPersonalMessageResponseBody body;

    public static ReadPersonalMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        ReadPersonalMessageResponse self = new ReadPersonalMessageResponse();
        return TeaModel.build(map, self);
    }

    public ReadPersonalMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReadPersonalMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReadPersonalMessageResponse setBody(ReadPersonalMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public ReadPersonalMessageResponseBody getBody() {
        return this.body;
    }

}
