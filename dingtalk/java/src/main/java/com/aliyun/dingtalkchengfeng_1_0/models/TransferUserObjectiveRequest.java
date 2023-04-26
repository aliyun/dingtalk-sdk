// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class TransferUserObjectiveRequest extends TeaModel {
    @NameInMap("objectiveId")
    public String objectiveId;

    @NameInMap("targetUserId")
    public String targetUserId;

    public static TransferUserObjectiveRequest build(java.util.Map<String, ?> map) throws Exception {
        TransferUserObjectiveRequest self = new TransferUserObjectiveRequest();
        return TeaModel.build(map, self);
    }

    public TransferUserObjectiveRequest setObjectiveId(String objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public String getObjectiveId() {
        return this.objectiveId;
    }

    public TransferUserObjectiveRequest setTargetUserId(String targetUserId) {
        this.targetUserId = targetUserId;
        return this;
    }
    public String getTargetUserId() {
        return this.targetUserId;
    }

}
