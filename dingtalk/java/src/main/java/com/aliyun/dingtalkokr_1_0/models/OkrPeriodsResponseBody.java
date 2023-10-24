// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OkrPeriodsResponseBody extends TeaModel {
    @NameInMap("content")
    public OkrPeriodsResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static OkrPeriodsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OkrPeriodsResponseBody self = new OkrPeriodsResponseBody();
        return TeaModel.build(map, self);
    }

    public OkrPeriodsResponseBody setContent(OkrPeriodsResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public OkrPeriodsResponseBodyContent getContent() {
        return this.content;
    }

    public OkrPeriodsResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public OkrPeriodsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class OkrPeriodsResponseBodyContent extends TeaModel {
        @NameInMap("pageNumber")
        public Integer pageNumber;

        @NameInMap("pageSize")
        public Integer pageSize;

        @NameInMap("result")
        public java.util.List<OpenPeriodDTO> result;

        @NameInMap("totalCount")
        public Long totalCount;

        public static OkrPeriodsResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            OkrPeriodsResponseBodyContent self = new OkrPeriodsResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public OkrPeriodsResponseBodyContent setPageNumber(Integer pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Integer getPageNumber() {
            return this.pageNumber;
        }

        public OkrPeriodsResponseBodyContent setPageSize(Integer pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Integer getPageSize() {
            return this.pageSize;
        }

        public OkrPeriodsResponseBodyContent setResult(java.util.List<OpenPeriodDTO> result) {
            this.result = result;
            return this;
        }
        public java.util.List<OpenPeriodDTO> getResult() {
            return this.result;
        }

        public OkrPeriodsResponseBodyContent setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
