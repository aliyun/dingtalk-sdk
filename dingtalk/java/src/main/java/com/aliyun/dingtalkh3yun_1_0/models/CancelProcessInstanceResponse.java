// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CancelProcessInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CancelProcessInstanceResponseBody body;

    public static CancelProcessInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        CancelProcessInstanceResponse self = new CancelProcessInstanceResponse();
        return TeaModel.build(map, self);
    }

    public CancelProcessInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CancelProcessInstanceResponse setBody(CancelProcessInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public CancelProcessInstanceResponseBody getBody() {
        return this.body;
    }

}
