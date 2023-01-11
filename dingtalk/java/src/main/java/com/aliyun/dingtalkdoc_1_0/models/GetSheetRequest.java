// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetSheetRequest extends TeaModel {
    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetSheetRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSheetRequest self = new GetSheetRequest();
        return TeaModel.build(map, self);
    }

    public GetSheetRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
