// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class GetPersonalCarbonInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>salary</p>
     */
    @NameInMap("actionType")
    public String actionType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>23121</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetPersonalCarbonInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPersonalCarbonInfoRequest self = new GetPersonalCarbonInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetPersonalCarbonInfoRequest setActionType(String actionType) {
        this.actionType = actionType;
        return this;
    }
    public String getActionType() {
        return this.actionType;
    }

    public GetPersonalCarbonInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
