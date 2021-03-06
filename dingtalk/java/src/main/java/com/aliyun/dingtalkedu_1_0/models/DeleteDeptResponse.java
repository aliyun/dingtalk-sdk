// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteDeptResponseBody body;

    public static DeleteDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteDeptResponse self = new DeleteDeptResponse();
        return TeaModel.build(map, self);
    }

    public DeleteDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteDeptResponse setBody(DeleteDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteDeptResponseBody getBody() {
        return this.body;
    }

}
