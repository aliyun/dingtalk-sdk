<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryProcessesWorkItemsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 006f870b-4d1c-4cd0-85b3-2e866798e947
     *
     * @var string
     */
    public $processInstanceId;
    protected $_name = [
        'processInstanceId' => 'processInstanceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryProcessesWorkItemsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }

        return $model;
    }
}
