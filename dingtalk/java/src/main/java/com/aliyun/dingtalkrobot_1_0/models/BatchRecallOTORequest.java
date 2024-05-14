// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchRecallOTORequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processQueryKeys")
    public java.util.List<String> processQueryKeys;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static BatchRecallOTORequest build(java.util.Map<String, ?> map) throws Exception {
        BatchRecallOTORequest self = new BatchRecallOTORequest();
        return TeaModel.build(map, self);
    }

    public BatchRecallOTORequest setProcessQueryKeys(java.util.List<String> processQueryKeys) {
        this.processQueryKeys = processQueryKeys;
        return this;
    }
    public java.util.List<String> getProcessQueryKeys() {
        return this.processQueryKeys;
    }

    public BatchRecallOTORequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
