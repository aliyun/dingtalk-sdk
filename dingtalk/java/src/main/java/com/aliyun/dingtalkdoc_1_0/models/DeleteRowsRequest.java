// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteRowsRequest extends TeaModel {
    /**
     * <p>要删除的第一行的位置，从0开始。</p>
     */
    @NameInMap("row")
    public Long row;

    /**
     * <p>要删除的行的数量。</p>
     */
    @NameInMap("rowCount")
    public Long rowCount;

    /**
     * <p>操作人id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteRowsRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteRowsRequest self = new DeleteRowsRequest();
        return TeaModel.build(map, self);
    }

    public DeleteRowsRequest setRow(Long row) {
        this.row = row;
        return this;
    }
    public Long getRow() {
        return this.row;
    }

    public DeleteRowsRequest setRowCount(Long rowCount) {
        this.rowCount = rowCount;
        return this;
    }
    public Long getRowCount() {
        return this.rowCount;
    }

    public DeleteRowsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
