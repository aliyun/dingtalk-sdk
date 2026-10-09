// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.domain20180129.models;

import com.aliyun.tea.*;

public class DomainKnowledgeRetrieveResponseBody extends TeaModel {
    @NameInMap("Data")
    public java.util.List<DomainKnowledgeRetrieveResponseBodyData> data;

    @NameInMap("RequestId")
    public String requestId;

    public static DomainKnowledgeRetrieveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DomainKnowledgeRetrieveResponseBody self = new DomainKnowledgeRetrieveResponseBody();
        return TeaModel.build(map, self);
    }

    public DomainKnowledgeRetrieveResponseBody setData(java.util.List<DomainKnowledgeRetrieveResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<DomainKnowledgeRetrieveResponseBodyData> getData() {
        return this.data;
    }

    public DomainKnowledgeRetrieveResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class DomainKnowledgeRetrieveResponseBodyData extends TeaModel {
        @NameInMap("Score")
        public Double score;

        @NameInMap("Source")
        public String source;

        @NameInMap("Text")
        public String text;

        public static DomainKnowledgeRetrieveResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            DomainKnowledgeRetrieveResponseBodyData self = new DomainKnowledgeRetrieveResponseBodyData();
            return TeaModel.build(map, self);
        }

        public DomainKnowledgeRetrieveResponseBodyData setScore(Double score) {
            this.score = score;
            return this;
        }
        public Double getScore() {
            return this.score;
        }

        public DomainKnowledgeRetrieveResponseBodyData setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public DomainKnowledgeRetrieveResponseBodyData setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

}
