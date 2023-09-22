// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListRulesResponseBody extends TeaModel {
    @NameInMap("detailModelList")
    public java.util.List<java.util.Map<String, String>> detailModelList;

    public static ListRulesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListRulesResponseBody self = new ListRulesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListRulesResponseBody setDetailModelList(java.util.List<java.util.Map<String, String>> detailModelList) {
        this.detailModelList = detailModelList;
        return this;
    }
    public java.util.List<java.util.Map<String, String>> getDetailModelList() {
        return this.detailModelList;
    }

}
