<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteConvNavTabRequest extends Model
{
    /**
     * @example cidc4iLyQBuHFQRvzxznz204Q
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var string[]
     */
    public $tabIds;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'tabIds' => 'tabIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->tabIds) {
            $res['tabIds'] = $this->tabIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteConvNavTabRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['tabIds'])) {
            if (!empty($map['tabIds'])) {
                $model->tabIds = $map['tabIds'];
            }
        }

        return $model;
    }
}
