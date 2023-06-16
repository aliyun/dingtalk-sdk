// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class GetTaskFromShanhuiDocResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetTaskFromShanhuiDocResponseBody body;

    public static GetTaskFromShanhuiDocResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTaskFromShanhuiDocResponse self = new GetTaskFromShanhuiDocResponse();
        return TeaModel.build(map, self);
    }

    public GetTaskFromShanhuiDocResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTaskFromShanhuiDocResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTaskFromShanhuiDocResponse setBody(GetTaskFromShanhuiDocResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTaskFromShanhuiDocResponseBody getBody() {
        return this.body;
    }

}
