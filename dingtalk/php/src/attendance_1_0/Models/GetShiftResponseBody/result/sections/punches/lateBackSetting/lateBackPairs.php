<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result\sections\punches\lateBackSetting;

use AlibabaCloud\Tea\Model;

class lateBackPairs extends Model
{
    /**
     * @var int
     */
    public $extra;

    /**
     * @var int
     */
    public $late;
    protected $_name = [
        'extra' => 'extra',
        'late'  => 'late',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extra) {
            $res['extra'] = $this->extra;
        }
        if (null !== $this->late) {
            $res['late'] = $this->late;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return lateBackPairs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extra'])) {
            $model->extra = $map['extra'];
        }
        if (isset($map['late'])) {
            $model->late = $map['late'];
        }

        return $model;
    }
}
