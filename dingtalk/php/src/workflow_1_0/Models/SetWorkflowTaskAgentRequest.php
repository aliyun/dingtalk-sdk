<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetWorkflowTaskAgentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $agentStaffId;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $all;

    /**
     * @description This parameter is required.
     *
     * @example 2026-08-25
     *
     * @var string
     */
    public $endDate;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fromStaffId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $managerStaffId;

    /**
     * @var string[]
     */
    public $processCodes;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @description This parameter is required.
     *
     * @example 2026-08-25
     *
     * @var string
     */
    public $startDate;
    protected $_name = [
        'agentStaffId' => 'agentStaffId',
        'all' => 'all',
        'endDate' => 'endDate',
        'fromStaffId' => 'fromStaffId',
        'managerStaffId' => 'managerStaffId',
        'processCodes' => 'processCodes',
        'requestId' => 'requestId',
        'startDate' => 'startDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentStaffId) {
            $res['agentStaffId'] = $this->agentStaffId;
        }
        if (null !== $this->all) {
            $res['all'] = $this->all;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->fromStaffId) {
            $res['fromStaffId'] = $this->fromStaffId;
        }
        if (null !== $this->managerStaffId) {
            $res['managerStaffId'] = $this->managerStaffId;
        }
        if (null !== $this->processCodes) {
            $res['processCodes'] = $this->processCodes;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetWorkflowTaskAgentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentStaffId'])) {
            $model->agentStaffId = $map['agentStaffId'];
        }
        if (isset($map['all'])) {
            $model->all = $map['all'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['fromStaffId'])) {
            $model->fromStaffId = $map['fromStaffId'];
        }
        if (isset($map['managerStaffId'])) {
            $model->managerStaffId = $map['managerStaffId'];
        }
        if (isset($map['processCodes'])) {
            if (!empty($map['processCodes'])) {
                $model->processCodes = $map['processCodes'];
            }
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }

        return $model;
    }
}
