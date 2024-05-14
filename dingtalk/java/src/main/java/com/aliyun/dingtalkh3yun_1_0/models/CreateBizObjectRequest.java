// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateBizObjectRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizObjectJson")
    public String bizObjectJson;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isDraft")
    public Boolean isDraft;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
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
