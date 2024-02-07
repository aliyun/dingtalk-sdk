<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ApproveProcessCallbackRequest;

use AlibabaCloud\Tea\Model;

class request extends Model
{
    /**
     * @example agree
     *
     * @var string
     */
    public $approveResult;

    /**
     * @var string
     */
    public $approveType;

    /**
     * @var string[]
     */
    public $approvers;

    /**
     * @example 1495592259000
     *
     * @var int
     */
    public $createTime;

    /**
     * @example approve_open_group_expansion
     *
     * @var string
     */
    public $eventType;

    /**
     * @example 1495592259000
     *
     * @var int
     */
    public $finishTime;

    /**
     * @var string
     */
    public $params;

    /**
     * @var string
     */
    public $processInstanceId;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'approveResult'     => 'approveResult',
        'approveType'       => 'approveType',
        'approvers'         => 'approvers',
        'createTime'        => 'createTime',
        'eventType'         => 'eventType',
        'finishTime'        => 'finishTime',
        'params'            => 'params',
        'processInstanceId' => 'processInstanceId',
        'title'             => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approveResult) {
            $res['approveResult'] = $this->approveResult;
        }
        if (null !== $this->approveType) {
            $res['approveType'] = $this->approveType;
        }
        if (null !== $this->approvers) {
            $res['approvers'] = $this->approvers;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }
        if (null !== $this->finishTime) {
            $res['finishTime'] = $this->finishTime;
        }
        if (null !== $this->params) {
            $res['params'] = $this->params;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return request
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approveResult'])) {
            $model->approveResult = $map['approveResult'];
        }
        if (isset($map['approveType'])) {
            $model->approveType = $map['approveType'];
        }
        if (isset($map['approvers'])) {
            if (!empty($map['approvers'])) {
                $model->approvers = $map['approvers'];
            }
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['eventType'])) {
            $model->eventType = $map['eventType'];
        }
        if (isset($map['finishTime'])) {
            $model->finishTime = $map['finishTime'];
        }
        if (isset($map['params'])) {
            $model->params = $map['params'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
