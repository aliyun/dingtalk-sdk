// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetColumnWidthRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("column")
    public Integer column;

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

    public static SetColumnWidthRequest build(java.util.Map<String, ?> map) throws Exception {
        SetColumnWidthRequest self = new SetColumnWidthRequest();
        return TeaModel.build(map, self);
    }

    public SetColumnWidthRequest setColumn(Integer column) {
        this.column = column;
        return this;
    }
    public Integer getColumn() {
        return this.column;
    }

    public SetColumnWidthRequest setWidth(Integer width) {
        this.width = width;
        return this;
    }
    public Integer getWidth() {
        return this.width;
    }

    public SetColumnWidthRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
