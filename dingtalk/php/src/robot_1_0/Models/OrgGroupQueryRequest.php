<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class OrgGroupQueryRequest extends Model
{
    /**
     * @example 50
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 50
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example cid6KeBBLoveMJOGXoYKF5x7EeiodoA==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @example Kna29Ra5pdJznx1ghavbumkQKwDzgfxZLapw55G7x0Q=
     *
     * @var string
     */
    public $processQueryKey;

    /**
     * @example dingue4kfzdxbyn0pjqd
     *
     * @var string
     */
    public $robotCode;

    /**
     * @example 02feb1cd4ncmed92998723813a6bfa89eea1df91a750721979992870dd90bdfa
     *
     * @var string
     */
    public $token;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'openConversationId' => 'openConversationId',
        'processQueryKey' => 'processQueryKey',
        'robotCode' => 'robotCode',
        'token' => 'token',
    ];

    public function validate() {}

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
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OrgGroupQueryRequest
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
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }

        return $model;
    }
}
