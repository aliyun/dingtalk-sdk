<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\props;

use AlibabaCloud\Tea\Model;

class push extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $attendanceRule;

    /**
     * @example 1
     *
     * @var int
     */
    public $pushSwitch;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $pushTag;
    protected $_name = [
        'attendanceRule' => 'attendanceRule',
        'pushSwitch'     => 'pushSwitch',
        'pushTag'        => 'pushTag',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attendanceRule) {
            $res['attendanceRule'] = $this->attendanceRule;
        }
        if (null !== $this->pushSwitch) {
            $res['pushSwitch'] = $this->pushSwitch;
        }
        if (null !== $this->pushTag) {
            $res['pushTag'] = $this->pushTag;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return push
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attendanceRule'])) {
            $model->attendanceRule = $map['attendanceRule'];
        }
        if (isset($map['pushSwitch'])) {
            $model->pushSwitch = $map['pushSwitch'];
        }
        if (isset($map['pushTag'])) {
            $model->pushTag = $map['pushTag'];
        }

        return $model;
    }
}
