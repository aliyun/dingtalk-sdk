// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectTemplateRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>模板1</p>
     */
    @NameInMap("keyword")
    public String keyword;

    public static SearchProjectTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectTemplateRequest self = new SearchProjectTemplateRequest();
        return TeaModel.build(map, self);
    }

    public SearchProjectTemplateRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

}
