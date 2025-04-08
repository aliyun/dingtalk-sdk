// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreCapacityUsageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding1234</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static GetPrivateStoreCapacityUsageRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreCapacityUsageRequest self = new GetPrivateStoreCapacityUsageRequest();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreCapacityUsageRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
