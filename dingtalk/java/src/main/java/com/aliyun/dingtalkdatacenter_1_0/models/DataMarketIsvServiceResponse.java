// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class DataMarketIsvServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DataMarketIsvServiceResponseBody body;

    public static DataMarketIsvServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        DataMarketIsvServiceResponse self = new DataMarketIsvServiceResponse();
        return TeaModel.build(map, self);
    }

    public DataMarketIsvServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DataMarketIsvServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DataMarketIsvServiceResponse setBody(DataMarketIsvServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public DataMarketIsvServiceResponseBody getBody() {
        return this.body;
    }

}
