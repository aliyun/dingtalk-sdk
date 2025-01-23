// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class ExportShanhuiToDocResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static ExportShanhuiToDocResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExportShanhuiToDocResponseBody self = new ExportShanhuiToDocResponseBody();
        return TeaModel.build(map, self);
    }

    public ExportShanhuiToDocResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public ExportShanhuiToDocResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
