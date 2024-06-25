// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteColumnsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>column</p>
     */
    @NameInMap("column")
    public Long column;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>column_count</p>
     */
    @NameInMap("columnCount")
    public Long columnCount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
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
