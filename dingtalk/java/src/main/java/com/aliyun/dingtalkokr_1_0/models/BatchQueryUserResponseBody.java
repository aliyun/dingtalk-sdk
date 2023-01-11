// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryUserResponseBody extends TeaModel {
    /**
     * <p>data</p>
     */
    @NameInMap("data")
    public java.util.List<BatchQueryUserResponseBodyData> data;

    /**
     * <p>请求成功的标识。</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static BatchQueryUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryUserResponseBody self = new BatchQueryUserResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryUserResponseBody setData(java.util.List<BatchQueryUserResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<BatchQueryUserResponseBodyData> getData() {
        return this.data;
    }

    public BatchQueryUserResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BatchQueryUserResponseBodyData extends TeaModel {
        /**
         * <p>所属者头像。 ID</p>
         */
        @NameInMap("avatarMediaId")
        public java.io.InputStream avatarMediaId;

        /**
         * <p>所属者头像。 URL</p>
         */
        @NameInMap("avatarUrl")
        public java.io.InputStream avatarUrl;

        /**
         * <p>所属者组织 I。D</p>
         */
        @NameInMap("corpId")
        public java.io.InputStream corpId;

        /**
         * <p>所属者在 OKR 系统中的 ID。</p>
         */
        @NameInMap("id")
        public java.io.InputStream id;

        /**
         * <p>所属者昵称。</p>
         */
        @NameInMap("nickname")
        public java.io.InputStream nickname;

        /**
         * <p>所属者 userId。</p>
         */
        @NameInMap("userId")
        public java.io.InputStream userId;

        public static BatchQueryUserResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryUserResponseBodyData self = new BatchQueryUserResponseBodyData();
            return TeaModel.build(map, self);
        }

        public BatchQueryUserResponseBodyData setAvatarMediaId(java.io.InputStream avatarMediaId) {
            this.avatarMediaId = avatarMediaId;
            return this;
        }
        public java.io.InputStream getAvatarMediaId() {
            return this.avatarMediaId;
        }

        public BatchQueryUserResponseBodyData setAvatarUrl(java.io.InputStream avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public java.io.InputStream getAvatarUrl() {
            return this.avatarUrl;
        }

        public BatchQueryUserResponseBodyData setCorpId(java.io.InputStream corpId) {
            this.corpId = corpId;
            return this;
        }
        public java.io.InputStream getCorpId() {
            return this.corpId;
        }

        public BatchQueryUserResponseBodyData setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public BatchQueryUserResponseBodyData setNickname(java.io.InputStream nickname) {
            this.nickname = nickname;
            return this;
        }
        public java.io.InputStream getNickname() {
            return this.nickname;
        }

        public BatchQueryUserResponseBodyData setUserId(java.io.InputStream userId) {
            this.userId = userId;
            return this;
        }
        public java.io.InputStream getUserId() {
            return this.userId;
        }

    }

}
