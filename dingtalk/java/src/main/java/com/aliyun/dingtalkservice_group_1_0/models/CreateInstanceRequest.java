// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateInstanceRequest extends TeaModel {
    // 渠道
    @NameInMap("channel")
    public String channel;

    // 外部业务ID，由英文、数字构成
    @NameInMap("externalBizId")
    public String externalBizId;

    // 表单CODE,客户表单：DING_CUSTOMER；联系人表单：DING_CONTACT
    @NameInMap("formCode")
    public String formCode;

    // 表单数据，JSON格式
    @NameInMap("formDataList")
    public String formDataList;

    // 开放团队ID，从服务群后台ID信息中获取
    @NameInMap("openTeamId")
    public String openTeamId;

    // 操作人unionId
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    // 拥有人unionId
    @NameInMap("ownerUnionId")
    public String ownerUnionId;

    public static CreateInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateInstanceRequest self = new CreateInstanceRequest();
        return TeaModel.build(map, self);
    }

    public CreateInstanceRequest setChannel(String channel) {
        this.channel = channel;
        return this;
    }
    public String getChannel() {
        return this.channel;
    }

    public CreateInstanceRequest setExternalBizId(String externalBizId) {
        this.externalBizId = externalBizId;
        return this;
    }
    public String getExternalBizId() {
        return this.externalBizId;
    }

    public CreateInstanceRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public CreateInstanceRequest setFormDataList(String formDataList) {
        this.formDataList = formDataList;
        return this;
    }
    public String getFormDataList() {
        return this.formDataList;
    }

    public CreateInstanceRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public CreateInstanceRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public CreateInstanceRequest setOwnerUnionId(String ownerUnionId) {
        this.ownerUnionId = ownerUnionId;
        return this;
    }
    public String getOwnerUnionId() {
        return this.ownerUnionId;
    }

}
