// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StopCloudRecordResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public StopCloudRecordResponseBody body;

    public static StopCloudRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        StopCloudRecordResponse self = new StopCloudRecordResponse();
        return TeaModel.build(map, self);
    }

    public StopCloudRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public StopCloudRecordResponse setBody(StopCloudRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public StopCloudRecordResponseBody getBody() {
        return this.body;
    }

}
