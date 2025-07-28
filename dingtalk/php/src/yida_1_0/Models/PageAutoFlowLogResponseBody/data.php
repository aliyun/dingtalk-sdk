<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\PageAutoFlowLogResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example APP_XCE0EVXS6DYG3YDYC5RD
     *
     * @var string
     */
    public $appType;

    /**
     * @var int
     */
    public $elapsedTimeGMT;

    /**
     * @example 2021-01-01
     *
     * @var string
     */
    public $finishTimeGMT;

    /**
     * @var string
     */
    public $flag;

    /**
     * @var string
     */
    public $procInstanceId;

    /**
     * @var string
     */
    public $processCode;

    /**
     * @var string
     */
    public $srcProcInstanceFinishTimeGMT;

    /**
     * @var string
     */
    public $srcProcInstanceId;

    /**
     * @example running
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'appType' => 'appType',
        'elapsedTimeGMT' => 'elapsedTimeGMT',
        'finishTimeGMT' => 'finishTimeGMT',
        'flag' => 'flag',
        'procInstanceId' => 'procInstanceId',
        'processCode' => 'processCode',
        'srcProcInstanceFinishTimeGMT' => 'srcProcInstanceFinishTimeGMT',
        'srcProcInstanceId' => 'srcProcInstanceId',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->elapsedTimeGMT) {
            $res['elapsedTimeGMT'] = $this->elapsedTimeGMT;
        }
        if (null !== $this->finishTimeGMT) {
            $res['finishTimeGMT'] = $this->finishTimeGMT;
        }
        if (null !== $this->flag) {
            $res['flag'] = $this->flag;
        }
        if (null !== $this->procInstanceId) {
            $res['procInstanceId'] = $this->procInstanceId;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->srcProcInstanceFinishTimeGMT) {
            $res['srcProcInstanceFinishTimeGMT'] = $this->srcProcInstanceFinishTimeGMT;
        }
        if (null !== $this->srcProcInstanceId) {
            $res['srcProcInstanceId'] = $this->srcProcInstanceId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['elapsedTimeGMT'])) {
            $model->elapsedTimeGMT = $map['elapsedTimeGMT'];
        }
        if (isset($map['finishTimeGMT'])) {
            $model->finishTimeGMT = $map['finishTimeGMT'];
        }
        if (isset($map['flag'])) {
            $model->flag = $map['flag'];
        }
        if (isset($map['procInstanceId'])) {
            $model->procInstanceId = $map['procInstanceId'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['srcProcInstanceFinishTimeGMT'])) {
            $model->srcProcInstanceFinishTimeGMT = $map['srcProcInstanceFinishTimeGMT'];
        }
        if (isset($map['srcProcInstanceId'])) {
            $model->srcProcInstanceId = $map['srcProcInstanceId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
