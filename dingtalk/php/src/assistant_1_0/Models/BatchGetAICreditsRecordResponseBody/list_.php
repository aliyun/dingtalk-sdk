<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\BatchGetAICreditsRecordResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $actionNames;

    /**
     * @var string
     */
    public $assistantId;

    /**
     * @var string
     */
    public $assistantName;

    /**
     * @var int
     */
    public $deptId;

    /**
     * @var string
     */
    public $deptName;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var string
     */
    public $time;

    /**
     * @var string
     */
    public $unionId;

    /**
     * @var float
     */
    public $usedNum;

    /**
     * @var string
     */
    public $userName;
    protected $_name = [
        'actionNames' => 'actionNames',
        'assistantId' => 'assistantId',
        'assistantName' => 'assistantName',
        'deptId' => 'deptId',
        'deptName' => 'deptName',
        'requestId' => 'requestId',
        'time' => 'time',
        'unionId' => 'unionId',
        'usedNum' => 'usedNum',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionNames) {
            $res['actionNames'] = $this->actionNames;
        }
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
        }
        if (null !== $this->assistantName) {
            $res['assistantName'] = $this->assistantName;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->usedNum) {
            $res['usedNum'] = $this->usedNum;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionNames'])) {
            $model->actionNames = $map['actionNames'];
        }
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['assistantName'])) {
            $model->assistantName = $map['assistantName'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['usedNum'])) {
            $model->usedNum = $map['usedNum'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
