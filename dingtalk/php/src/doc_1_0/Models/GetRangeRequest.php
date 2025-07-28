<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRangeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example select
     *
     * @var string
     */
    public $select;
    protected $_name = [
        'operatorId' => 'operatorId',
        'select' => 'select',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->select) {
            $res['select'] = $this->select;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRangeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['select'])) {
            $model->select = $map['select'];
        }

        return $model;
    }
}
