// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchOTOQueryRequest extends TeaModel {
    // 机器人robotCode
    @NameInMap("robotCode")
    public String robotCode;

    // 消息已读查询标志
    @NameInMap("processQueryKey")
    public String processQueryKey;

    public static BatchOTOQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchOTOQueryRequest self = new BatchOTOQueryRequest();
        return TeaModel.build(map, self);
    }

    public BatchOTOQueryRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public BatchOTOQueryRequest setProcessQueryKey(String processQueryKey) {
        this.processQueryKey = processQueryKey;
        return this;
    }
    public String getProcessQueryKey() {
        return this.processQueryKey;
    }

}
