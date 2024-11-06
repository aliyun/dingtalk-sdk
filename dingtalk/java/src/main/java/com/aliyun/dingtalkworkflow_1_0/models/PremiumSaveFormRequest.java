// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveFormRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>用于员工差旅费用报销使用</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formComponents")
    public java.util.List<FormComponent> formComponents;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>出差报销审批</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>proc-abc</p>
     */
    @NameInMap("processCode")
    public String processCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static PremiumSaveFormRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveFormRequest self = new PremiumSaveFormRequest();
        return TeaModel.build(map, self);
    }

    public PremiumSaveFormRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public PremiumSaveFormRequest setFormComponents(java.util.List<FormComponent> formComponents) {
        this.formComponents = formComponents;
        return this;
    }
    public java.util.List<FormComponent> getFormComponents() {
        return this.formComponents;
    }

    public PremiumSaveFormRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public PremiumSaveFormRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public PremiumSaveFormRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
