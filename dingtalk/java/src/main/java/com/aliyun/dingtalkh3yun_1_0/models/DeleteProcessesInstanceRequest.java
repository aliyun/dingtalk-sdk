// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class DeleteProcessesInstanceRequest extends TeaModel {
    // 流程实例id
    @NameInMap("processInstanceId")
    public String processInstanceId;

    // 删除成功后，是否需要更新业务表单关联的流程实例id
    @NameInMap("isAutoUpdateBizObject")
    public Boolean isAutoUpdateBizObject;

    public static DeleteProcessesInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteProcessesInstanceRequest self = new DeleteProcessesInstanceRequest();
        return TeaModel.build(map, self);
    }

    public DeleteProcessesInstanceRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public DeleteProcessesInstanceRequest setIsAutoUpdateBizObject(Boolean isAutoUpdateBizObject) {
        this.isAutoUpdateBizObject = isAutoUpdateBizObject;
        return this;
    }
    public Boolean getIsAutoUpdateBizObject() {
        return this.isAutoUpdateBizObject;
    }

}
