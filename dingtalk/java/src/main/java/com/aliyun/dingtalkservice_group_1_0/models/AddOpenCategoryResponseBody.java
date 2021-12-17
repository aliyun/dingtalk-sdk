// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenCategoryResponseBody extends TeaModel {
    // 请求是否成功
    @NameInMap("success")
    public Boolean success;

    // 返回结果
    @NameInMap("result")
    public AddOpenCategoryResponseBodyResult result;

    public static AddOpenCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddOpenCategoryResponseBody self = new AddOpenCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public AddOpenCategoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public AddOpenCategoryResponseBody setResult(AddOpenCategoryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddOpenCategoryResponseBodyResult getResult() {
        return this.result;
    }

    public static class AddOpenCategoryResponseBodyResult extends TeaModel {
        // 操作是否成功
        @NameInMap("success")
        public Boolean success;

        // 添加成类目ID
        @NameInMap("id")
        public Long id;

        // 失败时的错误消息
        @NameInMap("message")
        public String message;

        public static AddOpenCategoryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddOpenCategoryResponseBodyResult self = new AddOpenCategoryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddOpenCategoryResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
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

    }

}
