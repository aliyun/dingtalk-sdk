<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest;

use AlibabaCloud\Tea\Model;

class queryGroup extends Model
{
    /**
     * @description 群发圈选类型 1. AIMED 精准圈选 2. MULTI_CONDITIONS 多条件圈选
     *
     * @var string
     */
    public $queryType;

    /**
     * @description 精准圈选-群ID集合
     *
     * @var string[]
     */
    public $openConversationIds;

    /**
     * @description 最近活跃时间的开始时间
     *
     * @var string
     */
    public $lastActiveTimeStart;

    /**
     * @description 最近活跃时间的结束时间
     *
     * @var string
     */
    public $lastActiveTimeEnd;

    /**
     * @description 活跃日期筛选类型，ACTIVE=活跃      NOTACTIVE=不活跃
     *
     * @var string
     */
    public $lastActiveDateFilterType;

    /**
     * @description 群标签
     *
     * @var string[]
     */
    public $groupTagNames;

    /**
     * @description 开放群组ID
     *
     * @var string
     */
    public $openGroupSetId;
    protected $_name = [
        'queryType'                => 'queryType',
        'openConversationIds'      => 'openConversationIds',
        'lastActiveTimeStart'      => 'lastActiveTimeStart',
        'lastActiveTimeEnd'        => 'lastActiveTimeEnd',
        'lastActiveDateFilterType' => 'lastActiveDateFilterType',
        'groupTagNames'            => 'groupTagNames',
        'openGroupSetId'           => 'openGroupSetId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->queryType) {
            $res['queryType'] = $this->queryType;
        }
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }
        if (null !== $this->lastActiveTimeStart) {
            $res['lastActiveTimeStart'] = $this->lastActiveTimeStart;
        }
        if (null !== $this->lastActiveTimeEnd) {
            $res['lastActiveTimeEnd'] = $this->lastActiveTimeEnd;
        }
        if (null !== $this->lastActiveDateFilterType) {
            $res['lastActiveDateFilterType'] = $this->lastActiveDateFilterType;
        }
        if (null !== $this->groupTagNames) {
            $res['groupTagNames'] = $this->groupTagNames;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return queryGroup
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['queryType'])) {
            $model->queryType = $map['queryType'];
        }
        if (isset($map['openConversationIds'])) {
            if (!empty($map['openConversationIds'])) {
                $model->openConversationIds = $map['openConversationIds'];
            }
        }
        if (isset($map['lastActiveTimeStart'])) {
            $model->lastActiveTimeStart = $map['lastActiveTimeStart'];
        }
        if (isset($map['lastActiveTimeEnd'])) {
            $model->lastActiveTimeEnd = $map['lastActiveTimeEnd'];
        }
        if (isset($map['lastActiveDateFilterType'])) {
            $model->lastActiveDateFilterType = $map['lastActiveDateFilterType'];
        }
        if (isset($map['groupTagNames'])) {
            if (!empty($map['groupTagNames'])) {
                $model->groupTagNames = $map['groupTagNames'];
            }
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }

        return $model;
    }
}
