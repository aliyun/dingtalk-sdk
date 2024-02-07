<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveFinishRequest\topCalculateApproveDurationParam;
use AlibabaCloud\Tea\Model;

class ProcessApproveFinishRequest extends Model
{
    /**
     * @example 1234abcd
     *
     * @var string
     */
    public $approveId;

    /**
     * @example https://open.dingtalk.com/
     *
     * @var string
     */
    public $jumpUrl;

    /**
     * @example 1
     *
     * @var int
     */
    public $overTimeToMore;

    /**
     * @example 1.07
     *
     * @var string
     */
    public $overtimeDuration;

    /**
     * @example 年假
     *
     * @var string
     */
    public $subType;

    /**
     * @example 请假
     *
     * @var string
     */
    public $tagName;

    /**
     * @var topCalculateApproveDurationParam
     */
    public $topCalculateApproveDurationParam;

    /**
     * @example manager123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'approveId'                        => 'approveId',
        'jumpUrl'                          => 'jumpUrl',
        'overTimeToMore'                   => 'overTimeToMore',
        'overtimeDuration'                 => 'overtimeDuration',
        'subType'                          => 'subType',
        'tagName'                          => 'tagName',
        'topCalculateApproveDurationParam' => 'topCalculateApproveDurationParam',
        'userId'                           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approveId) {
            $res['approveId'] = $this->approveId;
        }
        if (null !== $this->jumpUrl) {
            $res['jumpUrl'] = $this->jumpUrl;
        }
        if (null !== $this->overTimeToMore) {
            $res['overTimeToMore'] = $this->overTimeToMore;
        }
        if (null !== $this->overtimeDuration) {
            $res['overtimeDuration'] = $this->overtimeDuration;
        }
        if (null !== $this->subType) {
            $res['subType'] = $this->subType;
        }
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
        }
        if (null !== $this->topCalculateApproveDurationParam) {
            $res['topCalculateApproveDurationParam'] = null !== $this->topCalculateApproveDurationParam ? $this->topCalculateApproveDurationParam->toMap() : null;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ProcessApproveFinishRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approveId'])) {
            $model->approveId = $map['approveId'];
        }
        if (isset($map['jumpUrl'])) {
            $model->jumpUrl = $map['jumpUrl'];
        }
        if (isset($map['overTimeToMore'])) {
            $model->overTimeToMore = $map['overTimeToMore'];
        }
        if (isset($map['overtimeDuration'])) {
            $model->overtimeDuration = $map['overtimeDuration'];
        }
        if (isset($map['subType'])) {
            $model->subType = $map['subType'];
        }
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }
        if (isset($map['topCalculateApproveDurationParam'])) {
            $model->topCalculateApproveDurationParam = topCalculateApproveDurationParam::fromMap($map['topCalculateApproveDurationParam']);
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
