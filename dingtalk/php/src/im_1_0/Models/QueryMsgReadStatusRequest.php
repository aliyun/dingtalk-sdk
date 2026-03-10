<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMsgReadStatusRequest extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $cursor;

    /**
     * @example cidc4iLyQBuHFQRvzxznz204Q==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $openTaskId;

    /**
     * @example 200
     *
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'cursor' => 'cursor',
        'openConversationId' => 'openConversationId',
        'openTaskId' => 'openTaskId',
        'pageSize' => 'pageSize',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openTaskId) {
            $res['openTaskId'] = $this->openTaskId;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMsgReadStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openTaskId'])) {
            $model->openTaskId = $map['openTaskId'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}
