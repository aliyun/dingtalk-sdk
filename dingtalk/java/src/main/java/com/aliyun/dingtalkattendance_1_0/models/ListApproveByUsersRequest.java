// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ListApproveByUsersRequest extends TeaModel {
    /**
     * <p>传入需要查询的审批单类型：</p>
     * <p>● 1：加班</p>
     * <p>● 2：出差、外出</p>
     * <p>● 3：请假</p>
     * <p>● 4:  补卡</p>
     * <p>● 5：外勤审批</p>
     */
    @NameInMap("bizTypes")
    public java.util.List<Integer> bizTypes;

    /**
     * <p>起始日期，Unix时间戳，单位毫秒。（不支持180天前）</p>
     */
    @NameInMap("fromDateTime")
    public Long fromDateTime;

    /**
     * <p>结束日期，Unix时间戳，单位毫秒。（不支持180天前，开始和结束不能超过30天）</p>
     */
    @NameInMap("toDateTime")
    public Long toDateTime;

    /**
     * <p>要查询的人员userId列表，多个userId用逗号分隔，一次最多可传50个</p>
     */
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
