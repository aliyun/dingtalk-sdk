<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetFamilySchoolConversationMsgResponseBody\messages;
use AlibabaCloud\Tea\Model;

class GetFamilySchoolConversationMsgResponseBody extends Model
{
    /**
     * @description 企业名称，corp123
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 是否有更多数据
     *
     * @var string
     */
    public $hasMore;

    /**
     * @description 消息数据
     *
     * @var messages[]
     */
    public $messages;

    /**
     * @description 查询下次消息的游标,时间毫秒值
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 开放群Id
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'corpId'             => 'corpId',
        'hasMore'            => 'hasMore',
        'messages'           => 'messages',
        'nextToken'          => 'nextToken',
        'openConversationId' => 'openConversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->messages) {
            $res['messages'] = [];
            if (null !== $this->messages && \is_array($this->messages)) {
                $n = 0;
                foreach ($this->messages as $item) {
                    $res['messages'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFamilySchoolConversationMsgResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['messages'])) {
            if (!empty($map['messages'])) {
                $model->messages = [];
                $n               = 0;
                foreach ($map['messages'] as $item) {
                    $model->messages[$n++] = null !== $item ? messages::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
