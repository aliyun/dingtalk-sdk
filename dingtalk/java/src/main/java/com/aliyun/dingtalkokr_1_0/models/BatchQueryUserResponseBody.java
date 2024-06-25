// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryUserResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("data")
    public java.util.List<BatchQueryUserResponseBodyData> data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
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
         * <strong>example:</strong>
         * <p>@lADPDh0cQ_j4Mi_NBULNBUA</p>
         */
        @NameInMap("avatarMediaId")
        public java.io.InputStream avatarMediaId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://static.dingtalk.com/media/lADPEj_RiGhUdKjNC9TNC9A_3024_3028.jpg_620x10000q90.jpg">https://static.dingtalk.com/media/lADPEj_RiGhUdKjNC9TNC9A_3024_3028.jpg_620x10000q90.jpg</a></p>
         */
        @NameInMap("avatarUrl")
        public java.io.InputStream avatarUrl;

        /**
         * <strong>example:</strong>
         * <p>ding4d1c8883ff63ee8124f2f5cc6abecb85</p>
         */
        @NameInMap("corpId")
        public java.io.InputStream corpId;

        /**
         * <strong>example:</strong>
         * <p>K1AMgq</p>
         */
        @NameInMap("id")
        public java.io.InputStream id;

        /**
         * <strong>example:</strong>
         * <p>你好</p>
         */
        @NameInMap("nickname")
        public java.io.InputStream nickname;

        /**
         * <strong>example:</strong>
         * <p>06186238011033616</p>
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
