// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetCardInUserHolderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetCardInUserHolderResponseBody body;

    public static GetCardInUserHolderResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCardInUserHolderResponse self = new GetCardInUserHolderResponse();
        return TeaModel.build(map, self);
    }

    public GetCardInUserHolderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCardInUserHolderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCardInUserHolderResponse setBody(GetCardInUserHolderResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCardInUserHolderResponseBody getBody() {
        return this.body;
    }

}
