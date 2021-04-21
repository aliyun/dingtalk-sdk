// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class RecoverRecycleFilesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static RecoverRecycleFilesResponse build(java.util.Map<String, ?> map) throws Exception {
        RecoverRecycleFilesResponse self = new RecoverRecycleFilesResponse();
        return TeaModel.build(map, self);
    }

    public RecoverRecycleFilesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
