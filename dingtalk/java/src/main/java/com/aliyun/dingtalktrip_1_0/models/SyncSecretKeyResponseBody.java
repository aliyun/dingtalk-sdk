// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncSecretKeyResponseBody extends TeaModel {
    @NameInMap("result")
    public SyncSecretKeyResponseBodyResult result;

    /**
     * <p>是否成功</p>
     * <br>
     */
    @NameInMap("success")
    public String success;

    public static SyncSecretKeyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncSecretKeyResponseBody self = new SyncSecretKeyResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncSecretKeyResponseBody setResult(SyncSecretKeyResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SyncSecretKeyResponseBodyResult getResult() {
        return this.result;
    }

    public SyncSecretKeyResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class SyncSecretKeyResponseBodyResult extends TeaModel {
        /**
         * <p>验签加密串</p>
         */
        @NameInMap("secretString")
        public String secretString;

        /**
         * <p>钉钉侧对应的组织ID</p>
         */
        @NameInMap("targetCorpId")
        public String targetCorpId;

        /**
         * <p>商旅侧对接key</p>
         */
        @NameInMap("tripAppKey")
        public String tripAppKey;

        /**
         * <p>商旅侧对接密钥</p>
         */
        @NameInMap("tripAppSecurity")
        public String tripAppSecurity;

        /**
         * <p>商旅侧对应的组织ID</p>
         */
        @NameInMap("tripCorpId")
        public String tripCorpId;

        public static SyncSecretKeyResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SyncSecretKeyResponseBodyResult self = new SyncSecretKeyResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SyncSecretKeyResponseBodyResult setSecretString(String secretString) {
            this.secretString = secretString;
            return this;
        }
        public String getSecretString() {
            return this.secretString;
        }

        public SyncSecretKeyResponseBodyResult setTargetCorpId(String targetCorpId) {
            this.targetCorpId = targetCorpId;
            return this;
        }
        public String getTargetCorpId() {
            return this.targetCorpId;
        }

        public SyncSecretKeyResponseBodyResult setTripAppKey(String tripAppKey) {
            this.tripAppKey = tripAppKey;
            return this;
        }
        public String getTripAppKey() {
            return this.tripAppKey;
        }

        public SyncSecretKeyResponseBodyResult setTripAppSecurity(String tripAppSecurity) {
            this.tripAppSecurity = tripAppSecurity;
            return this;
        }
        public String getTripAppSecurity() {
            return this.tripAppSecurity;
        }

        public SyncSecretKeyResponseBodyResult setTripCorpId(String tripCorpId) {
            this.tripCorpId = tripCorpId;
            return this;
        }
        public String getTripCorpId() {
            return this.tripCorpId;
        }

    }

}
