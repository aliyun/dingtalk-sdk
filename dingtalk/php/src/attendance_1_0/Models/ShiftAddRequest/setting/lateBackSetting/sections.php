<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest\setting\lateBackSetting;

use AlibabaCloud\Tea\Model;

class sections extends Model
{
    /**
     * @example 120
     *
     * @var int
     */
    public $extra;

    /**
     * @example 60
     *
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
     * @return sections
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
