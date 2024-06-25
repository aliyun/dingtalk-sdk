// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class PageAutoFlowLogRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>APP_XCE0EVXS6DYG3YDYC5RD</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding5d17e3add038d44535c2f4657eb6378e</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>2021-01-01</p>
     */
    @NameInMap("endTimeGMT")
    public Long endTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("processCode")
    public String processCode;

    @NameInMap("startTimeGMT")
    public Long startTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>running</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>B073AF673BEB044D59F8F612D65E1EA2</p>
     */
    @NameInMap("token")
    public String token;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding173982232112232</p>
     */
    @NameInMap("userId")
    public String userId;

    public static PageAutoFlowLogRequest build(java.util.Map<String, ?> map) throws Exception {
        PageAutoFlowLogRequest self = new PageAutoFlowLogRequest();
        return TeaModel.build(map, self);
    }

    public PageAutoFlowLogRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public PageAutoFlowLogRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public PageAutoFlowLogRequest setEndTimeGMT(Long endTimeGMT) {
        this.endTimeGMT = endTimeGMT;
        return this;
    }
    public Long getEndTimeGMT() {
        return this.endTimeGMT;
    }

    public PageAutoFlowLogRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public PageAutoFlowLogRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public PageAutoFlowLogRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public PageAutoFlowLogRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public PageAutoFlowLogRequest setStartTimeGMT(Long startTimeGMT) {
        this.startTimeGMT = startTimeGMT;
        return this;
    }
    public Long getStartTimeGMT() {
        return this.startTimeGMT;
    }

    public PageAutoFlowLogRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public PageAutoFlowLogRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

    public PageAutoFlowLogRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
