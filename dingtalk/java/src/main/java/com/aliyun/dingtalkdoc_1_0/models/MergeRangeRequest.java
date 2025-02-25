// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class MergeRangeRequest extends TeaModel {
    @NameInMap("mergeType")
    public String mergeType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ppgAQuHfOoNVpJiStDwWCEgiEiE</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static MergeRangeRequest build(java.util.Map<String, ?> map) throws Exception {
        MergeRangeRequest self = new MergeRangeRequest();
        return TeaModel.build(map, self);
    }

    public MergeRangeRequest setMergeType(String mergeType) {
        this.mergeType = mergeType;
        return this;
    }
    public String getMergeType() {
        return this.mergeType;
    }

    public MergeRangeRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
