// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RevokeSignRecordsResponseBody extends TeaModel {
    @NameInMap("result")
    public RevokeSignRecordsResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static RevokeSignRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RevokeSignRecordsResponseBody self = new RevokeSignRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public RevokeSignRecordsResponseBody setResult(RevokeSignRecordsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public RevokeSignRecordsResponseBodyResult getResult() {
        return this.result;
    }

    public RevokeSignRecordsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class RevokeSignRecordsResponseBodyResultFailItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>6fe06f57ab5a45078f3219be8fd829c6</p>
         */
        @NameInMap("itemId")
        public String itemId;

        /**
         * <strong>example:</strong>
         * <p>电子签状态变更不合法</p>
         */
        @NameInMap("type")
        public String type;

        public static RevokeSignRecordsResponseBodyResultFailItems build(java.util.Map<String, ?> map) throws Exception {
            RevokeSignRecordsResponseBodyResultFailItems self = new RevokeSignRecordsResponseBodyResultFailItems();
            return TeaModel.build(map, self);
        }

        public RevokeSignRecordsResponseBodyResultFailItems setItemId(String itemId) {
            this.itemId = itemId;
            return this;
        }
        public String getItemId() {
            return this.itemId;
        }

        public RevokeSignRecordsResponseBodyResultFailItems setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class RevokeSignRecordsResponseBodyResultSuccessItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>6fe06f57ab5a45078f3219be8fd829c6</p>
         */
        @NameInMap("itemId")
        public String itemId;

        public static RevokeSignRecordsResponseBodyResultSuccessItems build(java.util.Map<String, ?> map) throws Exception {
            RevokeSignRecordsResponseBodyResultSuccessItems self = new RevokeSignRecordsResponseBodyResultSuccessItems();
            return TeaModel.build(map, self);
        }

        public RevokeSignRecordsResponseBodyResultSuccessItems setItemId(String itemId) {
            this.itemId = itemId;
            return this;
        }
        public String getItemId() {
            return this.itemId;
        }

    }

    public static class RevokeSignRecordsResponseBodyResult extends TeaModel {
        @NameInMap("failItems")
        public java.util.List<RevokeSignRecordsResponseBodyResultFailItems> failItems;

        @NameInMap("successItems")
        public java.util.List<RevokeSignRecordsResponseBodyResultSuccessItems> successItems;

        public static RevokeSignRecordsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            RevokeSignRecordsResponseBodyResult self = new RevokeSignRecordsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public RevokeSignRecordsResponseBodyResult setFailItems(java.util.List<RevokeSignRecordsResponseBodyResultFailItems> failItems) {
            this.failItems = failItems;
            return this;
        }
        public java.util.List<RevokeSignRecordsResponseBodyResultFailItems> getFailItems() {
            return this.failItems;
        }

        public RevokeSignRecordsResponseBodyResult setSuccessItems(java.util.List<RevokeSignRecordsResponseBodyResultSuccessItems> successItems) {
            this.successItems = successItems;
            return this;
        }
        public java.util.List<RevokeSignRecordsResponseBodyResultSuccessItems> getSuccessItems() {
            return this.successItems;
        }

    }

}
