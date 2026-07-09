// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class QueryExternalAuthControlledSheetsResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("sheets")
    public java.util.List<QueryExternalAuthControlledSheetsResponseBodySheets> sheets;

    public static QueryExternalAuthControlledSheetsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryExternalAuthControlledSheetsResponseBody self = new QueryExternalAuthControlledSheetsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryExternalAuthControlledSheetsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryExternalAuthControlledSheetsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryExternalAuthControlledSheetsResponseBody setSheets(java.util.List<QueryExternalAuthControlledSheetsResponseBodySheets> sheets) {
        this.sheets = sheets;
        return this;
    }
    public java.util.List<QueryExternalAuthControlledSheetsResponseBodySheets> getSheets() {
        return this.sheets;
    }

    public static class QueryExternalAuthControlledSheetsResponseBodySheets extends TeaModel {
        @NameInMap("externalAuthType")
        public String externalAuthType;

        @NameInMap("externalConfig")
        public String externalConfig;

        @NameInMap("markedBy")
        public String markedBy;

        @NameInMap("markedTime")
        public Long markedTime;

        @NameInMap("sheetId")
        public String sheetId;

        @NameInMap("sheetName")
        public String sheetName;

        public static QueryExternalAuthControlledSheetsResponseBodySheets build(java.util.Map<String, ?> map) throws Exception {
            QueryExternalAuthControlledSheetsResponseBodySheets self = new QueryExternalAuthControlledSheetsResponseBodySheets();
            return TeaModel.build(map, self);
        }

        public QueryExternalAuthControlledSheetsResponseBodySheets setExternalAuthType(String externalAuthType) {
            this.externalAuthType = externalAuthType;
            return this;
        }
        public String getExternalAuthType() {
            return this.externalAuthType;
        }

        public QueryExternalAuthControlledSheetsResponseBodySheets setExternalConfig(String externalConfig) {
            this.externalConfig = externalConfig;
            return this;
        }
        public String getExternalConfig() {
            return this.externalConfig;
        }

        public QueryExternalAuthControlledSheetsResponseBodySheets setMarkedBy(String markedBy) {
            this.markedBy = markedBy;
            return this;
        }
        public String getMarkedBy() {
            return this.markedBy;
        }

        public QueryExternalAuthControlledSheetsResponseBodySheets setMarkedTime(Long markedTime) {
            this.markedTime = markedTime;
            return this;
        }
        public Long getMarkedTime() {
            return this.markedTime;
        }

        public QueryExternalAuthControlledSheetsResponseBodySheets setSheetId(String sheetId) {
            this.sheetId = sheetId;
            return this;
        }
        public String getSheetId() {
            return this.sheetId;
        }

        public QueryExternalAuthControlledSheetsResponseBodySheets setSheetName(String sheetName) {
            this.sheetName = sheetName;
            return this;
        }
        public String getSheetName() {
            return this.sheetName;
        }

    }

}
