<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskDetailResponseBody;

use AlibabaCloud\Tea\Model;

class executorStatus extends Model
{
    /**
     * @description 执行者完成状态
     *
     * @var bool
     */
    public $isDone;

    /**
     * @description 执行者id（用户的unionId）
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'isDone' => 'isDone',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
