// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeleteDomainWordsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("assistantId")
    public String assistantId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("domainWords")
    public java.util.List<DeleteDomainWordsRequestDomainWords> domainWords;

    public static DeleteDomainWordsRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDomainWordsRequest self = new DeleteDomainWordsRequest();
        return TeaModel.build(map, self);
    }

    public DeleteDomainWordsRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public DeleteDomainWordsRequest setDomainWords(java.util.List<DeleteDomainWordsRequestDomainWords> domainWords) {
        this.domainWords = domainWords;
        return this;
    }
    public java.util.List<DeleteDomainWordsRequestDomainWords> getDomainWords() {
        return this.domainWords;
    }

    public static class DeleteDomainWordsRequestDomainWords extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("domainWord")
        public String domainWord;

        @NameInMap("formalWords")
        public java.util.List<String> formalWords;

        public static DeleteDomainWordsRequestDomainWords build(java.util.Map<String, ?> map) throws Exception {
            DeleteDomainWordsRequestDomainWords self = new DeleteDomainWordsRequestDomainWords();
            return TeaModel.build(map, self);
        }

        public DeleteDomainWordsRequestDomainWords setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public DeleteDomainWordsRequestDomainWords setDomainWord(String domainWord) {
            this.domainWord = domainWord;
            return this;
        }
        public String getDomainWord() {
            return this.domainWord;
        }

        public DeleteDomainWordsRequestDomainWords setFormalWords(java.util.List<String> formalWords) {
            this.formalWords = formalWords;
            return this;
        }
        public java.util.List<String> getFormalWords() {
            return this.formalWords;
        }

    }

}
