// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripProcessTemplatesResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryTripProcessTemplatesResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryTripProcessTemplatesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTripProcessTemplatesResponseBody self = new QueryTripProcessTemplatesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTripProcessTemplatesResponseBody setResult(QueryTripProcessTemplatesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryTripProcessTemplatesResponseBodyResult getResult() {
        return this.result;
    }

    public QueryTripProcessTemplatesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryTripProcessTemplatesResponseBodyResultSchemas extends TeaModel {
        @NameInMap("processCode")
        public String processCode;

        @NameInMap("processName")
        public String processName;

        @NameInMap("type")
        public String type;

        public static QueryTripProcessTemplatesResponseBodyResultSchemas build(java.util.Map<String, ?> map) throws Exception {
            QueryTripProcessTemplatesResponseBodyResultSchemas self = new QueryTripProcessTemplatesResponseBodyResultSchemas();
            return TeaModel.build(map, self);
        }

        public QueryTripProcessTemplatesResponseBodyResultSchemas setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public QueryTripProcessTemplatesResponseBodyResultSchemas setProcessName(String processName) {
            this.processName = processName;
            return this;
        }
        public String getProcessName() {
            return this.processName;
        }

        public QueryTripProcessTemplatesResponseBodyResultSchemas setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class QueryTripProcessTemplatesResponseBodyResult extends TeaModel {
        @NameInMap("schemas")
        public java.util.List<QueryTripProcessTemplatesResponseBodyResultSchemas> schemas;

        public static QueryTripProcessTemplatesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryTripProcessTemplatesResponseBodyResult self = new QueryTripProcessTemplatesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryTripProcessTemplatesResponseBodyResult setSchemas(java.util.List<QueryTripProcessTemplatesResponseBodyResultSchemas> schemas) {
            this.schemas = schemas;
            return this;
        }
        public java.util.List<QueryTripProcessTemplatesResponseBodyResultSchemas> getSchemas() {
            return this.schemas;
        }

    }

}
