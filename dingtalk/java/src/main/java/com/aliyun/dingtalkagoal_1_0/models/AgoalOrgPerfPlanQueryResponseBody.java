// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgPerfPlanQueryResponseBody extends TeaModel {
    @NameInMap("content")
    public AgoalOrgPerfPlanQueryResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static AgoalOrgPerfPlanQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgPerfPlanQueryResponseBody self = new AgoalOrgPerfPlanQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalOrgPerfPlanQueryResponseBody setContent(AgoalOrgPerfPlanQueryResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public AgoalOrgPerfPlanQueryResponseBodyContent getContent() {
        return this.content;
    }

    public AgoalOrgPerfPlanQueryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalOrgPerfPlanQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AgoalOrgPerfPlanQueryResponseBodyContent extends TeaModel {
        @NameInMap("pageNumber")
        public Integer pageNumber;

        @NameInMap("pageSize")
        public Integer pageSize;

        @NameInMap("result")
        public java.util.List<OpenOrgPerfPlanDTO> result;

        @NameInMap("totalCount")
        public Long totalCount;

        public static AgoalOrgPerfPlanQueryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            AgoalOrgPerfPlanQueryResponseBodyContent self = new AgoalOrgPerfPlanQueryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public AgoalOrgPerfPlanQueryResponseBodyContent setPageNumber(Integer pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Integer getPageNumber() {
            return this.pageNumber;
        }

        public AgoalOrgPerfPlanQueryResponseBodyContent setPageSize(Integer pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Integer getPageSize() {
            return this.pageSize;
        }

        public AgoalOrgPerfPlanQueryResponseBodyContent setResult(java.util.List<OpenOrgPerfPlanDTO> result) {
            this.result = result;
            return this;
        }
        public java.util.List<OpenOrgPerfPlanDTO> getResult() {
            return this.result;
        }

        public AgoalOrgPerfPlanQueryResponseBodyContent setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
