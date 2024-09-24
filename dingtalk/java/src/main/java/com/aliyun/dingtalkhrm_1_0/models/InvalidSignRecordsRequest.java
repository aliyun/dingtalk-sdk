// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class InvalidSignRecordsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("invalidUserId")
    public String invalidUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("signRecordIds")
    public java.util.List<String> signRecordIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>作废测试</p>
     */
    @NameInMap("statusRemark")
    public String statusRemark;

    public static InvalidSignRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        InvalidSignRecordsRequest self = new InvalidSignRecordsRequest();
        return TeaModel.build(map, self);
    }

    public InvalidSignRecordsRequest setInvalidUserId(String invalidUserId) {
        this.invalidUserId = invalidUserId;
        return this;
    }
    public String getInvalidUserId() {
        return this.invalidUserId;
    }

    public InvalidSignRecordsRequest setSignRecordIds(java.util.List<String> signRecordIds) {
        this.signRecordIds = signRecordIds;
        return this;
    }
    public java.util.List<String> getSignRecordIds() {
        return this.signRecordIds;
    }

    public InvalidSignRecordsRequest setStatusRemark(String statusRemark) {
        this.statusRemark = statusRemark;
        return this;
    }
    public String getStatusRemark() {
        return this.statusRemark;
    }

}
