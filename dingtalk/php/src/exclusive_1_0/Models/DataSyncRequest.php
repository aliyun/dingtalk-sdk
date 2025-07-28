<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class DataSyncRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example sql语句
     *
     * @var string
     */
    public $sql;
    protected $_name = [
        'sql' => 'sql',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sql) {
            $res['sql'] = $this->sql;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DataSyncRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sql'])) {
            $model->sql = $map['sql'];
        }

        return $model;
    }
}
