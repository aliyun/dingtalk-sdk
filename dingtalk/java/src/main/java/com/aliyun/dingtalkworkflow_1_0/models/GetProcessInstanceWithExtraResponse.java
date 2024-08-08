// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessInstanceWithExtraResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetProcessInstanceWithExtraResponseBody body;

    public static GetProcessInstanceWithExtraResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProcessInstanceWithExtraResponse self = new GetProcessInstanceWithExtraResponse();
        return TeaModel.build(map, self);
    }

    public GetProcessInstanceWithExtraResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProcessInstanceWithExtraResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetProcessInstanceWithExtraResponse setBody(GetProcessInstanceWithExtraResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProcessInstanceWithExtraResponseBody getBody() {
        return this.body;
    }

}
