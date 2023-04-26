<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReportCustomerStatisticsRequest extends Model
{
    /**
     * @var string[]
     */
    public $groupOwnerUserIds;

    /**
     * @var string[]
     */
    public $groupTags;

    /**
     * @example 20220102
     *
     * @var string
     */
    public $maxDt;

    /**
     * @example 20220101
     *
     * @var string
     */
    public $minDt;

    /**
     * @var string[]
     */
    public $openConversationIds;

    /**
     * @example iFoqrhLQDtK
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @example iSoqrhLQDtK
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 20
     *
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'groupOwnerUserIds'   => 'groupOwnerUserIds',
        'groupTags'           => 'groupTags',
        'maxDt'               => 'maxDt',
        'minDt'               => 'minDt',
        'openConversationIds' => 'openConversationIds',
        'openGroupSetId'      => 'openGroupSetId',
        'openTeamId'          => 'openTeamId',
        'pageNumber'          => 'pageNumber',
        'pageSize'            => 'pageSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupOwnerUserIds) {
            $res['groupOwnerUserIds'] = $this->groupOwnerUserIds;
        }
        if (null !== $this->groupTags) {
            $res['groupTags'] = $this->groupTags;
        }
        if (null !== $this->maxDt) {
            $res['maxDt'] = $this->maxDt;
        }
        if (null !== $this->minDt) {
            $res['minDt'] = $this->minDt;
        }
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ReportCustomerStatisticsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupOwnerUserIds'])) {
            if (!empty($map['groupOwnerUserIds'])) {
                $model->groupOwnerUserIds = $map['groupOwnerUserIds'];
            }
        }
        if (isset($map['groupTags'])) {
            if (!empty($map['groupTags'])) {
                $model->groupTags = $map['groupTags'];
            }
        }
        if (isset($map['maxDt'])) {
            $model->maxDt = $map['maxDt'];
        }
        if (isset($map['minDt'])) {
            $model->minDt = $map['minDt'];
        }
        if (isset($map['openConversationIds'])) {
            if (!empty($map['openConversationIds'])) {
                $model->openConversationIds = $map['openConversationIds'];
            }
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}
