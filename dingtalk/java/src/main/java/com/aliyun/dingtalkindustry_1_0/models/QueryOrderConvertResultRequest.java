// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryOrderConvertResultRequest extends TeaModel {
    @NameInMap("contentSearch")
    public String contentSearch;

    @NameInMap("createTimeEnd")
    public Long createTimeEnd;

    @NameInMap("createTimeStart")
    public Long createTimeStart;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageNo")
    public Long pageNo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("status")
    public String status;

    @NameInMap("title")
    public String title;

    @NameInMap("userId")
    public String userId;

    public static QueryOrderConvertResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOrderConvertResultRequest self = new QueryOrderConvertResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryOrderConvertResultRequest setContentSearch(String contentSearch) {
        this.contentSearch = contentSearch;
        return this;
    }
    public String getContentSearch() {
        return this.contentSearch;
    }

    public QueryOrderConvertResultRequest setCreateTimeEnd(Long createTimeEnd) {
        this.createTimeEnd = createTimeEnd;
        return this;
    }
    public Long getCreateTimeEnd() {
        return this.createTimeEnd;
    }

    public QueryOrderConvertResultRequest setCreateTimeStart(Long createTimeStart) {
        this.createTimeStart = createTimeStart;
        return this;
    }
    public Long getCreateTimeStart() {
        return this.createTimeStart;
    }

    public QueryOrderConvertResultRequest setPageNo(Long pageNo) {
        this.pageNo = pageNo;
        return this;
    }
    public Long getPageNo() {
        return this.pageNo;
    }

    public QueryOrderConvertResultRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryOrderConvertResultRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public QueryOrderConvertResultRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public QueryOrderConvertResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
