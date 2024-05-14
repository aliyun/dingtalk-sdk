// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class BatchDeleteRecentsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dentryUuids")
    public java.util.List<String> dentryUuids;

    /**
     * <p>This parameter is required.</p>
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
