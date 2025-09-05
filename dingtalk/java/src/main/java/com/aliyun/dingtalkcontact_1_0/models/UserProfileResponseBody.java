// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UserProfileResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<UserProfileResponseBodyResult> result;

    public static UserProfileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UserProfileResponseBody self = new UserProfileResponseBody();
        return TeaModel.build(map, self);
    }

    public UserProfileResponseBody setResult(java.util.List<UserProfileResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<UserProfileResponseBodyResult> getResult() {
        return this.result;
    }

    public static class UserProfileResponseBodyResult extends TeaModel {
        @NameInMap("mobile")
        public String mobile;

        @NameInMap("nick")
        public String nick;

        @NameInMap("orgIds")
        public String orgIds;

        @NameInMap("stateCode")
        public String stateCode;

        public static UserProfileResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UserProfileResponseBodyResult self = new UserProfileResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UserProfileResponseBodyResult setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public UserProfileResponseBodyResult setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public UserProfileResponseBodyResult setOrgIds(String orgIds) {
            this.orgIds = orgIds;
            return this;
        }
        public String getOrgIds() {
            return this.orgIds;
        }

        public UserProfileResponseBodyResult setStateCode(String stateCode) {
            this.stateCode = stateCode;
            return this;
        }
        public String getStateCode() {
            return this.stateCode;
        }

    }

}
