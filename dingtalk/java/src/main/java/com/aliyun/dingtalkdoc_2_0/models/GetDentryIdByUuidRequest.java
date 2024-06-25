// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetDentryIdByUuidRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetDentryIdByUuidRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDentryIdByUuidRequest self = new GetDentryIdByUuidRequest();
        return TeaModel.build(map, self);
    }

    public GetDentryIdByUuidRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
