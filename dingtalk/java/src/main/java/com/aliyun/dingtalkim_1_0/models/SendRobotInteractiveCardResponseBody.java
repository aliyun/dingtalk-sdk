// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendRobotInteractiveCardResponseBody extends TeaModel {
    // 用于业务方后续查看已读列表的查询key
    @NameInMap("processQueryKey")
    public String processQueryKey;

    public static SendRobotInteractiveCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendRobotInteractiveCardResponseBody self = new SendRobotInteractiveCardResponseBody();
        return TeaModel.build(map, self);
    }

    public SendRobotInteractiveCardResponseBody setProcessQueryKey(String processQueryKey) {
        this.processQueryKey = processQueryKey;
        return this;
    }
    public String getProcessQueryKey() {
        return this.processQueryKey;
    }

}
