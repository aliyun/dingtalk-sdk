<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardBatchQueryCardsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardBatchQueryCardsResponseBody\result\cards;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var cards[]
     */
    public $cards;
    protected $_name = [
        'cards' => 'cards',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cards) {
            $res['cards'] = [];
            if (null !== $this->cards && \is_array($this->cards)) {
                $n = 0;
                foreach ($this->cards as $item) {
                    $res['cards'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cards'])) {
            if (!empty($map['cards'])) {
                $model->cards = [];
                $n = 0;
                foreach ($map['cards'] as $item) {
                    $model->cards[$n++] = null !== $item ? cards::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
