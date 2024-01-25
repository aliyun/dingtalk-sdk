// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmMailSendResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrmMailSendResponseBody body;

    public static HrmMailSendResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmMailSendResponse self = new HrmMailSendResponse();
        return TeaModel.build(map, self);
    }

    public HrmMailSendResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmMailSendResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrmMailSendResponse setBody(HrmMailSendResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmMailSendResponseBody getBody() {
        return this.body;
    }

}
