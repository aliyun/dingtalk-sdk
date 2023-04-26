// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InsertColumnsBeforeRequest extends TeaModel {
    @NameInMap("column")
    public Long column;

    @NameInMap("columnCount")
    public Long columnCount;

    @NameInMap("operatorId")
    public String operatorId;

    public static InsertColumnsBeforeRequest build(java.util.Map<String, ?> map) throws Exception {
        InsertColumnsBeforeRequest self = new InsertColumnsBeforeRequest();
        return TeaModel.build(map, self);
    }

    public InsertColumnsBeforeRequest setColumn(Long column) {
        this.column = column;
        return this;
    }
    public Long getColumn() {
        return this.column;
    }

    public InsertColumnsBeforeRequest setColumnCount(Long columnCount) {
        this.columnCount = columnCount;
        return this;
    }
    public Long getColumnCount() {
        return this.columnCount;
    }

    public InsertColumnsBeforeRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
