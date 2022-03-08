<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail\messageBody\actionCard;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail\messageBody\link;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail\messageBody\markdown;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail\messageBody\text;
use AlibabaCloud\Tea\Model;

class messageBody extends Model
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

    /**
     * @var text
     */
    public $text;
    protected $_name = [
        'actionCard' => 'actionCard',
        'link'       => 'link',
        'markdown'   => 'markdown',
        'text'       => 'text',
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
