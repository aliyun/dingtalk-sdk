// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceRecordResponseBody extends TeaModel {
    @NameInMap("totalCount")
    public Integer totalCount;

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
        @NameInMap("formInstanceId")
        public String formInstanceId;

        @NameInMap("formUuid")
        public String formUuid;

        @NameInMap("hookType")
        public String hookType;

        @NameInMap("hookUuid")
        public String hookUuid;

        @NameInMap("invokeParameter")
        public String invokeParameter;

        @NameInMap("invokeResult")
        public String invokeResult;

        @NameInMap("invokeStatus")
        public String invokeStatus;

        @NameInMap("invokeSuccess")
        public String invokeSuccess;

        @NameInMap("invokeUrl")
        public String invokeUrl;

        @NameInMap("serviceContent")
        public String serviceContent;

        @NameInMap("serviceName")
        public String serviceName;

        @NameInMap("serviceParameter")
        public String serviceParameter;

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
