<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreConversationsResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @example xxxx店
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

    /**
     * @example 123
     *
     * @var int
     */
    public $id;
    protected $_name = [
        'conversationTitle' => 'conversationTitle',
        'conversationType'  => 'conversationType',
        'id'                => 'id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationTitle) {
            $res['conversationTitle'] = $this->conversationTitle;
        }
        if (null !== $this->conversationType) {
            $res['conversationType'] = $this->conversationType;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }

        return $model;
    }
}
