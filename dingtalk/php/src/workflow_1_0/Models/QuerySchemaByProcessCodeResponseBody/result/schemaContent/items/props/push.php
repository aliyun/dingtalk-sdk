<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\props;

use AlibabaCloud\Tea\Model;

class push extends Model
{
    /**
     * @description 开启状态(1表示开启, 0表示关闭)
     *
     * @var int
     */
    public $pushSwitch;

    /**
     * @description 状态显示名称
     *
     * @var string
     */
    public $pushTag;

    /**
     * @description 考勤类型(1表示请假, 2表示出差, 3表示加班, 4表示外出)
     *
     * @var int
     */
    public $attendanceRule;
    protected $_name = [
        'pushSwitch'     => 'pushSwitch',
        'pushTag'        => 'pushTag',
        'attendanceRule' => 'attendanceRule',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pushSwitch) {
            $res['pushSwitch'] = $this->pushSwitch;
        }
        if (null !== $this->pushTag) {
            $res['pushTag'] = $this->pushTag;
        }
        if (null !== $this->attendanceRule) {
            $res['attendanceRule'] = $this->attendanceRule;
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
        if (isset($map['pushSwitch'])) {
            $model->pushSwitch = $map['pushSwitch'];
        }
        if (isset($map['pushTag'])) {
            $model->pushTag = $map['pushTag'];
        }
        if (isset($map['attendanceRule'])) {
            $model->attendanceRule = $map['attendanceRule'];
        }

        return $model;
    }
}
