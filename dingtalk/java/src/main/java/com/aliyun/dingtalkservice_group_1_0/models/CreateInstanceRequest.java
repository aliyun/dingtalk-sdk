// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateInstanceRequest extends TeaModel {
    /**
     * <p>渠道</p>
     */
    @NameInMap("channel")
    public String channel;

    /**
     * <p>外部业务ID，由英文、数字构成</p>
     */
    @NameInMap("externalBizId")
    public String externalBizId;

    /**
     * <p>表单CODE,客户表单：DING_CUSTOMER；联系人表单：DING_CONTACT</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <p>表单数据，JSON格式</p>
     */
    @NameInMap("formDataList")
    public String formDataList;

    /**
     * <p>开放团队ID，从服务群后台ID信息中获取</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    /**
     * <p>拥有人unionId</p>
     */
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
