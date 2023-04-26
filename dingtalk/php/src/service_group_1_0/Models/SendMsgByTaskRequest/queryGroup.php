<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest;

use AlibabaCloud\Tea\Model;

class queryGroup extends Model
{
    /**
     * @var string[]
     */
    public $groupTagNames;

    /**
     * @var string
     */
    public $lastActiveDateFilterType;

    /**
     * @var string
     */
    public $lastActiveTimeEnd;

    /**
     * @var string
     */
    public $lastActiveTimeStart;

    /**
     * @var string[]
     */
    public $openConversationIds;

    /**
     * @var string
     */
    public $openGroupSetId;

    /**
     * @var string
     */
    public $queryType;
    protected $_name = [
        'groupTagNames'            => 'groupTagNames',
        'lastActiveDateFilterType' => 'lastActiveDateFilterType',
        'lastActiveTimeEnd'        => 'lastActiveTimeEnd',
        'lastActiveTimeStart'      => 'lastActiveTimeStart',
        'openConversationIds'      => 'openConversationIds',
        'openGroupSetId'           => 'openGroupSetId',
        'queryType'                => 'queryType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupTagNames) {
            $res['groupTagNames'] = $this->groupTagNames;
        }
        if (null !== $this->lastActiveDateFilterType) {
            $res['lastActiveDateFilterType'] = $this->lastActiveDateFilterType;
        }
        if (null !== $this->lastActiveTimeEnd) {
            $res['lastActiveTimeEnd'] = $this->lastActiveTimeEnd;
        }
        if (null !== $this->lastActiveTimeStart) {
            $res['lastActiveTimeStart'] = $this->lastActiveTimeStart;
        }
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->queryType) {
            $res['queryType'] = $this->queryType;
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
        if (isset($map['groupTagNames'])) {
            if (!empty($map['groupTagNames'])) {
                $model->groupTagNames = $map['groupTagNames'];
            }
        }
        if (isset($map['lastActiveDateFilterType'])) {
            $model->lastActiveDateFilterType = $map['lastActiveDateFilterType'];
        }
        if (isset($map['lastActiveTimeEnd'])) {
            $model->lastActiveTimeEnd = $map['lastActiveTimeEnd'];
        }
        if (isset($map['lastActiveTimeStart'])) {
            $model->lastActiveTimeStart = $map['lastActiveTimeStart'];
        }
        if (isset($map['openConversationIds'])) {
            if (!empty($map['openConversationIds'])) {
                $model->openConversationIds = $map['openConversationIds'];
            }
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['queryType'])) {
            $model->queryType = $map['queryType'];
        }

        return $model;
    }
}
