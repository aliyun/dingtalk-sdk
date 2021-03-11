<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysRequest\topHolidayQueryParam;
use AlibabaCloud\Tea\Model;

class GetUserHolidaysRequest extends Model
{
    /**
     * @description 查询对象
     *
     * @var topHolidayQueryParam
     */
    public $topHolidayQueryParam;
    protected $_name = [
        'topHolidayQueryParam' => 'topHolidayQueryParam',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->topHolidayQueryParam) {
            $res['topHolidayQueryParam'] = null !== $this->topHolidayQueryParam ? $this->topHolidayQueryParam->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserHolidaysRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['topHolidayQueryParam'])) {
            $model->topHolidayQueryParam = topHolidayQueryParam::fromMap($map['topHolidayQueryParam']);
        }

        return $model;
    }
}
