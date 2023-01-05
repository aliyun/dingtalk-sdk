<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListProcessInstanceIdsRequest extends Model
{
    /**
     * @description 审批实例结束时间，Unix时间戳，单位毫秒。  例如：获取审批单发起时间在2020.4.10-2020.4.14之间审批单，该值传2020.4.14 23:59:59对应的时间戳1586879999000。
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 分页参数，每页大小，最多传20。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页查询的游标，最开始传0，后续传返回参数中的nextToken值。
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 审批流的唯一码。
     *
     * processCode在审批模板编辑页面的URL中获取。
     * @var string
     */
    public $processCode;

    /**
     * @description 审批实例开始时间。Unix时间戳，单位毫秒。
     *
     * 例如：获取审批单发起时间在2020.4.10-2020.4.14之间审批单，该值传2020.4.10 00:00:00对应的时间戳1586448000000。
     * @var int
     */
    public $startTime;

    /**
     * @description 流程实例状态，未传值代表查询所有状态的实例ID列表。
     * CANCELED：取消
     * @var string[]
     */
    public $statuses;

    /**
     * @description 发起userid列表，最大列表长度为10。
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'endTime'     => 'endTime',
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'processCode' => 'processCode',
        'startTime'   => 'startTime',
        'statuses'    => 'statuses',
        'userIds'     => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->statuses) {
            $res['statuses'] = $this->statuses;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListProcessInstanceIdsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['statuses'])) {
            if (!empty($map['statuses'])) {
                $model->statuses = $map['statuses'];
            }
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
