// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetRowsHeightRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("height")
    public Long height;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("row")
    public Long row;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("rowCount")
    public Long rowCount;

    @NameInMap("dingAccessTokenType")
    public String dingAccessTokenType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ppgAQuHfOoNVpJiStDwWCEgiEiE</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static SetRowsHeightRequest build(java.util.Map<String, ?> map) throws Exception {
        SetRowsHeightRequest self = new SetRowsHeightRequest();
        return TeaModel.build(map, self);
    }

    public SetRowsHeightRequest setHeight(Long height) {
        this.height = height;
        return this;
    }
    public Long getHeight() {
        return this.height;
    }

    public SetRowsHeightRequest setRow(Long row) {
        this.row = row;
        return this;
    }
    public Long getRow() {
        return this.row;
    }

    public SetRowsHeightRequest setRowCount(Long rowCount) {
        this.rowCount = rowCount;
        return this;
    }
    public Long getRowCount() {
        return this.rowCount;
    }

    public SetRowsHeightRequest setDingAccessTokenType(String dingAccessTokenType) {
        this.dingAccessTokenType = dingAccessTokenType;
        return this;
    }
    public String getDingAccessTokenType() {
        return this.dingAccessTokenType;
    }

    public SetRowsHeightRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
