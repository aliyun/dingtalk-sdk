// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class CheckOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>corp1234</p>
     */
    @NameInMap("channelCorpId")
    public String channelCorpId;

    /**
     * <strong>example:</strong>
     * <p>be5f1dce-5a15-451a-8be5-2bfe8836b2c3</p>
     */
    @NameInMap("journeyBizNo")
    public String journeyBizNo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("orderType")
    public String orderType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ljzvGcPYSkyqZ6FsbziK4w10171764232149</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("staffId")
    public String staffId;

    public static CheckOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckOrderRequest self = new CheckOrderRequest();
        return TeaModel.build(map, self);
    }

    public CheckOrderRequest setChannelCorpId(String channelCorpId) {
        this.channelCorpId = channelCorpId;
        return this;
    }
    public String getChannelCorpId() {
        return this.channelCorpId;
    }

    public CheckOrderRequest setJourneyBizNo(String journeyBizNo) {
        this.journeyBizNo = journeyBizNo;
        return this;
    }
    public String getJourneyBizNo() {
        return this.journeyBizNo;
    }

    public CheckOrderRequest setOrderType(String orderType) {
        this.orderType = orderType;
        return this;
    }
    public String getOrderType() {
        return this.orderType;
    }

    public CheckOrderRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public CheckOrderRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

}
