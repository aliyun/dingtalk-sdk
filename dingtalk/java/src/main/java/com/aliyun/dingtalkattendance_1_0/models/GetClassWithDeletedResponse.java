// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetClassWithDeletedResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetClassWithDeletedResponseBody body;

    public static GetClassWithDeletedResponse build(java.util.Map<String, ?> map) throws Exception {
        GetClassWithDeletedResponse self = new GetClassWithDeletedResponse();
        return TeaModel.build(map, self);
    }

    public GetClassWithDeletedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetClassWithDeletedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetClassWithDeletedResponse setBody(GetClassWithDeletedResponseBody body) {
        this.body = body;
        return this;
    }
    public GetClassWithDeletedResponseBody getBody() {
        return this.body;
    }

}
