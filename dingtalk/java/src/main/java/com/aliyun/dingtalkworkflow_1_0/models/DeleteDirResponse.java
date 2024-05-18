// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class DeleteDirResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteDirResponseBody body;

    public static DeleteDirResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteDirResponse self = new DeleteDirResponse();
        return TeaModel.build(map, self);
    }

    public DeleteDirResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteDirResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteDirResponse setBody(DeleteDirResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteDirResponseBody getBody() {
        return this.body;
    }

}
