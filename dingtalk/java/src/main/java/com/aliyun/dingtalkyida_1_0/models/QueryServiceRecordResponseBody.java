// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceRecordResponseBody extends TeaModel {
    /**
     * <p>总数量</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    /**
     * <p>服务调用记录数组</p>
     */
    @NameInMap("values")
    public java.util.List<QueryServiceRecordResponseBodyValues> values;

    public static QueryServiceRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceRecordResponseBody self = new QueryServiceRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryServiceRecordResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public QueryServiceRecordResponseBody setValues(java.util.List<QueryServiceRecordResponseBodyValues> values) {
        this.values = values;
        return this;
    }
    public java.util.List<QueryServiceRecordResponseBodyValues> getValues() {
        return this.values;
    }

    public static class QueryServiceRecordResponseBodyValues extends TeaModel {
        /**
         * <p>表单实例id</p>
         */
        @NameInMap("formInstanceId")
        public String formInstanceId;

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
         * <p>服务调用的实际入参</p>
         */
        @NameInMap("invokeParameter")
        public String invokeParameter;

        /**
         * <p>服务调用的返回结果</p>
         */
        @NameInMap("invokeResult")
        public String invokeResult;

        /**
         * <p>服务调用状态</p>
         */
        @NameInMap("invokeStatus")
        public String invokeStatus;

        /**
         * <p>服务调用是否成功</p>
         */
        @NameInMap("invokeSuccess")
        public String invokeSuccess;

        /**
         * <p>服务调用地址</p>
         */
        @NameInMap("invokeUrl")
        public String invokeUrl;

        /**
         * <p>宜搭调用目标服务时传的实际参数</p>
         */
        @NameInMap("serviceContent")
        public String serviceContent;

        /**
         * <p>服务名称</p>
         */
        @NameInMap("serviceName")
        public String serviceName;

        /**
         * <p>服务调用的实际入参</p>
         */
        @NameInMap("serviceParameter")
        public String serviceParameter;

        /**
         * <p>重试的服务调用唯一ID(此次服务调用是重试哪个执行失败的服务调用)</p>
         */
        @NameInMap("sourceUuid")
        public String sourceUuid;

        public static QueryServiceRecordResponseBodyValues build(java.util.Map<String, ?> map) throws Exception {
            QueryServiceRecordResponseBodyValues self = new QueryServiceRecordResponseBodyValues();
            return TeaModel.build(map, self);
        }

        public QueryServiceRecordResponseBodyValues setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public QueryServiceRecordResponseBodyValues setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public QueryServiceRecordResponseBodyValues setHookType(String hookType) {
            this.hookType = hookType;
            return this;
        }
        public String getHookType() {
            return this.hookType;
        }

        public QueryServiceRecordResponseBodyValues setHookUuid(String hookUuid) {
            this.hookUuid = hookUuid;
            return this;
        }
        public String getHookUuid() {
            return this.hookUuid;
        }

        public QueryServiceRecordResponseBodyValues setInvokeParameter(String invokeParameter) {
            this.invokeParameter = invokeParameter;
            return this;
        }
        public String getInvokeParameter() {
            return this.invokeParameter;
        }

        public QueryServiceRecordResponseBodyValues setInvokeResult(String invokeResult) {
            this.invokeResult = invokeResult;
            return this;
        }
        public String getInvokeResult() {
            return this.invokeResult;
        }

        public QueryServiceRecordResponseBodyValues setInvokeStatus(String invokeStatus) {
            this.invokeStatus = invokeStatus;
            return this;
        }
        public String getInvokeStatus() {
            return this.invokeStatus;
        }

        public QueryServiceRecordResponseBodyValues setInvokeSuccess(String invokeSuccess) {
            this.invokeSuccess = invokeSuccess;
            return this;
        }
        public String getInvokeSuccess() {
            return this.invokeSuccess;
        }

        public QueryServiceRecordResponseBodyValues setInvokeUrl(String invokeUrl) {
            this.invokeUrl = invokeUrl;
            return this;
        }
        public String getInvokeUrl() {
            return this.invokeUrl;
        }

        public QueryServiceRecordResponseBodyValues setServiceContent(String serviceContent) {
            this.serviceContent = serviceContent;
            return this;
        }
        public String getServiceContent() {
            return this.serviceContent;
        }

        public QueryServiceRecordResponseBodyValues setServiceName(String serviceName) {
            this.serviceName = serviceName;
            return this;
        }
        public String getServiceName() {
            return this.serviceName;
        }

        public QueryServiceRecordResponseBodyValues setServiceParameter(String serviceParameter) {
            this.serviceParameter = serviceParameter;
            return this;
        }
        public String getServiceParameter() {
            return this.serviceParameter;
        }

        public QueryServiceRecordResponseBodyValues setSourceUuid(String sourceUuid) {
            this.sourceUuid = sourceUuid;
            return this;
        }
        public String getSourceUuid() {
            return this.sourceUuid;
        }

    }

}
