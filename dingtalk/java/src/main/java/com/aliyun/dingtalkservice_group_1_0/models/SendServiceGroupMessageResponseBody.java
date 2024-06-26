// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SendServiceGroupMessageResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>msgxxxxxx==</p>
     */
    @NameInMap("openMsgTaskId")
    public String openMsgTaskId;

    public static SendServiceGroupMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendServiceGroupMessageResponseBody self = new SendServiceGroupMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendServiceGroupMessageResponseBody setOpenMsgTaskId(String openMsgTaskId) {
        this.openMsgTaskId = openMsgTaskId;
        return this;
    }
    public String getOpenMsgTaskId() {
        return this.openMsgTaskId;
    }

}
