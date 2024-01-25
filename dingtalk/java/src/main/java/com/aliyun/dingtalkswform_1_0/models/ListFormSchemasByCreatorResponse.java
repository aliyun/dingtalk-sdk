// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class ListFormSchemasByCreatorResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListFormSchemasByCreatorResponseBody body;

    public static ListFormSchemasByCreatorResponse build(java.util.Map<String, ?> map) throws Exception {
        ListFormSchemasByCreatorResponse self = new ListFormSchemasByCreatorResponse();
        return TeaModel.build(map, self);
    }

    public ListFormSchemasByCreatorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListFormSchemasByCreatorResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListFormSchemasByCreatorResponse setBody(ListFormSchemasByCreatorResponseBody body) {
        this.body = body;
        return this;
    }
    public ListFormSchemasByCreatorResponseBody getBody() {
        return this.body;
    }

}
