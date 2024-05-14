<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteGroupBlackboardRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example e3b4f5
     *
     * @var string
     */
    public $dataId;

    /**
     * @description This parameter is required.
     *
     * @example cid123456
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @example 001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'dataId'             => 'dataId',
        'openConversationId' => 'openConversationId',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataId) {
            $res['dataId'] = $this->dataId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteGroupBlackboardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dataId'])) {
            $model->dataId = $map['dataId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
