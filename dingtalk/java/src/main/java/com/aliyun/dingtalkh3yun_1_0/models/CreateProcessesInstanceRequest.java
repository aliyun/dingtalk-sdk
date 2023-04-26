// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateProcessesInstanceRequest extends TeaModel {
    @NameInMap("bizObjectId")
    public String bizObjectId;

    @NameInMap("opUserId")
    public String opUserId;

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
