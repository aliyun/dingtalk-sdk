// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListAuditLogRequest extends TeaModel {
    /**
     * <p>操作日志截止时间，unix时间戳，单位ms</p>
     */
    @NameInMap("endDate")
    public Long endDate;

    /**
     * <p>操作记录文件id，作为分页偏移量，与nextGmtCreate一起使用，返回记录的bizId为nextBizId且gmtCreate为nextGmtCreate之后的操作列表，分页查询获取下一页时，传最后一条记录的bizId和gmtCreate。</p>
     */
    @NameInMap("nextBizId")
    public Long nextBizId;

    /**
     * <p>操作记录生成时间，作为分页偏移量，分页查询时必传，unix时间戳，单位ms</p>
     */
    @NameInMap("nextGmtCreate")
    public Long nextGmtCreate;

    /**
     * <p>操作列表长度，最大500</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>操作日志起始时间，unix时间戳，单位ms</p>
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
