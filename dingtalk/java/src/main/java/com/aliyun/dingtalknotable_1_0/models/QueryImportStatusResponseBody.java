// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class QueryImportStatusResponseBody extends TeaModel {
    @NameInMap("count")
    public Integer count;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMessage")
    public String errorMessage;

    @NameInMap("importId")
    public String importId;

    @NameInMap("phase")
    public String phase;

    @NameInMap("status")
    public String status;

    @NameInMap("tableIds")
    public java.util.List<String> tableIds;

    public static QueryImportStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryImportStatusResponseBody self = new QueryImportStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryImportStatusResponseBody setCount(Integer count) {
        this.count = count;
        return this;
    }
    public Integer getCount() {
        return this.count;
    }

    public QueryImportStatusResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public QueryImportStatusResponseBody setErrorMessage(String errorMessage) {
        this.errorMessage = errorMessage;
        return this;
    }
    public String getErrorMessage() {
        return this.errorMessage;
    }

    public QueryImportStatusResponseBody setImportId(String importId) {
        this.importId = importId;
        return this;
    }
    public String getImportId() {
        return this.importId;
    }

    public QueryImportStatusResponseBody setPhase(String phase) {
        this.phase = phase;
        return this;
    }
    public String getPhase() {
        return this.phase;
    }

    public QueryImportStatusResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public QueryImportStatusResponseBody setTableIds(java.util.List<String> tableIds) {
        this.tableIds = tableIds;
        return this;
    }
    public java.util.List<String> getTableIds() {
        return this.tableIds;
    }

}
