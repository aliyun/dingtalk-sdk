// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SendMsgByTaskResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("openBatchTaskId")
    public String openBatchTaskId;

    public static SendMsgByTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendMsgByTaskResponseBody self = new SendMsgByTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public SendMsgByTaskResponseBody setOpenBatchTaskId(String openBatchTaskId) {
        this.openBatchTaskId = openBatchTaskId;
        return this;
    }
    public String getOpenBatchTaskId() {
        return this.openBatchTaskId;
    }

}
