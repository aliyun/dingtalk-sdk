// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetLatestDingIndexResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetLatestDingIndexResponseBody body;

    public static GetLatestDingIndexResponse build(java.util.Map<String, ?> map) throws Exception {
        GetLatestDingIndexResponse self = new GetLatestDingIndexResponse();
        return TeaModel.build(map, self);
    }

    public GetLatestDingIndexResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetLatestDingIndexResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetLatestDingIndexResponse setBody(GetLatestDingIndexResponseBody body) {
        this.body = body;
        return this;
    }
    public GetLatestDingIndexResponseBody getBody() {
        return this.body;
    }

}
