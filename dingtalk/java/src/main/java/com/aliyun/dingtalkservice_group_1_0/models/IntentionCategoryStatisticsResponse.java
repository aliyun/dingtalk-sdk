// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class IntentionCategoryStatisticsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public IntentionCategoryStatisticsResponseBody body;

    public static IntentionCategoryStatisticsResponse build(java.util.Map<String, ?> map) throws Exception {
        IntentionCategoryStatisticsResponse self = new IntentionCategoryStatisticsResponse();
        return TeaModel.build(map, self);
    }

    public IntentionCategoryStatisticsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IntentionCategoryStatisticsResponse setBody(IntentionCategoryStatisticsResponseBody body) {
        this.body = body;
        return this;
    }
    public IntentionCategoryStatisticsResponseBody getBody() {
        return this.body;
    }

}
