// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InsertRowsBeforeRequest extends TeaModel {
    @NameInMap("row")
    public Long row;

    @NameInMap("rowCount")
    public Long rowCount;

    @NameInMap("operatorId")
    public String operatorId;

    public static InsertRowsBeforeRequest build(java.util.Map<String, ?> map) throws Exception {
        InsertRowsBeforeRequest self = new InsertRowsBeforeRequest();
        return TeaModel.build(map, self);
    }

    public InsertRowsBeforeRequest setRow(Long row) {
        this.row = row;
        return this;
    }
    public Long getRow() {
        return this.row;
    }

    public InsertRowsBeforeRequest setRowCount(Long rowCount) {
        this.rowCount = rowCount;
        return this;
    }
    public Long getRowCount() {
        return this.rowCount;
    }

    public InsertRowsBeforeRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
