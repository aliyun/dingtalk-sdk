<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendMessageRequest;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendMessageRequest\msgBody\actionCard;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendMessageRequest\msgBody\link;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendMessageRequest\msgBody\markdown;
use AlibabaCloud\Tea\Model;

class msgBody extends Model
{
    /**
     * @var actionCard
     */
    public $actionCard;

    /**
     * @var link
     */
    public $link;

    /**
     * @var markdown
     */
    public $markdown;
    protected $_name = [
        'actionCard' => 'action_card',
        'link' => 'link',
        'markdown' => 'markdown',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionCard) {
            $res['action_card'] = null !== $this->actionCard ? $this->actionCard->toMap() : null;
        }
        if (null !== $this->link) {
            $res['link'] = null !== $this->link ? $this->link->toMap() : null;
        }
        if (null !== $this->markdown) {
            $res['markdown'] = null !== $this->markdown ? $this->markdown->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return msgBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action_card'])) {
            $model->actionCard = actionCard::fromMap($map['action_card']);
        }
        if (isset($map['link'])) {
            $model->link = link::fromMap($map['link']);
        }
        if (isset($map['markdown'])) {
            $model->markdown = markdown::fromMap($map['markdown']);
        }

        return $model;
    }
}
