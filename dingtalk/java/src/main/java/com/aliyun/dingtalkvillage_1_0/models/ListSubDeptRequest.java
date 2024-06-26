// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubDeptRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subCorpId")
    public String subCorpId;

    public static ListSubDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSubDeptRequest self = new ListSubDeptRequest();
        return TeaModel.build(map, self);
    }

    public ListSubDeptRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public ListSubDeptRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

}
