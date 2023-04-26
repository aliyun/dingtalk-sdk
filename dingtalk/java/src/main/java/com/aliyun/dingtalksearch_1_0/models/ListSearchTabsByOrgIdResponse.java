// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class ListSearchTabsByOrgIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListSearchTabsByOrgIdResponseBody body;

    public static ListSearchTabsByOrgIdResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSearchTabsByOrgIdResponse self = new ListSearchTabsByOrgIdResponse();
        return TeaModel.build(map, self);
    }

    public ListSearchTabsByOrgIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSearchTabsByOrgIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSearchTabsByOrgIdResponse setBody(ListSearchTabsByOrgIdResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSearchTabsByOrgIdResponseBody getBody() {
        return this.body;
    }

}
