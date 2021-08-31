<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptUsersResponseBody\userList;
use AlibabaCloud\Tea\Model;

class ListDeptUsersResponseBody extends Model
{
    /**
     * @description 用户列表
     *
     * @var userList[]
     */
    public $userList;

    /**
     * @var int
     */
    public $nextCursor;

    /**
     * @var bool
     */
    public $hasMore;
    protected $_name = [
        'userList'   => 'userList',
        'nextCursor' => 'nextCursor',
        'hasMore'    => 'hasMore',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userList) {
            $res['userList'] = [];
            if (null !== $this->userList && \is_array($this->userList)) {
                $n = 0;
                foreach ($this->userList as $item) {
                    $res['userList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListDeptUsersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userList'])) {
            if (!empty($map['userList'])) {
                $model->userList = [];
                $n               = 0;
                foreach ($map['userList'] as $item) {
                    $model->userList[$n++] = null !== $item ? userList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }

        return $model;
    }
}
