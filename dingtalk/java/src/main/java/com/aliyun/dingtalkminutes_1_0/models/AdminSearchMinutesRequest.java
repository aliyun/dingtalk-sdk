// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class AdminSearchMinutesRequest extends TeaModel {
    @NameInMap("creatorUnionIds")
    public java.util.List<String> creatorUnionIds;

    /**
     * <strong>example:</strong>
     * <p>1700100000000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>会议纪要</p>
     */
    @NameInMap("query")
    public String query;

    /**
     * <strong>example:</strong>
     * <p>fulltext</p>
     */
    @NameInMap("searchType")
    public String searchType;

    /**
     * <strong>example:</strong>
     * <p>1700000000000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static AdminSearchMinutesRequest build(java.util.Map<String, ?> map) throws Exception {
        AdminSearchMinutesRequest self = new AdminSearchMinutesRequest();
        return TeaModel.build(map, self);
    }

    public AdminSearchMinutesRequest setCreatorUnionIds(java.util.List<String> creatorUnionIds) {
        this.creatorUnionIds = creatorUnionIds;
        return this;
    }
    public java.util.List<String> getCreatorUnionIds() {
        return this.creatorUnionIds;
    }

    public AdminSearchMinutesRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public AdminSearchMinutesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public AdminSearchMinutesRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public AdminSearchMinutesRequest setQuery(String query) {
        this.query = query;
        return this;
    }
    public String getQuery() {
        return this.query;
    }

    public AdminSearchMinutesRequest setSearchType(String searchType) {
        this.searchType = searchType;
        return this;
    }
    public String getSearchType() {
        return this.searchType;
    }

    public AdminSearchMinutesRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public AdminSearchMinutesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
