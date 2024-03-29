// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SheetAutofitRowsRequest extends TeaModel {
    @NameInMap("fontWidth")
    public Long fontWidth;

    @NameInMap("row")
    public Long row;

    @NameInMap("rowCount")
    public Long rowCount;

    @NameInMap("operatorId")
    public String operatorId;

    public static SheetAutofitRowsRequest build(java.util.Map<String, ?> map) throws Exception {
        SheetAutofitRowsRequest self = new SheetAutofitRowsRequest();
        return TeaModel.build(map, self);
    }

    public SheetAutofitRowsRequest setFontWidth(Long fontWidth) {
        this.fontWidth = fontWidth;
        return this;
    }
    public Long getFontWidth() {
        return this.fontWidth;
    }

    public SheetAutofitRowsRequest setRow(Long row) {
        this.row = row;
        return this;
    }
    public Long getRow() {
        return this.row;
    }

    public SheetAutofitRowsRequest setRowCount(Long rowCount) {
        this.rowCount = rowCount;
        return this;
    }
    public Long getRowCount() {
        return this.rowCount;
    }

    public SheetAutofitRowsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
