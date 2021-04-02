// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryCityCarApplyRequest extends TeaModel {
    // 第三方企业ID
    @NameInMap("corpId")
    public String corpId;

    // 审批单创建时间小于值
    @NameInMap("createdEndAt")
    public String createdEndAt;

    // 审批单创建时间大于等于值
    @NameInMap("createdStartAt")
    public String createdStartAt;

    // 页码，要求大于等于1，默认1
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 每页数据量，要求大于等于1，默认20
    @NameInMap("pageSize")
    public Long pageSize;

    // 三方审批单ID
    @NameInMap("thirdPartApplyId")
    public String thirdPartApplyId;

    // 第三方员工ID
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
