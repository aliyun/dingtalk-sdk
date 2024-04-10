// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetColumnvalsRequest extends TeaModel {
    @NameInMap("columnIdList")
    public java.util.List<String> columnIdList;

    @NameInMap("fromDate")
    public Long fromDate;

    @NameInMap("toDate")
    public Long toDate;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetColumnvalsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetColumnvalsRequest self = new GetColumnvalsRequest();
        return TeaModel.build(map, self);
    }

    public GetColumnvalsRequest setColumnIdList(java.util.List<String> columnIdList) {
        this.columnIdList = columnIdList;
        return this;
    }
    public java.util.List<String> getColumnIdList() {
        return this.columnIdList;
    }

    public GetColumnvalsRequest setFromDate(Long fromDate) {
        this.fromDate = fromDate;
        return this;
    }
    public Long getFromDate() {
        return this.fromDate;
    }

    public GetColumnvalsRequest setToDate(Long toDate) {
        this.toDate = toDate;
        return this;
    }
    public Long getToDate() {
        return this.toDate;
    }

    public GetColumnvalsRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
