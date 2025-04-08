// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class DeleteMailFolderResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static DeleteMailFolderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteMailFolderResponseBody self = new DeleteMailFolderResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteMailFolderResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
