// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskContentResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateTaskContentResponseBodyResult result;

    public static UpdateTaskContentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskContentResponseBody self = new UpdateTaskContentResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTaskContentResponseBody setResult(UpdateTaskContentResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateTaskContentResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateTaskContentResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>更改后的标题</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static UpdateTaskContentResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateTaskContentResponseBodyResult self = new UpdateTaskContentResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateTaskContentResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public UpdateTaskContentResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
