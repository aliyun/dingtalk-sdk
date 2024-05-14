<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendMessageTipRequest\defaultView;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendMessageTipRequest\publicField;
use AlibabaCloud\Tea\Model;

class SendMessageTipRequest extends Model
{
    /**
     * @var defaultView
     */
    public $defaultView;

    /**
     * @description This parameter is required.
     *
     * @example msg_f9aae78558b34e20a5badead4c29244c_123
     *
     * @var string
     */
    public $messageId;

    /**
     * @description This parameter is required.
     *
     * @example cidVcYPzxnAySJOMhYX2QDbLwUA==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var PrivateFieldMapValue[]
     */
    public $privateFieldMap;

    /**
     * @var publicField
     */
    public $publicField;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $receiverUserId;

    /**
     * @example 0808541222161261721
     *
     * @var string
     */
    public $senderUserId;
    protected $_name = [
        'defaultView'        => 'defaultView',
        'messageId'          => 'messageId',
        'openConversationId' => 'openConversationId',
        'privateFieldMap'    => 'privateFieldMap',
        'publicField'        => 'publicField',
        'receiverUserId'     => 'receiverUserId',
        'senderUserId'       => 'senderUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->defaultView) {
            $res['defaultView'] = null !== $this->defaultView ? $this->defaultView->toMap() : null;
        }
        if (null !== $this->messageId) {
            $res['messageId'] = $this->messageId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->privateFieldMap) {
            $res['privateFieldMap'] = [];
            if (null !== $this->privateFieldMap && \is_array($this->privateFieldMap)) {
                foreach ($this->privateFieldMap as $key => $val) {
                    $res['privateFieldMap'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->publicField) {
            $res['publicField'] = null !== $this->publicField ? $this->publicField->toMap() : null;
        }
        if (null !== $this->receiverUserId) {
            $res['receiverUserId'] = $this->receiverUserId;
        }
        if (null !== $this->senderUserId) {
            $res['senderUserId'] = $this->senderUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMessageTipRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['defaultView'])) {
            $model->defaultView = defaultView::fromMap($map['defaultView']);
        }
        if (isset($map['messageId'])) {
            $model->messageId = $map['messageId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['privateFieldMap'])) {
            $model->privateFieldMap = $map['privateFieldMap'];
        }
        if (isset($map['publicField'])) {
            $model->publicField = publicField::fromMap($map['publicField']);
        }
        if (isset($map['receiverUserId'])) {
            if (!empty($map['receiverUserId'])) {
                $model->receiverUserId = $map['receiverUserId'];
            }
        }
        if (isset($map['senderUserId'])) {
            $model->senderUserId = $map['senderUserId'];
        }

        return $model;
    }
}
