<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksResponseBody\todoCards;
use AlibabaCloud\Tea\Model;

class QueryTodoTasksResponseBody extends Model
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

    /**
     * @description 数据总量
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'nextToken'  => 'nextToken',
        'todoCards'  => 'todoCards',
        'totalCount' => 'totalCount',
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
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTodoTasksResponseBody
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
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
