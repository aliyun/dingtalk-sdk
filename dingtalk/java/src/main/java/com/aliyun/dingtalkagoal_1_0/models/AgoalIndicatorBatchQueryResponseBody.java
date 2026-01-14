// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalIndicatorBatchQueryResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<AgoalIndicatorBatchQueryResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static AgoalIndicatorBatchQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalIndicatorBatchQueryResponseBody self = new AgoalIndicatorBatchQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalIndicatorBatchQueryResponseBody setResult(java.util.List<AgoalIndicatorBatchQueryResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<AgoalIndicatorBatchQueryResponseBodyResult> getResult() {
        return this.result;
    }

    public AgoalIndicatorBatchQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AgoalIndicatorBatchQueryResponseBodyResult extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("description")
        public String description;

        @NameInMap("id")
        public String id;

        @NameInMap("title")
        public String title;

        public static AgoalIndicatorBatchQueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AgoalIndicatorBatchQueryResponseBodyResult self = new AgoalIndicatorBatchQueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AgoalIndicatorBatchQueryResponseBodyResult setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public AgoalIndicatorBatchQueryResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public AgoalIndicatorBatchQueryResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public AgoalIndicatorBatchQueryResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
