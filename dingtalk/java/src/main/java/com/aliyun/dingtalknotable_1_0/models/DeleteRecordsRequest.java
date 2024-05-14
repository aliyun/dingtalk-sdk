// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecordsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("recordIds")
    public java.util.List<String> recordIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecordsRequest self = new DeleteRecordsRequest();
        return TeaModel.build(map, self);
    }

    public DeleteRecordsRequest setRecordIds(java.util.List<String> recordIds) {
        this.recordIds = recordIds;
        return this;
    }
    public java.util.List<String> getRecordIds() {
        return this.recordIds;
    }

    public DeleteRecordsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
