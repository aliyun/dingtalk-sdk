// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchRemovalByFormInstanceIdListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static BatchRemovalByFormInstanceIdListResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchRemovalByFormInstanceIdListResponse self = new BatchRemovalByFormInstanceIdListResponse();
        return TeaModel.build(map, self);
    }

    public BatchRemovalByFormInstanceIdListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
