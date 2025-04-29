// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PushClassGroupCardRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("classId")
    public Long classId;

    @NameInMap("groupTypeList")
    public java.util.List<String> groupTypeList;

    @NameInMap("privateCardData")
    public java.util.Map<String, java.util.Map<String, ?>> privateCardData;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("publicCardData")
    public java.util.Map<String, String> publicCardData;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("senderUserId")
    public String senderUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("studentUserIds")
    public java.util.List<String> studentUserIds;

    public static PushClassGroupCardRequest build(java.util.Map<String, ?> map) throws Exception {
        PushClassGroupCardRequest self = new PushClassGroupCardRequest();
        return TeaModel.build(map, self);
    }

    public PushClassGroupCardRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public PushClassGroupCardRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public PushClassGroupCardRequest setGroupTypeList(java.util.List<String> groupTypeList) {
        this.groupTypeList = groupTypeList;
        return this;
    }
    public java.util.List<String> getGroupTypeList() {
        return this.groupTypeList;
    }

    public PushClassGroupCardRequest setPrivateCardData(java.util.Map<String, java.util.Map<String, ?>> privateCardData) {
        this.privateCardData = privateCardData;
        return this;
    }
    public java.util.Map<String, java.util.Map<String, ?>> getPrivateCardData() {
        return this.privateCardData;
    }

    public PushClassGroupCardRequest setPublicCardData(java.util.Map<String, String> publicCardData) {
        this.publicCardData = publicCardData;
        return this;
    }
    public java.util.Map<String, String> getPublicCardData() {
        return this.publicCardData;
    }

    public PushClassGroupCardRequest setSenderUserId(String senderUserId) {
        this.senderUserId = senderUserId;
        return this;
    }
    public String getSenderUserId() {
        return this.senderUserId;
    }

    public PushClassGroupCardRequest setStudentUserIds(java.util.List<String> studentUserIds) {
        this.studentUserIds = studentUserIds;
        return this;
    }
    public java.util.List<String> getStudentUserIds() {
        return this.studentUserIds;
    }

}
