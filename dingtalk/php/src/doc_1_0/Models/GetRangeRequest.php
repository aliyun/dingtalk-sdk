<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRangeRequest extends Model
{
    /**
     * @description 操作人id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 限定要返回的字段
     *
     * @var string
     */
    public $select;
    protected $_name = [
        'operatorId' => 'operatorId',
        'select'     => 'select',
    ];

    public function validate()
    {
    }

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
