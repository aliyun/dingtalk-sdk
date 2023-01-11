// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AbandonCustomerRequest extends TeaModel {
    /**
     * <p>自定义动态描述</p>
     */
    @NameInMap("customTrackDesc")
    public String customTrackDesc;

    /**
     * <p>客户实例 id 数组</p>
     */
    @NameInMap("instanceIdList")
    public java.util.List<String> instanceIdList;

    /**
     * <p>操作人staffId，一般为企业员工</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>释放类型：returnPool-退回公海（默认），innerAbandon-仅清除负责人</p>
     */
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
