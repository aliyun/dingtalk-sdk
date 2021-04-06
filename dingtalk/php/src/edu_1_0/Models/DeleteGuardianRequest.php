<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteGuardianRequest extends Model
{
    /**
     * @description 学生ID
     *
     * @var string
     */
    public $stuId;

    /**
     * @description 钉钉企业管理员员工ID
     *
     * @var string
     */
    public $operator;
    protected $_name = [
        'stuId'    => 'stuId',
        'operator' => 'operator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->stuId) {
            $res['stuId'] = $this->stuId;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteGuardianRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['stuId'])) {
            $model->stuId = $map['stuId'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
