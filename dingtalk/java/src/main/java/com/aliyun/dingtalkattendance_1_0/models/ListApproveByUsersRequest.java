// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ListApproveByUsersRequest extends TeaModel {
    @NameInMap("bizTypes")
    public java.util.List<Integer> bizTypes;

    @NameInMap("fromDateTime")
    public Long fromDateTime;

    @NameInMap("toDateTime")
    public Long toDateTime;

    @NameInMap("userIds")
    public String userIds;

    public static ListApproveByUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListApproveByUsersRequest self = new ListApproveByUsersRequest();
        return TeaModel.build(map, self);
    }

    public ListApproveByUsersRequest setBizTypes(java.util.List<Integer> bizTypes) {
        this.bizTypes = bizTypes;
        return this;
    }
    public java.util.List<Integer> getBizTypes() {
        return this.bizTypes;
    }

    public ListApproveByUsersRequest setFromDateTime(Long fromDateTime) {
        this.fromDateTime = fromDateTime;
        return this;
    }
    public Long getFromDateTime() {
        return this.fromDateTime;
    }

    public ListApproveByUsersRequest setToDateTime(Long toDateTime) {
        this.toDateTime = toDateTime;
        return this;
    }
    public Long getToDateTime() {
        return this.toDateTime;
    }

    public ListApproveByUsersRequest setUserIds(String userIds) {
        this.userIds = userIds;
        return this;
    }
    public String getUserIds() {
        return this.userIds;
    }

}
