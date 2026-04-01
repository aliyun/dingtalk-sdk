<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListGroupBlackboardRequest extends Model
{
    /**
     * @var string
     */
    public $nextPageCursor;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'nextPageCursor' => 'nextPageCursor',
        'openConversationId' => 'openConversationId',
        'pageSize' => 'pageSize',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextPageCursor) {
            $res['nextPageCursor'] = $this->nextPageCursor;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListGroupBlackboardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextPageCursor'])) {
            $model->nextPageCursor = $map['nextPageCursor'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
