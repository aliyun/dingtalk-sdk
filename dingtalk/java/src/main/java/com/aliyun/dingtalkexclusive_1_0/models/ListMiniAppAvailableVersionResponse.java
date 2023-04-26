// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListMiniAppAvailableVersionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListMiniAppAvailableVersionResponseBody body;

    public static ListMiniAppAvailableVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        ListMiniAppAvailableVersionResponse self = new ListMiniAppAvailableVersionResponse();
        return TeaModel.build(map, self);
    }

    public ListMiniAppAvailableVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListMiniAppAvailableVersionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListMiniAppAvailableVersionResponse setBody(ListMiniAppAvailableVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public ListMiniAppAvailableVersionResponseBody getBody() {
        return this.body;
    }

}
