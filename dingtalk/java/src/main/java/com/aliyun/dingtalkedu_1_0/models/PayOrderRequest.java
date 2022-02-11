// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PayOrderRequest extends TeaModel {
    // 人脸id
    @NameInMap("faceId")
    public String faceId;

    // 订单号
    @NameInMap("orderNo")
    public String orderNo;

    // 签名
    @NameInMap("signature")
    public String signature;

    // 设备序列号
    @NameInMap("sn")
    public String sn;

    // utc时间戳
    @NameInMap("timestamp")
    public Long timestamp;

    // 员工id
    @NameInMap("userId")
    public String userId;

    public static PayOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        PayOrderRequest self = new PayOrderRequest();
        return TeaModel.build(map, self);
    }

    public PayOrderRequest setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

    public PayOrderRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public PayOrderRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public PayOrderRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public PayOrderRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

    public PayOrderRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
