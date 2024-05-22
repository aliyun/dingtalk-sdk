// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenSearchGroupListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenSearchGroupListResponseBody body;

    public static OpenSearchGroupListResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenSearchGroupListResponse self = new OpenSearchGroupListResponse();
        return TeaModel.build(map, self);
    }

    public OpenSearchGroupListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenSearchGroupListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenSearchGroupListResponse setBody(OpenSearchGroupListResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenSearchGroupListResponseBody getBody() {
        return this.body;
    }

}
