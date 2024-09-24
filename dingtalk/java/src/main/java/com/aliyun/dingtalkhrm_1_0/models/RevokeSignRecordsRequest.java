// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RevokeSignRecordsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("revokeUserId")
    public String revokeUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("signRecordIds")
    public java.util.List<String> signRecordIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>撤销签署</p>
     */
    @NameInMap("statusRemark")
    public String statusRemark;

    public static RevokeSignRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        RevokeSignRecordsRequest self = new RevokeSignRecordsRequest();
        return TeaModel.build(map, self);
    }

    public RevokeSignRecordsRequest setRevokeUserId(String revokeUserId) {
        this.revokeUserId = revokeUserId;
        return this;
    }
    public String getRevokeUserId() {
        return this.revokeUserId;
    }

    public RevokeSignRecordsRequest setSignRecordIds(java.util.List<String> signRecordIds) {
        this.signRecordIds = signRecordIds;
        return this;
    }
    public java.util.List<String> getSignRecordIds() {
        return this.signRecordIds;
    }

    public RevokeSignRecordsRequest setStatusRemark(String statusRemark) {
        this.statusRemark = statusRemark;
        return this;
    }
    public String getStatusRemark() {
        return this.statusRemark;
    }

}
