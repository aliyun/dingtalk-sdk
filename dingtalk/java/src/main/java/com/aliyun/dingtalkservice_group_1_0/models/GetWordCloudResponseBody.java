// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetWordCloudResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("count")
        public Long count;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>销售</p>
         */
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
