<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail;

use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody\actionCard;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody\image;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody\interactiveMessage;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody\link;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody\markdown;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody\text;
use AlibabaCloud\Tea\Model;

class messageBody extends Model
{
    /**
     * @description 卡片消息
     *
     * @var actionCard
     */
    public $actionCard;

    /**
     * @description 图片类型的消息场景使用
     *
     * @var image
     */
    public $image;

    /**
     * @var interactiveMessage
     */
    public $interactiveMessage;

    /**
     * @description 链接消息类型
     *
     * @var link
     */
    public $link;

    /**
     * @description markdown消息，仅对消息类型为markdown时有效
     *
     * @var markdown
     */
    public $markdown;

    /**
     * @description 文本消息体  对于文本类型消息时必填
     *
     * @var text
     */
    public $text;
    protected $_name = [
        'actionCard'         => 'actionCard',
        'image'              => 'image',
        'interactiveMessage' => 'interactiveMessage',
        'link'               => 'link',
        'markdown'           => 'markdown',
        'text'               => 'text',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionCard) {
            $res['actionCard'] = null !== $this->actionCard ? $this->actionCard->toMap() : null;
        }
        if (null !== $this->image) {
            $res['image'] = null !== $this->image ? $this->image->toMap() : null;
        }
        if (null !== $this->interactiveMessage) {
            $res['interactiveMessage'] = null !== $this->interactiveMessage ? $this->interactiveMessage->toMap() : null;
        }
        if (null !== $this->link) {
            $res['link'] = null !== $this->link ? $this->link->toMap() : null;
        }
        if (null !== $this->markdown) {
            $res['markdown'] = null !== $this->markdown ? $this->markdown->toMap() : null;
        }
        if (null !== $this->text) {
            $res['text'] = null !== $this->text ? $this->text->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return messageBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionCard'])) {
            $model->actionCard = actionCard::fromMap($map['actionCard']);
        }
        if (isset($map['image'])) {
            $model->image = image::fromMap($map['image']);
        }
        if (isset($map['interactiveMessage'])) {
            $model->interactiveMessage = interactiveMessage::fromMap($map['interactiveMessage']);
        }
        if (isset($map['link'])) {
            $model->link = link::fromMap($map['link']);
        }
        if (isset($map['markdown'])) {
            $model->markdown = markdown::fromMap($map['markdown']);
        }
        if (isset($map['text'])) {
            $model->text = text::fromMap($map['text']);
        }

        return $model;
    }
}
