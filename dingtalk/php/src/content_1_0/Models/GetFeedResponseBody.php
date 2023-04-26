<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetFeedResponseBody\feedItem;
use AlibabaCloud\Tea\Model;

class GetFeedResponseBody extends Model
{
    /**
     * @example 3d******-1cd2-****-ba1d-8******3c6dc
     *
     * @var string
     */
    public $feedId;

    /**
     * @var feedItem[]
     */
    public $feedItem;
    protected $_name = [
        'feedId'   => 'feedId',
        'feedItem' => 'feedItem',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->feedId) {
            $res['feedId'] = $this->feedId;
        }
        if (null !== $this->feedItem) {
            $res['feedItem'] = [];
            if (null !== $this->feedItem && \is_array($this->feedItem)) {
                $n = 0;
                foreach ($this->feedItem as $item) {
                    $res['feedItem'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFeedResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['feedId'])) {
            $model->feedId = $map['feedId'];
        }
        if (isset($map['feedItem'])) {
            if (!empty($map['feedItem'])) {
                $model->feedItem = [];
                $n               = 0;
                foreach ($map['feedItem'] as $item) {
                    $model->feedItem[$n++] = null !== $item ? feedItem::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
