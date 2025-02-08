// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class BatchGetMinutesDetailsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskUuids")
    public java.util.List<String> taskUuids;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static BatchGetMinutesDetailsRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetMinutesDetailsRequest self = new BatchGetMinutesDetailsRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetMinutesDetailsRequest setTaskUuids(java.util.List<String> taskUuids) {
        this.taskUuids = taskUuids;
        return this;
    }
    public java.util.List<String> getTaskUuids() {
        return this.taskUuids;
    }

    public BatchGetMinutesDetailsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
