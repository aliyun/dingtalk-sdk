<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest\detail;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest\detail\messageBody\actionCard;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest\detail\messageBody\link;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest\detail\messageBody\markdown;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest\detail\messageBody\text;
use AlibabaCloud\Tea\Model;

class messageBody extends Model
{
    /**
     * @description 文本消息体  对于文本类型消息时必填
     *
     * @var text
     */
    public $text;

    /**
     * @description markdown消息，仅对消息类型为markdown时有效
     *
     * @var markdown
     */
    public $markdown;

    /**
     * @description 链接消息类型
     *
     * @var link
     */
    public $link;

    /**
     * @description 卡片消息
     *
     * @var actionCard
     */
    public $actionCard;
    protected $_name = [
        'text'       => 'text',
        'markdown'   => 'markdown',
        'link'       => 'link',
        'actionCard' => 'actionCard',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->text) {
            $res['text'] = null !== $this->text ? $this->text->toMap() : null;
        }
        if (null !== $this->markdown) {
            $res['markdown'] = null !== $this->markdown ? $this->markdown->toMap() : null;
        }
        if (null !== $this->link) {
            $res['link'] = null !== $this->link ? $this->link->toMap() : null;
        }
        if (null !== $this->actionCard) {
            $res['actionCard'] = null !== $this->actionCard ? $this->actionCard->toMap() : null;
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
        if (isset($map['text'])) {
            $model->text = text::fromMap($map['text']);
        }
        if (isset($map['markdown'])) {
            $model->markdown = markdown::fromMap($map['markdown']);
        }
        if (isset($map['link'])) {
            $model->link = link::fromMap($map['link']);
        }
        if (isset($map['actionCard'])) {
            $model->actionCard = actionCard::fromMap($map['actionCard']);
        }

        return $model;
    }
}
