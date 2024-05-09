<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 白班
     *
     * @var string
     */
    public $name;

    /**
     * @example 1111
     *
     * @var int
     */
    public $shiftId;
    protected $_name = [
        'name'    => 'name',
        'shiftId' => 'shiftId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->shiftId) {
            $res['shiftId'] = $this->shiftId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['shiftId'])) {
            $model->shiftId = $map['shiftId'];
        }

        return $model;
    }
}
