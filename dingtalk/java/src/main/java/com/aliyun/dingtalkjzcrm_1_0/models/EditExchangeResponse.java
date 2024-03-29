// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditExchangeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EditExchangeResponseBody body;

    public static EditExchangeResponse build(java.util.Map<String, ?> map) throws Exception {
        EditExchangeResponse self = new EditExchangeResponse();
        return TeaModel.build(map, self);
    }

    public EditExchangeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditExchangeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditExchangeResponse setBody(EditExchangeResponseBody body) {
        this.body = body;
        return this;
    }
    public EditExchangeResponseBody getBody() {
        return this.body;
    }

}
