// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessApproveFinishResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ProcessApproveFinishResponseBody body;

    public static ProcessApproveFinishResponse build(java.util.Map<String, ?> map) throws Exception {
        ProcessApproveFinishResponse self = new ProcessApproveFinishResponse();
        return TeaModel.build(map, self);
    }

    public ProcessApproveFinishResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ProcessApproveFinishResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ProcessApproveFinishResponse setBody(ProcessApproveFinishResponseBody body) {
        this.body = body;
        return this;
    }
    public ProcessApproveFinishResponseBody getBody() {
        return this.body;
    }

}
