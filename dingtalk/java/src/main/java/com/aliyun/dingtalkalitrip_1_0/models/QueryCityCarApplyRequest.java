// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryCityCarApplyRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("createdEndAt")
    public String createdEndAt;

    @NameInMap("createdStartAt")
    public String createdStartAt;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("thirdPartApplyId")
    public String thirdPartApplyId;

    @NameInMap("userId")
    public String userId;

    public static QueryCityCarApplyRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCityCarApplyRequest self = new QueryCityCarApplyRequest();
        return TeaModel.build(map, self);
    }

    public QueryCityCarApplyRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryCityCarApplyRequest setCreatedEndAt(String createdEndAt) {
        this.createdEndAt = createdEndAt;
        return this;
    }
    public String getCreatedEndAt() {
        return this.createdEndAt;
    }

    public QueryCityCarApplyRequest setCreatedStartAt(String createdStartAt) {
        this.createdStartAt = createdStartAt;
        return this;
    }
    public String getCreatedStartAt() {
        return this.createdStartAt;
    }

    public QueryCityCarApplyRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryCityCarApplyRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryCityCarApplyRequest setThirdPartApplyId(String thirdPartApplyId) {
        this.thirdPartApplyId = thirdPartApplyId;
        return this;
    }
    public String getThirdPartApplyId() {
        return this.thirdPartApplyId;
    }

    public QueryCityCarApplyRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
