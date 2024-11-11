// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PageQueryKitOpenRecordResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<PageQueryKitOpenRecordResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static PageQueryKitOpenRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageQueryKitOpenRecordResponseBody self = new PageQueryKitOpenRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public PageQueryKitOpenRecordResponseBody setResult(java.util.List<PageQueryKitOpenRecordResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<PageQueryKitOpenRecordResponseBodyResult> getResult() {
        return this.result;
    }

    public PageQueryKitOpenRecordResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PageQueryKitOpenRecordResponseBodyResult extends TeaModel {
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

        public static PageQueryKitOpenRecordResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PageQueryKitOpenRecordResponseBodyResult self = new PageQueryKitOpenRecordResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PageQueryKitOpenRecordResponseBodyResult setAttributes(String attributes) {
            this.attributes = attributes;
            return this;
        }
        public String getAttributes() {
            return this.attributes;
        }

        public PageQueryKitOpenRecordResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public PageQueryKitOpenRecordResponseBodyResult setIsvCode(String isvCode) {
            this.isvCode = isvCode;
            return this;
        }
        public String getIsvCode() {
            return this.isvCode;
        }

        public PageQueryKitOpenRecordResponseBodyResult setIsvProductScene(String isvProductScene) {
            this.isvProductScene = isvProductScene;
            return this;
        }
        public String getIsvProductScene() {
            return this.isvProductScene;
        }

        public PageQueryKitOpenRecordResponseBodyResult setOpenEndTime(Long openEndTime) {
            this.openEndTime = openEndTime;
            return this;
        }
        public Long getOpenEndTime() {
            return this.openEndTime;
        }

        public PageQueryKitOpenRecordResponseBodyResult setOpenStartTime(Long openStartTime) {
            this.openStartTime = openStartTime;
            return this;
        }
        public Long getOpenStartTime() {
            return this.openStartTime;
        }

        public PageQueryKitOpenRecordResponseBodyResult setOpenUserId(String openUserId) {
            this.openUserId = openUserId;
            return this;
        }
        public String getOpenUserId() {
            return this.openUserId;
        }

    }

}
