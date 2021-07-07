<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMessageRequest extends Model
{
    /**
     * @var string
     */
    public $senderUid;

    /**
     * @var string
     */
    public $receiverUid;

    /**
     * @var string
     */
    public $conversationId;

    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $uuid;

    /**
     * @var int
     */
    public $createTime;
    protected $_name = [
        'senderUid'      => 'senderUid',
        'receiverUid'    => 'receiverUid',
        'conversationId' => 'conversationId',
        'content'        => 'content',
        'uuid'           => 'uuid',
        'createTime'     => 'createTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->senderUid) {
            $res['senderUid'] = $this->senderUid;
        }
        if (null !== $this->receiverUid) {
            $res['receiverUid'] = $this->receiverUid;
        }
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['senderUid'])) {
            $model->senderUid = $map['senderUid'];
        }
        if (isset($map['receiverUid'])) {
            $model->receiverUid = $map['receiverUid'];
        }
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }

        return $model;
    }
}
