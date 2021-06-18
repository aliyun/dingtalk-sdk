<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\Tea\Model;

class PullDataByPkRequest extends Model
{
    /**
     * @description 数据的主键字段值。
     *
     * @var string
     */
    public $primaryKey;
    protected $_name = [
        'primaryKey' => 'primaryKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->primaryKey) {
            $res['primaryKey'] = $this->primaryKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PullDataByPkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['primaryKey'])) {
            $model->primaryKey = $map['primaryKey'];
        }

        return $model;
    }
}
