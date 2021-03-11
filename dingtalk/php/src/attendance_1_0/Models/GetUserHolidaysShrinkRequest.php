<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserHolidaysShrinkRequest extends Model
{
    /**
     * @description 查询对象
     *
     * @var string
     */
    public $topHolidayQueryParamShrink;
    protected $_name = [
        'topHolidayQueryParamShrink' => 'topHolidayQueryParam',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->topHolidayQueryParamShrink) {
            $res['topHolidayQueryParam'] = $this->topHolidayQueryParamShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserHolidaysShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['topHolidayQueryParam'])) {
            $model->topHolidayQueryParamShrink = $map['topHolidayQueryParam'];
        }

        return $model;
    }
}
