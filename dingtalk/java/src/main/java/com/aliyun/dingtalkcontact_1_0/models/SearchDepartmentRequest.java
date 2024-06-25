// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SearchDepartmentRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("offset")
    public Integer offset;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>财务部</p>
     */
    @NameInMap("queryWord")
    public String queryWord;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("size")
    public Integer size;

    public static SearchDepartmentRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchDepartmentRequest self = new SearchDepartmentRequest();
        return TeaModel.build(map, self);
    }

    public SearchDepartmentRequest setOffset(Integer offset) {
        this.offset = offset;
        return this;
    }
    public Integer getOffset() {
        return this.offset;
    }

    public SearchDepartmentRequest setQueryWord(String queryWord) {
        this.queryWord = queryWord;
        return this;
    }
    public String getQueryWord() {
        return this.queryWord;
    }

    public SearchDepartmentRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

}
