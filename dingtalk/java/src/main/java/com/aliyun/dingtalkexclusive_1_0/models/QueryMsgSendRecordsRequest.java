// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryMsgSendRecordsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1766479616000</p>
     */
    @NameInMap("end_time")
    public Long endTime;

    @NameInMap("msgTypeList")
    public java.util.List<String> msgTypeList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("page_number")
    public Integer pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("page_size")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>1766479616000</p>
     */
    @NameInMap("start_time")
    public Long startTime;

    /**
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>jYdrJoCmTo0iE</p>
     */
    @NameInMap("unionid")
    public String unionid;

    public static QueryMsgSendRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMsgSendRecordsRequest self = new QueryMsgSendRecordsRequest();
        return TeaModel.build(map, self);
    }

    public QueryMsgSendRecordsRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryMsgSendRecordsRequest setMsgTypeList(java.util.List<String> msgTypeList) {
        this.msgTypeList = msgTypeList;
        return this;
    }
    public java.util.List<String> getMsgTypeList() {
        return this.msgTypeList;
    }

    public QueryMsgSendRecordsRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryMsgSendRecordsRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryMsgSendRecordsRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryMsgSendRecordsRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public QueryMsgSendRecordsRequest setUnionid(String unionid) {
        this.unionid = unionid;
        return this;
    }
    public String getUnionid() {
        return this.unionid;
    }

}
