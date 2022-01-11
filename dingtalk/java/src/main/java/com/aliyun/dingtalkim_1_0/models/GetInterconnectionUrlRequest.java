// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetInterconnectionUrlRequest extends TeaModel {
    // appUserAvatar
    @NameInMap("appUserAvatar")
    public String appUserAvatar;

    // appUserAvatarType
    @NameInMap("appUserAvatarType")
    public Integer appUserAvatarType;

    // appUserId
    @NameInMap("appUserId")
    public String appUserId;

    // appUserMobileNumber
    @NameInMap("appUserMobileNumber")
    public String appUserMobileNumber;

    // appUserName
    @NameInMap("appUserName")
    public String appUserName;

    // dingCorpId
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // dingUserId
    @NameInMap("dingUserId")
    public String dingUserId;

    // msgPageSettingId
    @NameInMap("msgPageSettingId")
    public Long msgPageSettingId;

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

    public GetInterconnectionUrlRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public GetInterconnectionUrlRequest setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public GetInterconnectionUrlRequest setMsgPageSettingId(Long msgPageSettingId) {
        this.msgPageSettingId = msgPageSettingId;
        return this;
    }
    public Long getMsgPageSettingId() {
        return this.msgPageSettingId;
    }

}
