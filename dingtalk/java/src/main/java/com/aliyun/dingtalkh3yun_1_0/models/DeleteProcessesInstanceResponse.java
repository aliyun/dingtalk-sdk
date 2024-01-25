// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class DeleteProcessesInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteProcessesInstanceResponseBody body;

    public static DeleteProcessesInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteProcessesInstanceResponse self = new DeleteProcessesInstanceResponse();
        return TeaModel.build(map, self);
    }

    public DeleteProcessesInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteProcessesInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteProcessesInstanceResponse setBody(DeleteProcessesInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteProcessesInstanceResponseBody getBody() {
        return this.body;
    }

}
