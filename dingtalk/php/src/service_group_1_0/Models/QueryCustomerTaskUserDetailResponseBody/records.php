<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCustomerTaskUserDetailResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCustomerTaskUserDetailResponseBody\records\eventTrackResponses;
use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @example 客户名称
     *
     * @var string
     */
    public $customerNames;

    /**
     * @example 11111
     *
     * @var string
     */
    public $errorCode;

    /**
     * @example 错误信息
     *
     * @var string
     */
    public $errorDetail;

    /**
     * @var eventTrackResponses[]
     */
    public $eventTrackResponses;

    /**
     * @example 8888
     *
     * @var string
     */
    public $openBatchTaskId;

    /**
     * @example 1
     *
     * @var int
     */
    public $readStatus;

    /**
     * @example 2023-07-14 00:00:00
     *
     * @var string
     */
    public $readTime;

    /**
     * @example 接收人姓名
     *
     * @var string
     */
    public $receiverName;

    /**
     * @example 接收人ID
     *
     * @var string
     */
    public $receiverUnionId;

    /**
     * @example 2023-07-14 00:00:00
     *
     * @var string
     */
    public $sendTime;

    /**
     * @example UNSEND未发；SEND_SUCCESS成功；SEND_FAILED失败；EXCEED_LIMIT被限流
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'customerNames'       => 'customerNames',
        'errorCode'           => 'errorCode',
        'errorDetail'         => 'errorDetail',
        'eventTrackResponses' => 'eventTrackResponses',
        'openBatchTaskId'     => 'openBatchTaskId',
        'readStatus'          => 'readStatus',
        'readTime'            => 'readTime',
        'receiverName'        => 'receiverName',
        'receiverUnionId'     => 'receiverUnionId',
        'sendTime'            => 'sendTime',
        'status'              => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customerNames) {
            $res['customerNames'] = $this->customerNames;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorDetail) {
            $res['errorDetail'] = $this->errorDetail;
        }
        if (null !== $this->eventTrackResponses) {
            $res['eventTrackResponses'] = [];
            if (null !== $this->eventTrackResponses && \is_array($this->eventTrackResponses)) {
                $n = 0;
                foreach ($this->eventTrackResponses as $item) {
                    $res['eventTrackResponses'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->openBatchTaskId) {
            $res['openBatchTaskId'] = $this->openBatchTaskId;
        }
        if (null !== $this->readStatus) {
            $res['readStatus'] = $this->readStatus;
        }
        if (null !== $this->readTime) {
            $res['readTime'] = $this->readTime;
        }
        if (null !== $this->receiverName) {
            $res['receiverName'] = $this->receiverName;
        }
        if (null !== $this->receiverUnionId) {
            $res['receiverUnionId'] = $this->receiverUnionId;
        }
        if (null !== $this->sendTime) {
            $res['sendTime'] = $this->sendTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customerNames'])) {
            $model->customerNames = $map['customerNames'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorDetail'])) {
            $model->errorDetail = $map['errorDetail'];
        }
        if (isset($map['eventTrackResponses'])) {
            if (!empty($map['eventTrackResponses'])) {
                $model->eventTrackResponses = [];
                $n                          = 0;
                foreach ($map['eventTrackResponses'] as $item) {
                    $model->eventTrackResponses[$n++] = null !== $item ? eventTrackResponses::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['openBatchTaskId'])) {
            $model->openBatchTaskId = $map['openBatchTaskId'];
        }
        if (isset($map['readStatus'])) {
            $model->readStatus = $map['readStatus'];
        }
        if (isset($map['readTime'])) {
            $model->readTime = $map['readTime'];
        }
        if (isset($map['receiverName'])) {
            $model->receiverName = $map['receiverName'];
        }
        if (isset($map['receiverUnionId'])) {
            $model->receiverUnionId = $map['receiverUnionId'];
        }
        if (isset($map['sendTime'])) {
            $model->sendTime = $map['sendTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
