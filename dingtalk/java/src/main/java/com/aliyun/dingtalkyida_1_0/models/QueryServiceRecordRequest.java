// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceRecordRequest extends TeaModel {
    /**
     * <p>宜搭应用编码</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>表单编码</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>服务类型</p>
     */
    @NameInMap("hookType")
    public String hookType;

    /**
     * <p>本次服务调用的唯一ID</p>
     */
    @NameInMap("hookUuid")
    public String hookUuid;

    /**
     * <p>表单实例ID</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <p>服务在此时间之后调用的</p>
     */
    @NameInMap("invokeAfterDateGMT")
    public String invokeAfterDateGMT;

    /**
     * <p>服务在此时间之前调用的</p>
     */
    @NameInMap("invokeBeforeDateGMT")
    public String invokeBeforeDateGMT;

    /**
     * <p>服务调用状态</p>
     */
    @NameInMap("invokeStatus")
    public String invokeStatus;

    /**
     * <p>分页第几页</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>分页大小</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>服务调用地址包含的部分字符串，用于模糊搜索</p>
     */
    @NameInMap("requestUrl")
    public String requestUrl;

    /**
     * <p>被重试的服务调用唯一ID(此次服务调用是重试哪个执行失败的服务调用)</p>
     */
    @NameInMap("sourceUuid")
    public String sourceUuid;

    /**
     * <p>服务调用是否成功(不传此参数则查询全部的)</p>
     */
    @NameInMap("success")
    public Boolean success;

    /**
     * <p>宜搭应用秘钥</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>操作人的钉钉userId</p>
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
