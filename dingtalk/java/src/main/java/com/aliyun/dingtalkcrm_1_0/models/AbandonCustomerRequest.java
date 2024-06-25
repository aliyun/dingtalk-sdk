// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AbandonCustomerRequest extends TeaModel {
    @NameInMap("customTrackDesc")
    public String customTrackDesc;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("instanceIdList")
    public java.util.List<String> instanceIdList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123123123</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    @NameInMap("optType")
    public String optType;

    public static AbandonCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        AbandonCustomerRequest self = new AbandonCustomerRequest();
        return TeaModel.build(map, self);
    }

    public AbandonCustomerRequest setCustomTrackDesc(String customTrackDesc) {
        this.customTrackDesc = customTrackDesc;
        return this;
    }
    public String getCustomTrackDesc() {
        return this.customTrackDesc;
    }

    public AbandonCustomerRequest setInstanceIdList(java.util.List<String> instanceIdList) {
        this.instanceIdList = instanceIdList;
        return this;
    }
    public java.util.List<String> getInstanceIdList() {
        return this.instanceIdList;
    }

    public AbandonCustomerRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public AbandonCustomerRequest setOptType(String optType) {
        this.optType = optType;
        return this;
    }
    public String getOptType() {
        return this.optType;
    }

}
