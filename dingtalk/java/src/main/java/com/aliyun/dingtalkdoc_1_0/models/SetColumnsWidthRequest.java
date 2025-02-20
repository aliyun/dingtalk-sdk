// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetColumnsWidthRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("column")
    public Integer column;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("columnCount")
    public Integer columnCount;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("width")
    public Integer width;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ppgAQuHfOoNVpJiStDwWCEgiEiE</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static SetColumnsWidthRequest build(java.util.Map<String, ?> map) throws Exception {
        SetColumnsWidthRequest self = new SetColumnsWidthRequest();
        return TeaModel.build(map, self);
    }

    public SetColumnsWidthRequest setColumn(Integer column) {
        this.column = column;
        return this;
    }
    public Integer getColumn() {
        return this.column;
    }

    public SetColumnsWidthRequest setColumnCount(Integer columnCount) {
        this.columnCount = columnCount;
        return this;
    }
    public Integer getColumnCount() {
        return this.columnCount;
    }

    public SetColumnsWidthRequest setWidth(Integer width) {
        this.width = width;
        return this;
    }
    public Integer getWidth() {
        return this.width;
    }

    public SetColumnsWidthRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
