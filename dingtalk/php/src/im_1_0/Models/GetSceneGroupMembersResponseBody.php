<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSceneGroupMembersResponseBody extends Model
{
    /**
     * @description 是否还有更多数据
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 群成员员工号
     *
     * @var string[]
     */
    public $memberUserIds;

    /**
     * @description 下一次请求的游标
     *
     * @var string
     */
    public $nextCursor;

    /**
     * @description result
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'hasMore'       => 'hasMore',
        'memberUserIds' => 'memberUserIds',
        'nextCursor'    => 'nextCursor',
        'success'       => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->memberUserIds) {
            $res['memberUserIds'] = $this->memberUserIds;
        }
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSceneGroupMembersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['memberUserIds'])) {
            if (!empty($map['memberUserIds'])) {
                $model->memberUserIds = $map['memberUserIds'];
            }
        }
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
