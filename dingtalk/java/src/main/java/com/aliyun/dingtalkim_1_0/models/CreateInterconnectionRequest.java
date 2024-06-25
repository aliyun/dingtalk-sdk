// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateInterconnectionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>http://***.png</p>
         */
        @NameInMap("appUserAvatar")
        public String appUserAvatar;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("appUserAvatarMediaType")
        public Integer appUserAvatarMediaType;

        /**
         * <strong>example:</strong>
         * <p>认真工作,快乐生活</p>
         */
        @NameInMap("appUserDynamics")
        public String appUserDynamics;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1107****2120</p>
         */
        @NameInMap("appUserId")
        public String appUserId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>188****8655</p>
         */
        @NameInMap("appUserMobile")
        public String appUserMobile;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>Foo</p>
         */
        @NameInMap("appUserName")
        public String appUserName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("channelCode")
        public String channelCode;

        /**
         * <strong>example:</strong>
         * <p>1745****8777</p>
         */
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
