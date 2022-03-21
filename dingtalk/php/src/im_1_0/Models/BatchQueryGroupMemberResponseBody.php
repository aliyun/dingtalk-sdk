<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryGroupMemberResponseBody extends Model
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
    public $nextToken;

    /**
     * @description result
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'hasMore'       => 'hasMore',
        'memberUserIds' => 'memberUserIds',
        'nextToken'     => 'nextToken',
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
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryGroupMemberResponseBody
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
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
