// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenCategoryResponseBody extends TeaModel {
    @NameInMap("result")
    public AddOpenCategoryResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AddOpenCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddOpenCategoryResponseBody self = new AddOpenCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public AddOpenCategoryResponseBody setResult(AddOpenCategoryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddOpenCategoryResponseBodyResult getResult() {
        return this.result;
    }

    public AddOpenCategoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddOpenCategoryResponseBodyResult extends TeaModel {
        @NameInMap("id")
        public Long id;

        @NameInMap("message")
        public String message;

        @NameInMap("success")
        public Boolean success;

        public static AddOpenCategoryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddOpenCategoryResponseBodyResult self = new AddOpenCategoryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddOpenCategoryResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public AddOpenCategoryResponseBodyResult setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

        public AddOpenCategoryResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
