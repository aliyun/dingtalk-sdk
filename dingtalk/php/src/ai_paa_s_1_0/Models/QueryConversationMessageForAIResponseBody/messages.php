<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryConversationMessageForAIResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryConversationMessageForAIResponseBody\messages\atUsers;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryConversationMessageForAIResponseBody\messages\sender;
use AlibabaCloud\Tea\Model;

class messages extends Model
{
    /**
     * @var bool
     */
    public $atAll;

    /**
     * @var atUsers[]
     */
    public $atUsers;

    /**
     * @var string
     */
    public $msgContent;

    /**
     * @var string
     */
    public $msgType;

    /**
     * @var string
     */
    public $sendTime;

    /**
     * @var sender
     */
    public $sender;

    /**
     * @var string
     */
    public $summary;
    protected $_name = [
        'atAll' => 'atAll',
        'atUsers' => 'atUsers',
        'msgContent' => 'msgContent',
        'msgType' => 'msgType',
        'sendTime' => 'sendTime',
        'sender' => 'sender',
        'summary' => 'summary',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->atAll) {
            $res['atAll'] = $this->atAll;
        }
        if (null !== $this->atUsers) {
            $res['atUsers'] = [];
            if (null !== $this->atUsers && \is_array($this->atUsers)) {
                $n = 0;
                foreach ($this->atUsers as $item) {
                    $res['atUsers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->msgContent) {
            $res['msgContent'] = $this->msgContent;
        }
        if (null !== $this->msgType) {
            $res['msgType'] = $this->msgType;
        }
        if (null !== $this->sendTime) {
            $res['sendTime'] = $this->sendTime;
        }
        if (null !== $this->sender) {
            $res['sender'] = null !== $this->sender ? $this->sender->toMap() : null;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return messages
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atAll'])) {
            $model->atAll = $map['atAll'];
        }
        if (isset($map['atUsers'])) {
            if (!empty($map['atUsers'])) {
                $model->atUsers = [];
                $n = 0;
                foreach ($map['atUsers'] as $item) {
                    $model->atUsers[$n++] = null !== $item ? atUsers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['msgContent'])) {
            $model->msgContent = $map['msgContent'];
        }
        if (isset($map['msgType'])) {
            $model->msgType = $map['msgType'];
        }
        if (isset($map['sendTime'])) {
            $model->sendTime = $map['sendTime'];
        }
        if (isset($map['sender'])) {
            $model->sender = sender::fromMap($map['sender']);
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }

        return $model;
    }
}
