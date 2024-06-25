// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpdateInstanceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>hhdhg</p>
     */
    @NameInMap("externalBizId")
    public String externalBizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>DING_CUSTOMER</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;node_888&quot;:&quot;hhhh&quot;}</p>
     */
    @NameInMap("formDataList")
    public String formDataList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>888555</p>
     */
    @NameInMap("openDataInstanceId")
    public String openDataInstanceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>888***</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <strong>example:</strong>
     * <p>8888</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    /**
     * <strong>example:</strong>
     * <p>88888</p>
     */
    @NameInMap("ownerUnionId")
    public String ownerUnionId;

    public static UpdateInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInstanceRequest self = new UpdateInstanceRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInstanceRequest setExternalBizId(String externalBizId) {
        this.externalBizId = externalBizId;
        return this;
    }
    public String getExternalBizId() {
        return this.externalBizId;
    }

    public UpdateInstanceRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public UpdateInstanceRequest setFormDataList(String formDataList) {
        this.formDataList = formDataList;
        return this;
    }
    public String getFormDataList() {
        return this.formDataList;
    }

    public UpdateInstanceRequest setOpenDataInstanceId(String openDataInstanceId) {
        this.openDataInstanceId = openDataInstanceId;
        return this;
    }
    public String getOpenDataInstanceId() {
        return this.openDataInstanceId;
    }

    public UpdateInstanceRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public UpdateInstanceRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public UpdateInstanceRequest setOwnerUnionId(String ownerUnionId) {
        this.ownerUnionId = ownerUnionId;
        return this;
    }
    public String getOwnerUnionId() {
        return this.ownerUnionId;
    }

}
