// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class GetDataListResponseBody extends TeaModel {
    /**
     * <p>数据列表</p>
     */
    @NameInMap("data")
    public java.util.List<GetDataListResponseBodyData> data;

    /**
     * <p>字段明细</p>
     */
    @NameInMap("dataname")
    public java.util.Map<String, String> dataname;

    /**
     * <p>当前页码</p>
     */
    @NameInMap("page")
    public Long page;

    /**
     * <p>分页条数</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <p>响应时间</p>
     */
    @NameInMap("time")
    public String time;

    /**
     * <p>总条数</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static GetDataListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDataListResponseBody self = new GetDataListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDataListResponseBody setData(java.util.List<GetDataListResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetDataListResponseBodyData> getData() {
        return this.data;
    }

    public GetDataListResponseBody setDataname(java.util.Map<String, String> dataname) {
        this.dataname = dataname;
        return this;
    }
    public java.util.Map<String, String> getDataname() {
        return this.dataname;
    }

    public GetDataListResponseBody setPage(Long page) {
        this.page = page;
        return this;
    }
    public Long getPage() {
        return this.page;
    }

    public GetDataListResponseBody setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public GetDataListResponseBody setTime(String time) {
        this.time = time;
        return this;
    }
    public String getTime() {
        return this.time;
    }

    public GetDataListResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetDataListResponseBodyData extends TeaModel {
        @NameInMap("detail")
        public java.util.Map<String, String> detail;

        public static GetDataListResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetDataListResponseBodyData self = new GetDataListResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetDataListResponseBodyData setDetail(java.util.Map<String, String> detail) {
            this.detail = detail;
            return this;
        }
        public java.util.Map<String, String> getDetail() {
            return this.detail;
        }

    }

}
