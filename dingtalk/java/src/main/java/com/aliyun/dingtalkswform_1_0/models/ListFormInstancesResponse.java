// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class ListFormInstancesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListFormInstancesResponseBody body;

    public static ListFormInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListFormInstancesResponse self = new ListFormInstancesResponse();
        return TeaModel.build(map, self);
    }

    public ListFormInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListFormInstancesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListFormInstancesResponse setBody(ListFormInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListFormInstancesResponseBody getBody() {
        return this.body;
    }

}
