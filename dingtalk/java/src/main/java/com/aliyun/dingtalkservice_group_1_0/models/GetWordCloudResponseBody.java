// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetWordCloudResponseBody extends TeaModel {
    // 词列表
    @NameInMap("words")
    public java.util.List<GetWordCloudResponseBodyWords> words;

    public static GetWordCloudResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWordCloudResponseBody self = new GetWordCloudResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWordCloudResponseBody setWords(java.util.List<GetWordCloudResponseBodyWords> words) {
        this.words = words;
        return this;
    }
    public java.util.List<GetWordCloudResponseBodyWords> getWords() {
        return this.words;
    }

    public static class GetWordCloudResponseBodyWords extends TeaModel {
        // 词数量
        @NameInMap("count")
        public Long count;

        // 词名
        @NameInMap("word")
        public String word;

        public static GetWordCloudResponseBodyWords build(java.util.Map<String, ?> map) throws Exception {
            GetWordCloudResponseBodyWords self = new GetWordCloudResponseBodyWords();
            return TeaModel.build(map, self);
        }

        public GetWordCloudResponseBodyWords setCount(Long count) {
            this.count = count;
            return this;
        }
        public Long getCount() {
            return this.count;
        }

        public GetWordCloudResponseBodyWords setWord(String word) {
            this.word = word;
            return this;
        }
        public String getWord() {
            return this.word;
        }

    }

}
