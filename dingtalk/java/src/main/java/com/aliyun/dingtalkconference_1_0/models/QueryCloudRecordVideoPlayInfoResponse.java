// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordVideoPlayInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCloudRecordVideoPlayInfoResponseBody body;

    public static QueryCloudRecordVideoPlayInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCloudRecordVideoPlayInfoResponse self = new QueryCloudRecordVideoPlayInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryCloudRecordVideoPlayInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCloudRecordVideoPlayInfoResponse setBody(QueryCloudRecordVideoPlayInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCloudRecordVideoPlayInfoResponseBody getBody() {
        return this.body;
    }

}
