<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateRequest;

use AlibabaCloud\Tea\Model;

class shiftVOList extends Model
{
    /**
     * @example 123
     *
     * @var int
     */
    public $shiftId;
    protected $_name = [
        'shiftId' => 'shiftId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->shiftId) {
            $res['shiftId'] = $this->shiftId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return shiftVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['shiftId'])) {
            $model->shiftId = $map['shiftId'];
        }

        return $model;
    }
}
