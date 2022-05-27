// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConfBaseInfoByLogicalIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetConfBaseInfoByLogicalIdResponseBody body;

    public static GetConfBaseInfoByLogicalIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetConfBaseInfoByLogicalIdResponse self = new GetConfBaseInfoByLogicalIdResponse();
        return TeaModel.build(map, self);
    }

    public GetConfBaseInfoByLogicalIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetConfBaseInfoByLogicalIdResponse setBody(GetConfBaseInfoByLogicalIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetConfBaseInfoByLogicalIdResponseBody getBody() {
        return this.body;
    }

}
