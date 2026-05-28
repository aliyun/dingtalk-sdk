// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryExportTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryExportTaskResponseBody body;

    public static QueryExportTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryExportTaskResponse self = new QueryExportTaskResponse();
        return TeaModel.build(map, self);
    }

    public QueryExportTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryExportTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryExportTaskResponse setBody(QueryExportTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryExportTaskResponseBody getBody() {
        return this.body;
    }

}
