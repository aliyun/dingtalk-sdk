// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetLeaveRecordsRequest extends TeaModel {
    /**
     * <p>假期类型唯一标识。</p>
     */
    @NameInMap("leaveCode")
    public String leaveCode;

    /**
     * <p>操作人userId。</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>分页页码。</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>分页大小。</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>查询员工userId列表。一次最多支持50个。</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetLeaveRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetLeaveRecordsRequest self = new GetLeaveRecordsRequest();
        return TeaModel.build(map, self);
    }

    public GetLeaveRecordsRequest setLeaveCode(String leaveCode) {
        this.leaveCode = leaveCode;
        return this;
    }
    public String getLeaveCode() {
        return this.leaveCode;
    }

    public GetLeaveRecordsRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public GetLeaveRecordsRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetLeaveRecordsRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetLeaveRecordsRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
