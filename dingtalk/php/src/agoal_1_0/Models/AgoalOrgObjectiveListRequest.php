<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class AgoalOrgObjectiveListRequest extends Model
{
    /**
     * @example 853530516
     *
     * @var string
     */
    public $dingTeamId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 10
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 662e006fe4b0f579bbcxxxxx
     *
     * @var string
     */
    public $periodId;
    protected $_name = [
        'dingTeamId' => 'dingTeamId',
        'pageNumber' => 'pageNumber',
        'pageSize' => 'pageSize',
        'periodId' => 'periodId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingTeamId) {
            $res['dingTeamId'] = $this->dingTeamId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->periodId) {
            $res['periodId'] = $this->periodId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AgoalOrgObjectiveListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingTeamId'])) {
            $model->dingTeamId = $map['dingTeamId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['periodId'])) {
            $model->periodId = $map['periodId'];
        }

        return $model;
    }
}
