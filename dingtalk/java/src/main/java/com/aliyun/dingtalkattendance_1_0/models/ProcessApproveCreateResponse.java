// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessApproveCreateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public ProcessApproveCreateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ProcessApproveCreateResponse setBody(ProcessApproveCreateResponseBody body) {
        this.body = body;
        return this;
    }
    public ProcessApproveCreateResponseBody getBody() {
        return this.body;
    }

}
