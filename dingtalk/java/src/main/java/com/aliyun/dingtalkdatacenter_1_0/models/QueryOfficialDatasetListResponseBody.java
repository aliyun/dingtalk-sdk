// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialDatasetListResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryOfficialDatasetListResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryOfficialDatasetListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialDatasetListResponseBody self = new QueryOfficialDatasetListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOfficialDatasetListResponseBody setResult(QueryOfficialDatasetListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryOfficialDatasetListResponseBodyResult getResult() {
        return this.result;
    }

    public QueryOfficialDatasetListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryOfficialDatasetListResponseBodyResultRows extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("dsId")
        public String dsId;

        public static QueryOfficialDatasetListResponseBodyResultRows build(java.util.Map<String, ?> map) throws Exception {
            QueryOfficialDatasetListResponseBodyResultRows self = new QueryOfficialDatasetListResponseBodyResultRows();
            return TeaModel.build(map, self);
        }

        public QueryOfficialDatasetListResponseBodyResultRows setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public QueryOfficialDatasetListResponseBodyResultRows setDsId(String dsId) {
            this.dsId = dsId;
            return this;
        }
        public String getDsId() {
            return this.dsId;
        }

    }

    public static class QueryOfficialDatasetListResponseBodyResult extends TeaModel {
        @NameInMap("rows")
        public java.util.List<QueryOfficialDatasetListResponseBodyResultRows> rows;

        @NameInMap("totalCount")
        public Long totalCount;

        public static QueryOfficialDatasetListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryOfficialDatasetListResponseBodyResult self = new QueryOfficialDatasetListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryOfficialDatasetListResponseBodyResult setRows(java.util.List<QueryOfficialDatasetListResponseBodyResultRows> rows) {
            this.rows = rows;
            return this;
        }
        public java.util.List<QueryOfficialDatasetListResponseBodyResultRows> getRows() {
            return this.rows;
        }

        public QueryOfficialDatasetListResponseBodyResult setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
