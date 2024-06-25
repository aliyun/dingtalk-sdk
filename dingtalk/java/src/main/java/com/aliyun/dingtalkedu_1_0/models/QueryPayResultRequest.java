// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPayResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12312333</p>
     */
    @NameInMap("faceId")
    public String faceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202201240001</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <strong>example:</strong>
     * <p>KSwZiSL1O7DiUNwjV168j3cP9ktp4bJTi5OQxAXre26KyBXza7+gCl/g1d0K3n3+9JhMqc2fUjBiENcAELw3Jb5xO/zslOeV4qFoMQfzW51+sdL/SSZCYvXEMhu9P6FAPhGZQ3vu6gr3oxUAXPIpWNb+sIfzR9epumoOXYeofH8=</p>
     */
    @NameInMap("signature")
    public String signature;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sn1234</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <strong>example:</strong>
     * <p>1644413947909</p>
     */
    @NameInMap("timestamp")
    public Long timestamp;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20200231</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <strong>example:</strong>
     * <p>1.0</p>
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
