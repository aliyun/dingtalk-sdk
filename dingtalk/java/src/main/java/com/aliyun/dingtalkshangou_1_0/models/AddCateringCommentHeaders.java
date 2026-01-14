// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkshangou_1_0.models;

import com.aliyun.tea.*;

public class AddCateringCommentHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static AddCateringCommentHeaders build(java.util.Map<String, ?> map) throws Exception {
        AddCateringCommentHeaders self = new AddCateringCommentHeaders();
        return TeaModel.build(map, self);
    }

    public AddCateringCommentHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public AddCateringCommentHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
