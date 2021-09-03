// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDocCreatedSummaryResponseBody extends TeaModel {
    // 最近1天累计创建文档数
    @NameInMap("docCreatedCnt")
    public String docCreatedCnt;

    public static GetDocCreatedSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDocCreatedSummaryResponseBody self = new GetDocCreatedSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDocCreatedSummaryResponseBody setDocCreatedCnt(String docCreatedCnt) {
        this.docCreatedCnt = docCreatedCnt;
        return this;
    }
    public String getDocCreatedCnt() {
        return this.docCreatedCnt;
    }

}
