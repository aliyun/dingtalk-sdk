// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CancelOrderRequest extends TeaModel {
    /**
     * <p>人脸id</p>
     */
    @NameInMap("faceId")
    public String faceId;

    /**
     * <p>订单号</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <p>签名</p>
     */
    @NameInMap("signature")
    public String signature;

    /**
     * <p>设备号</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>utc时间戳</p>
     */
    @NameInMap("timestamp")
    public Long timestamp;

    /**
     * <p>员工id</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CancelOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelOrderRequest self = new CancelOrderRequest();
        return TeaModel.build(map, self);
    }

    public CancelOrderRequest setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

    public CancelOrderRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public CancelOrderRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public CancelOrderRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public CancelOrderRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

    public CancelOrderRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
