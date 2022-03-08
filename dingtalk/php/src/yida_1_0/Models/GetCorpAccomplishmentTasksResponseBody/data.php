<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpAccomplishmentTasksResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description activeTime
     *
     * @var string
     */
    public $activeTimeGMT;

    /**
     * @description actualActionerId
     *
     * @var string
     */
    public $actualActionerId;

    /**
     * @description appType
     *
     * @var string
     */
    public $appType;

    /**
     * @description createTime
     *
     * @var string
     */
    public $createTimeGMT;

    /**
     * @description finishTime
     *
     * @var string
     */
    public $finishTimeGMT;

    /**
     * @description originatorEmail
     *
     * @var string
     */
    public $originatorEmail;

    /**
     * @description originatorId
     *
     * @var string
     */
    public $originatorId;

    /**
     * @description originatorName
     *
     * @var string
     */
    public $originatorName;

    /**
     * @description originatorNameEn
     *
     * @var string
     */
    public $originatorNameInEnglish;

    /**
     * @description originatorNickName
     *
     * @var string
     */
    public $originatorNickName;

    /**
     * @description originatorNickNameEn
     *
     * @var string
     */
    public $originatorNickNameInEnglish;

    /**
     * @description originatorPhoto
     *
     * @var string
     */
    public $originatorPhoto;

    /**
     * @description outResult
     *
     * @var string
     */
    public $outResult;

    /**
     * @description outResultName
     *
     * @var string
     */
    public $outResultName;

    /**
     * @description processInstanceId
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description status
     *
     * @var string
     */
    public $status;

    /**
     * @description taskId
     *
     * @var string
     */
    public $taskId;

    /**
     * @description taskType
     *
     * @var string
     */
    public $taskType;

    /**
     * @description title
     *
     * @var string
     */
    public $title;

    /**
     * @description titleEn
     *
     * @var string
     */
    public $titleInEnglish;
    protected $_name = [
        'activeTimeGMT'               => 'activeTimeGMT',
        'actualActionerId'            => 'actualActionerId',
        'appType'                     => 'appType',
        'createTimeGMT'               => 'createTimeGMT',
        'finishTimeGMT'               => 'finishTimeGMT',
        'originatorEmail'             => 'originatorEmail',
        'originatorId'                => 'originatorId',
        'originatorName'              => 'originatorName',
        'originatorNameInEnglish'     => 'originatorNameInEnglish',
        'originatorNickName'          => 'originatorNickName',
        'originatorNickNameInEnglish' => 'originatorNickNameInEnglish',
        'originatorPhoto'             => 'originatorPhoto',
        'outResult'                   => 'outResult',
        'outResultName'               => 'outResultName',
        'processInstanceId'           => 'processInstanceId',
        'status'                      => 'status',
        'taskId'                      => 'taskId',
        'taskType'                    => 'taskType',
        'title'                       => 'title',
        'titleInEnglish'              => 'titleInEnglish',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activeTimeGMT) {
            $res['activeTimeGMT'] = $this->activeTimeGMT;
        }
        if (null !== $this->actualActionerId) {
            $res['actualActionerId'] = $this->actualActionerId;
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
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activeTimeGMT'])) {
            $model->activeTimeGMT = $map['activeTimeGMT'];
        }
        if (isset($map['actualActionerId'])) {
            $model->actualActionerId = $map['actualActionerId'];
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
