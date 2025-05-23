<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedResponseBody\result\classSetting\restTimeList;

use AlibabaCloud\Tea\Model;

class end extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $across;

    /**
     * @example 1970-01-01T13:00Z
     *
     * @var string
     */
    public $checkTime;
    protected $_name = [
        'across' => 'across',
        'checkTime' => 'checkTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->across) {
            $res['across'] = $this->across;
        }
        if (null !== $this->checkTime) {
            $res['checkTime'] = $this->checkTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return end
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['across'])) {
            $model->across = $map['across'];
        }
        if (isset($map['checkTime'])) {
            $model->checkTime = $map['checkTime'];
        }

        return $model;
    }
}
