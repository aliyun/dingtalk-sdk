// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QuerySchemaAndProcessResponseBody extends TeaModel {
    @NameInMap("result")
    public QuerySchemaAndProcessResponseBodyResult result;

    public static QuerySchemaAndProcessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySchemaAndProcessResponseBody self = new QuerySchemaAndProcessResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySchemaAndProcessResponseBody setResult(QuerySchemaAndProcessResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QuerySchemaAndProcessResponseBodyResult getResult() {
        return this.result;
    }

    public static class QuerySchemaAndProcessResponseBodyResult extends TeaModel {
        @NameInMap("appType")
        public Integer appType;

        @NameInMap("content")
        public String content;

        @NameInMap("handSignEnable")
        public String handSignEnable;

        @NameInMap("iconUrl")
        public String iconUrl;

        @NameInMap("name")
        public String name;

        @NameInMap("processConfig")
        public String processConfig;

        public static QuerySchemaAndProcessResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaAndProcessResponseBodyResult self = new QuerySchemaAndProcessResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySchemaAndProcessResponseBodyResult setAppType(Integer appType) {
            this.appType = appType;
            return this;
        }
        public Integer getAppType() {
            return this.appType;
        }

        public QuerySchemaAndProcessResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public QuerySchemaAndProcessResponseBodyResult setHandSignEnable(String handSignEnable) {
            this.handSignEnable = handSignEnable;
            return this;
        }
        public String getHandSignEnable() {
            return this.handSignEnable;
        }

        public QuerySchemaAndProcessResponseBodyResult setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

        public QuerySchemaAndProcessResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QuerySchemaAndProcessResponseBodyResult setProcessConfig(String processConfig) {
            this.processConfig = processConfig;
            return this;
        }
        public String getProcessConfig() {
            return this.processConfig;
        }

    }

}
