// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryFamilySchoolMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchQueryFamilySchoolMessageResponseBody body;

    public static BatchQueryFamilySchoolMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryFamilySchoolMessageResponse self = new BatchQueryFamilySchoolMessageResponse();
        return TeaModel.build(map, self);
    }

    public BatchQueryFamilySchoolMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQueryFamilySchoolMessageResponse setBody(BatchQueryFamilySchoolMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQueryFamilySchoolMessageResponseBody getBody() {
        return this.body;
    }

}
