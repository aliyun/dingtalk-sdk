<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class AskRobotRequest extends Model
{
    /**
     * @description 问题
     *
     * @var string
     */
    public $question;

    /**
     * @description 企业corpId
     *
     * @var string
     */
    public $dingCorpId;

    /**
     * @description 机器人id
     *
     * @var string
     */
    public $robotAppKey;

    /**
     * @description sessionId(非必传)
     *
     * @var string
     */
    public $sessionUuid;

    /**
     * @description suiteKey
     *
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var string
     */
    public $dingUserId;
    protected $_name = [
        'question'     => 'question',
        'dingCorpId'   => 'dingCorpId',
        'robotAppKey'  => 'robotAppKey',
        'sessionUuid'  => 'sessionUuid',
        'dingSuiteKey' => 'dingSuiteKey',
        'dingUserId'   => 'dingUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->question) {
            $res['question'] = $this->question;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->robotAppKey) {
            $res['robotAppKey'] = $this->robotAppKey;
        }
        if (null !== $this->sessionUuid) {
            $res['sessionUuid'] = $this->sessionUuid;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AskRobotRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['question'])) {
            $model->question = $map['question'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['robotAppKey'])) {
            $model->robotAppKey = $map['robotAppKey'];
        }
        if (isset($map['sessionUuid'])) {
            $model->sessionUuid = $map['sessionUuid'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }

        return $model;
    }
}
