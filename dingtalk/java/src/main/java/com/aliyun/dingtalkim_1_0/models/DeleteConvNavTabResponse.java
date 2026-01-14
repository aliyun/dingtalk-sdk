// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DeleteConvNavTabResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteConvNavTabResponseBody body;

    public static DeleteConvNavTabResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteConvNavTabResponse self = new DeleteConvNavTabResponse();
        return TeaModel.build(map, self);
    }

    public DeleteConvNavTabResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteConvNavTabResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteConvNavTabResponse setBody(DeleteConvNavTabResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteConvNavTabResponseBody getBody() {
        return this.body;
    }

}
