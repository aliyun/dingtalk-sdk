// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OkrObjectivesByUserResponseBody extends TeaModel {
    @NameInMap("content")
    public OkrObjectivesByUserResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static OkrObjectivesByUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OkrObjectivesByUserResponseBody self = new OkrObjectivesByUserResponseBody();
        return TeaModel.build(map, self);
    }

    public OkrObjectivesByUserResponseBody setContent(OkrObjectivesByUserResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public OkrObjectivesByUserResponseBodyContent getContent() {
        return this.content;
    }

    public OkrObjectivesByUserResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public OkrObjectivesByUserResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class OkrObjectivesByUserResponseBodyContent extends TeaModel {
        @NameInMap("result")
        public java.util.List<OpenObjectiveDTO> result;

        /**
         * <strong>example:</strong>
         * <p>15</p>
         */
        @NameInMap("totalCount")
        public Long totalCount;

        public static OkrObjectivesByUserResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            OkrObjectivesByUserResponseBodyContent self = new OkrObjectivesByUserResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public OkrObjectivesByUserResponseBodyContent setResult(java.util.List<OpenObjectiveDTO> result) {
            this.result = result;
            return this;
        }
        public java.util.List<OpenObjectiveDTO> getResult() {
            return this.result;
        }

        public OkrObjectivesByUserResponseBodyContent setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
