// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceCustomTemplateListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryDeviceCustomTemplateListResponseBody body;

    public static QueryDeviceCustomTemplateListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceCustomTemplateListResponse self = new QueryDeviceCustomTemplateListResponse();
        return TeaModel.build(map, self);
    }

    public QueryDeviceCustomTemplateListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDeviceCustomTemplateListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDeviceCustomTemplateListResponse setBody(QueryDeviceCustomTemplateListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDeviceCustomTemplateListResponseBody getBody() {
        return this.body;
    }

}
