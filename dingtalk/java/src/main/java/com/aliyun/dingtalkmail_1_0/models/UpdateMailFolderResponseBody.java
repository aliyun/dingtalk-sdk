// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class UpdateMailFolderResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static UpdateMailFolderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateMailFolderResponseBody self = new UpdateMailFolderResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateMailFolderResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
