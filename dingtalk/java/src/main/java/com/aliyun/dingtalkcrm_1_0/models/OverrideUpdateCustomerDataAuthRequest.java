// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class OverrideUpdateCustomerDataAuthRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customerIds")
    public java.util.List<String> customerIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dataAuthUserIds")
    public java.util.List<String> dataAuthUserIds;

    /**
     * <strong>example:</strong>
     * <p>PROC-98187D45-EFC0-4FC4-887E-45BD24209D69</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>staffId2</p>
     */
    @NameInMap("operateUserId")
    public String operateUserId;

    /**
     * <strong>example:</strong>
     * <p>crm_customer</p>
     */
    @NameInMap("relationType")
    public String relationType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>owner</p>
     */
    @NameInMap("roleType")
    public String roleType;

    public static OverrideUpdateCustomerDataAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        OverrideUpdateCustomerDataAuthRequest self = new OverrideUpdateCustomerDataAuthRequest();
        return TeaModel.build(map, self);
    }

    public OverrideUpdateCustomerDataAuthRequest setCustomerIds(java.util.List<String> customerIds) {
        this.customerIds = customerIds;
        return this;
    }
    public java.util.List<String> getCustomerIds() {
        return this.customerIds;
    }

    public OverrideUpdateCustomerDataAuthRequest setDataAuthUserIds(java.util.List<String> dataAuthUserIds) {
        this.dataAuthUserIds = dataAuthUserIds;
        return this;
    }
    public java.util.List<String> getDataAuthUserIds() {
        return this.dataAuthUserIds;
    }

    public OverrideUpdateCustomerDataAuthRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public OverrideUpdateCustomerDataAuthRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

    public OverrideUpdateCustomerDataAuthRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public OverrideUpdateCustomerDataAuthRequest setRoleType(String roleType) {
        this.roleType = roleType;
        return this;
    }
    public String getRoleType() {
        return this.roleType;
    }

}
