// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class JoinGroupSetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public JoinGroupSetResponseBody body;

    public static JoinGroupSetResponse build(java.util.Map<String, ?> map) throws Exception {
        JoinGroupSetResponse self = new JoinGroupSetResponse();
        return TeaModel.build(map, self);
    }

    public JoinGroupSetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public JoinGroupSetResponse setBody(JoinGroupSetResponseBody body) {
        this.body = body;
        return this;
    }
    public JoinGroupSetResponseBody getBody() {
        return this.body;
    }

}
