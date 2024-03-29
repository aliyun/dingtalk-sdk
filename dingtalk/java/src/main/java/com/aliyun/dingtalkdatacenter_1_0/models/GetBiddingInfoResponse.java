// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetBiddingInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetBiddingInfoResponseBody body;

    public static GetBiddingInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBiddingInfoResponse self = new GetBiddingInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetBiddingInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetBiddingInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetBiddingInfoResponse setBody(GetBiddingInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetBiddingInfoResponseBody getBody() {
        return this.body;
    }

}
