// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class MoveMailFolderResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static MoveMailFolderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MoveMailFolderResponseBody self = new MoveMailFolderResponseBody();
        return TeaModel.build(map, self);
    }

    public MoveMailFolderResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
