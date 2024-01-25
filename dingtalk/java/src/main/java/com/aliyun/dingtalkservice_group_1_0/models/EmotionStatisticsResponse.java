// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class EmotionStatisticsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EmotionStatisticsResponseBody body;

    public static EmotionStatisticsResponse build(java.util.Map<String, ?> map) throws Exception {
        EmotionStatisticsResponse self = new EmotionStatisticsResponse();
        return TeaModel.build(map, self);
    }

    public EmotionStatisticsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EmotionStatisticsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EmotionStatisticsResponse setBody(EmotionStatisticsResponseBody body) {
        this.body = body;
        return this;
    }
    public EmotionStatisticsResponseBody getBody() {
        return this.body;
    }

}
