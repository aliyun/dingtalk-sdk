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

    /**
     * @example cid1234984881
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'conversationTitle'  => 'conversationTitle',
        'conversationType'   => 'conversationType',
        'id'                 => 'id',
        'openConversationId' => 'openConversationId',
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
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
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
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
