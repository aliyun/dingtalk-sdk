<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedResponseBody\result\classSetting;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedResponseBody\result\classSetting\restTimeList\begin;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedResponseBody\result\classSetting\restTimeList\end;
use AlibabaCloud\Tea\Model;

class restTimeList extends Model
{
    /**
     * @var begin
     */
    public $begin;

    /**
     * @var end
     */
    public $end;
    protected $_name = [
        'begin' => 'begin',
        'end' => 'end',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->begin) {
            $res['begin'] = null !== $this->begin ? $this->begin->toMap() : null;
        }
        if (null !== $this->end) {
            $res['end'] = null !== $this->end ? $this->end->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return restTimeList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['begin'])) {
            $model->begin = begin::fromMap($map['begin']);
        }
        if (isset($map['end'])) {
            $model->end = end::fromMap($map['end']);
        }

        return $model;
    }
}
