// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveRuleListResponseBody extends TeaModel {
    @NameInMap("content")
    public AgoalObjectiveRuleListResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static AgoalObjectiveRuleListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalObjectiveRuleListResponseBody self = new AgoalObjectiveRuleListResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalObjectiveRuleListResponseBody setContent(AgoalObjectiveRuleListResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public AgoalObjectiveRuleListResponseBodyContent getContent() {
        return this.content;
    }

    public AgoalObjectiveRuleListResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalObjectiveRuleListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AgoalObjectiveRuleListResponseBodyContent extends TeaModel {
        @NameInMap("pageNumber")
        public Integer pageNumber;

        @NameInMap("pageSize")
        public Integer pageSize;

        @NameInMap("result")
        public java.util.List<OpenObjectiveRuleDTO> result;

        @NameInMap("totalCount")
        public Long totalCount;

        public static AgoalObjectiveRuleListResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            AgoalObjectiveRuleListResponseBodyContent self = new AgoalObjectiveRuleListResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public AgoalObjectiveRuleListResponseBodyContent setPageNumber(Integer pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Integer getPageNumber() {
            return this.pageNumber;
        }

        public AgoalObjectiveRuleListResponseBodyContent setPageSize(Integer pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Integer getPageSize() {
            return this.pageSize;
        }

        public AgoalObjectiveRuleListResponseBodyContent setResult(java.util.List<OpenObjectiveRuleDTO> result) {
            this.result = result;
            return this;
        }
        public java.util.List<OpenObjectiveRuleDTO> getResult() {
            return this.result;
        }

        public AgoalObjectiveRuleListResponseBodyContent setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
