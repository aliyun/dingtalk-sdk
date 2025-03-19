<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetRunningTaskListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2021-02-01
     *
     * @var string
     */
    public $activeTimeGMT;

    /**
     * @example manager123
     *
     * @var string
     */
    public $actualActionExecutorId;

    /**
     * @var string
     */
    public $appType;

    /**
     * @example 2021-01-01
     *
     * @var string
     */
    public $createTimeGMT;

    /**
     * @example 2021-01-01
     *
     * @var string
     */
    public $finishTimeGMT;

    /**
     * @var string
     */
    public $originatorEmail;

    /**
     * @var string
     */
    public $originatorId;

    /**
     * @var string
     */
    public $originatorName;

    /**
     * @var string
     */
    public $originatorNameInEnglish;

    /**
     * @var string
     */
    public $originatorNickName;

    /**
     * @var string
     */
    public $originatorNickNameInEnglish;

    /**
     * @var string
     */
    public $originatorPhoto;

    /**
     * @var string
     */
    public $outResult;

    /**
     * @var string
     */
    public $outResultName;

    /**
     * @var string
     */
    public $processInstanceId;

    /**
     * @example running
     *
     * @var string
     */
    public $status;

    /**
     * @example task-123
     *
     * @var string
     */
    public $taskId;

    /**
     * @example append task
     *
     * @var string
     */
    public $taskType;

    /**
     * @example 李四发起的请购单
     *
     * @var string
     */
    public $title;

    /**
     * @example title A
     *
     * @var string
     */
    public $titleInEnglish;
    protected $_name = [
        'activeTimeGMT' => 'activeTimeGMT',
        'actualActionExecutorId' => 'actualActionExecutorId',
        'appType' => 'appType',
        'createTimeGMT' => 'createTimeGMT',
        'finishTimeGMT' => 'finishTimeGMT',
        'originatorEmail' => 'originatorEmail',
        'originatorId' => 'originatorId',
        'originatorName' => 'originatorName',
        'originatorNameInEnglish' => 'originatorNameInEnglish',
        'originatorNickName' => 'originatorNickName',
        'originatorNickNameInEnglish' => 'originatorNickNameInEnglish',
        'originatorPhoto' => 'originatorPhoto',
        'outResult' => 'outResult',
        'outResultName' => 'outResultName',
        'processInstanceId' => 'processInstanceId',
        'status' => 'status',
        'taskId' => 'taskId',
        'taskType' => 'taskType',
        'title' => 'title',
        'titleInEnglish' => 'titleInEnglish',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->activeTimeGMT) {
            $res['activeTimeGMT'] = $this->activeTimeGMT;
        }
        if (null !== $this->actualActionExecutorId) {
            $res['actualActionExecutorId'] = $this->actualActionExecutorId;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->createTimeGMT) {
            $res['createTimeGMT'] = $this->createTimeGMT;
        }
        if (null !== $this->finishTimeGMT) {
            $res['finishTimeGMT'] = $this->finishTimeGMT;
        }
        if (null !== $this->originatorEmail) {
            $res['originatorEmail'] = $this->originatorEmail;
        }
        if (null !== $this->originatorId) {
            $res['originatorId'] = $this->originatorId;
        }
        if (null !== $this->originatorName) {
            $res['originatorName'] = $this->originatorName;
        }
        if (null !== $this->originatorNameInEnglish) {
            $res['originatorNameInEnglish'] = $this->originatorNameInEnglish;
        }
        if (null !== $this->originatorNickName) {
            $res['originatorNickName'] = $this->originatorNickName;
        }
        if (null !== $this->originatorNickNameInEnglish) {
            $res['originatorNickNameInEnglish'] = $this->originatorNickNameInEnglish;
        }
        if (null !== $this->originatorPhoto) {
            $res['originatorPhoto'] = $this->originatorPhoto;
        }
        if (null !== $this->outResult) {
            $res['outResult'] = $this->outResult;
        }
        if (null !== $this->outResultName) {
            $res['outResultName'] = $this->outResultName;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->taskType) {
            $res['taskType'] = $this->taskType;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->titleInEnglish) {
            $res['titleInEnglish'] = $this->titleInEnglish;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activeTimeGMT'])) {
            $model->activeTimeGMT = $map['activeTimeGMT'];
        }
        if (isset($map['actualActionExecutorId'])) {
            $model->actualActionExecutorId = $map['actualActionExecutorId'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['createTimeGMT'])) {
            $model->createTimeGMT = $map['createTimeGMT'];
        }
        if (isset($map['finishTimeGMT'])) {
            $model->finishTimeGMT = $map['finishTimeGMT'];
        }
        if (isset($map['originatorEmail'])) {
            $model->originatorEmail = $map['originatorEmail'];
        }
        if (isset($map['originatorId'])) {
            $model->originatorId = $map['originatorId'];
        }
        if (isset($map['originatorName'])) {
            $model->originatorName = $map['originatorName'];
        }
        if (isset($map['originatorNameInEnglish'])) {
            $model->originatorNameInEnglish = $map['originatorNameInEnglish'];
        }
        if (isset($map['originatorNickName'])) {
            $model->originatorNickName = $map['originatorNickName'];
        }
        if (isset($map['originatorNickNameInEnglish'])) {
            $model->originatorNickNameInEnglish = $map['originatorNickNameInEnglish'];
        }
        if (isset($map['originatorPhoto'])) {
            $model->originatorPhoto = $map['originatorPhoto'];
        }
        if (isset($map['outResult'])) {
            $model->outResult = $map['outResult'];
        }
        if (isset($map['outResultName'])) {
            $model->outResultName = $map['outResultName'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['taskType'])) {
            $model->taskType = $map['taskType'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['titleInEnglish'])) {
            $model->titleInEnglish = $map['titleInEnglish'];
        }

        return $model;
    }
}
