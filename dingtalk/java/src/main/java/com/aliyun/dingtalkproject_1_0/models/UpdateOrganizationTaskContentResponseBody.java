// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskContentResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateOrganizationTaskContentResponseBodyResult result;

    public static UpdateOrganizationTaskContentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskContentResponseBody self = new UpdateOrganizationTaskContentResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskContentResponseBody setResult(UpdateOrganizationTaskContentResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateOrganizationTaskContentResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateOrganizationTaskContentResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("updated")
        public String updated;

        public static UpdateOrganizationTaskContentResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateOrganizationTaskContentResponseBodyResult self = new UpdateOrganizationTaskContentResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateOrganizationTaskContentResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public UpdateOrganizationTaskContentResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
