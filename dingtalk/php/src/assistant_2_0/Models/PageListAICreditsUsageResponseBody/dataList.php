<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\PageListAICreditsUsageResponseBody;

use AlibabaCloud\Tea\Model;

class dataList extends Model
{
    /**
     * @var string
     */
    public $abilityName;

    /**
     * @var float
     */
    public $aiCreditsUsedNum;

    /**
     * @var string
     */
    public $bizId;

    /**
     * @var string
     */
    public $deptName;

    /**
     * @var bool
     */
    public $isTimeFree;

    /**
     * @var string
     */
    public $scenarioName;

    /**
     * @var string
     */
    public $taskName;

    /**
     * @var string
     */
    public $usageTime;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $userName;
    protected $_name = [
        'abilityName' => 'abilityName',
        'aiCreditsUsedNum' => 'aiCreditsUsedNum',
        'bizId' => 'bizId',
        'deptName' => 'deptName',
        'isTimeFree' => 'isTimeFree',
        'scenarioName' => 'scenarioName',
        'taskName' => 'taskName',
        'usageTime' => 'usageTime',
        'userId' => 'userId',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->abilityName) {
            $res['abilityName'] = $this->abilityName;
        }
        if (null !== $this->aiCreditsUsedNum) {
            $res['aiCreditsUsedNum'] = $this->aiCreditsUsedNum;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->isTimeFree) {
            $res['isTimeFree'] = $this->isTimeFree;
        }
        if (null !== $this->scenarioName) {
            $res['scenarioName'] = $this->scenarioName;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }
        if (null !== $this->usageTime) {
            $res['usageTime'] = $this->usageTime;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['abilityName'])) {
            $model->abilityName = $map['abilityName'];
        }
        if (isset($map['aiCreditsUsedNum'])) {
            $model->aiCreditsUsedNum = $map['aiCreditsUsedNum'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['isTimeFree'])) {
            $model->isTimeFree = $map['isTimeFree'];
        }
        if (isset($map['scenarioName'])) {
            $model->scenarioName = $map['scenarioName'];
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }
        if (isset($map['usageTime'])) {
            $model->usageTime = $map['usageTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
