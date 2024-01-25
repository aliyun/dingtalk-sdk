// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AnheiTestBResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AnheiTestBResponseBody body;

    public static AnheiTestBResponse build(java.util.Map<String, ?> map) throws Exception {
        AnheiTestBResponse self = new AnheiTestBResponse();
        return TeaModel.build(map, self);
    }

    public AnheiTestBResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AnheiTestBResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AnheiTestBResponse setBody(AnheiTestBResponseBody body) {
        this.body = body;
        return this;
    }
    public AnheiTestBResponseBody getBody() {
        return this.body;
    }

}
