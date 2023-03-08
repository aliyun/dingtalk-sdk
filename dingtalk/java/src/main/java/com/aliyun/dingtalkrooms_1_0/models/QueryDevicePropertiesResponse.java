// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDevicePropertiesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryDevicePropertiesResponseBody body;

    public static QueryDevicePropertiesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDevicePropertiesResponse self = new QueryDevicePropertiesResponse();
        return TeaModel.build(map, self);
    }

    public QueryDevicePropertiesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDevicePropertiesResponse setBody(QueryDevicePropertiesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDevicePropertiesResponseBody getBody() {
        return this.body;
    }

}
