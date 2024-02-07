<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendDingTipRequest\link;
use AlibabaCloud\Tea\Model;

class SendDingTipRequest extends Model
{
    /**
     * @var string[]
     */
    public $extension;

    /**
     * @var link
     */
    public $link;

    /**
     * @example msg_f9aae78558b34e20a5badead4c29244c_223
     *
     * @var string
     */
    public $messageId;

    /**
     * @var string[]
     */
    public $receiverUserId;

    /**
     * @example 080854121612261721
     *
     * @var string
     */
    public $senderUserId;

    /**
     * @example 您有一条闪读消息，请注意查收XX
     *
     * @var string
     */
    public $textContent;
    protected $_name = [
        'extension'      => 'extension',
        'link'           => 'link',
        'messageId'      => 'messageId',
        'receiverUserId' => 'receiverUserId',
        'senderUserId'   => 'senderUserId',
        'textContent'    => 'textContent',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->link) {
            $res['link'] = null !== $this->link ? $this->link->toMap() : null;
        }
        if (null !== $this->messageId) {
            $res['messageId'] = $this->messageId;
        }
        if (null !== $this->receiverUserId) {
            $res['receiverUserId'] = $this->receiverUserId;
        }
        if (null !== $this->senderUserId) {
            $res['senderUserId'] = $this->senderUserId;
        }
        if (null !== $this->textContent) {
            $res['textContent'] = $this->textContent;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendDingTipRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['link'])) {
            $model->link = link::fromMap($map['link']);
        }
        if (isset($map['messageId'])) {
            $model->messageId = $map['messageId'];
        }
        if (isset($map['receiverUserId'])) {
            if (!empty($map['receiverUserId'])) {
                $model->receiverUserId = $map['receiverUserId'];
            }
        }
        if (isset($map['senderUserId'])) {
            $model->senderUserId = $map['senderUserId'];
        }
        if (isset($map['textContent'])) {
            $model->textContent = $map['textContent'];
        }

        return $model;
    }
}
