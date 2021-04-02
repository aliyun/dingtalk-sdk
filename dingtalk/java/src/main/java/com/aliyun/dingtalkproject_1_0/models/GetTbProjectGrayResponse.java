// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbProjectGrayResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetTbProjectGrayResponseBody body;

    public static GetTbProjectGrayResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTbProjectGrayResponse self = new GetTbProjectGrayResponse();
        return TeaModel.build(map, self);
    }

    public GetTbProjectGrayResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTbProjectGrayResponse setBody(GetTbProjectGrayResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTbProjectGrayResponseBody getBody() {
        return this.body;
    }

}
