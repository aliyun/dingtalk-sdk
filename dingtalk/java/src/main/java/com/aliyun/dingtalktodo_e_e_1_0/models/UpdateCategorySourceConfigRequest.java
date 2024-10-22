// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class UpdateCategorySourceConfigRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1001</p>
     */
    @NameInMap("bizCategoryId")
    public String bizCategoryId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>考勤_财务</p>
     */
    @NameInMap("bizCategoryName")
    public String bizCategoryName;

    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateCategorySourceConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCategorySourceConfigRequest self = new UpdateCategorySourceConfigRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCategorySourceConfigRequest setBizCategoryId(String bizCategoryId) {
        this.bizCategoryId = bizCategoryId;
        return this;
    }
    public String getBizCategoryId() {
        return this.bizCategoryId;
    }

    public UpdateCategorySourceConfigRequest setBizCategoryName(String bizCategoryName) {
        this.bizCategoryName = bizCategoryName;
        return this;
    }
    public String getBizCategoryName() {
        return this.bizCategoryName;
    }

    public UpdateCategorySourceConfigRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
