// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class OpportunitySearchRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试组织</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static OpportunitySearchRequest build(java.util.Map<String, ?> map) throws Exception {
        OpportunitySearchRequest self = new OpportunitySearchRequest();
        return TeaModel.build(map, self);
    }

    public OpportunitySearchRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
