// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateProcessesInstanceRequest extends TeaModel {
    /**
     * <p>业务数据id</p>
     */
    @NameInMap("bizObjectId")
    public String bizObjectId;

    /**
     * <p>操作用户id。此为氚云的用户id，可从"获取用户数据API"获取</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>表单编码</p>
     */
    @NameInMap("schemaCode")
    public String schemaCode;

    public static CreateProcessesInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateProcessesInstanceRequest self = new CreateProcessesInstanceRequest();
        return TeaModel.build(map, self);
    }

    public CreateProcessesInstanceRequest setBizObjectId(String bizObjectId) {
        this.bizObjectId = bizObjectId;
        return this;
    }
    public String getBizObjectId() {
        return this.bizObjectId;
    }

    public CreateProcessesInstanceRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public CreateProcessesInstanceRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

}
