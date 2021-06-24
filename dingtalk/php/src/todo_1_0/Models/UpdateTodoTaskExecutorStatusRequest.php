<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskExecutorStatusRequest\executorStatusList;
use AlibabaCloud\Tea\Model;

class UpdateTodoTaskExecutorStatusRequest extends Model
{
    /**
     * @description 执行者状态列表，id需传用户的unionId
     *
     * @var executorStatusList[]
     */
    public $executorStatusList;

    /**
     * @description 当前操作者id，需传用户的unionId
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'executorStatusList' => 'executorStatusList',
        'operatorId'         => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->executorStatusList) {
            $res['executorStatusList'] = [];
            if (null !== $this->executorStatusList && \is_array($this->executorStatusList)) {
                $n = 0;
                foreach ($this->executorStatusList as $item) {
                    $res['executorStatusList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTodoTaskExecutorStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['executorStatusList'])) {
            if (!empty($map['executorStatusList'])) {
                $model->executorStatusList = [];
                $n                         = 0;
                foreach ($map['executorStatusList'] as $item) {
                    $model->executorStatusList[$n++] = null !== $item ? executorStatusList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
