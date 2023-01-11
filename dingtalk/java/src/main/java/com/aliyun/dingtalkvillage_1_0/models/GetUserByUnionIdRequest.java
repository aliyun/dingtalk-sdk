// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetUserByUnionIdRequest extends TeaModel {
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

    /**
     * <p>人员 id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetUserByUnionIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserByUnionIdRequest self = new GetUserByUnionIdRequest();
        return TeaModel.build(map, self);
    }

    public GetUserByUnionIdRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetUserByUnionIdRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

    public GetUserByUnionIdRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
