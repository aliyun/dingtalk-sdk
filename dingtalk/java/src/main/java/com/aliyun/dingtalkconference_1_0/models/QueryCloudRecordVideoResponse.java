// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordVideoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCloudRecordVideoResponseBody body;

    public static QueryCloudRecordVideoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCloudRecordVideoResponse self = new QueryCloudRecordVideoResponse();
        return TeaModel.build(map, self);
    }

    public QueryCloudRecordVideoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCloudRecordVideoResponse setBody(QueryCloudRecordVideoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCloudRecordVideoResponseBody getBody() {
        return this.body;
    }

}
