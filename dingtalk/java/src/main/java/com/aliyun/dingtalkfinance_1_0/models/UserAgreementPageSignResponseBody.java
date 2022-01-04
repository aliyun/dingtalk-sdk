// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UserAgreementPageSignResponseBody extends TeaModel {
    // 拉起签约页的字符串
    @NameInMap("pageData")
    public String pageData;

    public static UserAgreementPageSignResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UserAgreementPageSignResponseBody self = new UserAgreementPageSignResponseBody();
        return TeaModel.build(map, self);
    }

    public UserAgreementPageSignResponseBody setPageData(String pageData) {
        this.pageData = pageData;
        return this;
    }
    public String getPageData() {
        return this.pageData;
    }

}
