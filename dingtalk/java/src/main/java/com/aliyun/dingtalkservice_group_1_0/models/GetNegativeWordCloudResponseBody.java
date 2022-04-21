// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetNegativeWordCloudResponseBody extends TeaModel {
    // 词列表
    @NameInMap("words")
    public java.util.List<GetNegativeWordCloudResponseBodyWords> words;

    public static GetNegativeWordCloudResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetNegativeWordCloudResponseBody self = new GetNegativeWordCloudResponseBody();
        return TeaModel.build(map, self);
    }

    public GetNegativeWordCloudResponseBody setWords(java.util.List<GetNegativeWordCloudResponseBodyWords> words) {
        this.words = words;
        return this;
    }
    public java.util.List<GetNegativeWordCloudResponseBodyWords> getWords() {
        return this.words;
    }

    public static class GetNegativeWordCloudResponseBodyWords extends TeaModel {
        // 词数量
        @NameInMap("count")
        public Long count;

        // 词名
        @NameInMap("word")
        public String word;

        public static GetNegativeWordCloudResponseBodyWords build(java.util.Map<String, ?> map) throws Exception {
            GetNegativeWordCloudResponseBodyWords self = new GetNegativeWordCloudResponseBodyWords();
            return TeaModel.build(map, self);
        }

        public GetNegativeWordCloudResponseBodyWords setCount(Long count) {
            this.count = count;
            return this;
        }
        public Long getCount() {
            return this.count;
        }

        public GetNegativeWordCloudResponseBodyWords setWord(String word) {
            this.word = word;
            return this;
        }
        public String getWord() {
            return this.word;
        }

    }

}
