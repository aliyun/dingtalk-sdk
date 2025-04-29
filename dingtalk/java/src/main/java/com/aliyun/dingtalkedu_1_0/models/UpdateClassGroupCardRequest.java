// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateClassGroupCardRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizCardId")
    public String bizCardId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("classId")
    public Long classId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupTypeList")
    public java.util.List<String> groupTypeList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isFinalUpdate")
    public Boolean isFinalUpdate;

    @NameInMap("privateCardData")
    public java.util.Map<String, java.util.Map<String, ?>> privateCardData;

    @NameInMap("publicCardData")
    public java.util.Map<String, String> publicCardData;

    public static UpdateClassGroupCardRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateClassGroupCardRequest self = new UpdateClassGroupCardRequest();
        return TeaModel.build(map, self);
    }

    public UpdateClassGroupCardRequest setBizCardId(String bizCardId) {
        this.bizCardId = bizCardId;
        return this;
    }
    public String getBizCardId() {
        return this.bizCardId;
    }

    public UpdateClassGroupCardRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public UpdateClassGroupCardRequest setGroupTypeList(java.util.List<String> groupTypeList) {
        this.groupTypeList = groupTypeList;
        return this;
    }
    public java.util.List<String> getGroupTypeList() {
        return this.groupTypeList;
    }

    public UpdateClassGroupCardRequest setIsFinalUpdate(Boolean isFinalUpdate) {
        this.isFinalUpdate = isFinalUpdate;
        return this;
    }
    public Boolean getIsFinalUpdate() {
        return this.isFinalUpdate;
    }

    public UpdateClassGroupCardRequest setPrivateCardData(java.util.Map<String, java.util.Map<String, ?>> privateCardData) {
        this.privateCardData = privateCardData;
        return this;
    }
    public java.util.Map<String, java.util.Map<String, ?>> getPrivateCardData() {
        return this.privateCardData;
    }

    public UpdateClassGroupCardRequest setPublicCardData(java.util.Map<String, String> publicCardData) {
        this.publicCardData = publicCardData;
        return this;
    }
    public java.util.Map<String, String> getPublicCardData() {
        return this.publicCardData;
    }

}
