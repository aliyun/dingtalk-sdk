// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetDeptRequest extends TeaModel {
    /**
     * <p>通讯录语言(默认zh_CN另外支持en_US)</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>下属组织的组织ID，比如下属镇、村的corpId</p>
     */
    @NameInMap("subCorpId")
    public String subCorpId;

    public static GetDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDeptRequest self = new GetDeptRequest();
        return TeaModel.build(map, self);
    }

    public GetDeptRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetDeptRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
