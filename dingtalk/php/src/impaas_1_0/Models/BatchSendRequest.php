<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchSendRequest extends Model
{
    /**
     * @var string[]
     */
    public $appUids;

    /**
     * @var string
     */
    public $content;

    /**
     * @var string[]
     */
    public $conversationIds;

    /**
     * @example 234#dingxxx@dingding
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appUids'         => 'appUids',
        'content'         => 'content',
        'conversationIds' => 'conversationIds',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUids) {
            $res['appUids'] = $this->appUids;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->conversationIds) {
            $res['conversationIds'] = $this->conversationIds;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchSendRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUids'])) {
            if (!empty($map['appUids'])) {
                $model->appUids = $map['appUids'];
            }
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['conversationIds'])) {
            if (!empty($map['conversationIds'])) {
                $model->conversationIds = $map['conversationIds'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
