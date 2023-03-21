<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInnerGroupMembersResponseBody extends Model
{
    /**
     * @description 是否还有更多数据。
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 下一次请求的游标，若没有更多数据，则此参数为空。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 群成员userId列表。
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'hasMore'   => 'hasMore',
        'nextToken' => 'nextToken',
        'userIds'   => 'userIds',
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
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInnerGroupMembersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
