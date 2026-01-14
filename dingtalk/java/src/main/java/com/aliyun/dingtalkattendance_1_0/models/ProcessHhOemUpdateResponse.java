// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessHhOemUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ProcessHhOemUpdateResponseBody body;

    public static ProcessHhOemUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        ProcessHhOemUpdateResponse self = new ProcessHhOemUpdateResponse();
        return TeaModel.build(map, self);
    }

    public ProcessHhOemUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ProcessHhOemUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ProcessHhOemUpdateResponse setBody(ProcessHhOemUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public ProcessHhOemUpdateResponseBody getBody() {
        return this.body;
    }

}
