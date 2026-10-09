// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.domain20180129.models;

import com.aliyun.tea.*;

public class DomainKnowledgeRetrieveRequest extends TeaModel {
    @NameInMap("GlobalTopN")
    public Integer globalTopN;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("Keyword")
    public String keyword;

    /**
     * <strong>example:</strong>
     * <p>all</p>
     */
    @NameInMap("Site")
    public String site;

    public static DomainKnowledgeRetrieveRequest build(java.util.Map<String, ?> map) throws Exception {
        DomainKnowledgeRetrieveRequest self = new DomainKnowledgeRetrieveRequest();
        return TeaModel.build(map, self);
    }

    public DomainKnowledgeRetrieveRequest setGlobalTopN(Integer globalTopN) {
        this.globalTopN = globalTopN;
        return this;
    }
    public Integer getGlobalTopN() {
        return this.globalTopN;
    }

    public DomainKnowledgeRetrieveRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public DomainKnowledgeRetrieveRequest setSite(String site) {
        this.site = site;
        return this;
    }
    public String getSite() {
        return this.site;
    }

}
