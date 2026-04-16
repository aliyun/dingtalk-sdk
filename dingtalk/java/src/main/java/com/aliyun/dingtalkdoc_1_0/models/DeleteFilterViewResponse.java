// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteFilterViewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteFilterViewResponseBody body;

    public static DeleteFilterViewResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteFilterViewResponse self = new DeleteFilterViewResponse();
        return TeaModel.build(map, self);
    }

    public DeleteFilterViewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteFilterViewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteFilterViewResponse setBody(DeleteFilterViewResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteFilterViewResponseBody getBody() {
        return this.body;
    }

}
