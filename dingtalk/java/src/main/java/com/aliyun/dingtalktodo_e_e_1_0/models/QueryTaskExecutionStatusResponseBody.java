// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class QueryTaskExecutionStatusResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<QueryTaskExecutionStatusResponseBodyData> data;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static QueryTaskExecutionStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTaskExecutionStatusResponseBody self = new QueryTaskExecutionStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTaskExecutionStatusResponseBody setData(java.util.List<QueryTaskExecutionStatusResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<QueryTaskExecutionStatusResponseBodyData> getData() {
        return this.data;
    }

    public QueryTaskExecutionStatusResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryTaskExecutionStatusResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryTaskExecutionStatusResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryTaskExecutionStatusResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class QueryTaskExecutionStatusResponseBodyData extends TeaModel {
        @NameInMap("done")
        public Boolean done;

        @NameInMap("executorId")
        public String executorId;

        @NameInMap("finishDate")
        public Long finishDate;

        public static QueryTaskExecutionStatusResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            QueryTaskExecutionStatusResponseBodyData self = new QueryTaskExecutionStatusResponseBodyData();
            return TeaModel.build(map, self);
        }

        public QueryTaskExecutionStatusResponseBodyData setDone(Boolean done) {
            this.done = done;
            return this;
        }
        public Boolean getDone() {
            return this.done;
        }

        public QueryTaskExecutionStatusResponseBodyData setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public QueryTaskExecutionStatusResponseBodyData setFinishDate(Long finishDate) {
            this.finishDate = finishDate;
            return this;
        }
        public Long getFinishDate() {
            return this.finishDate;
        }

    }

}
