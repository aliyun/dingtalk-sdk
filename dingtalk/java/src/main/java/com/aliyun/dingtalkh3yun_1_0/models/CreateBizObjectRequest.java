// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateBizObjectRequest extends TeaModel {
    /**
     * <p>json格式的业务数据</p>
     */
    @NameInMap("bizObjectJson")
    public String bizObjectJson;

    /**
     * <p>是否是草稿数据。true=草稿数据，false=生效数据</p>
     */
    @NameInMap("isDraft")
    public Boolean isDraft;

    /**
     * <p>操作用户id。可从“获取用户信息”API获取</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>表单编码</p>
     */
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
