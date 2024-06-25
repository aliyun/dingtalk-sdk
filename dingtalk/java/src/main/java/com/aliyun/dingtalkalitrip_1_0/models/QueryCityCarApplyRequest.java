// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryCityCarApplyRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>corpx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>2021-03-18 20:26:56</p>
     */
    @NameInMap("createdEndAt")
    public String createdEndAt;

    /**
     * <strong>example:</strong>
     * <p>2021-03-18 20:26:56</p>
     */
    @NameInMap("createdStartAt")
    public String createdStartAt;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <strong>example:</strong>
     * <p>apply1</p>
     */
    @NameInMap("thirdPartApplyId")
    public String thirdPartApplyId;

    /**
     * <strong>example:</strong>
     * <p>user1</p>
     */
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
