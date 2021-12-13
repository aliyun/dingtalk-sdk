// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class DeleteProcessesInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public DeleteProcessesInstanceResponse setBody(DeleteProcessesInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteProcessesInstanceResponseBody getBody() {
        return this.body;
    }

}
