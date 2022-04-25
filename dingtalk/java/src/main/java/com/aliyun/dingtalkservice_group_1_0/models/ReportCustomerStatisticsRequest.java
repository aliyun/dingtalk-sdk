// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ReportCustomerStatisticsRequest extends TeaModel {
    // 群主列表
    @NameInMap("groupOwnerUserIds")
    public java.util.List<String> groupOwnerUserIds;

    // 群标签列表
    @NameInMap("groupTags")
    public java.util.List<String> groupTags;

    // 截止日期
    @NameInMap("maxDt")
    public String maxDt;

    // 起始日期
    @NameInMap("minDt")
    public String minDt;

    // 开放群id列表
    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    // 开放群组id
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    // 开发团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 页码
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 每页大小
    @NameInMap("pageSize")
    public Long pageSize;

    public static ReportCustomerStatisticsRequest build(java.util.Map<String, ?> map) throws Exception {
        ReportCustomerStatisticsRequest self = new ReportCustomerStatisticsRequest();
        return TeaModel.build(map, self);
    }

    public ReportCustomerStatisticsRequest setGroupOwnerUserIds(java.util.List<String> groupOwnerUserIds) {
        this.groupOwnerUserIds = groupOwnerUserIds;
        return this;
    }
    public java.util.List<String> getGroupOwnerUserIds() {
        return this.groupOwnerUserIds;
    }

    public ReportCustomerStatisticsRequest setGroupTags(java.util.List<String> groupTags) {
        this.groupTags = groupTags;
        return this;
    }
    public java.util.List<String> getGroupTags() {
        return this.groupTags;
    }

    public ReportCustomerStatisticsRequest setMaxDt(String maxDt) {
        this.maxDt = maxDt;
        return this;
    }
    public String getMaxDt() {
        return this.maxDt;
    }

    public ReportCustomerStatisticsRequest setMinDt(String minDt) {
        this.minDt = minDt;
        return this;
    }
    public String getMinDt() {
        return this.minDt;
    }

    public ReportCustomerStatisticsRequest setOpenConversationIds(java.util.List<String> openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public java.util.List<String> getOpenConversationIds() {
        return this.openConversationIds;
    }

    public ReportCustomerStatisticsRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public ReportCustomerStatisticsRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public ReportCustomerStatisticsRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public ReportCustomerStatisticsRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
