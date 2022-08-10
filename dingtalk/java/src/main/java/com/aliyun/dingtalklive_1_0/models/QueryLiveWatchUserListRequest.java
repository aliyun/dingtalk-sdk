// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryLiveWatchUserListRequest extends TeaModel {
    // 直播id
    @NameInMap("liveId")
    public String liveId;

    // 分页起始位置
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static QueryLiveWatchUserListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryLiveWatchUserListRequest self = new QueryLiveWatchUserListRequest();
        return TeaModel.build(map, self);
    }

    public QueryLiveWatchUserListRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public QueryLiveWatchUserListRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryLiveWatchUserListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryLiveWatchUserListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
