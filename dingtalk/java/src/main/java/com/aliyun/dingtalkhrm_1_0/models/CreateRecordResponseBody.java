// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class CreateRecordResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateRecordResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateRecordResponseBody self = new CreateRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateRecordResponseBody setResult(CreateRecordResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateRecordResponseBodyResult getResult() {
        return this.result;
    }

    public CreateRecordResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateRecordResponseBodyResult extends TeaModel {
        @NameInMap("details")
        public String details;

        @NameInMap("itemId")
        public String itemId;

        @NameInMap("type")
        public String type;

        public static CreateRecordResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateRecordResponseBodyResult self = new CreateRecordResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateRecordResponseBodyResult setDetails(String details) {
            this.details = details;
            return this;
        }
        public String getDetails() {
            return this.details;
        }

        public CreateRecordResponseBodyResult setItemId(String itemId) {
            this.itemId = itemId;
            return this;
        }
        public String getItemId() {
            return this.itemId;
        }

        public CreateRecordResponseBodyResult setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
