// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DescribeRelationMetaResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DescribeRelationMetaResponseBody body;

    public static DescribeRelationMetaResponse build(java.util.Map<String, ?> map) throws Exception {
        DescribeRelationMetaResponse self = new DescribeRelationMetaResponse();
        return TeaModel.build(map, self);
    }

    public DescribeRelationMetaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DescribeRelationMetaResponse setBody(DescribeRelationMetaResponseBody body) {
        this.body = body;
        return this;
    }
    public DescribeRelationMetaResponseBody getBody() {
        return this.body;
    }

}
