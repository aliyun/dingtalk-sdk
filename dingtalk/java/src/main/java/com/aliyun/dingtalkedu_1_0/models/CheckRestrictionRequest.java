// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CheckRestrictionRequest extends TeaModel {
    // 实付金额，单位分
    @NameInMap("actualAmount")
    public Long actualAmount;

    // 人脸id
    @NameInMap("faceId")
    public String faceId;

    // 场景
    @NameInMap("scene")
    public Long scene;

    // 设备号
    @NameInMap("sn")
    public String sn;

    // 员工id
    @NameInMap("userId")
    public String userId;

    public static CheckRestrictionRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckRestrictionRequest self = new CheckRestrictionRequest();
        return TeaModel.build(map, self);
    }

    public CheckRestrictionRequest setActualAmount(Long actualAmount) {
        this.actualAmount = actualAmount;
        return this;
    }
    public Long getActualAmount() {
        return this.actualAmount;
    }

    public CheckRestrictionRequest setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

    public CheckRestrictionRequest setScene(Long scene) {
        this.scene = scene;
        return this;
    }
    public Long getScene() {
        return this.scene;
    }

    public CheckRestrictionRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public CheckRestrictionRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
