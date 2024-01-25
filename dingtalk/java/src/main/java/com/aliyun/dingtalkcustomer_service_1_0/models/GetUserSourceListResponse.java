// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class GetUserSourceListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserSourceListResponseBody body;

    public static GetUserSourceListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserSourceListResponse self = new GetUserSourceListResponse();
        return TeaModel.build(map, self);
    }

    public GetUserSourceListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserSourceListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserSourceListResponse setBody(GetUserSourceListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserSourceListResponseBody getBody() {
        return this.body;
    }

}
