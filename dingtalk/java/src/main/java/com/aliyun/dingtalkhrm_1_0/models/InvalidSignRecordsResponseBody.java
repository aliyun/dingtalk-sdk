// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class InvalidSignRecordsResponseBody extends TeaModel {
    @NameInMap("result")
    public InvalidSignRecordsResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static InvalidSignRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InvalidSignRecordsResponseBody self = new InvalidSignRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public InvalidSignRecordsResponseBody setResult(InvalidSignRecordsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public InvalidSignRecordsResponseBodyResult getResult() {
        return this.result;
    }

    public InvalidSignRecordsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class InvalidSignRecordsResponseBodyResultFailItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1234566789</p>
         */
        @NameInMap("itemId")
        public String itemId;

        /**
         * <strong>example:</strong>
         * <p>电子签状态变更不合法</p>
         */
        @NameInMap("type")
        public String type;

        public static InvalidSignRecordsResponseBodyResultFailItems build(java.util.Map<String, ?> map) throws Exception {
            InvalidSignRecordsResponseBodyResultFailItems self = new InvalidSignRecordsResponseBodyResultFailItems();
            return TeaModel.build(map, self);
        }

        public InvalidSignRecordsResponseBodyResultFailItems setItemId(String itemId) {
            this.itemId = itemId;
            return this;
        }
        public String getItemId() {
            return this.itemId;
        }

        public InvalidSignRecordsResponseBodyResultFailItems setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class InvalidSignRecordsResponseBodyResultSuccessItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123456789</p>
         */
        @NameInMap("itemId")
        public String itemId;

        public static InvalidSignRecordsResponseBodyResultSuccessItems build(java.util.Map<String, ?> map) throws Exception {
            InvalidSignRecordsResponseBodyResultSuccessItems self = new InvalidSignRecordsResponseBodyResultSuccessItems();
            return TeaModel.build(map, self);
        }

        public InvalidSignRecordsResponseBodyResultSuccessItems setItemId(String itemId) {
            this.itemId = itemId;
            return this;
        }
        public String getItemId() {
            return this.itemId;
        }

    }

    public static class InvalidSignRecordsResponseBodyResult extends TeaModel {
        @NameInMap("failItems")
        public java.util.List<InvalidSignRecordsResponseBodyResultFailItems> failItems;

        @NameInMap("successItems")
        public java.util.List<InvalidSignRecordsResponseBodyResultSuccessItems> successItems;

        public static InvalidSignRecordsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            InvalidSignRecordsResponseBodyResult self = new InvalidSignRecordsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public InvalidSignRecordsResponseBodyResult setFailItems(java.util.List<InvalidSignRecordsResponseBodyResultFailItems> failItems) {
            this.failItems = failItems;
            return this;
        }
        public java.util.List<InvalidSignRecordsResponseBodyResultFailItems> getFailItems() {
            return this.failItems;
        }

        public InvalidSignRecordsResponseBodyResult setSuccessItems(java.util.List<InvalidSignRecordsResponseBodyResultSuccessItems> successItems) {
            this.successItems = successItems;
            return this;
        }
        public java.util.List<InvalidSignRecordsResponseBodyResultSuccessItems> getSuccessItems() {
            return this.successItems;
        }

    }

}
