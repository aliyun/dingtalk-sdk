<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetConversationSubtitleRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cidxxxx
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example 副标题
     *
     * @var string
     */
    public $subtitle;

    /**
     * @example #0000FF
     *
     * @var string
     */
    public $subtitleColor;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'subtitle' => 'subtitle',
        'subtitleColor' => 'subtitleColor',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->subtitle) {
            $res['subtitle'] = $this->subtitle;
        }
        if (null !== $this->subtitleColor) {
            $res['subtitleColor'] = $this->subtitleColor;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetConversationSubtitleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['subtitle'])) {
            $model->subtitle = $map['subtitle'];
        }
        if (isset($map['subtitleColor'])) {
            $model->subtitleColor = $map['subtitleColor'];
        }

        return $model;
    }
}
