// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenScoreCardDimensionDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dimensionList")
    public java.util.List<OpenScoreCardDimensionDTODimensionList> dimensionList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("scoreCardId")
    public String scoreCardId;

    public static OpenScoreCardDimensionDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenScoreCardDimensionDTO self = new OpenScoreCardDimensionDTO();
        return TeaModel.build(map, self);
    }

    public OpenScoreCardDimensionDTO setDimensionList(java.util.List<OpenScoreCardDimensionDTODimensionList> dimensionList) {
        this.dimensionList = dimensionList;
        return this;
    }
    public java.util.List<OpenScoreCardDimensionDTODimensionList> getDimensionList() {
        return this.dimensionList;
    }

    public OpenScoreCardDimensionDTO setScoreCardId(String scoreCardId) {
        this.scoreCardId = scoreCardId;
        return this;
    }
    public String getScoreCardId() {
        return this.scoreCardId;
    }

    public static class OpenScoreCardDimensionDTODimensionList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dimensionId")
        public String dimensionId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("indicatorIdList")
        public java.util.List<String> indicatorIdList;

        public static OpenScoreCardDimensionDTODimensionList build(java.util.Map<String, ?> map) throws Exception {
            OpenScoreCardDimensionDTODimensionList self = new OpenScoreCardDimensionDTODimensionList();
            return TeaModel.build(map, self);
        }

        public OpenScoreCardDimensionDTODimensionList setDimensionId(String dimensionId) {
            this.dimensionId = dimensionId;
            return this;
        }
        public String getDimensionId() {
            return this.dimensionId;
        }

        public OpenScoreCardDimensionDTODimensionList setIndicatorIdList(java.util.List<String> indicatorIdList) {
            this.indicatorIdList = indicatorIdList;
            return this;
        }
        public java.util.List<String> getIndicatorIdList() {
            return this.indicatorIdList;
        }

    }

}
