<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AddLeaveTypeRequest;

use AlibabaCloud\Tea\Model;

class visibilityRules extends Model
{
    /**
     * @description 规则类型：dept-部门；staff-员工；label-角色
     *
     * @var string
     */
    public $type;

    /**
     * @description 规则数据：当type=staff时，传员工userId列表；当type=dept时，传部门id列表；当type=label时，传角色id列表
     *
     * @var string[]
     */
    public $visible;
    protected $_name = [
        'type'    => 'type',
        'visible' => 'visible',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->visible) {
            $res['visible'] = $this->visible;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return visibilityRules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['visible'])) {
            if (!empty($map['visible'])) {
                $model->visible = $map['visible'];
            }
        }

        return $model;
    }
}
