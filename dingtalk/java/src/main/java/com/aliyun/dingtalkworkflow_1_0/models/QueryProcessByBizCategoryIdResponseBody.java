// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessByBizCategoryIdResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryProcessByBizCategoryIdResponseBodyResult> result;

    public static QueryProcessByBizCategoryIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryProcessByBizCategoryIdResponseBody self = new QueryProcessByBizCategoryIdResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryProcessByBizCategoryIdResponseBody setResult(java.util.List<QueryProcessByBizCategoryIdResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryProcessByBizCategoryIdResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryProcessByBizCategoryIdResponseBodyResult extends TeaModel {
        /**
         * <p>模板描述</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>模板名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>模板code</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <p>模版发布状态。</p>
         * <br>
         * <p>- PUBLISHED：已启用</p>
         * <br>
         * <p>- INVALID：停用</p>
         * <br>
         * <p>- SAVED：已保存</p>
         */
        @NameInMap("status")
        public String status;

        public static QueryProcessByBizCategoryIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryProcessByBizCategoryIdResponseBodyResult self = new QueryProcessByBizCategoryIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryProcessByBizCategoryIdResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QueryProcessByBizCategoryIdResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryProcessByBizCategoryIdResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public QueryProcessByBizCategoryIdResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
