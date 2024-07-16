// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ImportJobDataResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static ImportJobDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ImportJobDataResponseBody self = new ImportJobDataResponseBody();
        return TeaModel.build(map, self);
    }

    public ImportJobDataResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public ImportJobDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
