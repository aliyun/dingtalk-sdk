<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySendMsgTaskStatisticsDetailRequest extends Model
{
    /**
     * @description 每页条数
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 游标，首页传递空
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 开放群发任务ID
     *
     * @var string
     */
    public $openBatchTaskId;

    /**
     * @description 开放会话ID
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'maxResults'         => 'maxResults',
        'nextToken'          => 'nextToken',
        'openBatchTaskId'    => 'openBatchTaskId',
        'openConversationId' => 'openConversationId',
        'openTeamId'         => 'openTeamId',
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
        if (null !== $this->openBatchTaskId) {
            $res['openBatchTaskId'] = $this->openBatchTaskId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySendMsgTaskStatisticsDetailRequest
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
        if (isset($map['openBatchTaskId'])) {
            $model->openBatchTaskId = $map['openBatchTaskId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
