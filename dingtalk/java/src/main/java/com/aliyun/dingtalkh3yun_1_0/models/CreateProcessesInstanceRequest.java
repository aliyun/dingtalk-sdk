// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateProcessesInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>006f870b-4d1c-4cd0-85b3-2e866798e947</p>
     */
    @NameInMap("bizObjectId")
    public String bizObjectId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>aea4d7a7-d162-4c77-9c44-7bd9cb8316a5</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D0001833abb0fb61524487eb01848207bc89b47</p>
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
