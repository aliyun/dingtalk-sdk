// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ReportDeviceUseLogRequest extends TeaModel {
    // 操作
    @NameInMap("action")
    public String action;

    // 订单号
    @NameInMap("orderNo")
    public String orderNo;

    // 设备序列号
    @NameInMap("sn")
    public String sn;

    // 员工id
    @NameInMap("userId")
    public String userId;

    public static ReportDeviceUseLogRequest build(java.util.Map<String, ?> map) throws Exception {
        ReportDeviceUseLogRequest self = new ReportDeviceUseLogRequest();
        return TeaModel.build(map, self);
    }

    public ReportDeviceUseLogRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public ReportDeviceUseLogRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public ReportDeviceUseLogRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public ReportDeviceUseLogRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}