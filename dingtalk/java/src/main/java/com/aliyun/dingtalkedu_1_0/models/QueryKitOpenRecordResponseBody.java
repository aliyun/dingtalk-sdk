// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryKitOpenRecordResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryKitOpenRecordResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryKitOpenRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryKitOpenRecordResponseBody self = new QueryKitOpenRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryKitOpenRecordResponseBody setResult(QueryKitOpenRecordResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryKitOpenRecordResponseBodyResult getResult() {
        return this.result;
    }

    public QueryKitOpenRecordResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryKitOpenRecordResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{&quot;&quot;}</p>
         */
        @NameInMap("attributes")
        public String attributes;

        /**
         * <strong>example:</strong>
         * <p>dingxxx</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>ISV_XXX</p>
         */
        @NameInMap("isvCode")
        public String isvCode;

        /**
         * <strong>example:</strong>
         * <p>course</p>
         */
        @NameInMap("isvProductScene")
        public String isvProductScene;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("openEndTime")
        public Long openEndTime;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("openStartTime")
        public Long openStartTime;

        /**
         * <strong>example:</strong>
         * <p>staffxxx</p>
         */
        @NameInMap("openUserId")
        public String openUserId;

        public static QueryKitOpenRecordResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryKitOpenRecordResponseBodyResult self = new QueryKitOpenRecordResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryKitOpenRecordResponseBodyResult setAttributes(String attributes) {
            this.attributes = attributes;
            return this;
        }
        public String getAttributes() {
            return this.attributes;
        }

        public QueryKitOpenRecordResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryKitOpenRecordResponseBodyResult setIsvCode(String isvCode) {
            this.isvCode = isvCode;
            return this;
        }
        public String getIsvCode() {
            return this.isvCode;
        }

        public QueryKitOpenRecordResponseBodyResult setIsvProductScene(String isvProductScene) {
            this.isvProductScene = isvProductScene;
            return this;
        }
        public String getIsvProductScene() {
            return this.isvProductScene;
        }

        public QueryKitOpenRecordResponseBodyResult setOpenEndTime(Long openEndTime) {
            this.openEndTime = openEndTime;
            return this;
        }
        public Long getOpenEndTime() {
            return this.openEndTime;
        }

        public QueryKitOpenRecordResponseBodyResult setOpenStartTime(Long openStartTime) {
            this.openStartTime = openStartTime;
            return this;
        }
        public Long getOpenStartTime() {
            return this.openStartTime;
        }

        public QueryKitOpenRecordResponseBodyResult setOpenUserId(String openUserId) {
            this.openUserId = openUserId;
            return this;
        }
        public String getOpenUserId() {
            return this.openUserId;
        }

    }

}
