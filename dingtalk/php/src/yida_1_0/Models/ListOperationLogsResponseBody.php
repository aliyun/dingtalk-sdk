<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListOperationLogsResponseBody extends Model
{
    /**
     * @description 操作记录对象
     *
     * @var mixed[]
     */
    public $operationLogMap;
    protected $_name = [
        'operationLogMap' => 'operationLogMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operationLogMap) {
            $res['operationLogMap'] = $this->operationLogMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListOperationLogsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operationLogMap'])) {
            $model->operationLogMap = $map['operationLogMap'];
        }

        return $model;
    }
}
