// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AddDomainWordsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("assistantId")
    public String assistantId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("domainWords")
    public java.util.List<AddDomainWordsRequestDomainWords> domainWords;

    public static AddDomainWordsRequest build(java.util.Map<String, ?> map) throws Exception {
        AddDomainWordsRequest self = new AddDomainWordsRequest();
        return TeaModel.build(map, self);
    }

    public AddDomainWordsRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public AddDomainWordsRequest setDomainWords(java.util.List<AddDomainWordsRequestDomainWords> domainWords) {
        this.domainWords = domainWords;
        return this;
    }
    public java.util.List<AddDomainWordsRequestDomainWords> getDomainWords() {
        return this.domainWords;
    }

    public static class AddDomainWordsRequestDomainWords extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("domainWord")
        public String domainWord;

        @NameInMap("formalWords")
        public java.util.List<String> formalWords;

        public static AddDomainWordsRequestDomainWords build(java.util.Map<String, ?> map) throws Exception {
            AddDomainWordsRequestDomainWords self = new AddDomainWordsRequestDomainWords();
            return TeaModel.build(map, self);
        }

        public AddDomainWordsRequestDomainWords setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public AddDomainWordsRequestDomainWords setDomainWord(String domainWord) {
            this.domainWord = domainWord;
            return this;
        }
        public String getDomainWord() {
            return this.domainWord;
        }

        public AddDomainWordsRequestDomainWords setFormalWords(java.util.List<String> formalWords) {
            this.formalWords = formalWords;
            return this;
        }
        public java.util.List<String> getFormalWords() {
            return this.formalWords;
        }

    }

}
