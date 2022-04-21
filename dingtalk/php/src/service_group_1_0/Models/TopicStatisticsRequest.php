<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class TopicStatisticsRequest extends Model
{
    /**
     * @description 截止日期
     *
     * @var string
     */
    public $maxDt;

    /**
     * @description 起始日期
     *
     * @var string
     */
    public $minDt;

    /**
     * @description 开放群ID列表（多个用逗号拼接）
     *
     * @var string
     */
    public $openConversationIds;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 搜索内容
     *
     * @var string
     */
    public $searchContent;
    protected $_name = [
        'maxDt'               => 'maxDt',
        'minDt'               => 'minDt',
        'openConversationIds' => 'openConversationIds',
        'openTeamId'          => 'openTeamId',
        'searchContent'       => 'searchContent',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxDt) {
            $res['maxDt'] = $this->maxDt;
        }
        if (null !== $this->minDt) {
            $res['minDt'] = $this->minDt;
        }
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->searchContent) {
            $res['searchContent'] = $this->searchContent;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TopicStatisticsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxDt'])) {
            $model->maxDt = $map['maxDt'];
        }
        if (isset($map['minDt'])) {
            $model->minDt = $map['minDt'];
        }
        if (isset($map['openConversationIds'])) {
            $model->openConversationIds = $map['openConversationIds'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['searchContent'])) {
            $model->searchContent = $map['searchContent'];
        }

        return $model;
    }
}
