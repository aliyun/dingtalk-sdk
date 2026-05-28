// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryExportTaskResponseBody extends TeaModel {
    @NameInMap("downloadUrl")
    public String downloadUrl;

    @NameInMap("status")
    public String status;

    public static QueryExportTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryExportTaskResponseBody self = new QueryExportTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryExportTaskResponseBody setDownloadUrl(String downloadUrl) {
        this.downloadUrl = downloadUrl;
        return this;
    }
    public String getDownloadUrl() {
        return this.downloadUrl;
    }

    public QueryExportTaskResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
