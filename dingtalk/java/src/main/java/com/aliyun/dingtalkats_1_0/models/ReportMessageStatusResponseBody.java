// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ReportMessageStatusResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("result")
    public String result;

    public static ReportMessageStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReportMessageStatusResponseBody self = new ReportMessageStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public ReportMessageStatusResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
