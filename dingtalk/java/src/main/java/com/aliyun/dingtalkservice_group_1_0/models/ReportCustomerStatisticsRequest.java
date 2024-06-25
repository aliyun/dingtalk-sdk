// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ReportCustomerStatisticsRequest extends TeaModel {
    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("groupOwnerUserIds")
    public java.util.List<String> groupOwnerUserIds;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("groupTags")
    public java.util.List<String> groupTags;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20220102</p>
     */
    @NameInMap("maxDt")
    public String maxDt;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20220101</p>
     */
    @NameInMap("minDt")
    public String minDt;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    /**
     * <strong>example:</strong>
     * <p>iFoqrhLQDtK</p>
     */
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>iSoqrhLQDtK</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20</p>
     */
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
