<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskExecutorStatusRequest;

use AlibabaCloud\Tea\Model;

class executorStatusList extends Model
{
    /**
     * @description 执行者id，需传用户的unionId
     *
     * @var string
     */
    public $id;

    /**
     * @description 执行者完成状态
     *
     * @var bool
     */
    public $isDone;
    protected $_name = [
        'id'     => 'id',
        'isDone' => 'isDone',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return executorStatusList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }

        return $model;
    }
}
