// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ClearRecycleFilesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static ClearRecycleFilesResponse build(java.util.Map<String, ?> map) throws Exception {
        ClearRecycleFilesResponse self = new ClearRecycleFilesResponse();
        return TeaModel.build(map, self);
    }

    public ClearRecycleFilesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
