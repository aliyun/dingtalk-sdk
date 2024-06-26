// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetExclusiveAccountAllOrgListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>TBXK65QHiiorHvxxxxxxxxP6giEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetExclusiveAccountAllOrgListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetExclusiveAccountAllOrgListRequest self = new GetExclusiveAccountAllOrgListRequest();
        return TeaModel.build(map, self);
    }

    public GetExclusiveAccountAllOrgListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
