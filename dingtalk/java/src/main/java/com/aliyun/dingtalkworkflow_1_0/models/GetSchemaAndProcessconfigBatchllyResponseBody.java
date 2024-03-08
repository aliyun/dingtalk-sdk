// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSchemaAndProcessconfigBatchllyResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetSchemaAndProcessconfigBatchllyResponseBodyResult> result;

    public static GetSchemaAndProcessconfigBatchllyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSchemaAndProcessconfigBatchllyResponseBody self = new GetSchemaAndProcessconfigBatchllyResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSchemaAndProcessconfigBatchllyResponseBody setResult(java.util.List<GetSchemaAndProcessconfigBatchllyResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetSchemaAndProcessconfigBatchllyResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetSchemaAndProcessconfigBatchllyResponseBodyResult extends TeaModel {
        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("bizCategoryId")
        public String bizCategoryId;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("formUuid")
        public String formUuid;

        @NameInMap("managerList")
        public String managerList;

        @NameInMap("memo")
        public String memo;

        @NameInMap("name")
        public String name;

        @NameInMap("processCode")
        public String processCode;

        @NameInMap("processConfig")
        public String processConfig;

        @NameInMap("processId")
        public Long processId;

        @NameInMap("properties")
        public String properties;

        @NameInMap("schemaContent")
        public String schemaContent;

        @NameInMap("visibleScope")
        public String visibleScope;

        public static GetSchemaAndProcessconfigBatchllyResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSchemaAndProcessconfigBatchllyResponseBodyResult self = new GetSchemaAndProcessconfigBatchllyResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setBizCategoryId(String bizCategoryId) {
            this.bizCategoryId = bizCategoryId;
            return this;
        }
        public String getBizCategoryId() {
            return this.bizCategoryId;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setManagerList(String managerList) {
            this.managerList = managerList;
            return this;
        }
        public String getManagerList() {
            return this.managerList;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setProcessConfig(String processConfig) {
            this.processConfig = processConfig;
            return this;
        }
        public String getProcessConfig() {
            return this.processConfig;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setProcessId(Long processId) {
            this.processId = processId;
            return this;
        }
        public Long getProcessId() {
            return this.processId;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setProperties(String properties) {
            this.properties = properties;
            return this;
        }
        public String getProperties() {
            return this.properties;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setSchemaContent(String schemaContent) {
            this.schemaContent = schemaContent;
            return this;
        }
        public String getSchemaContent() {
            return this.schemaContent;
        }

        public GetSchemaAndProcessconfigBatchllyResponseBodyResult setVisibleScope(String visibleScope) {
            this.visibleScope = visibleScope;
            return this;
        }
        public String getVisibleScope() {
            return this.visibleScope;
        }

    }

}
