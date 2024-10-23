<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSceneGroupsByTemplateIdResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $openConversationIds;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'openConversationIds' => 'openConversationIds',
        'success'             => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSceneGroupsByTemplateIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationIds'])) {
            if (!empty($map['openConversationIds'])) {
                $model->openConversationIds = $map['openConversationIds'];
            }
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
