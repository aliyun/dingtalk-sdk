// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class DeleteProcessesInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("isAutoUpdateBizObject")
    public Boolean isAutoUpdateBizObject;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3d0ad4a4-d7d5-4196-9f2c-3ed246f2b713</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static DeleteProcessesInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteProcessesInstanceRequest self = new DeleteProcessesInstanceRequest();
        return TeaModel.build(map, self);
    }

    public DeleteProcessesInstanceRequest setIsAutoUpdateBizObject(Boolean isAutoUpdateBizObject) {
        this.isAutoUpdateBizObject = isAutoUpdateBizObject;
        return this;
    }
    public Boolean getIsAutoUpdateBizObject() {
        return this.isAutoUpdateBizObject;
    }

    public DeleteProcessesInstanceRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
