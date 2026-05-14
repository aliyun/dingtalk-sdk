// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class TruncateSheetRecordsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static TruncateSheetRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        TruncateSheetRecordsRequest self = new TruncateSheetRecordsRequest();
        return TeaModel.build(map, self);
    }

    public TruncateSheetRecordsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
