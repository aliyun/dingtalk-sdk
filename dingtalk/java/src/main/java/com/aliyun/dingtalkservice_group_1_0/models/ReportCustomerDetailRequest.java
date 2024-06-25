// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ReportCustomerDetailRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasLogin")
    public Boolean hasLogin;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasOpenConv")
    public Boolean hasOpenConv;

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
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidXXX</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

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

    public static ReportCustomerDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        ReportCustomerDetailRequest self = new ReportCustomerDetailRequest();
        return TeaModel.build(map, self);
    }

    public ReportCustomerDetailRequest setHasLogin(Boolean hasLogin) {
        this.hasLogin = hasLogin;
        return this;
    }
    public Boolean getHasLogin() {
        return this.hasLogin;
    }

    public ReportCustomerDetailRequest setHasOpenConv(Boolean hasOpenConv) {
        this.hasOpenConv = hasOpenConv;
        return this;
    }
    public Boolean getHasOpenConv() {
        return this.hasOpenConv;
    }

    public ReportCustomerDetailRequest setMaxDt(String maxDt) {
        this.maxDt = maxDt;
        return this;
    }
    public String getMaxDt() {
        return this.maxDt;
    }

    public ReportCustomerDetailRequest setMinDt(String minDt) {
        this.minDt = minDt;
        return this;
    }
    public String getMinDt() {
        return this.minDt;
    }

    public ReportCustomerDetailRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public ReportCustomerDetailRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public ReportCustomerDetailRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public ReportCustomerDetailRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
