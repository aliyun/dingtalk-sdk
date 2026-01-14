// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceQualityInspectionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetServiceQualityInspectionResponseBody body;

    public static GetServiceQualityInspectionResponse build(java.util.Map<String, ?> map) throws Exception {
        GetServiceQualityInspectionResponse self = new GetServiceQualityInspectionResponse();
        return TeaModel.build(map, self);
    }

    public GetServiceQualityInspectionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetServiceQualityInspectionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetServiceQualityInspectionResponse setBody(GetServiceQualityInspectionResponseBody body) {
        this.body = body;
        return this;
    }
    public GetServiceQualityInspectionResponseBody getBody() {
        return this.body;
    }

}
