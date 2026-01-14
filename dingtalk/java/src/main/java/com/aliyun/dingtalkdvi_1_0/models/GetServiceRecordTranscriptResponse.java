// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceRecordTranscriptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetServiceRecordTranscriptResponseBody body;

    public static GetServiceRecordTranscriptResponse build(java.util.Map<String, ?> map) throws Exception {
        GetServiceRecordTranscriptResponse self = new GetServiceRecordTranscriptResponse();
        return TeaModel.build(map, self);
    }

    public GetServiceRecordTranscriptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetServiceRecordTranscriptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetServiceRecordTranscriptResponse setBody(GetServiceRecordTranscriptResponseBody body) {
        this.body = body;
        return this;
    }
    public GetServiceRecordTranscriptResponseBody getBody() {
        return this.body;
    }

}
