// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRangeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetRangeResponseBody body;

    public static GetRangeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRangeResponse self = new GetRangeResponse();
        return TeaModel.build(map, self);
    }

    public GetRangeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRangeResponse setBody(GetRangeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRangeResponseBody getBody() {
        return this.body;
    }

}
