// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RecallMessagesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RecallMessagesResponseBody body;

    public static RecallMessagesResponse build(java.util.Map<String, ?> map) throws Exception {
        RecallMessagesResponse self = new RecallMessagesResponse();
        return TeaModel.build(map, self);
    }

    public RecallMessagesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RecallMessagesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RecallMessagesResponse setBody(RecallMessagesResponseBody body) {
        this.body = body;
        return this;
    }
    public RecallMessagesResponseBody getBody() {
        return this.body;
    }

}
