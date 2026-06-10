// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCorrectStyleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCorrectStyleResponseBody body;

    public static GetCorrectStyleResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCorrectStyleResponse self = new GetCorrectStyleResponse();
        return TeaModel.build(map, self);
    }

    public GetCorrectStyleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCorrectStyleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCorrectStyleResponse setBody(GetCorrectStyleResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCorrectStyleResponseBody getBody() {
        return this.body;
    }

}
