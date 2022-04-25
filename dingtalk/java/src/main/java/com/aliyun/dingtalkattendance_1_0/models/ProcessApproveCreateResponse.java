// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessApproveCreateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ProcessApproveCreateResponseBody body;

    public static ProcessApproveCreateResponse build(java.util.Map<String, ?> map) throws Exception {
        ProcessApproveCreateResponse self = new ProcessApproveCreateResponse();
        return TeaModel.build(map, self);
    }

    public ProcessApproveCreateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ProcessApproveCreateResponse setBody(ProcessApproveCreateResponseBody body) {
        this.body = body;
        return this;
    }
    public ProcessApproveCreateResponseBody getBody() {
        return this.body;
    }

}
