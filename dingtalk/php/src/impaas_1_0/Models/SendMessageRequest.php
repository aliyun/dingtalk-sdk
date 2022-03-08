<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMessageRequest extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $conversationId;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $receiverUid;

    /**
     * @var string
     */
    public $senderUid;

    /**
     * @var string
     */
    public $uuid;
    protected $_name = [
        'content'        => 'content',
        'conversationId' => 'conversationId',
        'createTime'     => 'createTime',
        'receiverUid'    => 'receiverUid',
        'senderUid'      => 'senderUid',
        'uuid'           => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->receiverUid) {
            $res['receiverUid'] = $this->receiverUid;
        }
        if (null !== $this->senderUid) {
            $res['senderUid'] = $this->senderUid;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
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
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['receiverUid'])) {
            $model->receiverUid = $map['receiverUid'];
        }
        if (isset($map['senderUid'])) {
            $model->senderUid = $map['senderUid'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
