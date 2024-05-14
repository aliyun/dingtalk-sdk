// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteRelationMetaFieldRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldIdList")
    public java.util.List<String> fieldIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relationType")
    public String relationType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tenant")
    public String tenant;

    public static DeleteRelationMetaFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteRelationMetaFieldRequest self = new DeleteRelationMetaFieldRequest();
        return TeaModel.build(map, self);
    }

    public DeleteRelationMetaFieldRequest setFieldIdList(java.util.List<String> fieldIdList) {
        this.fieldIdList = fieldIdList;
        return this;
    }
    public java.util.List<String> getFieldIdList() {
        return this.fieldIdList;
    }

    public DeleteRelationMetaFieldRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public DeleteRelationMetaFieldRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public DeleteRelationMetaFieldRequest setTenant(String tenant) {
        this.tenant = tenant;
        return this;
    }
    public String getTenant() {
        return this.tenant;
    }

}
