// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class BatchInsertSearchItemResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static BatchInsertSearchItemResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchInsertSearchItemResponse self = new BatchInsertSearchItemResponse();
        return TeaModel.build(map, self);
    }

    public BatchInsertSearchItemResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
