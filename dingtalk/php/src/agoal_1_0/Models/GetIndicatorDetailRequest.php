<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetIndicatorDetailRequest extends Model
{
    /**
     * @var string
     */
    public $indicatorId;

    /**
     * @var int
     */
    public $monthNum;
    protected $_name = [
        'indicatorId' => 'indicatorId',
        'monthNum' => 'monthNum',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->indicatorId) {
            $res['indicatorId'] = $this->indicatorId;
        }
        if (null !== $this->monthNum) {
            $res['monthNum'] = $this->monthNum;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetIndicatorDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['indicatorId'])) {
            $model->indicatorId = $map['indicatorId'];
        }
        if (isset($map['monthNum'])) {
            $model->monthNum = $map['monthNum'];
        }

        return $model;
    }
}
