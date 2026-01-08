<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMsgSendRecordsRequest extends Model
{
    /**
     * @example 1766479616000
     *
     * @var int
     */
    public $endTime;

    /**
     * @var string[]
     */
    public $msgTypeList;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 1766479616000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 2
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example jYdrJoCmTo0iE
     *
     * @var string
     */
    public $unionid;
    protected $_name = [
        'endTime' => 'end_time',
        'msgTypeList' => 'msgTypeList',
        'pageNumber' => 'page_number',
        'pageSize' => 'page_size',
        'startTime' => 'start_time',
        'status' => 'status',
        'unionid' => 'unionid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['end_time'] = $this->endTime;
        }
        if (null !== $this->msgTypeList) {
            $res['msgTypeList'] = $this->msgTypeList;
        }
        if (null !== $this->pageNumber) {
            $res['page_number'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['page_size'] = $this->pageSize;
        }
        if (null !== $this->startTime) {
            $res['start_time'] = $this->startTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->unionid) {
            $res['unionid'] = $this->unionid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMsgSendRecordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['end_time'])) {
            $model->endTime = $map['end_time'];
        }
        if (isset($map['msgTypeList'])) {
            if (!empty($map['msgTypeList'])) {
                $model->msgTypeList = $map['msgTypeList'];
            }
        }
        if (isset($map['page_number'])) {
            $model->pageNumber = $map['page_number'];
        }
        if (isset($map['page_size'])) {
            $model->pageSize = $map['page_size'];
        }
        if (isset($map['start_time'])) {
            $model->startTime = $map['start_time'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['unionid'])) {
            $model->unionid = $map['unionid'];
        }

        return $model;
    }
}
