<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class PrivateChatQueryResponseBody extends Model
{
    /**
     * @description 分页查询是否还有人员可查询消息已读状态
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 下次分页查询的加密凭证
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 消息已读人的userId列表
     *
     * @var string[]
     */
    public $readUserIds;

    /**
     * @description 消息发送状态
     *
     * @var string
     */
    public $sendStatus;
    protected $_name = [
        'hasMore'     => 'hasMore',
        'nextToken'   => 'nextToken',
        'readUserIds' => 'readUserIds',
        'sendStatus'  => 'sendStatus',
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
        if (null !== $this->readUserIds) {
            $res['readUserIds'] = $this->readUserIds;
        }
        if (null !== $this->sendStatus) {
            $res['sendStatus'] = $this->sendStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PrivateChatQueryResponseBody
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
        if (isset($map['readUserIds'])) {
            if (!empty($map['readUserIds'])) {
                $model->readUserIds = $map['readUserIds'];
            }
        }
        if (isset($map['sendStatus'])) {
            $model->sendStatus = $map['sendStatus'];
        }

        return $model;
    }
}
