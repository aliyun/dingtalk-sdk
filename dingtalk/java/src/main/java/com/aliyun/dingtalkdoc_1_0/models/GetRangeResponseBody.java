// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRangeResponseBody extends TeaModel {
    @NameInMap("backgroundColors")
    public java.util.List<java.util.List<GetRangeResponseBodyBackgroundColors>> backgroundColors;

    @NameInMap("displayValues")
    public java.util.List<java.util.List<String>> displayValues;

    @NameInMap("formulas")
    public java.util.List<java.util.List<String>> formulas;

    /**
     * <p>值</p>
     */
    @NameInMap("values")
    public java.util.List<java.util.List<?>> values;

    public static GetRangeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRangeResponseBody self = new GetRangeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRangeResponseBody setBackgroundColors(java.util.List<java.util.List<GetRangeResponseBodyBackgroundColors>> backgroundColors) {
        this.backgroundColors = backgroundColors;
        return this;
    }
    public java.util.List<java.util.List<GetRangeResponseBodyBackgroundColors>> getBackgroundColors() {
        return this.backgroundColors;
    }

    public GetRangeResponseBody setDisplayValues(java.util.List<java.util.List<String>> displayValues) {
        this.displayValues = displayValues;
        return this;
    }
    public java.util.List<java.util.List<String>> getDisplayValues() {
        return this.displayValues;
    }

    public GetRangeResponseBody setFormulas(java.util.List<java.util.List<String>> formulas) {
        this.formulas = formulas;
        return this;
    }
    public java.util.List<java.util.List<String>> getFormulas() {
        return this.formulas;
    }

    public GetRangeResponseBody setValues(java.util.List<java.util.List<?>> values) {
        this.values = values;
        return this;
    }
    public java.util.List<java.util.List<?>> getValues() {
        return this.values;
    }

    public static class GetRangeResponseBodyBackgroundColors extends TeaModel {
        /**
         * <p>RGB值中的红色值</p>
         */
        @NameInMap("red")
        public Long red;

        /**
         * <p>RGB值中的绿色值</p>
         */
        @NameInMap("green")
        public Long green;

        /**
         * <p>RGB值中的蓝色值</p>
         */
        @NameInMap("blue")
        public Long blue;

        /**
         * <p>16进制表示的颜色</p>
         */
        @NameInMap("hexString")
        public String hexString;

        public static GetRangeResponseBodyBackgroundColors build(java.util.Map<String, ?> map) throws Exception {
            GetRangeResponseBodyBackgroundColors self = new GetRangeResponseBodyBackgroundColors();
            return TeaModel.build(map, self);
        }

        public GetRangeResponseBodyBackgroundColors setRed(Long red) {
            this.red = red;
            return this;
        }
        public Long getRed() {
            return this.red;
        }

        public GetRangeResponseBodyBackgroundColors setGreen(Long green) {
            this.green = green;
            return this;
        }
        public Long getGreen() {
            return this.green;
        }

        public GetRangeResponseBodyBackgroundColors setBlue(Long blue) {
            this.blue = blue;
            return this;
        }
        public Long getBlue() {
            return this.blue;
        }

        public GetRangeResponseBodyBackgroundColors setHexString(String hexString) {
            this.hexString = hexString;
            return this;
        }
        public String getHexString() {
            return this.hexString;
        }

    }

}
