// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class DataMarketServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DataMarketServiceResponseBody body;

    public static DataMarketServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        DataMarketServiceResponse self = new DataMarketServiceResponse();
        return TeaModel.build(map, self);
    }

    public DataMarketServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DataMarketServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DataMarketServiceResponse setBody(DataMarketServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public DataMarketServiceResponseBody getBody() {
        return this.body;
    }

}
