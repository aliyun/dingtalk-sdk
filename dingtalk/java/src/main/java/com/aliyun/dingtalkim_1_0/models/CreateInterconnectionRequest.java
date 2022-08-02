// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateInterconnectionRequest extends TeaModel {
    // 钉外钉内关系列表。
    @NameInMap("interconnections")
    public java.util.List<CreateInterconnectionRequestInterconnections> interconnections;

    public static CreateInterconnectionRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateInterconnectionRequest self = new CreateInterconnectionRequest();
        return TeaModel.build(map, self);
    }

    public CreateInterconnectionRequest setInterconnections(java.util.List<CreateInterconnectionRequestInterconnections> interconnections) {
        this.interconnections = interconnections;
        return this;
    }
    public java.util.List<CreateInterconnectionRequestInterconnections> getInterconnections() {
        return this.interconnections;
    }

    public static class CreateInterconnectionRequestInterconnections extends TeaModel {
        // 钉外用户头像链接。
        @NameInMap("appUserAvatar")
        public String appUserAvatar;

        // 钉外用户头像类型，取值：
        // 1：http
        @NameInMap("appUserAvatarMediaType")
        public Integer appUserAvatarMediaType;

        // 钉外用户动态。
        @NameInMap("appUserDynamics")
        public String appUserDynamics;

        // 钉外用户在业务系统内的唯一标识。
        @NameInMap("appUserId")
        public String appUserId;

        // 钉外用户手机号。
        @NameInMap("appUserMobile")
        public String appUserMobile;

        // 钉外用户名称。
        @NameInMap("appUserName")
        public String appUserName;

        // 渠道code。
        @NameInMap("channelCode")
        public String channelCode;

        // 钉内用户userId。
        @NameInMap("userId")
        public String userId;

        public static CreateInterconnectionRequestInterconnections build(java.util.Map<String, ?> map) throws Exception {
            CreateInterconnectionRequestInterconnections self = new CreateInterconnectionRequestInterconnections();
            return TeaModel.build(map, self);
        }

        public CreateInterconnectionRequestInterconnections setAppUserAvatar(String appUserAvatar) {
            this.appUserAvatar = appUserAvatar;
            return this;
        }
        public String getAppUserAvatar() {
            return this.appUserAvatar;
        }

        public CreateInterconnectionRequestInterconnections setAppUserAvatarMediaType(Integer appUserAvatarMediaType) {
            this.appUserAvatarMediaType = appUserAvatarMediaType;
            return this;
        }
        public Integer getAppUserAvatarMediaType() {
            return this.appUserAvatarMediaType;
        }

        public CreateInterconnectionRequestInterconnections setAppUserDynamics(String appUserDynamics) {
            this.appUserDynamics = appUserDynamics;
            return this;
        }
        public String getAppUserDynamics() {
            return this.appUserDynamics;
        }

        public CreateInterconnectionRequestInterconnections setAppUserId(String appUserId) {
            this.appUserId = appUserId;
            return this;
        }
        public String getAppUserId() {
            return this.appUserId;
        }

        public CreateInterconnectionRequestInterconnections setAppUserMobile(String appUserMobile) {
            this.appUserMobile = appUserMobile;
            return this;
        }
        public String getAppUserMobile() {
            return this.appUserMobile;
        }

        public CreateInterconnectionRequestInterconnections setAppUserName(String appUserName) {
            this.appUserName = appUserName;
            return this;
        }
        public String getAppUserName() {
            return this.appUserName;
        }

        public CreateInterconnectionRequestInterconnections setChannelCode(String channelCode) {
            this.channelCode = channelCode;
            return this;
        }
        public String getChannelCode() {
            return this.channelCode;
        }

        public CreateInterconnectionRequestInterconnections setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
