<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class PrivateChatQueryRequest extends Model
{
    /**
     * @description 分页查询每页的数量
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 一次查询后返回的加密的分页凭证，首次查询不填
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 开放的群id
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 发送消息返回的加密消息id
     *
     * @var string
     */
    public $processQueryKey;

    /**
     * @description 企业机器人的robotcode
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'maxResults'         => 'maxResults',
        'nextToken'          => 'nextToken',
        'openConversationId' => 'openConversationId',
        'processQueryKey'    => 'processQueryKey',
        'robotCode'          => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->processQueryKey) {
            $res['processQueryKey'] = $this->processQueryKey;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PrivateChatQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['processQueryKey'])) {
            $model->processQueryKey = $map['processQueryKey'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
