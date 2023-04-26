<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryGroupMemberResponseBody extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @example cidXXXXXXXXX==
     *
     * @var string[]
     */
    public $memberUserIds;

    /**
     * @example 92233720368
     *
     * @var string
     */
    public $nextToken;

    /**
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
