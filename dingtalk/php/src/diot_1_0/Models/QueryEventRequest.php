<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryEventRequest extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string[]
     */
    public $deviceIdList;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $eventId;

    /**
     * @var int[]
     */
    public $eventStatusList;

    /**
     * @var string[]
     */
    public $eventTypeList;

    /**
     * @var int
     */
    public $pageNumber;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @var int
     */
    public $startTime;
    protected $_name = [
        'corpId'          => 'corpId',
        'deviceIdList'    => 'deviceIdList',
        'endTime'         => 'endTime',
        'eventId'         => 'eventId',
        'eventStatusList' => 'eventStatusList',
        'eventTypeList'   => 'eventTypeList',
        'pageNumber'      => 'pageNumber',
        'pageSize'        => 'pageSize',
        'startTime'       => 'startTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deviceIdList) {
            $res['deviceIdList'] = $this->deviceIdList;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->eventId) {
            $res['eventId'] = $this->eventId;
        }
        if (null !== $this->eventStatusList) {
            $res['eventStatusList'] = $this->eventStatusList;
        }
        if (null !== $this->eventTypeList) {
            $res['eventTypeList'] = $this->eventTypeList;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deviceIdList'])) {
            if (!empty($map['deviceIdList'])) {
                $model->deviceIdList = $map['deviceIdList'];
            }
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['eventId'])) {
            $model->eventId = $map['eventId'];
        }
        if (isset($map['eventStatusList'])) {
            if (!empty($map['eventStatusList'])) {
                $model->eventStatusList = $map['eventStatusList'];
            }
        }
        if (isset($map['eventTypeList'])) {
            if (!empty($map['eventTypeList'])) {
                $model->eventTypeList = $map['eventTypeList'];
            }
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
