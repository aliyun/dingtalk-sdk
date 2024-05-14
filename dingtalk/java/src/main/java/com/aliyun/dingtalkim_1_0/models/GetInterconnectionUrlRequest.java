// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetInterconnectionUrlRequest extends TeaModel {
    @NameInMap("appUserAvatar")
    public String appUserAvatar;

    @NameInMap("appUserAvatarType")
    public Integer appUserAvatarType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appUserId")
    public String appUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appUserMobileNumber")
    public String appUserMobileNumber;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appUserName")
    public String appUserName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("msgPageType")
    public Integer msgPageType;

    @NameInMap("qrCode")
    public String qrCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("signature")
    public String signature;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sourceCode")
    public String sourceCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sourceType")
    public Integer sourceType;

    @NameInMap("userId")
    public String userId;

    public static GetInterconnectionUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInterconnectionUrlRequest self = new GetInterconnectionUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetInterconnectionUrlRequest setAppUserAvatar(String appUserAvatar) {
        this.appUserAvatar = appUserAvatar;
        return this;
    }
    public String getAppUserAvatar() {
        return this.appUserAvatar;
    }

    public GetInterconnectionUrlRequest setAppUserAvatarType(Integer appUserAvatarType) {
        this.appUserAvatarType = appUserAvatarType;
        return this;
    }
    public Integer getAppUserAvatarType() {
        return this.appUserAvatarType;
    }

    public GetInterconnectionUrlRequest setAppUserId(String appUserId) {
        this.appUserId = appUserId;
        return this;
    }
    public String getAppUserId() {
        return this.appUserId;
    }

    public GetInterconnectionUrlRequest setAppUserMobileNumber(String appUserMobileNumber) {
        this.appUserMobileNumber = appUserMobileNumber;
        return this;
    }
    public String getAppUserMobileNumber() {
        return this.appUserMobileNumber;
    }

    public GetInterconnectionUrlRequest setAppUserName(String appUserName) {
        this.appUserName = appUserName;
        return this;
    }
    public String getAppUserName() {
        return this.appUserName;
    }

    public GetInterconnectionUrlRequest setMsgPageType(Integer msgPageType) {
        this.msgPageType = msgPageType;
        return this;
    }
    public Integer getMsgPageType() {
        return this.msgPageType;
    }

    public GetInterconnectionUrlRequest setQrCode(String qrCode) {
        this.qrCode = qrCode;
        return this;
    }
    public String getQrCode() {
        return this.qrCode;
    }

    public GetInterconnectionUrlRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public GetInterconnectionUrlRequest setSourceCode(String sourceCode) {
        this.sourceCode = sourceCode;
        return this;
    }
    public String getSourceCode() {
        return this.sourceCode;
    }

    public GetInterconnectionUrlRequest setSourceType(Integer sourceType) {
        this.sourceType = sourceType;
        return this;
    }
    public Integer getSourceType() {
        return this.sourceType;
    }

    public GetInterconnectionUrlRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
