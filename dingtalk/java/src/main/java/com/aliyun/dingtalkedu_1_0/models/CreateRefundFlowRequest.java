// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateRefundFlowRequest extends TeaModel {
    // 人脸id
    @NameInMap("faceId")
    public String faceId;

    // 操作人id
    @NameInMap("operatorId")
    public String operatorId;

    // 操作人名称
    @NameInMap("operatorName")
    public String operatorName;

    // 订单号
    @NameInMap("orderNo")
    public String orderNo;

    // 签名
    @NameInMap("signature")
    public String signature;

    // 设备号
    @NameInMap("sn")
    public String sn;

    // utc时间戳
    @NameInMap("timestamp")
    public Long timestamp;

    // 员工id
    @NameInMap("userId")
    public String userId;

    public static CreateRefundFlowRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateRefundFlowRequest self = new CreateRefundFlowRequest();
        return TeaModel.build(map, self);
    }

    public CreateRefundFlowRequest setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

    public CreateRefundFlowRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateRefundFlowRequest setOperatorName(String operatorName) {
        this.operatorName = operatorName;
        return this;
    }
    public String getOperatorName() {
        return this.operatorName;
    }

    public CreateRefundFlowRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public CreateRefundFlowRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public CreateRefundFlowRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public CreateRefundFlowRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

    public CreateRefundFlowRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
