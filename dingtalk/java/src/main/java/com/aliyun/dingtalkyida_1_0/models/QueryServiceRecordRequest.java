// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceRecordRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    @NameInMap("hookType")
    public String hookType;

    @NameInMap("hookUuid")
    public String hookUuid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("invokeAfterDateGMT")
    public String invokeAfterDateGMT;

    @NameInMap("invokeBeforeDateGMT")
    public String invokeBeforeDateGMT;

    @NameInMap("invokeStatus")
    public String invokeStatus;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("requestUrl")
    public String requestUrl;

    @NameInMap("sourceUuid")
    public String sourceUuid;

    @NameInMap("success")
    public Boolean success;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryServiceRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceRecordRequest self = new QueryServiceRecordRequest();
        return TeaModel.build(map, self);
    }

    public QueryServiceRecordRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public QueryServiceRecordRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public QueryServiceRecordRequest setHookType(String hookType) {
        this.hookType = hookType;
        return this;
    }
    public String getHookType() {
        return this.hookType;
    }

    public QueryServiceRecordRequest setHookUuid(String hookUuid) {
        this.hookUuid = hookUuid;
        return this;
    }
    public String getHookUuid() {
        return this.hookUuid;
    }

    public QueryServiceRecordRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public QueryServiceRecordRequest setInvokeAfterDateGMT(String invokeAfterDateGMT) {
        this.invokeAfterDateGMT = invokeAfterDateGMT;
        return this;
    }
    public String getInvokeAfterDateGMT() {
        return this.invokeAfterDateGMT;
    }

    public QueryServiceRecordRequest setInvokeBeforeDateGMT(String invokeBeforeDateGMT) {
        this.invokeBeforeDateGMT = invokeBeforeDateGMT;
        return this;
    }
    public String getInvokeBeforeDateGMT() {
        return this.invokeBeforeDateGMT;
    }

    public QueryServiceRecordRequest setInvokeStatus(String invokeStatus) {
        this.invokeStatus = invokeStatus;
        return this;
    }
    public String getInvokeStatus() {
        return this.invokeStatus;
    }

    public QueryServiceRecordRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryServiceRecordRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryServiceRecordRequest setRequestUrl(String requestUrl) {
        this.requestUrl = requestUrl;
        return this;
    }
    public String getRequestUrl() {
        return this.requestUrl;
    }

    public QueryServiceRecordRequest setSourceUuid(String sourceUuid) {
        this.sourceUuid = sourceUuid;
        return this;
    }
    public String getSourceUuid() {
        return this.sourceUuid;
    }

    public QueryServiceRecordRequest setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public QueryServiceRecordRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public QueryServiceRecordRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
