// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class OperateChartConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OperateChartConfigResponseBody body;

    public static OperateChartConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        OperateChartConfigResponse self = new OperateChartConfigResponse();
        return TeaModel.build(map, self);
    }

    public OperateChartConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OperateChartConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OperateChartConfigResponse setBody(OperateChartConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public OperateChartConfigResponseBody getBody() {
        return this.body;
    }

}
