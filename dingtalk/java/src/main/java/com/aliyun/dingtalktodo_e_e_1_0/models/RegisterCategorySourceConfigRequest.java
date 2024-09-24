// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class RegisterCategorySourceConfigRequest extends TeaModel {
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
     * <p>财务_审批_考勤</p>
     */
    @NameInMap("bizCategoryName")
    public String bizCategoryName;

    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static RegisterCategorySourceConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        RegisterCategorySourceConfigRequest self = new RegisterCategorySourceConfigRequest();
        return TeaModel.build(map, self);
    }

    public RegisterCategorySourceConfigRequest setBizCategoryId(String bizCategoryId) {
        this.bizCategoryId = bizCategoryId;
        return this;
    }
    public String getBizCategoryId() {
        return this.bizCategoryId;
    }

    public RegisterCategorySourceConfigRequest setBizCategoryName(String bizCategoryName) {
        this.bizCategoryName = bizCategoryName;
        return this;
    }
    public String getBizCategoryName() {
        return this.bizCategoryName;
    }

    public RegisterCategorySourceConfigRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
