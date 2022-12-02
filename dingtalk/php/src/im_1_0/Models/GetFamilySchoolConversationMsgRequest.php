<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFamilySchoolConversationMsgRequest extends Model
{
    /**
     * @description 查询最大消息数
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 要查询的消息类型
     *
     * @var int[]
     */
    public $msgTypes;

    /**
     * @description 下一次查询的游标，毫秒值
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 接收卡片的群的openConversationId
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 用户唯一标识
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'maxResults'         => 'maxResults',
        'msgTypes'           => 'msgTypes',
        'nextToken'          => 'nextToken',
        'openConversationId' => 'openConversationId',
        'unionId'            => 'unionId',
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
        if (null !== $this->msgTypes) {
            $res['msgTypes'] = $this->msgTypes;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFamilySchoolConversationMsgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['msgTypes'])) {
            if (!empty($map['msgTypes'])) {
                $model->msgTypes = $map['msgTypes'];
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
