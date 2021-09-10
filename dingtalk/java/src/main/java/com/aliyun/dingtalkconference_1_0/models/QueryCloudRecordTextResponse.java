// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordTextResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCloudRecordTextResponseBody body;

    public static QueryCloudRecordTextResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCloudRecordTextResponse self = new QueryCloudRecordTextResponse();
        return TeaModel.build(map, self);
    }

    public QueryCloudRecordTextResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCloudRecordTextResponse setBody(QueryCloudRecordTextResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCloudRecordTextResponseBody getBody() {
        return this.body;
    }

}
