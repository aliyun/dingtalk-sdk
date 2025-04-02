// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RecallPersonalMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RecallPersonalMessageResponseBody body;

    public static RecallPersonalMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        RecallPersonalMessageResponse self = new RecallPersonalMessageResponse();
        return TeaModel.build(map, self);
    }

    public RecallPersonalMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RecallPersonalMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RecallPersonalMessageResponse setBody(RecallPersonalMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public RecallPersonalMessageResponseBody getBody() {
        return this.body;
    }

}
