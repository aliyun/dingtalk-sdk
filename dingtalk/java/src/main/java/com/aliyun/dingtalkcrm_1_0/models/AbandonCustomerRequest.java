// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AbandonCustomerRequest extends TeaModel {
    // 操作人staffId，一般为企业员工
    @NameInMap("operatorUserId")
    public String operatorUserId;

    // 客户实例 id 数组
    @NameInMap("instanceIdList")
    public java.util.List<String> instanceIdList;

    public static AbandonCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        AbandonCustomerRequest self = new AbandonCustomerRequest();
        return TeaModel.build(map, self);
    }

    public AbandonCustomerRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public AbandonCustomerRequest setInstanceIdList(java.util.List<String> instanceIdList) {
        this.instanceIdList = instanceIdList;
        return this;
    }
    public java.util.List<String> getInstanceIdList() {
        return this.instanceIdList;
    }

}
