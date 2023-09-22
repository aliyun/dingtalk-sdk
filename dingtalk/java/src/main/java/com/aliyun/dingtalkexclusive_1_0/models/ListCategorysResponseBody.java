// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListCategorysResponseBody extends TeaModel {
    @NameInMap("detailModelList")
    public java.util.List<java.util.Map<String, String>> detailModelList;

    public static ListCategorysResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListCategorysResponseBody self = new ListCategorysResponseBody();
        return TeaModel.build(map, self);
    }

    public ListCategorysResponseBody setDetailModelList(java.util.List<java.util.Map<String, String>> detailModelList) {
        this.detailModelList = detailModelList;
        return this;
    }
    public java.util.List<java.util.Map<String, String>> getDetailModelList() {
        return this.detailModelList;
    }

}
