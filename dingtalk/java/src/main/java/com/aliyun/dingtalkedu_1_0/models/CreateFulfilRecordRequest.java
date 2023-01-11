// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateFulfilRecordRequest extends TeaModel {
    /**
     * <p>业务发生时间</p>
     */
    @NameInMap("bizTime")
    public Long bizTime;

    /**
     * <p>扩展信息，json格式</p>
     */
    @NameInMap("extInfo")
    public String extInfo;

    /**
     * <p>人脸id</p>
     */
    @NameInMap("faceId")
    public String faceId;

    /**
     * <p>场景</p>
     */
    @NameInMap("scene")
    public Long scene;

    /**
     * <p>设备sn号</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>员工id</p>
     */
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
