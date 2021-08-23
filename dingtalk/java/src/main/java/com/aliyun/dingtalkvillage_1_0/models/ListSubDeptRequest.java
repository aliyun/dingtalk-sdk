// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubDeptRequest extends TeaModel {
    // 真实请求的组织corpId
    @NameInMap("subCorpId")
    public String subCorpId;

    // 通讯录语言(默认zh_CN另外支持en_US)
    @NameInMap("language")
    public String language;

    public static ListSubDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSubDeptRequest self = new ListSubDeptRequest();
        return TeaModel.build(map, self);
    }

    public ListSubDeptRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

    public ListSubDeptRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

}
