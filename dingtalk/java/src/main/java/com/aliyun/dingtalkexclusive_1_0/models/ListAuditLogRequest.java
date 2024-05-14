// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListAuditLogRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("endDate")
    public Long endDate;

    @NameInMap("nextBizId")
    public Long nextBizId;

    @NameInMap("nextGmtCreate")
    public Long nextGmtCreate;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startDate")
    public Long startDate;

    public static ListAuditLogRequest build(java.util.Map<String, ?> map) throws Exception {
        ListAuditLogRequest self = new ListAuditLogRequest();
        return TeaModel.build(map, self);
    }

    public ListAuditLogRequest setEndDate(Long endDate) {
        this.endDate = endDate;
        return this;
    }
    public Long getEndDate() {
        return this.endDate;
    }

    public ListAuditLogRequest setNextBizId(Long nextBizId) {
        this.nextBizId = nextBizId;
        return this;
    }
    public Long getNextBizId() {
        return this.nextBizId;
    }

    public ListAuditLogRequest setNextGmtCreate(Long nextGmtCreate) {
        this.nextGmtCreate = nextGmtCreate;
        return this;
    }
    public Long getNextGmtCreate() {
        return this.nextGmtCreate;
    }

    public ListAuditLogRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListAuditLogRequest setStartDate(Long startDate) {
        this.startDate = startDate;
        return this;
    }
    public Long getStartDate() {
        return this.startDate;
    }

}
