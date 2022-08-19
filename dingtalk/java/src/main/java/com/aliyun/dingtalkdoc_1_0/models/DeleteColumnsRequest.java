// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteColumnsRequest extends TeaModel {
    // 要删除的第一列的位置，从0开始
    @NameInMap("column")
    public Long column;

    // 要删除的列的数量
    @NameInMap("columnCount")
    public Long columnCount;

    // 操作人unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteColumnsRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteColumnsRequest self = new DeleteColumnsRequest();
        return TeaModel.build(map, self);
    }

    public DeleteColumnsRequest setColumn(Long column) {
        this.column = column;
        return this;
    }
    public Long getColumn() {
        return this.column;
    }

    public DeleteColumnsRequest setColumnCount(Long columnCount) {
        this.columnCount = columnCount;
        return this;
    }
    public Long getColumnCount() {
        return this.columnCount;
    }

    public DeleteColumnsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
