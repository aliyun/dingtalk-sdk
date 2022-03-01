// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class NlpWordDistinguishResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("wordEntities")
    public java.util.List<NlpWordDistinguishResponseBodyWordEntities> wordEntities;

    public static NlpWordDistinguishResponseBody build(java.util.Map<String, ?> map) throws Exception {
        NlpWordDistinguishResponseBody self = new NlpWordDistinguishResponseBody();
        return TeaModel.build(map, self);
    }

    public NlpWordDistinguishResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public NlpWordDistinguishResponseBody setWordEntities(java.util.List<NlpWordDistinguishResponseBodyWordEntities> wordEntities) {
        this.wordEntities = wordEntities;
        return this;
    }
    public java.util.List<NlpWordDistinguishResponseBodyWordEntities> getWordEntities() {
        return this.wordEntities;
    }

    public static class NlpWordDistinguishResponseBodyWordEntities extends TeaModel {
        @NameInMap("word")
        public String word;

        public static NlpWordDistinguishResponseBodyWordEntities build(java.util.Map<String, ?> map) throws Exception {
            NlpWordDistinguishResponseBodyWordEntities self = new NlpWordDistinguishResponseBodyWordEntities();
            return TeaModel.build(map, self);
        }

        public NlpWordDistinguishResponseBodyWordEntities setWord(String word) {
            this.word = word;
            return this;
        }
        public String getWord() {
            return this.word;
        }

    }

}
