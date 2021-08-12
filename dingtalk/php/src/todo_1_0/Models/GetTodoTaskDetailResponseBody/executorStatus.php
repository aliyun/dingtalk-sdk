<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskDetailResponseBody;

use AlibabaCloud\Tea\Model;

class executorStatus extends Model
{
    /**
     * @description 执行者id（用户的unionId）
     *
     * @var string
     */
    public $userId;

    /**
     * @description 执行者完成状态
     *
     * @var bool
     */
    public $isDone;
    protected $_name = [
        'userId' => 'userId',
        'isDone' => 'isDone',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return executorStatus
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }

        return $model;
    }
}
