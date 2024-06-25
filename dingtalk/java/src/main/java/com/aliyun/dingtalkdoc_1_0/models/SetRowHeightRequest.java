// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetRowHeightRequest extends TeaModel {
    @NameInMap("height")
    public Integer height;

    @NameInMap("row")
    public Integer row;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ppgAQuHfOoNVpJiStDwWCEgiEiE</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static SetRowHeightRequest build(java.util.Map<String, ?> map) throws Exception {
        SetRowHeightRequest self = new SetRowHeightRequest();
        return TeaModel.build(map, self);
    }

    public SetRowHeightRequest setHeight(Integer height) {
        this.height = height;
        return this;
    }
    public Integer getHeight() {
        return this.height;
    }

    public SetRowHeightRequest setRow(Integer row) {
        this.row = row;
        return this;
    }
    public Integer getRow() {
        return this.row;
    }

    public SetRowHeightRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
