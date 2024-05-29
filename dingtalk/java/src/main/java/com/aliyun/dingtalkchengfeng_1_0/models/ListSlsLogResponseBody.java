// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListSlsLogResponseBody extends TeaModel {
    @NameInMap("content")
    public ListSlsLogResponseBodyContent content;

    @NameInMap("success")
    public Boolean success;

    public static ListSlsLogResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSlsLogResponseBody self = new ListSlsLogResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSlsLogResponseBody setContent(ListSlsLogResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public ListSlsLogResponseBodyContent getContent() {
        return this.content;
    }

    public ListSlsLogResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListSlsLogResponseBodyContent extends TeaModel {
        @NameInMap("currentPageSize")
        public Long currentPageSize;

        @NameInMap("data")
        public java.util.List<SlsLogResp> data;

        @NameInMap("pageNumber")
        public Long pageNumber;

        @NameInMap("pageSize")
        public Long pageSize;

        @NameInMap("pages")
        public Long pages;

        @NameInMap("totalCount")
        public Long totalCount;

        public static ListSlsLogResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            ListSlsLogResponseBodyContent self = new ListSlsLogResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public ListSlsLogResponseBodyContent setCurrentPageSize(Long currentPageSize) {
            this.currentPageSize = currentPageSize;
            return this;
        }
        public Long getCurrentPageSize() {
            return this.currentPageSize;
        }

        public ListSlsLogResponseBodyContent setData(java.util.List<SlsLogResp> data) {
            this.data = data;
            return this;
        }
        public java.util.List<SlsLogResp> getData() {
            return this.data;
        }

        public ListSlsLogResponseBodyContent setPageNumber(Long pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Long getPageNumber() {
            return this.pageNumber;
        }

        public ListSlsLogResponseBodyContent setPageSize(Long pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Long getPageSize() {
            return this.pageSize;
        }

        public ListSlsLogResponseBodyContent setPages(Long pages) {
            this.pages = pages;
            return this;
        }
        public Long getPages() {
            return this.pages;
        }

        public ListSlsLogResponseBodyContent setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
