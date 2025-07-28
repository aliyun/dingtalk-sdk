<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ReadPersonalMessageRequest\dingOpenConversationMessageIdArray;
use AlibabaCloud\Tea\Model;

class ReadPersonalMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var dingOpenConversationMessageIdArray[]
     */
    public $dingOpenConversationMessageIdArray;
    protected $_name = [
        'dingOpenConversationMessageIdArray' => 'dingOpenConversationMessageIdArray',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingOpenConversationMessageIdArray) {
            $res['dingOpenConversationMessageIdArray'] = [];
            if (null !== $this->dingOpenConversationMessageIdArray && \is_array($this->dingOpenConversationMessageIdArray)) {
                $n = 0;
                foreach ($this->dingOpenConversationMessageIdArray as $item) {
                    $res['dingOpenConversationMessageIdArray'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ReadPersonalMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingOpenConversationMessageIdArray'])) {
            if (!empty($map['dingOpenConversationMessageIdArray'])) {
                $model->dingOpenConversationMessageIdArray = [];
                $n = 0;
                foreach ($map['dingOpenConversationMessageIdArray'] as $item) {
                    $model->dingOpenConversationMessageIdArray[$n++] = null !== $item ? dingOpenConversationMessageIdArray::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
