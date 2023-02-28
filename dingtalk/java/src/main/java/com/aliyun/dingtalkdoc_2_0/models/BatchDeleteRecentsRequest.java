// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class BatchDeleteRecentsRequest extends TeaModel {
    /**
     * <p>移除最近记录文档uuid</p>
     * <p>最大size:</p>
     * <p>	20</p>
     */
    @NameInMap("dentryUuids")
    public java.util.List<String> dentryUuids;

    /**
     * <p>操作人id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static BatchDeleteRecentsRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteRecentsRequest self = new BatchDeleteRecentsRequest();
        return TeaModel.build(map, self);
    }

    public BatchDeleteRecentsRequest setDentryUuids(java.util.List<String> dentryUuids) {
        this.dentryUuids = dentryUuids;
        return this;
    }
    public java.util.List<String> getDentryUuids() {
        return this.dentryUuids;
    }

    public BatchDeleteRecentsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
