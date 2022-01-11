// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateBizObjectRequest extends TeaModel {
    // json格式的业务数据
    @NameInMap("bizObjectJson")
    public String bizObjectJson;

    // 是否是草稿数据。true=草稿数据，false=生效数据
    @NameInMap("isDraft")
    public Boolean isDraft;

    // 操作用户id。可从“获取用户信息”API获取
    @NameInMap("opUserId")
    public String opUserId;

    // 表单编码
    @NameInMap("schemaCode")
    public String schemaCode;

    public static CreateBizObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateBizObjectRequest self = new CreateBizObjectRequest();
        return TeaModel.build(map, self);
    }

    public CreateBizObjectRequest setBizObjectJson(String bizObjectJson) {
        this.bizObjectJson = bizObjectJson;
        return this;
    }
    public String getBizObjectJson() {
        return this.bizObjectJson;
    }

    public CreateBizObjectRequest setIsDraft(Boolean isDraft) {
        this.isDraft = isDraft;
        return this;
    }
    public Boolean getIsDraft() {
        return this.isDraft;
    }

    public CreateBizObjectRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public CreateBizObjectRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

}
