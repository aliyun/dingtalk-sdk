// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class GetBaseProfileListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetBaseProfileListResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static GetBaseProfileListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetBaseProfileListResponseBody self = new GetBaseProfileListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetBaseProfileListResponseBody setResult(java.util.List<GetBaseProfileListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetBaseProfileListResponseBodyResult> getResult() {
        return this.result;
    }

    public GetBaseProfileListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetBaseProfileListResponseBodyResult extends TeaModel {
        @NameInMap("avatarMediaId")
        public String avatarMediaId;

        @NameInMap("nick")
        public String nick;

        @NameInMap("nickPinyin")
        public String nickPinyin;

        @NameInMap("userId")
        public String userId;

        public static GetBaseProfileListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetBaseProfileListResponseBodyResult self = new GetBaseProfileListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetBaseProfileListResponseBodyResult setAvatarMediaId(String avatarMediaId) {
            this.avatarMediaId = avatarMediaId;
            return this;
        }
        public String getAvatarMediaId() {
            return this.avatarMediaId;
        }

        public GetBaseProfileListResponseBodyResult setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public GetBaseProfileListResponseBodyResult setNickPinyin(String nickPinyin) {
            this.nickPinyin = nickPinyin;
            return this;
        }
        public String getNickPinyin() {
            return this.nickPinyin;
        }

        public GetBaseProfileListResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
