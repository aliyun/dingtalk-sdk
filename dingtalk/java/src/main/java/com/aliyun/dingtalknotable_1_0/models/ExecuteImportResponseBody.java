// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class ExecuteImportResponseBody extends TeaModel {
    @NameInMap("importId")
    public String importId;

    @NameInMap("status")
    public String status;

    public static ExecuteImportResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExecuteImportResponseBody self = new ExecuteImportResponseBody();
        return TeaModel.build(map, self);
    }

    public ExecuteImportResponseBody setImportId(String importId) {
        this.importId = importId;
        return this;
    }
    public String getImportId() {
        return this.importId;
    }

    public ExecuteImportResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
