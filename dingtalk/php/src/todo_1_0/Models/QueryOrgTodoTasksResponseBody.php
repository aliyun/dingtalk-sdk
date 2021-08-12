<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryOrgTodoTasksResponseBody\todoCards;
use AlibabaCloud\Tea\Model;

class QueryOrgTodoTasksResponseBody extends Model
{
    /**
     * @description 翻页token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 待办卡片列表
     *
     * @var todoCards[]
     */
    public $todoCards;
    protected $_name = [
        'nextToken' => 'nextToken',
        'todoCards' => 'todoCards',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->todoCards) {
            $res['todoCards'] = [];
            if (null !== $this->todoCards && \is_array($this->todoCards)) {
                $n = 0;
                foreach ($this->todoCards as $item) {
                    $res['todoCards'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrgTodoTasksResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['todoCards'])) {
            if (!empty($map['todoCards'])) {
                $model->todoCards = [];
                $n                = 0;
                foreach ($map['todoCards'] as $item) {
                    $model->todoCards[$n++] = null !== $item ? todoCards::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
