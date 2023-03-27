// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetJobPostResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetJobPostResponseBody body;

    public static GetJobPostResponse build(java.util.Map<String, ?> map) throws Exception {
        GetJobPostResponse self = new GetJobPostResponse();
        return TeaModel.build(map, self);
    }

    public GetJobPostResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetJobPostResponse setBody(GetJobPostResponseBody body) {
        this.body = body;
        return this;
    }
    public GetJobPostResponseBody getBody() {
        return this.body;
    }

}
