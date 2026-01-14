// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalIndicatorBatchQueryRequest extends TeaModel {
    @NameInMap("codeList")
    public java.util.List<String> codeList;

    public static AgoalIndicatorBatchQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalIndicatorBatchQueryRequest self = new AgoalIndicatorBatchQueryRequest();
        return TeaModel.build(map, self);
    }

    public AgoalIndicatorBatchQueryRequest setCodeList(java.util.List<String> codeList) {
        this.codeList = codeList;
        return this;
    }
    public java.util.List<String> getCodeList() {
        return this.codeList;
    }

}
