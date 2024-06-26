// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetTotalNumberOfSpacesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abcd</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetTotalNumberOfSpacesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTotalNumberOfSpacesRequest self = new GetTotalNumberOfSpacesRequest();
        return TeaModel.build(map, self);
    }

    public GetTotalNumberOfSpacesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
