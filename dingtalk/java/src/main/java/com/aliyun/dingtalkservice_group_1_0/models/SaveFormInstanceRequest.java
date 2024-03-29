// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SaveFormInstanceRequest extends TeaModel {
    @NameInMap("formDataList")
    public String formDataList;

    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    @NameInMap("ownerUnionId")
    public String ownerUnionId;

    public static SaveFormInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveFormInstanceRequest self = new SaveFormInstanceRequest();
        return TeaModel.build(map, self);
    }

    public SaveFormInstanceRequest setFormDataList(String formDataList) {
        this.formDataList = formDataList;
        return this;
    }
    public String getFormDataList() {
        return this.formDataList;
    }

    public SaveFormInstanceRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public SaveFormInstanceRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public SaveFormInstanceRequest setOwnerUnionId(String ownerUnionId) {
        this.ownerUnionId = ownerUnionId;
        return this;
    }
    public String getOwnerUnionId() {
        return this.ownerUnionId;
    }

}
