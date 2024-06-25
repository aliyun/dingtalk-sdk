// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SheetAutofitRowsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fontWidth")
    public Long fontWidth;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("row")
    public Long row;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("rowCount")
    public Long rowCount;

    /**
     * <p>This parameter is required.</p>
     */
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
