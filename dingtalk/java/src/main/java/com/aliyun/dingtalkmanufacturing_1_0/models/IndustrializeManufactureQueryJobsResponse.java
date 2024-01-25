// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureQueryJobsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IndustrializeManufactureQueryJobsResponseBody body;

    public static IndustrializeManufactureQueryJobsResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustrializeManufactureQueryJobsResponse self = new IndustrializeManufactureQueryJobsResponse();
        return TeaModel.build(map, self);
    }

    public IndustrializeManufactureQueryJobsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustrializeManufactureQueryJobsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustrializeManufactureQueryJobsResponse setBody(IndustrializeManufactureQueryJobsResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustrializeManufactureQueryJobsResponseBody getBody() {
        return this.body;
    }

}
