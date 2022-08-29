// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveProcessResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SaveProcessResponseBody body;

    public static SaveProcessResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveProcessResponse self = new SaveProcessResponse();
        return TeaModel.build(map, self);
    }

    public SaveProcessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveProcessResponse setBody(SaveProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveProcessResponseBody getBody() {
        return this.body;
    }

}
