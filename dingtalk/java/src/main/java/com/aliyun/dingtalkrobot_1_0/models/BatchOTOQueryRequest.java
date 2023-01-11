// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchOTOQueryRequest extends TeaModel {
    /**
     * <p>消息已读查询标志</p>
     */
    @NameInMap("processQueryKey")
    public String processQueryKey;

    /**
     * <p>机器人robotCode</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static BatchOTOQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchOTOQueryRequest self = new BatchOTOQueryRequest();
        return TeaModel.build(map, self);
    }

    public BatchOTOQueryRequest setProcessQueryKey(String processQueryKey) {
        this.processQueryKey = processQueryKey;
        return this;
    }
    public String getProcessQueryKey() {
        return this.processQueryKey;
    }

    public BatchOTOQueryRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
