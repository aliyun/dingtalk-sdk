// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, ResultValue> result;

    @NameInMap("success")
    public Boolean success;

    public static GetFileDownloadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileDownloadInfoResponseBody self = new GetFileDownloadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileDownloadInfoResponseBody setResult(java.util.Map<String, ResultValue> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ResultValue> getResult() {
        return this.result;
    }

    public GetFileDownloadInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
