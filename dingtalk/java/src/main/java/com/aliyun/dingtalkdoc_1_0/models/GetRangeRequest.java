// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRangeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <strong>example:</strong>
     * <p>select</p>
     */
    @NameInMap("select")
    public String select;

    public static GetRangeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRangeRequest self = new GetRangeRequest();
        return TeaModel.build(map, self);
    }

    public GetRangeRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public GetRangeRequest setSelect(String select) {
        this.select = select;
        return this;
    }
    public String getSelect() {
        return this.select;
    }

}
