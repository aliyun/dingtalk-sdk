// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPayResultRequest extends TeaModel {
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
     * <p>设备序列号</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>utc时间戳</p>
     */
    @NameInMap("timestamp")
    public Long timestamp;

    /**
     * <p>用户id</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>版本号</p>
     */
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
