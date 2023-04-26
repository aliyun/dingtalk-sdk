// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateFulfilRecordRequest extends TeaModel {
    @NameInMap("bizTime")
    public Long bizTime;

    @NameInMap("extInfo")
    public String extInfo;

    @NameInMap("faceId")
    public String faceId;

    @NameInMap("scene")
    public Long scene;

    @NameInMap("sn")
    public String sn;

    @NameInMap("userId")
    public String userId;

    public static CreateFulfilRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateFulfilRecordRequest self = new CreateFulfilRecordRequest();
        return TeaModel.build(map, self);
    }

    public CreateFulfilRecordRequest setBizTime(Long bizTime) {
        this.bizTime = bizTime;
        return this;
    }
    public Long getBizTime() {
        return this.bizTime;
    }

    public CreateFulfilRecordRequest setExtInfo(String extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public String getExtInfo() {
        return this.extInfo;
    }

    public CreateFulfilRecordRequest setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

    public CreateFulfilRecordRequest setScene(Long scene) {
        this.scene = scene;
        return this;
    }
    public Long getScene() {
        return this.scene;
    }

    public CreateFulfilRecordRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public CreateFulfilRecordRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
