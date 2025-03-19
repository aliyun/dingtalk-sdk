<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreConversationsRequest extends Model
{
    /**
     * @example xxx店
     *
     * @var string
     */
    public $conversationTitle;

    /**
     * @example store
     *
     * @var string
     */
    public $conversationType;
    protected $_name = [
        'conversationTitle' => 'conversationTitle',
        'conversationType' => 'conversationType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationTitle) {
            $res['conversationTitle'] = $this->conversationTitle;
        }
        if (null !== $this->conversationType) {
            $res['conversationType'] = $this->conversationType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreConversationsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationTitle'])) {
            $model->conversationTitle = $map['conversationTitle'];
        }
        if (isset($map['conversationType'])) {
            $model->conversationType = $map['conversationType'];
        }

        return $model;
    }
}
