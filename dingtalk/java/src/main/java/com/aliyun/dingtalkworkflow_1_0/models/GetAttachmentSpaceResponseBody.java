// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetAttachmentSpaceResponseBody extends TeaModel {
    @NameInMap("result")
    public GetAttachmentSpaceResponseBodyResult result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetAttachmentSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAttachmentSpaceResponseBody self = new GetAttachmentSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAttachmentSpaceResponseBody setResult(GetAttachmentSpaceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetAttachmentSpaceResponseBodyResult getResult() {
        return this.result;
    }

    public GetAttachmentSpaceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetAttachmentSpaceResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>3996960664</p>
         */
        @NameInMap("spaceId")
        public Long spaceId;

        public static GetAttachmentSpaceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetAttachmentSpaceResponseBodyResult self = new GetAttachmentSpaceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetAttachmentSpaceResponseBodyResult setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
