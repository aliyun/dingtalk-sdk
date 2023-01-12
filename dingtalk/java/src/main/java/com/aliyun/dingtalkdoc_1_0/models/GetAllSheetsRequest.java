// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetAllSheetsRequest extends TeaModel {
    /**
     * <p>操作人id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetAllSheetsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAllSheetsRequest self = new GetAllSheetsRequest();
        return TeaModel.build(map, self);
    }

    public GetAllSheetsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
