// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveProgressListResponseBody extends TeaModel {
    @NameInMap("content")
    public AgoalObjectiveProgressListResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static AgoalObjectiveProgressListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalObjectiveProgressListResponseBody self = new AgoalObjectiveProgressListResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalObjectiveProgressListResponseBody setContent(AgoalObjectiveProgressListResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public AgoalObjectiveProgressListResponseBodyContent getContent() {
        return this.content;
    }

    public AgoalObjectiveProgressListResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalObjectiveProgressListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AgoalObjectiveProgressListResponseBodyContent extends TeaModel {
        @NameInMap("pageNumber")
        public String pageNumber;

        @NameInMap("pageSize")
        public String pageSize;

        @NameInMap("result")
        public java.util.List<OpenAgoalProgressDTO> result;

        @NameInMap("totalCount")
        public String totalCount;

        public static AgoalObjectiveProgressListResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            AgoalObjectiveProgressListResponseBodyContent self = new AgoalObjectiveProgressListResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public AgoalObjectiveProgressListResponseBodyContent setPageNumber(String pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public String getPageNumber() {
            return this.pageNumber;
        }

        public AgoalObjectiveProgressListResponseBodyContent setPageSize(String pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public String getPageSize() {
            return this.pageSize;
        }

        public AgoalObjectiveProgressListResponseBodyContent setResult(java.util.List<OpenAgoalProgressDTO> result) {
            this.result = result;
            return this;
        }
        public java.util.List<OpenAgoalProgressDTO> getResult() {
            return this.result;
        }

        public AgoalObjectiveProgressListResponseBodyContent setTotalCount(String totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public String getTotalCount() {
            return this.totalCount;
        }

    }

}
