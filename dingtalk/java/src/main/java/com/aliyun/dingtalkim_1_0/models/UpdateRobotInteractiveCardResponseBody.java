// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotInteractiveCardResponseBody extends TeaModel {
    // 用于业务方后续查看已读列表的查询key
    @NameInMap("processQueryKey")
    public String processQueryKey;

    public static UpdateRobotInteractiveCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRobotInteractiveCardResponseBody self = new UpdateRobotInteractiveCardResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRobotInteractiveCardResponseBody setProcessQueryKey(String processQueryKey) {
        this.processQueryKey = processQueryKey;
        return this;
    }
    public String getProcessQueryKey() {
        return this.processQueryKey;
    }

}
