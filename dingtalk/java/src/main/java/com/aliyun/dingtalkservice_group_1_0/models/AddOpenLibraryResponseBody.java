// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenLibraryResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     */
    @NameInMap("result")
    public AddOpenLibraryResponseBodyResult result;

    /**
     * <p>请求是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static AddOpenLibraryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddOpenLibraryResponseBody self = new AddOpenLibraryResponseBody();
        return TeaModel.build(map, self);
    }

    public AddOpenLibraryResponseBody setResult(AddOpenLibraryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddOpenLibraryResponseBodyResult getResult() {
        return this.result;
    }

    public AddOpenLibraryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddOpenLibraryResponseBodyResult extends TeaModel {
        /**
         * <p>知识库ID</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>失败时错误消息</p>
         */
        @NameInMap("message")
        public String message;

        /**
         * <p>添加/修改知识库是否成功</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static AddOpenLibraryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddOpenLibraryResponseBodyResult self = new AddOpenLibraryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddOpenLibraryResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public AddOpenLibraryResponseBodyResult setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

        public AddOpenLibraryResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
