// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.domain20180129.models;

import com.aliyun.tea.*;

public class SaveBatchTaskForTransferOutByAuthorizationCodeResponseBody extends TeaModel {
    @NameInMap("RequestId")
    public String requestId;

    @NameInMap("TaskNo")
    public String taskNo;

    public static SaveBatchTaskForTransferOutByAuthorizationCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveBatchTaskForTransferOutByAuthorizationCodeResponseBody self = new SaveBatchTaskForTransferOutByAuthorizationCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveBatchTaskForTransferOutByAuthorizationCodeResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SaveBatchTaskForTransferOutByAuthorizationCodeResponseBody setTaskNo(String taskNo) {
        this.taskNo = taskNo;
        return this;
    }
    public String getTaskNo() {
        return this.taskNo;
    }

}
