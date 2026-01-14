// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceChatSummaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetServiceChatSummaryResponseBody body;

    public static GetServiceChatSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetServiceChatSummaryResponse self = new GetServiceChatSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetServiceChatSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetServiceChatSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetServiceChatSummaryResponse setBody(GetServiceChatSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetServiceChatSummaryResponseBody getBody() {
        return this.body;
    }

}
