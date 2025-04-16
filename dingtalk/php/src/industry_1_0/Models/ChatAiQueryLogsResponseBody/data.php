<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatAiQueryLogsResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $appName;

    /**
     * @var string
     */
    public $extendInfo;

    /**
     * @var int
     */
    public $feedbackState;

    /**
     * @var string
     */
    public $feedbackStateDesc;

    /**
     * @var string
     */
    public $question;

    /**
     * @var int
     */
    public $questionTime;

    /**
     * @var string
     */
    public $response;

    /**
     * @var int
     */
    public $runtime;

    /**
     * @var string
     */
    public $scene;

    /**
     * @var string
     */
    public $sessionType;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $userName;
    protected $_name = [
        'appName' => 'appName',
        'extendInfo' => 'extendInfo',
        'feedbackState' => 'feedbackState',
        'feedbackStateDesc' => 'feedbackStateDesc',
        'question' => 'question',
        'questionTime' => 'questionTime',
        'response' => 'response',
        'runtime' => 'runtime',
        'scene' => 'scene',
        'sessionType' => 'sessionType',
        'userId' => 'userId',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->feedbackState) {
            $res['feedbackState'] = $this->feedbackState;
        }
        if (null !== $this->feedbackStateDesc) {
            $res['feedbackStateDesc'] = $this->feedbackStateDesc;
        }
        if (null !== $this->question) {
            $res['question'] = $this->question;
        }
        if (null !== $this->questionTime) {
            $res['questionTime'] = $this->questionTime;
        }
        if (null !== $this->response) {
            $res['response'] = $this->response;
        }
        if (null !== $this->runtime) {
            $res['runtime'] = $this->runtime;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->sessionType) {
            $res['sessionType'] = $this->sessionType;
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
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['feedbackState'])) {
            $model->feedbackState = $map['feedbackState'];
        }
        if (isset($map['feedbackStateDesc'])) {
            $model->feedbackStateDesc = $map['feedbackStateDesc'];
        }
        if (isset($map['question'])) {
            $model->question = $map['question'];
        }
        if (isset($map['questionTime'])) {
            $model->questionTime = $map['questionTime'];
        }
        if (isset($map['response'])) {
            $model->response = $map['response'];
        }
        if (isset($map['runtime'])) {
            $model->runtime = $map['runtime'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['sessionType'])) {
            $model->sessionType = $map['sessionType'];
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
