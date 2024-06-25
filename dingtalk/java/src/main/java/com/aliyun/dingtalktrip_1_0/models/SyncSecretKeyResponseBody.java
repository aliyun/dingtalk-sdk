// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncSecretKeyResponseBody extends TeaModel {
    @NameInMap("result")
    public SyncSecretKeyResponseBodyResult result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
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
         * <strong>example:</strong>
         * <p>dsiuuuuiasudnuai</p>
         */
        @NameInMap("secretString")
        public String secretString;

        /**
         * <strong>example:</strong>
         * <p>ding001</p>
         */
        @NameInMap("targetCorpId")
        public String targetCorpId;

        /**
         * <strong>example:</strong>
         * <p>dingwieudsiu</p>
         */
        @NameInMap("tripAppKey")
        public String tripAppKey;

        /**
         * <strong>example:</strong>
         * <p>dusuduiidvs</p>
         */
        @NameInMap("tripAppSecurity")
        public String tripAppSecurity;

        /**
         * <strong>example:</strong>
         * <p>isv001</p>
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
