<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMsgReadStatusResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var int
     */
    public $nextCursor;

    /**
     * @var string
     */
    public $openMessageId;

    /**
     * @var string[]
     */
    public $readUnionIds;

    /**
     * @var string[]
     */
    public $readUserIds;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'hasMore' => 'hasMore',
        'nextCursor' => 'nextCursor',
        'openMessageId' => 'openMessageId',
        'readUnionIds' => 'readUnionIds',
        'readUserIds' => 'readUserIds',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
        }
        if (null !== $this->openMessageId) {
            $res['openMessageId'] = $this->openMessageId;
        }
        if (null !== $this->readUnionIds) {
            $res['readUnionIds'] = $this->readUnionIds;
        }
        if (null !== $this->readUserIds) {
            $res['readUserIds'] = $this->readUserIds;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }
        if (isset($map['openMessageId'])) {
            $model->openMessageId = $map['openMessageId'];
        }
        if (isset($map['readUnionIds'])) {
            if (!empty($map['readUnionIds'])) {
                $model->readUnionIds = $map['readUnionIds'];
            }
        }
        if (isset($map['readUserIds'])) {
            if (!empty($map['readUserIds'])) {
                $model->readUserIds = $map['readUserIds'];
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
