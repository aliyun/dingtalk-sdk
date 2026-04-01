<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\ListGroupBlackboardResponseBody\blackboardList;
use AlibabaCloud\Tea\Model;

class ListGroupBlackboardResponseBody extends Model
{
    /**
     * @var blackboardList[]
     */
    public $blackboardList;

    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var string
     */
    public $nextPageCursor;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'blackboardList' => 'blackboardList',
        'hasMore' => 'hasMore',
        'nextPageCursor' => 'nextPageCursor',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->blackboardList) {
            $res['blackboardList'] = [];
            if (null !== $this->blackboardList && \is_array($this->blackboardList)) {
                $n = 0;
                foreach ($this->blackboardList as $item) {
                    $res['blackboardList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextPageCursor) {
            $res['nextPageCursor'] = $this->nextPageCursor;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListGroupBlackboardResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blackboardList'])) {
            if (!empty($map['blackboardList'])) {
                $model->blackboardList = [];
                $n = 0;
                foreach ($map['blackboardList'] as $item) {
                    $model->blackboardList[$n++] = null !== $item ? blackboardList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextPageCursor'])) {
            $model->nextPageCursor = $map['nextPageCursor'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
