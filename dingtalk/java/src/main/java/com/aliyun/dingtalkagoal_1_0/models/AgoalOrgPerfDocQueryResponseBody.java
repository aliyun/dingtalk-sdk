// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgPerfDocQueryResponseBody extends TeaModel {
    @NameInMap("content")
    public AgoalOrgPerfDocQueryResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static AgoalOrgPerfDocQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgPerfDocQueryResponseBody self = new AgoalOrgPerfDocQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalOrgPerfDocQueryResponseBody setContent(AgoalOrgPerfDocQueryResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public AgoalOrgPerfDocQueryResponseBodyContent getContent() {
        return this.content;
    }

    public AgoalOrgPerfDocQueryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalOrgPerfDocQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AgoalOrgPerfDocQueryResponseBodyContent extends TeaModel {
        @NameInMap("pageNumber")
        public Integer pageNumber;

        @NameInMap("pageSize")
        public Integer pageSize;

        @NameInMap("result")
        public java.util.List<OpenOrgPerfDocDTO> result;

        @NameInMap("totalCount")
        public Long totalCount;

        public static AgoalOrgPerfDocQueryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            AgoalOrgPerfDocQueryResponseBodyContent self = new AgoalOrgPerfDocQueryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public AgoalOrgPerfDocQueryResponseBodyContent setPageNumber(Integer pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Integer getPageNumber() {
            return this.pageNumber;
        }

        public AgoalOrgPerfDocQueryResponseBodyContent setPageSize(Integer pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Integer getPageSize() {
            return this.pageSize;
        }

        public AgoalOrgPerfDocQueryResponseBodyContent setResult(java.util.List<OpenOrgPerfDocDTO> result) {
            this.result = result;
            return this;
        }
        public java.util.List<OpenOrgPerfDocDTO> getResult() {
            return this.result;
        }

        public AgoalOrgPerfDocQueryResponseBodyContent setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
