// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDocCreatedSummaryResponseBody extends TeaModel {
    @NameInMap("docCreateUserCnt1d")
    public String docCreateUserCnt1d;

    @NameInMap("docCreatedCnt")
    public String docCreatedCnt;

    public static GetDocCreatedSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDocCreatedSummaryResponseBody self = new GetDocCreatedSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDocCreatedSummaryResponseBody setDocCreateUserCnt1d(String docCreateUserCnt1d) {
        this.docCreateUserCnt1d = docCreateUserCnt1d;
        return this;
    }
    public String getDocCreateUserCnt1d() {
        return this.docCreateUserCnt1d;
    }

    public GetDocCreatedSummaryResponseBody setDocCreatedCnt(String docCreatedCnt) {
        this.docCreatedCnt = docCreatedCnt;
        return this;
    }
    public String getDocCreatedCnt() {
        return this.docCreatedCnt;
    }

}
