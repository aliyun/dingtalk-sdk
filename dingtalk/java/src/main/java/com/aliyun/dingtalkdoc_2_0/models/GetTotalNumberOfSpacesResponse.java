// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetTotalNumberOfSpacesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetTotalNumberOfSpacesResponseBody body;

    public static GetTotalNumberOfSpacesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTotalNumberOfSpacesResponse self = new GetTotalNumberOfSpacesResponse();
        return TeaModel.build(map, self);
    }

    public GetTotalNumberOfSpacesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTotalNumberOfSpacesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTotalNumberOfSpacesResponse setBody(GetTotalNumberOfSpacesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTotalNumberOfSpacesResponseBody getBody() {
        return this.body;
    }

}
