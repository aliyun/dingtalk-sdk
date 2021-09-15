// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AbandonCustomerResponseBody extends TeaModel {
    // 成功退回公海的客户实例 id 数组
    @NameInMap("instanceIdList")
    public java.util.List<String> instanceIdList;

    public static AbandonCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AbandonCustomerResponseBody self = new AbandonCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public AbandonCustomerResponseBody setInstanceIdList(java.util.List<String> instanceIdList) {
        this.instanceIdList = instanceIdList;
        return this;
    }
    public java.util.List<String> getInstanceIdList() {
        return this.instanceIdList;
    }

}
