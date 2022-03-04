// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPayResultRequest extends TeaModel {
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

    // 用户id
    @NameInMap("userId")
    public String userId;

    // 版本号
    @NameInMap("version")
    public String version;

    public static QueryPayResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPayResultRequest self = new QueryPayResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryPayResultRequest setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

    public QueryPayResultRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public QueryPayResultRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public QueryPayResultRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public QueryPayResultRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

    public QueryPayResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public QueryPayResultRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
