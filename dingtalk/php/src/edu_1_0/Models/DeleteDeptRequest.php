<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteDeptRequest extends Model
{
    /**
     * @example manager1234
     *
     * @var string
     */
    public $operator;
    protected $_name = [
        'operator' => 'operator',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
