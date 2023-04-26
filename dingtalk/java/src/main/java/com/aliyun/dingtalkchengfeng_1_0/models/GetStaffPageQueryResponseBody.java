// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetStaffPageQueryResponseBody extends TeaModel {
    @NameInMap("content")
    public GetStaffPageQueryResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    public static GetStaffPageQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetStaffPageQueryResponseBody self = new GetStaffPageQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetStaffPageQueryResponseBody setContent(GetStaffPageQueryResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public GetStaffPageQueryResponseBodyContent getContent() {
        return this.content;
    }

    public GetStaffPageQueryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class GetStaffPageQueryResponseBodyContent extends TeaModel {
        @NameInMap("data")
        public java.util.List<CfStaffResp> data;

        @NameInMap("pageNumber")
        public Integer pageNumber;

        @NameInMap("pageSize")
        public Integer pageSize;

        @NameInMap("totalCount")
        public Long totalCount;

        public static GetStaffPageQueryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            GetStaffPageQueryResponseBodyContent self = new GetStaffPageQueryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public GetStaffPageQueryResponseBodyContent setData(java.util.List<CfStaffResp> data) {
            this.data = data;
            return this;
        }
        public java.util.List<CfStaffResp> getData() {
            return this.data;
        }

        public GetStaffPageQueryResponseBodyContent setPageNumber(Integer pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Integer getPageNumber() {
            return this.pageNumber;
        }

        public GetStaffPageQueryResponseBodyContent setPageSize(Integer pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Integer getPageSize() {
            return this.pageSize;
        }

        public GetStaffPageQueryResponseBodyContent setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
