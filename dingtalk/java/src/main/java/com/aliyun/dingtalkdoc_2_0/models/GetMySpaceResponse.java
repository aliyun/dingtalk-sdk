// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetMySpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetMySpaceResponseBody body;

    public static GetMySpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMySpaceResponse self = new GetMySpaceResponse();
        return TeaModel.build(map, self);
    }

    public GetMySpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMySpaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMySpaceResponse setBody(GetMySpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMySpaceResponseBody getBody() {
        return this.body;
    }

}
