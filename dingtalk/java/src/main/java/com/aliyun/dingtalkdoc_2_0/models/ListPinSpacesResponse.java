// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListPinSpacesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListPinSpacesResponseBody body;

    public static ListPinSpacesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListPinSpacesResponse self = new ListPinSpacesResponse();
        return TeaModel.build(map, self);
    }

    public ListPinSpacesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListPinSpacesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListPinSpacesResponse setBody(ListPinSpacesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListPinSpacesResponseBody getBody() {
        return this.body;
    }

}
