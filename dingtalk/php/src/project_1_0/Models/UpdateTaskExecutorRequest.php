<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTaskExecutorRequest extends Model
{
    /**
     * @description 执行者用户ID。
     *
     * @var string
     */
    public $executorId;
    protected $_name = [
        'executorId' => 'executorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->executorId) {
            $res['executorId'] = $this->executorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTaskExecutorRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['executorId'])) {
            $model->executorId = $map['executorId'];
        }

        return $model;
    }
}
