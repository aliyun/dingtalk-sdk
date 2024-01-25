// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceCustomTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDeviceCustomTemplateResponseBody body;

    public static QueryDeviceCustomTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceCustomTemplateResponse self = new QueryDeviceCustomTemplateResponse();
        return TeaModel.build(map, self);
    }

    public QueryDeviceCustomTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDeviceCustomTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDeviceCustomTemplateResponse setBody(QueryDeviceCustomTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDeviceCustomTemplateResponseBody getBody() {
        return this.body;
    }

}
