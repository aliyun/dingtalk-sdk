// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetRowsVisibilityRequest extends TeaModel {
    @NameInMap("row")
    public Long row;

    @NameInMap("rowCount")
    public Long rowCount;

    @NameInMap("visibility")
    public String visibility;

    @NameInMap("operatorId")
    public String operatorId;

    public static SetRowsVisibilityRequest build(java.util.Map<String, ?> map) throws Exception {
        SetRowsVisibilityRequest self = new SetRowsVisibilityRequest();
        return TeaModel.build(map, self);
    }

    public SetRowsVisibilityRequest setRow(Long row) {
        this.row = row;
        return this;
    }
    public Long getRow() {
        return this.row;
    }

    public SetRowsVisibilityRequest setRowCount(Long rowCount) {
        this.rowCount = rowCount;
        return this;
    }
    public Long getRowCount() {
        return this.rowCount;
    }

    public SetRowsVisibilityRequest setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

    public SetRowsVisibilityRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
