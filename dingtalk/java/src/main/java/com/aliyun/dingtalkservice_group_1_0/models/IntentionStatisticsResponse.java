// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class IntentionStatisticsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public IntentionStatisticsResponseBody body;

    public static IntentionStatisticsResponse build(java.util.Map<String, ?> map) throws Exception {
        IntentionStatisticsResponse self = new IntentionStatisticsResponse();
        return TeaModel.build(map, self);
    }

    public IntentionStatisticsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IntentionStatisticsResponse setBody(IntentionStatisticsResponseBody body) {
        this.body = body;
        return this;
    }
    public IntentionStatisticsResponseBody getBody() {
        return this.body;
    }

}
