// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchRemoveFollowRecordsRequest extends TeaModel {
    /**
     * <p>关系数据列表。</p>
     */
    @NameInMap("instanceIds")
    public java.util.List<String> instanceIds;

    /**
     * <p>操作人userId</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    public static BatchRemoveFollowRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchRemoveFollowRecordsRequest self = new BatchRemoveFollowRecordsRequest();
        return TeaModel.build(map, self);
    }

    public BatchRemoveFollowRecordsRequest setInstanceIds(java.util.List<String> instanceIds) {
        this.instanceIds = instanceIds;
        return this;
    }
    public java.util.List<String> getInstanceIds() {
        return this.instanceIds;
    }

    public BatchRemoveFollowRecordsRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

}
