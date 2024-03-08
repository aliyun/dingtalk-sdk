// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PagesExportInstancesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PagesExportInstancesResponseBody body;

    public static PagesExportInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        PagesExportInstancesResponse self = new PagesExportInstancesResponse();
        return TeaModel.build(map, self);
    }

    public PagesExportInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PagesExportInstancesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PagesExportInstancesResponse setBody(PagesExportInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public PagesExportInstancesResponseBody getBody() {
        return this.body;
    }

}
