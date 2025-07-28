<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRangeResponseBody;

use AlibabaCloud\Tea\Model;

class backgroundColors extends Model
{
    /**
     * @example red_value
     *
     * @var int
     */
    public $red;

    /**
     * @example green_value
     *
     * @var int
     */
    public $green;

    /**
     * @example blue_value
     *
     * @var int
     */
    public $blue;

    /**
     * @example hex_string_value
     *
     * @var string
     */
    public $hexString;
    protected $_name = [
        'red' => 'red',
        'green' => 'green',
        'blue' => 'blue',
        'hexString' => 'hexString',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->red) {
            $res['red'] = $this->red;
        }
        if (null !== $this->green) {
            $res['green'] = $this->green;
        }
        if (null !== $this->blue) {
            $res['blue'] = $this->blue;
        }
        if (null !== $this->hexString) {
            $res['hexString'] = $this->hexString;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return backgroundColors
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['red'])) {
            $model->red = $map['red'];
        }
        if (isset($map['green'])) {
            $model->green = $map['green'];
        }
        if (isset($map['blue'])) {
            $model->blue = $map['blue'];
        }
        if (isset($map['hexString'])) {
            $model->hexString = $map['hexString'];
        }

        return $model;
    }
}
