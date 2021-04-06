<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteTeacherRequest extends Model
{
    /**
     * @description 是否班主任；1:班主任；0:非班主任
     *
     * @var int
     */
    public $adviser;

    /**
     * @description 钉钉企业管理员员工ID
     *
     * @var string
     */
    public $operator;
    protected $_name = [
        'adviser'  => 'adviser',
        'operator' => 'operator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->adviser) {
            $res['adviser'] = $this->adviser;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteTeacherRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adviser'])) {
            $model->adviser = $map['adviser'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
