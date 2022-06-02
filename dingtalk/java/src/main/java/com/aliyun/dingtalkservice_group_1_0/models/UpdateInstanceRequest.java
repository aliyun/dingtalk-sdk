// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpdateInstanceRequest extends TeaModel {
    // 外部业务ID
    @NameInMap("externalBizId")
    public String externalBizId;

    // 表单CODE
    @NameInMap("formCode")
    public String formCode;

    // 数据表单实例数据，JSON格式
    @NameInMap("formDataList")
    public String formDataList;

    // 开放数据实例ID
    @NameInMap("openDataInstanceId")
    public String openDataInstanceId;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 操作人unionId
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    // 拥有人unionId
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
