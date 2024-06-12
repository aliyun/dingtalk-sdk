// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DescribeMetaModelResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DescribeMetaModelResponseBody body;

    public static DescribeMetaModelResponse build(java.util.Map<String, ?> map) throws Exception {
        DescribeMetaModelResponse self = new DescribeMetaModelResponse();
        return TeaModel.build(map, self);
    }

    public DescribeMetaModelResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DescribeMetaModelResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DescribeMetaModelResponse setBody(DescribeMetaModelResponseBody body) {
        this.body = body;
        return this;
    }
    public DescribeMetaModelResponseBody getBody() {
        return this.body;
    }

}
