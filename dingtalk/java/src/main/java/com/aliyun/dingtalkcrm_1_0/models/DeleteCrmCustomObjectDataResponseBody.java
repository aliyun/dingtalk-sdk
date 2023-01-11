// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCrmCustomObjectDataResponseBody extends TeaModel {
    /**
     * <p>删除成功的CRM自定义对象数据ID。</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    public static DeleteCrmCustomObjectDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteCrmCustomObjectDataResponseBody self = new DeleteCrmCustomObjectDataResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteCrmCustomObjectDataResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
