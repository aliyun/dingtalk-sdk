<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSceneGroupMembersResponseBody extends Model
{
    /**
     * @description result
     *
     * @var bool
     */
    public $success;

    /**
     * @description 群成员员工号
     *
     * @var string[]
     */
    public $memberUserIds;

    /**
     * @description 是否还有更多数据
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 下一次请求的游标
     *
     * @var string
     */
    public $nextCursor;
    protected $_name = [
        'success'       => 'success',
        'memberUserIds' => 'memberUserIds',
        'hasMore'       => 'hasMore',
        'nextCursor'    => 'nextCursor',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->memberUserIds) {
            $res['memberUserIds'] = $this->memberUserIds;
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
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
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['memberUserIds'])) {
            if (!empty($map['memberUserIds'])) {
                $model->memberUserIds = $map['memberUserIds'];
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }

        return $model;
    }
}
