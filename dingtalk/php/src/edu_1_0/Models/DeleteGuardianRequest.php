<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteGuardianRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example manager123
     *
     * @var string
     */
    public $operator;

    /**
     * @description This parameter is required.
     *
     * @example 1345
     *
     * @var string
     */
    public $stuId;
    protected $_name = [
        'operator' => 'operator',
        'stuId'    => 'stuId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->stuId) {
            $res['stuId'] = $this->stuId;
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
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['stuId'])) {
            $model->stuId = $map['stuId'];
        }

        return $model;
    }
}
