// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CustomerSendMsgTaskResponseBody extends TeaModel {
    @NameInMap("openBatchTaskId")
    public String openBatchTaskId;

    public static CustomerSendMsgTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomerSendMsgTaskResponseBody self = new CustomerSendMsgTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomerSendMsgTaskResponseBody setOpenBatchTaskId(String openBatchTaskId) {
        this.openBatchTaskId = openBatchTaskId;
        return this;
    }
    public String getOpenBatchTaskId() {
        return this.openBatchTaskId;
    }

}
